
namespace FIX.Models;
[MessageCode("AD")]
public class TradeCaptureReportRequest
{
    
    [FieldNumber("568")]
    public FixString TradeRequestID { get; set; }
    
    [FieldNumber("569")]
    public FixInt TradeRequestType { get; set; }
    
    [FieldNumber("263")]
    public FixChar? SubscriptionRequestType { get; set; }
    
    [FieldNumber("571")]
    public FixString? TradeReportID { get; set; }
    
    [FieldNumber("818")]
    public FixString? SecondaryTradeReportID { get; set; }
    
    [FieldNumber("17")]
    public FixString? ExecID { get; set; }
    
    [FieldNumber("150")]
    public FixChar? ExecType { get; set; }
    
    [FieldNumber("37")]
    public FixString? OrderID { get; set; }
    
    [FieldNumber("11")]
    public FixString? ClOrdID { get; set; }
    
    [FieldNumber("573")]
    public FixChar? MatchStatus { get; set; }
    
    [FieldNumber("828")]
    public FixInt? TrdType { get; set; }
    
    [FieldNumber("829")]
    public FixInt? TrdSubType { get; set; }
    
    [FieldNumber("830")]
    public FixString? TransferReason { get; set; }
    
    [FieldNumber("855")]
    public FixInt? SecondaryTrdType { get; set; }
    
    [FieldNumber("820")]
    public FixString? TradeLinkID { get; set; }
    
    [FieldNumber("880")]
    public FixString? TrdMatchID { get; set; }
    
    [FieldNumber("711")]
    public NumInGroup? NoUnderlyings { get; set; }
    
    [FieldNumber("555")]
    public NumInGroup? NoLegs { get; set; }
    
    [FieldNumber("580")]
    public NumInGroup? NoDates { get; set; }
    
    [FieldNumber("715")]
    public LocalMktDate? ClearingBusinessDate { get; set; }
    
    [FieldNumber("336")]
    public FixString? TradingSessionID { get; set; }
    
    [FieldNumber("625")]
    public FixString? TradingSessionSubID { get; set; }
    
    [FieldNumber("943")]
    public FixString? TimeBracket { get; set; }
    
    [FieldNumber("54")]
    public FixChar? Side { get; set; }
    
    [FieldNumber("442")]
    public FixChar? MultiLegReportingType { get; set; }
    
    [FieldNumber("578")]
    public FixString? TradeInputSource { get; set; }
    
    [FieldNumber("579")]
    public FixString? TradeInputDevice { get; set; }
    
    [FieldNumber("725")]
    public FixInt? ResponseTransportType { get; set; }
    
    [FieldNumber("726")]
    public FixString? ResponseDestination { get; set; }
    
    [FieldNumber("58")]
    public FixString? Text { get; set; }
    
    [FieldNumber("354")]
    public Length? EncodedTextLen { get; set; }
    
    [FieldNumber("355")]
    public FixData? EncodedText { get; set; }

}
