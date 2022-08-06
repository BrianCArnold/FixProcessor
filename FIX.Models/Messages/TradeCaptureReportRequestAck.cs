
namespace FIX.Models;
[MessageCode("AQ")]
public class TradeCaptureReportRequestAck
{
    
    [FieldNumber("568")]
    public FixString TradeRequestID { get; set; }
    
    [FieldNumber("569")]
    public FixInt TradeRequestType { get; set; }
    
    [FieldNumber("749")]
    public FixInt TradeRequestResult { get; set; }
    
    [FieldNumber("750")]
    public FixInt TradeRequestStatus { get; set; }
    
    [FieldNumber("263")]
    public FixChar? SubscriptionRequestType { get; set; }
    
    [FieldNumber("748")]
    public FixInt? TotNumTradeReports { get; set; }
    
    [FieldNumber("711")]
    public NumInGroup? NoUnderlyings { get; set; }
    
    [FieldNumber("555")]
    public NumInGroup? NoLegs { get; set; }
    
    [FieldNumber("442")]
    public FixChar? MultiLegReportingType { get; set; }
    
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
