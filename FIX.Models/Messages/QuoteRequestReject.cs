
namespace FIX.Models;
[MessageCode("AG")]
public class QuoteRequestReject
{
    
    [FieldNumber("131")]
    public FixString QuoteReqID { get; set; }
    
    [FieldNumber("658")]
    public FixInt QuoteRequestRejectReason { get; set; }
    
    [FieldNumber("146")]
    public NumInGroup NoRelatedSym { get; set; }
    
    [FieldNumber("644")]
    public FixString? RFQReqID { get; set; }
    
    [FieldNumber("58")]
    public FixString? Text { get; set; }
    
    [FieldNumber("354")]
    public Length? EncodedTextLen { get; set; }
    
    [FieldNumber("355")]
    public FixData? EncodedText { get; set; }

}
