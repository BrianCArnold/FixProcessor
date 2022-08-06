
namespace FIX.Models;
[MessageCode("AP")]
public class PositionReport
{
    
    [FieldNumber("721")]
    public FixString PosMaintRptID { get; set; }
    
    [FieldNumber("728")]
    public FixInt PosReqResult { get; set; }
    
    [FieldNumber("715")]
    public LocalMktDate ClearingBusinessDate { get; set; }
    
    [FieldNumber("1")]
    public FixString Account { get; set; }
    
    [FieldNumber("581")]
    public FixInt AccountType { get; set; }
    
    [FieldNumber("730")]
    public Price SettlPrice { get; set; }
    
    [FieldNumber("731")]
    public FixInt SettlPriceType { get; set; }
    
    [FieldNumber("734")]
    public Price PriorSettlPrice { get; set; }
    
    [FieldNumber("710")]
    public FixString? PosReqID { get; set; }
    
    [FieldNumber("724")]
    public FixInt? PosReqType { get; set; }
    
    [FieldNumber("263")]
    public FixChar? SubscriptionRequestType { get; set; }
    
    [FieldNumber("727")]
    public FixInt? TotalNumPosReports { get; set; }
    
    [FieldNumber("325")]
    public FixBool? UnsolicitedIndicator { get; set; }
    
    [FieldNumber("716")]
    public FixString? SettlSessID { get; set; }
    
    [FieldNumber("717")]
    public FixString? SettlSessSubID { get; set; }
    
    [FieldNumber("660")]
    public FixInt? AcctIDSource { get; set; }
    
    [FieldNumber("15")]
    public Currency? Currency { get; set; }
    
    [FieldNumber("555")]
    public NumInGroup? NoLegs { get; set; }
    
    [FieldNumber("711")]
    public NumInGroup? NoUnderlyings { get; set; }
    
    [FieldNumber("506")]
    public FixChar? RegistStatus { get; set; }
    
    [FieldNumber("743")]
    public LocalMktDate? DeliveryDate { get; set; }
    
    [FieldNumber("58")]
    public FixString? Text { get; set; }
    
    [FieldNumber("354")]
    public Length? EncodedTextLen { get; set; }
    
    [FieldNumber("355")]
    public FixData? EncodedText { get; set; }

}
