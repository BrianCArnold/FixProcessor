namespace FIX.Models
{
    public class UnknownMessageComponent : IFixMessageComponent
    {
        public IEnumerable<ValidityMessage> GetStatus()
            => Enumerable.Empty<ValidityMessage>();
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