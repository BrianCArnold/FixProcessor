
namespace FIX.Models;
[MessageCode("R")]
public class QuoteRequest
{
    
    [FieldNumber("131")]
    public FixString QuoteReqID { get; set; }
    
    [FieldNumber("146")]
    public NumInGroup NoRelatedSym { get; set; }
    
    [FieldNumber("644")]
    public FixString? RFQReqID { get; set; }
    
    [FieldNumber("11")]
    public FixString? ClOrdID { get; set; }
    
    [FieldNumber("528")]
    public FixChar? OrderCapacity { get; set; }
    
    [FieldNumber("58")]
    public FixString? Text { get; set; }
    
    [FieldNumber("354")]
    public Length? EncodedTextLen { get; set; }
    
    [FieldNumber("355")]
    public FixData? EncodedText { get; set; }

}
