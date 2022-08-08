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
            .Where(t => 
            {
                var isAssignable = t.IsAssignableTo(typeof(IFixMessageComponent));
                var hasMessageCode =  t.GetCustomAttribute<MessageCodeAttribute>() != null;
                return isAssignable && hasMessageCode;
            })
            .ToDictionary(
                t => t.GetCustomAttribute<MessageCodeAttribute>().MessageCode,
                t => 
                {
                    var ctor = t.GetConstructor(BindingFlags.Instance | BindingFlags.Public, new Type[]{});
                    var closure = (() => (IFixMessageComponent) ctor.Invoke(null));
                    return closure;
                });
    }
    public long LastValidSequenceNumber { get; set; } = long.MinValue;
    public FixMessage ParseFixMessage(Stream data)
    {
        var processingMessages = new List<ValidityMessage>();
        var fieldQueue = new FixStreamFieldQueue(data, options);
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
        
        #warning Need to check in with the trailer to see what fields it can process, we're only checking for checksum at the moment.
        while(fieldQueue.Fields.Peek().FieldNumber != 10)
        {
            fieldQueue.Fields.Dequeue();
        }
        var trailer = new StandardTrailer();
        processingMessages.AddRange(trailer.PopulateMessageFields(fieldQueue, options));

        return new FixMessage(header, body, trailer, processingMessages);
    }
}
