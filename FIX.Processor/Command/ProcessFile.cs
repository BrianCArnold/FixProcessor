using System.Text;
using FIX.Models;

namespace FIX.Processor;

public static class ProcessFile
{
    public static IEnumerable<Stream> FileMessageStream(Options options)
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
        }
    }
    public static IEnumerable<Stream> ConsoleMessageStream(Options options)
    {
        Console.WriteLine("Enter one message per line. Press Ctrl+C or enter an empty line to quit.");
        while (true)
        {
            string line = Console.ReadLine();
            if (line == null || line.Length == 0)
                break;
            byte[] messageBytes = Encoding.UTF8.GetBytes(line);
            yield return new MemoryStream(messageBytes);
        }
    }
    public static void Execute(Options options)
    {

        var messageParser = new FixMessageParser();

        ConsoleColor defColor = Console.ForegroundColor;

        IEnumerable<Stream> messageStreamEnumerable;

        if (options.Stdin)
        {
            messageStreamEnumerable = ConsoleMessageStream(options);
        }
        else
        {
            messageStreamEnumerable = FileMessageStream(options);
        }
        int messageNum = 0;
        foreach (var messageStream in messageStreamEnumerable)
        {
            messageNum++;
            Console.WriteLine($"Processing message #{messageNum}");
            var message = messageParser.ParseFixMessage(messageStream, options.Delimiter, options.TreatDelimiterAsSOHForChecksum);
            foreach (var parsingMessage in message.ValidityMessages)
            {
                switch (parsingMessage.Level)
                {
                    case MessageLevel.Error:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("  Err: " + parsingMessage);
                        break;
                    case MessageLevel.Warning:
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("  Warn:" + parsingMessage);
                        break;
                    case MessageLevel.Info:
                        if (options.Verbose)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("  Info:" + parsingMessage);
                        }
                        break;
                }
                Console.ForegroundColor = defColor;
            }
            if (message.ValidityMessages.Any(m=> m.Level == MessageLevel.Error))
            {
                Console.WriteLine($"Unable to process message #{messageNum} with Seq: {message.Header.MsgSeqNum.Value}, see above for details.");
                
            }
            else 
            {//No errors, it counts.
                Console.WriteLine($"Processed message #{messageNum} with Seq: {message.Header.MsgSeqNum.Value}");
            }
            
        }
        
    }
}