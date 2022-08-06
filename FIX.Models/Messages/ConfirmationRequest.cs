
namespace FIX.Models;
[MessageCode("BH")]
public class ConfirmationRequest
{
    
    [FieldNumber("859")]
    public FixString ConfirmReqID { get; set; }
    
    [FieldNumber("773")]
    public FixInt ConfirmType { get; set; }
    
    [FieldNumber("60")]
    public UTCTimestamp TransactTime { get; set; }
    
    [FieldNumber("73")]
    public NumInGroup? NoOrders { get; set; }
    
    [FieldNumber("70")]
    public FixString? AllocID { get; set; }
    
    [FieldNumber("793")]
    public FixString? SecondaryAllocID { get; set; }
    
    [FieldNumber("467")]
    public FixString? IndividualAllocID { get; set; }
    
    [FieldNumber("79")]
    public FixString? AllocAccount { get; set; }
    
    [FieldNumber("661")]
    public FixInt? AllocAcctIDSource { get; set; }
    
    [FieldNumber("798")]
    public FixInt? AllocAccountType { get; set; }
    
    [FieldNumber("58")]
    public FixString? Text { get; set; }
    
    [FieldNumber("354")]
    public Length? EncodedTextLen { get; set; }
    
    [FieldNumber("355")]
    public FixData? EncodedText { get; set; }

}
