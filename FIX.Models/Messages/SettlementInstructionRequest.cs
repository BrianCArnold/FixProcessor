
namespace FIX.Models;
[MessageCode("AV")]
public class SettlementInstructionRequest
{
    
    [FieldNumber("791")]
    public FixString SettlInstReqID { get; set; }
    
    [FieldNumber("60")]
    public UTCTimestamp TransactTime { get; set; }
    
    [FieldNumber("79")]
    public FixString? AllocAccount { get; set; }
    
    [FieldNumber("661")]
    public FixInt? AllocAcctIDSource { get; set; }
    
    [FieldNumber("54")]
    public FixChar? Side { get; set; }
    
    [FieldNumber("460")]
    public FixInt? Product { get; set; }
    
    [FieldNumber("167")]
    public FixString? SecurityType { get; set; }
    
    [FieldNumber("461")]
    public FixString? CFICode { get; set; }
    
    [FieldNumber("168")]
    public UTCTimestamp? EffectiveTime { get; set; }
    
    [FieldNumber("126")]
    public UTCTimestamp? ExpireTime { get; set; }
    
    [FieldNumber("779")]
    public UTCTimestamp? LastUpdateTime { get; set; }
    
    [FieldNumber("169")]
    public FixInt? StandInstDbType { get; set; }
    
    [FieldNumber("170")]
    public FixString? StandInstDbName { get; set; }
    
    [FieldNumber("171")]
    public FixString? StandInstDbID { get; set; }

}
