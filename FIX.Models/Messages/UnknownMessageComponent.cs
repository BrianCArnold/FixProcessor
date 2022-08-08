namespace FIX.Models
{
    public class UnknownMessageComponent : IFixMessageComponent
    {
        public IEnumerable<ValidityMessage> GetStatus()
            => Enumerable.Empty<ValidityMessage>();
        Dictionary<uint, FixData> CustomFields { get; set; } = new Dictionary<uint, FixData>();
        public IEnumerable<ValidityMessage> PopulateMessageFields(FixStreamFieldQueue fields)
        {
            while (fields.Fields.Peek().FieldNumber != 10)
            {
                var field = fields.Fields.Dequeue();
                if (CustomFields.ContainsKey(field.FieldNumber))
                {
                    yield return new ValidityMessage(MessageLevel.Error, $"Duplicate field {field.FieldNumber}");
                }
                else
                {
                    CustomFields.Add(field.FieldNumber, new FixData(field.Value));
                }
            }
        }
    }   
}