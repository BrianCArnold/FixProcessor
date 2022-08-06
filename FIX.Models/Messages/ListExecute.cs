
namespace FIX.Models;
[MessageCode("L")]
public class ListExecute
{
    
    [FieldNumber("66")]
    public FixString ListID { get; set; }
    
    [FieldNumber("60")]
    public UTCTimestamp TransactTime { get; set; }
    
    [FieldNumber("391")]
    public FixString? ClientBidID { get; set; }
    
    [FieldNumber("390")]
    public FixString? BidID { get; set; }
    
    [FieldNumber("58")]
    public FixString? Text { get; set; }
    
    [FieldNumber("354")]
    public Length? EncodedTextLen { get; set; }
    
    [FieldNumber("355")]
    public FixData? EncodedText { get; set; }

}
