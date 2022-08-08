namespace FIX.Models
{
    public class UnknownMessageComponent : IFixMessageComponent
    {
        public IEnumerable<ValidityMessage> GetStatus()
            => Enumerable.Empty<ValidityMessage>();
        Dictionary<uint, FixData> CustomFields { get; set; } = new Dictionary<uint, FixData>();
        public IEnumerable<ValidityMessage> PopulateMessageFields(FixStreamFieldQueue fields, MessageParserOptions options)
        {
            
            while (fields.Fields.Peek().FieldNumber != 10)
            {
                var field = fields.Fields.Dequeue();
                if (CustomFields.ContainsKey(field.FieldNumber))
                {
                    yield return new ValidityMessage(MessageLevel.Error, $"Unexpected duplicate field {fields.Fields.Peek().FieldNumber} in {nameof(UnknownMessageComponent)}");
                }
                else
                {
                    CustomFields.Add(field.FieldNumber, new FixData(field.Value));
                }
            }
        }
    }   
}