
namespace FIX.Models;
[MessageCode("AR")]
public class TradeCaptureReportAck
{
    
    [FieldNumber("571")]
    public FixString TradeReportID { get; set; }
    
    [FieldNumber("150")]
    public FixChar ExecType { get; set; }
    
    [FieldNumber("487")]
    public FixInt? TradeReportTransType { get; set; }
    
    [FieldNumber("856")]
    public FixInt? TradeReportType { get; set; }
    
    [FieldNumber("828")]
    public FixInt? TrdType { get; set; }
    
    [FieldNumber("829")]
    public FixInt? TrdSubType { get; set; }
    
    [FieldNumber("855")]
    public FixInt? SecondaryTrdType { get; set; }
    
    [FieldNumber("830")]
    public FixString? TransferReason { get; set; }
    
    [FieldNumber("572")]
    public FixString? TradeReportRefID { get; set; }
    
    [FieldNumber("881")]
    public FixString? SecondaryTradeReportRefID { get; set; }
    
    [FieldNumber("939")]
    public FixInt? TrdRptStatus { get; set; }
    
    [FieldNumber("751")]
    public FixInt? TradeReportRejectReason { get; set; }
    
    [FieldNumber("818")]
    public FixString? SecondaryTradeReportID { get; set; }
    
    [FieldNumber("263")]
    public FixChar? SubscriptionRequestType { get; set; }
    
    [FieldNumber("820")]
    public FixString? TradeLinkID { get; set; }
    
    [FieldNumber("880")]
    public FixString? TrdMatchID { get; set; }
    
    [FieldNumber("17")]
    public FixString? ExecID { get; set; }
    
    [FieldNumber("527")]
    public FixString? SecondaryExecID { get; set; }
    
    [FieldNumber("60")]
    public UTCTimestamp? TransactTime { get; set; }
    
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
    
    [FieldNumber("555")]
    public NumInGroup? NoLegs { get; set; }
    
    [FieldNumber("635")]
    public FixString? ClearingFeeIndicator { get; set; }
    
    [FieldNumber("528")]
    public FixChar? OrderCapacity { get; set; }
    
    [FieldNumber("529")]
    public MultipleValueString? OrderRestrictions { get; set; }
    
    [FieldNumber("582")]
    public FixInt? CustOrderCapacity { get; set; }
    
    [FieldNumber("1")]
    public FixString? Account { get; set; }
    
    [FieldNumber("660")]
    public FixInt? AcctIDSource { get; set; }
    
    [FieldNumber("581")]
    public FixInt? AccountType { get; set; }
    
    [FieldNumber("77")]
    public FixChar? PositionEffect { get; set; }
    
    [FieldNumber("591")]
    public FixChar? PreallocMethod { get; set; }
    
    [FieldNumber("78")]
    public NumInGroup? NoAllocs { get; set; }

}
