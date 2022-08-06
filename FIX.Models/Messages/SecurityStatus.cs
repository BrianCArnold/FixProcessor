
namespace FIX.Models;
[MessageCode("f")]
public class SecurityStatus
{
    
    [FieldNumber("324")]
    public FixString? SecurityStatusReqID { get; set; }
    
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
    
    [FieldNumber("325")]
    public FixBool? UnsolicitedIndicator { get; set; }
    
    [FieldNumber("326")]
    public FixInt? SecurityTradingStatus { get; set; }
    
    [FieldNumber("291")]
    public MultipleValueString? FinancialStatus { get; set; }
    
    [FieldNumber("292")]
    public MultipleValueString? CorporateAction { get; set; }
    
    [FieldNumber("327")]
    public FixChar? HaltReason { get; set; }
    
    [FieldNumber("328")]
    public FixBool? InViewOfCommon { get; set; }
    
    [FieldNumber("329")]
    public FixBool? DueToRelated { get; set; }
    
    [FieldNumber("330")]
    public Qty? BuyVolume { get; set; }
    
    [FieldNumber("331")]
    public Qty? SellVolume { get; set; }
    
    [FieldNumber("332")]
    public Price? HighPx { get; set; }
    
    [FieldNumber("333")]
    public Price? LowPx { get; set; }
    
    [FieldNumber("31")]
    public Price? LastPx { get; set; }
    
    [FieldNumber("60")]
    public UTCTimestamp? TransactTime { get; set; }
    
    [FieldNumber("334")]
    public FixInt? Adjustment { get; set; }
    
    [FieldNumber("58")]
    public FixString? Text { get; set; }
    
    [FieldNumber("354")]
    public Length? EncodedTextLen { get; set; }
    
    [FieldNumber("355")]
    public FixData? EncodedText { get; set; }

}
