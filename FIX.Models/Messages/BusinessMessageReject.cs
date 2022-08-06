
namespace FIX.Models;
[MessageCode("j")]
public class BusinessMessageReject
{
    
    [FieldNumber("372")]
    public FixString RefMsgType { get; set; }
    
    [FieldNumber("380")]
    public FixInt BusinessRejectReason { get; set; }
    
    [FieldNumber("45")]
    public SeqNum? RefSeqNum { get; set; }
    
    [FieldNumber("379")]
    public FixString? BusinessRejectRefID { get; set; }
    
    [FieldNumber("58")]
    public FixString? Text { get; set; }
    
    [FieldNumber("354")]
    public Length? EncodedTextLen { get; set; }
    
    [FieldNumber("355")]
    public FixData? EncodedText { get; set; }

}
