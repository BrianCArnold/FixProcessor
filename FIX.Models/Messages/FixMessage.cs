using System.Reflection;

namespace FIX.Models;

public class FixMessage<TMessage>
where TMessage : FixMessage<TMessage>
{
    public FixMessage()
    {
        
    }

    public Dictionary<Type, Dictionary<uint, PropertyInfo>> TypeProperties { get; set; }

    public Dictionary<Type, bool> TypePropertiesPopulated { get; set; }
    public Dictionary<uint, PropertyInfo> GetProperties(Type type)
    {
        if (TypeProperties.ContainsKey(type))
        {
            return TypeProperties[type];
        }
        var properties = type.GetProperties();
        TypeProperties.Add(type, properties.ToDictionary(p => p.GetCustomAttribute<FieldNumberAttribute>().FieldNumber));
        TypePropertiesPopulated.Add(type, true);
        return TypeProperties[type];
    }
    public void PopulateMessageFields(IEnumerator<FixField> fields)
    {
        while (fields.MoveNext())
        {
            var field = fields.Current;
            var properties = GetProperties(typeof(TMessage));
            if (properties.ContainsKey(field.FieldNumber))
            {
                var property = properties[field.FieldNumber];
                property.SetValue(this, field.Value);
            }
        }
    }

    
}
