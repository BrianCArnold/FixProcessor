using System.Reflection;

namespace FIX.Models;

public abstract class FixMessageComponent<TMessage> : IFixMessageComponent
    where TMessage : FixMessageComponent<TMessage>
{
    public FixMessageComponent()
    {
        
    }
    public Dictionary<uint, FixData> CustomFields { get; set; } = new Dictionary<uint, FixData>();
    private static Dictionary<Type, Dictionary<uint, PropertyInfo>> TypeProperties { get; set; } = new Dictionary<Type, Dictionary<uint, PropertyInfo>>();
    private static Dictionary<Type, Dictionary<uint, PropertyInfo>> TypeCollectionProperties { get; set; } = new Dictionary<Type, Dictionary<uint, PropertyInfo>>();
    private static Dictionary<Type, bool> TypePropertiesPopulated { get; set; } = new Dictionary<Type, bool>();
    private static Dictionary<Type, bool> TypeCollectionPropertiesPopulated { get; set; } = new Dictionary<Type, bool>();
    
    private static Dictionary<uint, PropertyInfo> GetCollectionProperties(Type type)
    {
        if (!TypeCollectionProperties.ContainsKey(type))
        {
            var properties = type.GetProperties();
            TypeCollectionProperties.Add(type, properties.Where(p => p.GetCustomAttribute<FieldNumberTargetAttribute>() != null).ToDictionary(p => p.GetCustomAttribute<FieldNumberTargetAttribute>().FieldNumber));
            TypeCollectionPropertiesPopulated.Add(type, true);
        }
        return TypeCollectionProperties[type];

    }
    private static Dictionary<uint, PropertyInfo> GetProperties(Type type)
    {
        if (!TypeProperties.ContainsKey(type))
        {
            var properties = type.GetProperties();
            TypeProperties.Add(type, properties.Where(p => p.GetCustomAttribute<FieldNumberAttribute>() != null).ToDictionary(p => p.GetCustomAttribute<FieldNumberAttribute>().FieldNumber));
            TypePropertiesPopulated.Add(type, true);
        }
        return TypeProperties[type];
    }
    public virtual void PopulateMessageFields(FixStreamFieldQueue fields)
    {
        var messageProperties = GetProperties(typeof(TMessage));
        var collectionProperties = GetCollectionProperties(typeof(TMessage));
        while (fields.Fields.Any())
        {
            if (messageProperties.ContainsKey(fields.Fields.Peek().FieldNumber))
            {
                var field = fields.Fields.Dequeue();
                var property = messageProperties[field.FieldNumber];
                var propertyValue = Activator.CreateInstance(property.PropertyType, field.Value);
                property.SetValue(this, propertyValue);
                if (collectionProperties.ContainsKey(field.FieldNumber))
                {
                    //ICollection<$SubType>
                    var collectionProperty = collectionProperties[field.FieldNumber];
                    //$SubType
                    var repeatedPart = collectionProperty.PropertyType.GenericTypeArguments[0];
                    var collection = collectionProperty.GetValue(this);
                    var addMethod = collectionProperty.PropertyType.GetMethod("Add");
                    for (int i = 0; i < ((FixInt)propertyValue).Value; i++)
                    {
                        var subComponent = (IFixMessageComponent)Activator.CreateInstance(repeatedPart);
                        subComponent.PopulateMessageFields(fields);
                        addMethod.Invoke(collection, new object[] { subComponent });
                    }
                }
            }
            else if (fields.Fields.Peek().FieldNumber >= 5000) 
            {//User Defined Tags
                var customField = fields.Fields.Dequeue();
                var customFieldNum = customField.FieldNumber;
                var customData = new FixData(customField.Value);
                CustomFields.Add(customFieldNum, customData);
            }
            else 
            {
                break;
            }
        }
    }
}

