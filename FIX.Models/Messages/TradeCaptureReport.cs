
namespace FIX.Models;
[MessageCode("AE")]
public class TradeCaptureReport
{
    
    [FieldNumber("571")]
    public FixString TradeReportID { get; set; }
    
    [FieldNumber("570")]
    public FixBool PreviouslyReported { get; set; }
    
    [FieldNumber("32")]
    public Qty LastQty { get; set; }
    
    [FieldNumber("31")]
    public Price LastPx { get; set; }
    
    [FieldNumber("75")]
    public LocalMktDate TradeDate { get; set; }
    
    [FieldNumber("60")]
    public UTCTimestamp TransactTime { get; set; }
    
    [FieldNumber("552")]
    public NumInGroup NoSides { get; set; }
    
    [FieldNumber("487")]
    public FixInt? TradeReportTransType { get; set; }
    
    [FieldNumber("856")]
    public FixInt? TradeReportType { get; set; }
    
    [FieldNumber("568")]
    public FixString? TradeRequestID { get; set; }
    
    [FieldNumber("828")]
    public FixInt? TrdType { get; set; }
    
    [FieldNumber("829")]
    public FixInt? TrdSubType { get; set; }
    
    [FieldNumber("855")]
    public FixInt? SecondaryTrdType { get; set; }
    
    [FieldNumber("830")]
    public FixString? TransferReason { get; set; }
    
    [FieldNumber("150")]
    public FixChar? ExecType { get; set; }
    
    [FieldNumber("748")]
    public FixInt? TotNumTradeReports { get; set; }
    
    [FieldNumber("912")]
    public FixBool? LastRptRequested { get; set; }
    
    [FieldNumber("325")]
    public FixBool? UnsolicitedIndicator { get; set; }
    
    [FieldNumber("263")]
    public FixChar? SubscriptionRequestType { get; set; }
    
    [FieldNumber("572")]
    public FixString? TradeReportRefID { get; set; }
    
    [FieldNumber("881")]
    public FixString? SecondaryTradeReportRefID { get; set; }
    
    [FieldNumber("818")]
    public FixString? SecondaryTradeReportID { get; set; }
    
    [FieldNumber("820")]
    public FixString? TradeLinkID { get; set; }
    
    [FieldNumber("880")]
    public FixString? TrdMatchID { get; set; }
    
    [FieldNumber("17")]
    public FixString? ExecID { get; set; }
    
    [FieldNumber("39")]
    public FixChar? OrdStatus { get; set; }
    
    [FieldNumber("527")]
    public FixString? SecondaryExecID { get; set; }
    
    [FieldNumber("378")]
    public FixInt? ExecRestatementReason { get; set; }
    
    [FieldNumber("423")]
    public FixInt? PriceType { get; set; }
    
    [FieldNumber("854")]
    public FixInt? QtyType { get; set; }
    
    [FieldNumber("711")]
    public NumInGroup? NoUnderlyings { get; set; }
    
    [FieldNumber("822")]
    public FixString? UnderlyingTradingSessionID { get; set; }
    
    [FieldNumber("823")]
    public FixString? UnderlyingTradingSessionSubID { get; set; }
    
    [FieldNumber("669")]
    public Price? LastParPx { get; set; }
    
    [FieldNumber("194")]
    public Price? LastSpotRate { get; set; }
    
    [FieldNumber("195")]
    public PriceOffset? LastForwardPoints { get; set; }
    
    [FieldNumber("30")]
    public Exchange? LastMkt { get; set; }
    
    [FieldNumber("715")]
    public LocalMktDate? ClearingBusinessDate { get; set; }
    
    [FieldNumber("6")]
    public Price? AvgPx { get; set; }
    
    [FieldNumber("819")]
    public FixInt? AvgPxIndicator { get; set; }
    
    [FieldNumber("442")]
    public FixChar? MultiLegReportingType { get; set; }
    
    [FieldNumber("824")]
    public FixString? TradeLegRefID { get; set; }
    
    [FieldNumber("555")]
    public NumInGroup? NoLegs { get; set; }
    
    [FieldNumber("63")]
    public FixChar? SettlType { get; set; }
    
    [FieldNumber("64")]
    public LocalMktDate? SettlDate { get; set; }
    
    [FieldNumber("573")]
    public FixChar? MatchStatus { get; set; }
    
    [FieldNumber("574")]
    public FixString? MatchType { get; set; }
    
    [FieldNumber("797")]
    public FixBool? CopyMsgIndicator { get; set; }
    
    [FieldNumber("852")]
    public FixBool? PublishTrdIndicator { get; set; }
    
    [FieldNumber("853")]
    public FixInt? ShortSaleReason { get; set; }

}
