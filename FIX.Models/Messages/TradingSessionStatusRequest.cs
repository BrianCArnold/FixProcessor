
namespace FIX.Models;
[MessageCode("g")]
public class TradingSessionStatusRequest
{
    
    [FieldNumber("335")]
    public FixString TradSesReqID { get; set; }
    
    [FieldNumber("263")]
    public FixChar SubscriptionRequestType { get; set; }
    
    [FieldNumber("336")]
    public FixString? TradingSessionID { get; set; }
    
    [FieldNumber("625")]
    public FixString? TradingSessionSubID { get; set; }
    
    [FieldNumber("338")]
    public FixInt? TradSesMethod { get; set; }
    
    [FieldNumber("339")]
    public FixInt? TradSesMode { get; set; }

}
