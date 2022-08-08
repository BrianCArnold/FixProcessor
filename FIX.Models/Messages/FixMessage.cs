using System.Reflection;

namespace FIX.Models;

public abstract class FixMessage<TMessage> : IFixMessage
    where TMessage : FixMessage<TMessage>
{
    public FixMessage()
    {
        
    }

    private Dictionary<Type, Dictionary<uint, PropertyInfo>> TypeProperties { get; set; } = new Dictionary<Type, Dictionary<uint, PropertyInfo>>();
    private Dictionary<Type, bool> TypePropertiesPopulated { get; set; } = new Dictionary<Type, bool>();
    public Dictionary<uint, PropertyInfo> GetProperties(Type type)
    {
        if (TypeProperties.ContainsKey(type))
        {
            return TypeProperties[type];
        }
        var properties = type.GetProperties();
        TypeProperties.Add(type, properties.Where(p=>p.GetCustomAttribute<FieldNumberAttribute>() != null).ToDictionary(p => p.GetCustomAttribute<FieldNumberAttribute>().FieldNumber));
        TypePropertiesPopulated.Add(type, true);
        return TypeProperties[type];
    }
    public void PopulateMessageFields(FixStreamFieldQueue fields)
    {
        var messageProperties = GetProperties(typeof(TMessage));
        while (fields.Fields.Any() && messageProperties.ContainsKey(fields.Fields.Peek().FieldNumber))
        {
            var field = fields.Fields.Dequeue();
            var property = messageProperties[field.FieldNumber];
            var propertyValue = Activator.CreateInstance(property.PropertyType, field.Value);
            property.SetValue(this, propertyValue);
        }
    }
}


