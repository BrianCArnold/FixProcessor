
namespace FIX.Models;
[MessageCode("3")]
public class Reject
{
    
    [FieldNumber("45")]
    public SeqNum RefSeqNum { get; set; }
    
    [FieldNumber("371")]
    public FixInt? RefTagID { get; set; }
    
    [FieldNumber("372")]
    public FixString? RefMsgType { get; set; }
    
    [FieldNumber("373")]
    public FixInt? SessionRejectReason { get; set; }
    
    [FieldNumber("58")]
    public FixString? Text { get; set; }
    
    [FieldNumber("354")]
    public Length? EncodedTextLen { get; set; }
    
    [FieldNumber("355")]
    public FixData? EncodedText { get; set; }

}
