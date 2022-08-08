using System.Reflection;

namespace FIX.Models;

public class FixMessageParser
{
    private static Dictionary<string, Func<IFixMessageComponent>> messageConstructors;
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

    public FixMessage ParseFixMessage(Stream data)
    {
        var processingMessages = new List<ValidityMessage>();
        var fieldQueue = new FixStreamFieldQueue(data);
        StandardHeader header = new StandardHeader();
        processingMessages.AddRange(header.PopulateMessageFields(fieldQueue));

        IFixMessageComponent body;
        if (messageConstructors.ContainsKey(header.MsgType.Value))
        {
            body = messageConstructors[header.MsgType.Value]();
        }
        else
        {
            body = new UnknownMessageComponent();
        }
        processingMessages.AddRange(body.PopulateMessageFields(fieldQueue));
        
        #warning Need to check in with the trailer to see what fields it can process, we're only checking for checksum at the moment.
        while(fieldQueue.Fields.Peek().FieldNumber != 10)
        {
            fieldQueue.Fields.Dequeue();
        }
        var trailer = new StandardTrailer();
        processingMessages.AddRange(trailer.PopulateMessageFields(fieldQueue));

        return new FixMessage(header, body, trailer, processingMessages);
    }
}
