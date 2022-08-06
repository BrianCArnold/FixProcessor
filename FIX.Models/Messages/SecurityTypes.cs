
namespace FIX.Models;
[MessageCode("w")]
public class SecurityTypes
{
    
    [FieldNumber("320")]
    public FixString SecurityReqID { get; set; }
    
    [FieldNumber("322")]
    public FixString SecurityResponseID { get; set; }
    
    [FieldNumber("323")]
    public FixInt SecurityResponseType { get; set; }
    
    [FieldNumber("557")]
    public FixInt? TotNoSecurityTypes { get; set; }
    
    [FieldNumber("893")]
    public FixBool? LastFragment { get; set; }
    
    [FieldNumber("558")]
    public NumInGroup? NoSecurityTypes { get; set; }
    
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
    
    [FieldNumber("263")]
    public FixChar? SubscriptionRequestType { get; set; }

}
