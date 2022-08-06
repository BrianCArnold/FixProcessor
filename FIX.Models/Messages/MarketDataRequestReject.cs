
namespace FIX.Models;
[MessageCode("Y")]
public class MarketDataRequestReject
{
    
    [FieldNumber("262")]
    public FixString MDReqID { get; set; }
    
    [FieldNumber("281")]
    public FixChar? MDReqRejReason { get; set; }
    
    [FieldNumber("816")]
    public NumInGroup? NoAltMDSource { get; set; }
    
    [FieldNumber("58")]
    public FixString? Text { get; set; }
    
    [FieldNumber("354")]
    public Length? EncodedTextLen { get; set; }
    
    [FieldNumber("355")]
    public FixData? EncodedText { get; set; }

}
