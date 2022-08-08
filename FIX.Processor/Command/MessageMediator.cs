using System;
using System.Reactive.Subjects;
using System.Text;
using FIX.Models;

namespace FIX.Processor;

public class MessageMediator
{
    private readonly ProcessOptions options;
    private readonly FixMessageParser messageParser;
    private int messageNum = 0;
    private readonly Dictionary<string, ICollection<decimal>> accountPrices = new Dictionary<string, ICollection<decimal>>();
    private readonly List<FixMessage> messages = new List<FixMessage>();
    private int errCount = 0;

    public MessageMediator(ProcessOptions options)
    {
        this.options = options;

        this.messageParser = new FixMessageParser(new MessageParserOptions
        {
            TreatDelimiterAsSOHForChecksum = options.TreatDelimiterAsSOHForChecksum,
            Delimiter = options.Delimiter,
            DisableChecksum = options.DisableChecksum,
            DisableSequenceCheck = options.DisableSequenceCheck,
            HideErrors = options.HideErrors
        });
    }
    private IEnumerable<Stream> FileMessageStream()
    {
        var file = new FileInfo(options.File);
        if (!file.Exists)
        {
            Console.WriteLine("File not found: {0}", options.File);
            yield break;
        }
        var fileStream = file.OpenText();
        while (!fileStream.EndOfStream)
        {
            string line = fileStream.ReadLine();
            byte[] messageBytes = Encoding.UTF8.GetBytes(line);
            yield return new MemoryStream(messageBytes);
            Thread.Sleep(options.WaitTime);
        }
    }
    private IEnumerable<Stream> ConsoleMessageStream()
    {
        Console.WriteLine("Enter one message per line. Press Ctrl+C or enter an empty line to quit.");
        while (true)
        {
            string line = Console.ReadLine();
            if (line == null || line.Length == 0)
                break;
            byte[] messageBytes = Encoding.UTF8.GetBytes(line);
            yield return new MemoryStream(messageBytes);
            Thread.Sleep(options.WaitTime);
        }
    }
    private void ProcessMessageStream(Stream messageStream)
    {
        var defColor = ConsoleColor.Gray;
        if (options.Verbose)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Processing message #{messageNum}");
            Console.ForegroundColor = defColor;
        }
        var message = messageParser.ParseFixMessage(messageStream);

        if (!message.ValidityMessages.Any(m => m.Level == MessageLevel.Error))
        {//No errors, it counts.

            messages.Add(message);
            if (message.Body is NewOrderSingleMessage orderSingleMessage)
            {
                if (!accountPrices.ContainsKey(orderSingleMessage.Account))
                {
                    accountPrices[orderSingleMessage.Account] = new List<decimal>();
                }
                accountPrices[orderSingleMessage.Account].Add(orderSingleMessage.Price);
                
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Out  .WriteLine($"Successfully Processed message #{messageNum}, MessageType: {message.Header.MsgType.Value}, SeqNum: {message.Header.MsgSeqNum.Value}");

        }
        else
        {
            errCount++;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Error.WriteLine($"Error(s) in Processing message #{messageNum}, MessageType: {message.Header.MsgType.Value}, SeqNum: {message.Header.MsgSeqNum.Value}");
        }
        foreach (var parsingMessage in message.ValidityMessages)
        {
            switch (parsingMessage.Level)
            {
                case MessageLevel.Error:
                    if (!options.HideErrors)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Error.WriteLine("  " + parsingMessage.Message);
                    }
                    break;
                case MessageLevel.Warning:
                    if (!options.HideErrors)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Error.WriteLine("  " + parsingMessage.Message);
                    }
                    break;
                case MessageLevel.Info:
                    if (options.Verbose)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("  " + parsingMessage.Message);
                    }
                    break;
            }
            Console.ForegroundColor = defColor;
        }
        Console.ForegroundColor = defColor;

    }
    public int Execute()
    {

        ConsoleColor defColor = Console.ForegroundColor;

        IEnumerable<Stream> messageStreamEnumerable = options.Source switch {
            SourceType.File => FileMessageStream(),
            SourceType.StdIn => ConsoleMessageStream(),
            _ => throw new NotImplementedException()
        };

        foreach (var messageStream in messageStreamEnumerable)
        {
            messageNum++;
            ProcessMessageStream(messageStream);
        }
        foreach (var key in accountPrices.Keys)
        {
            var min = accountPrices[key].Min();
            var max = accountPrices[key].Max();
            Console.WriteLine($"Account: {key}, Min: {min}, Max: {max}");
        }
        return errCount;
    }
    
}