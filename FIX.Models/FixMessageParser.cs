using System.Reflection;

namespace FIX.Models;
public class FixMessageParser
{
    public FixMessageParser(MessageParserOptions options)
    {
        this.options = options;
    }
    private static Dictionary<string, Func<IFixMessageComponent>> messageConstructors;
    private readonly MessageParserOptions options;

    static FixMessageParser()
    {
        Type mm = typeof(FixMessageParser);
        messageConstructors = Assembly
            .GetExecutingAssembly()
            .GetTypes()
            .Where(t => t.IsAssignableTo(typeof(IFixMessageComponent)) && t.GetCustomAttribute<MessageCodeAttribute>() != null)
            .ToDictionary(
                t => t.GetCustomAttribute<MessageCodeAttribute>().MessageCode,
                t =>
                {
                    var ctor = t.GetConstructor(BindingFlags.Instance | BindingFlags.Public, new Type[] { });
                    var closure = (() => (IFixMessageComponent)ctor.Invoke(null));
                    return closure;
                });
    }
    public long LastValidSequenceNumber { get; set; } = long.MinValue;
    public FixMessage ParseFixMessage(Stream messageData)
    {
        var processingMessages = new List<ValidityMessage>();
        var fieldQueue = new FixStreamFieldQueue(messageData, options);

        StandardHeader header = ParseHeader(processingMessages, fieldQueue);
        IFixMessageComponent body = ParseBody(processingMessages, fieldQueue, header);
        StandardTrailer trailer = ParseTrailer(processingMessages, fieldQueue);

        return new FixMessage(header, body, trailer, processingMessages);
    }

    private StandardTrailer ParseTrailer(List<ValidityMessage> processingMessages, FixStreamFieldQueue fieldQueue)
    {
        //Skip over any fields that couldn't be processed by the Body.
#warning Need to check in with the trailer to see what fields it can process, we're only checking for checksum at the moment.
        while (fieldQueue.Fields.Peek().FieldNumber != 10)
        {
            var failedTag = fieldQueue.Fields.Dequeue();
            processingMessages.Add(new ValidityMessage(MessageLevel.Error, $"Could not process Tag {failedTag.FieldNumber}."));
        }

        var trailer = new StandardTrailer();
        processingMessages.AddRange(trailer.PopulateMessageFields(fieldQueue, options));
        return trailer;
    }

    private IFixMessageComponent ParseBody(List<ValidityMessage> processingMessages, FixStreamFieldQueue fieldQueue, StandardHeader header)
    {
        //Construct the Body block, and process all the fields in the body.
        IFixMessageComponent body;
        if (messageConstructors.ContainsKey(header.MsgType.Value))
        {
            body = messageConstructors[header.MsgType.Value]();
        }
        else
        {
            body = new UnknownMessageComponent();
            processingMessages.Insert(0, new ValidityMessage(MessageLevel.Error, $"Unrecognized Message Type ({header.MsgType.Value}) for this version of FIX."));
        }
        processingMessages.AddRange(body.PopulateMessageFields(fieldQueue, options));
        return body;
    }

    private StandardHeader ParseHeader(List<ValidityMessage> processingMessages, FixStreamFieldQueue fieldQueue)
    {
        StandardHeader header = new StandardHeader();
        processingMessages.AddRange(header.PopulateMessageFields(fieldQueue, options));
        if (header.MsgSeqNum > LastValidSequenceNumber)
        {
            LastValidSequenceNumber = header.MsgSeqNum;
        }
        else if (!options.DisableSequenceCheck)
        {
#warning This may be because the SequenceNumber is associated with a particular sender or reciever?
            processingMessages.Add(new ValidityMessage(MessageLevel.Warning, "Sequence number may be out of order"));
        }

        return header;
    }
}
