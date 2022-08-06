
namespace FIX.Models;
[MessageCode("P")]
public class AllocationInstructionAck
{
    
    [FieldNumber("70")]
    public FixString AllocID { get; set; }
    
    [FieldNumber("60")]
    public UTCTimestamp TransactTime { get; set; }
    
    [FieldNumber("87")]
    public FixInt AllocStatus { get; set; }
    
    [FieldNumber("793")]
    public FixString? SecondaryAllocID { get; set; }
    
    [FieldNumber("75")]
    public LocalMktDate? TradeDate { get; set; }
    
    [FieldNumber("88")]
    public FixInt? AllocRejCode { get; set; }
    
    [FieldNumber("626")]
    public FixInt? AllocType { get; set; }
    
    [FieldNumber("808")]
    public FixInt? AllocIntermedReqType { get; set; }
    
    [FieldNumber("573")]
    public FixChar? MatchStatus { get; set; }
    
    [FieldNumber("460")]
    public FixInt? Product { get; set; }
    
    [FieldNumber("167")]
    public FixString? SecurityType { get; set; }
    
    [FieldNumber("58")]
    public FixString? Text { get; set; }
    
    [FieldNumber("354")]
    public Length? EncodedTextLen { get; set; }
    
    [FieldNumber("355")]
    public FixData? EncodedText { get; set; }
    
    [FieldNumber("78")]
    public NumInGroup? NoAllocs { get; set; }

}
