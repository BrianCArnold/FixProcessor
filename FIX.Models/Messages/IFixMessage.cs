namespace FIX.Models
{
    public interface IFixMessageComponent
    {
        
        IEnumerable<ValidityMessage> PopulateMessageFields(FixStreamFieldQueue fields);
    }
}