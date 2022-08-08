namespace FIX.Models
{
    public interface IFixMessageComponent
    {
        bool PopulateMessageFields(FixStreamFieldQueue fields);
    }
    public class UnknownMessageComponent : IFixMessageComponent
    {
        Dictionary<uint, FixData> CustomFields { get; set; } = new Dictionary<uint, FixData>();
        public bool PopulateMessageFields(FixStreamFieldQueue fields)
        {
            while (fields.Fields.Peek().FieldNumber != 10)
            {
                var field = fields.Fields.Dequeue();
                if (CustomFields.ContainsKey(field.FieldNumber))
                {
                    return false;
                }
                else
                {
                    CustomFields.Add(field.FieldNumber, new FixData(field.Value));
                }
            }
            return true;
        }
    }   
}