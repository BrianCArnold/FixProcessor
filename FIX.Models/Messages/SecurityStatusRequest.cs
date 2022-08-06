
namespace FIX.Models;
[MessageCode("e")]
public class SecurityStatusRequest
{
    
    [FieldNumber("324")]
    public FixString SecurityStatusReqID { get; set; }
    
    [FieldNumber("263")]
    public FixChar SubscriptionRequestType { get; set; }
    
    [FieldNumber("711")]
    public NumInGroup? NoUnderlyings { get; set; }
    
    [FieldNumber("555")]
    public NumInGroup? NoLegs { get; set; }
    
    [FieldNumber("15")]
    public Currency? Currency { get; set; }
    
    [FieldNumber("336")]
    public FixString? TradingSessionID { get; set; }
    
    [FieldNumber("625")]
    public FixString? TradingSessionSubID { get; set; }

}
