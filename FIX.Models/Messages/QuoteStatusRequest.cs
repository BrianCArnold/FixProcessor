
namespace FIX.Models;
[MessageCode("a")]
public class QuoteStatusRequest
{
    
    [FieldNumber("649")]
    public FixString? QuoteStatusReqID { get; set; }
    
    [FieldNumber("117")]
    public FixString? QuoteID { get; set; }
    
    [FieldNumber("711")]
    public NumInGroup? NoUnderlyings { get; set; }
    
    [FieldNumber("555")]
    public NumInGroup? NoLegs { get; set; }
    
    [FieldNumber("1")]
    public FixString? Account { get; set; }
    
    [FieldNumber("660")]
    public FixInt? AcctIDSource { get; set; }
    
    [FieldNumber("581")]
    public FixInt? AccountType { get; set; }
    
    [FieldNumber("336")]
    public FixString? TradingSessionID { get; set; }
    
    [FieldNumber("625")]
    public FixString? TradingSessionSubID { get; set; }
    
    [FieldNumber("263")]
    public FixChar? SubscriptionRequestType { get; set; }

}
