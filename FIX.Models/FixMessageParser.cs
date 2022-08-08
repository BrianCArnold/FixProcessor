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
        var fieldQueue = new FixStreamFieldQueue(data);
        StandardHeader header = new StandardHeader();
        header.PopulateMessageFields(fieldQueue);

        IFixMessageComponent body;
        if (messageConstructors.ContainsKey(header.MsgType.Value))
        {
            body = messageConstructors[header.MsgType.Value]();
        }
        else
        {
            body = new UnknownMessageComponent();
        }
        var successfullyProcessedBody = body.PopulateMessageFields(fieldQueue);
        
        if (!successfullyProcessedBody)
        {
            //Ran into some kind of processing issue, skip to the end.
            while(fieldQueue.Fields.Peek().FieldNumber != 10)
            {
                fieldQueue.Fields.Dequeue();
            }
        }
        var trailer = new StandardTrailer();
        trailer.PopulateMessageFields(fieldQueue);

        return new FixMessage(header, body, trailer, fieldQueue.CheckSum, successfullyProcessedBody);
    }
}
