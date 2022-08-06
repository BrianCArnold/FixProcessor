
namespace FIX.Models;
[MessageCode("c")]
public class SecurityDefinitionRequest
{
    
    [FieldNumber("320")]
    public FixString SecurityReqID { get; set; }
    
    [FieldNumber("321")]
    public FixInt SecurityRequestType { get; set; }
    
    [FieldNumber("711")]
    public NumInGroup? NoUnderlyings { get; set; }
    
    [FieldNumber("15")]
    public Currency? Currency { get; set; }
    
    [FieldNumber("58")]
    public FixString? Text { get; set; }
    
    [FieldNumber("354")]
    public Length? EncodedTextLen { get; set; }
    
    [FieldNumber("355")]
    public FixData? EncodedText { get; set; }
    
    [FieldNumber("336")]
    public FixString? TradingSessionID { get; set; }
    
    [FieldNumber("625")]
    public FixString? TradingSessionSubID { get; set; }
    
    [FieldNumber("555")]
    public NumInGroup? NoLegs { get; set; }
    
    [FieldNumber("827")]
    public FixInt? ExpirationCycle { get; set; }
    
    [FieldNumber("263")]
    public FixChar? SubscriptionRequestType { get; set; }

}
