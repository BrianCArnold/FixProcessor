namespace FIX.Models
{
    public interface IFixMessageComponent
    {
        void PopulateMessageFields(FixStreamFieldQueue fields);
    }
    
}