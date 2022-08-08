using System.Reflection;

namespace FIX.Models;

public class FixMessageFactory
{
    private static Dictionary<string, Func<IFixMessage>> messageConstructors;
    static FixMessageFactory()
    {
        Type mm = typeof(FixMessageFactory);
        messageConstructors = Assembly
            .GetExecutingAssembly()
            .GetTypes()
            .Where(t => t.IsAssignableTo(typeof(IFixMessage)))
            .ToDictionary(
                t => t.GetCustomAttribute<MessageCodeAttribute>().MessageCode,
                t => 
                {
                    var ctor = t.GetConstructor(BindingFlags.Default, new Type[]{});
                    //returning a closure so invocation of the constructor is fast.
                    var closure = (() => (IFixMessage) ctor.Invoke(null));
                    return closure;
                });
    }

    public IFixMessage ParseFixMessage(Stream data)
    {
        var fieldQueue = new FixStreamFieldQueue(data);
        StandardHeader header = new StandardHeader();
        header.PopulateMessageFields(fieldQueue);

        if (messageConstructors.ContainsKey(header.MsgType.Value))
        {
            var message = messageConstructors[header.MsgType.Value]();
            message.PopulateMessageFields(fieldQueue);
            return message;
        }
        else
        {
            throw new Exception($"Message type {header.MsgType.Value} not supported");
        }

    }
}
