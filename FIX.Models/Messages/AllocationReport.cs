
namespace FIX.Models;
[MessageCode("AS")]
public class AllocationReport
{
    
    [FieldNumber("755")]
    public FixString AllocReportID { get; set; }
    
    [FieldNumber("71")]
    public FixChar AllocTransType { get; set; }
    
    [FieldNumber("794")]
    public FixInt AllocReportType { get; set; }
    
    [FieldNumber("87")]
    public FixInt AllocStatus { get; set; }
    
    [FieldNumber("857")]
    public FixInt AllocNoOrdersType { get; set; }
    
    [FieldNumber("54")]
    public FixChar Side { get; set; }
    
    [FieldNumber("53")]
    public Qty Quantity { get; set; }
    
    [FieldNumber("6")]
    public Price AvgPx { get; set; }
    
    [FieldNumber("75")]
    public LocalMktDate TradeDate { get; set; }
    
    [FieldNumber("78")]
    public NumInGroup NoAllocs { get; set; }
    
    [FieldNumber("70")]
    public FixString? AllocID { get; set; }
    
    [FieldNumber("795")]
    public FixString? AllocReportRefID { get; set; }
    
    [FieldNumber("796")]
    public FixInt? AllocCancReplaceReason { get; set; }
    
    [FieldNumber("793")]
    public FixString? SecondaryAllocID { get; set; }
    
    [FieldNumber("88")]
    public FixInt? AllocRejCode { get; set; }
    
    [FieldNumber("72")]
    public FixString? RefAllocID { get; set; }
    
    [FieldNumber("808")]
    public FixInt? AllocIntermedReqType { get; set; }
    
    [FieldNumber("196")]
    public FixString? AllocLinkID { get; set; }
    
    [FieldNumber("197")]
    public FixInt? AllocLinkType { get; set; }
    
    [FieldNumber("466")]
    public FixString? BookingRefID { get; set; }
    
    [FieldNumber("73")]
    public NumInGroup? NoOrders { get; set; }
    
    [FieldNumber("124")]
    public NumInGroup? NoExecs { get; set; }
    
    [FieldNumber("570")]
    public FixBool? PreviouslyReported { get; set; }
    
    [FieldNumber("700")]
    public FixBool? ReversalIndicator { get; set; }
    
    [FieldNumber("574")]
    public FixString? MatchType { get; set; }
    
    [FieldNumber("711")]
    public NumInGroup? NoUnderlyings { get; set; }
    
    [FieldNumber("555")]
    public NumInGroup? NoLegs { get; set; }
    
    [FieldNumber("854")]
    public FixInt? QtyType { get; set; }
    
    [FieldNumber("30")]
    public Exchange? LastMkt { get; set; }
    
    [FieldNumber("229")]
    public LocalMktDate? TradeOriginationDate { get; set; }
    
    [FieldNumber("336")]
    public FixString? TradingSessionID { get; set; }
    
    [FieldNumber("625")]
    public FixString? TradingSessionSubID { get; set; }
    
    [FieldNumber("423")]
    public FixInt? PriceType { get; set; }
    
    [FieldNumber("860")]
    public Price? AvgParPx { get; set; }
    
    [FieldNumber("15")]
    public Currency? Currency { get; set; }
    
    [FieldNumber("74")]
    public FixInt? AvgPxPrecision { get; set; }
    
    [FieldNumber("60")]
    public UTCTimestamp? TransactTime { get; set; }
    
    [FieldNumber("63")]
    public FixChar? SettlType { get; set; }
    
    [FieldNumber("64")]
    public LocalMktDate? SettlDate { get; set; }
    
    [FieldNumber("775")]
    public FixInt? BookingType { get; set; }
    
    [FieldNumber("381")]
    public Amt? GrossTradeAmt { get; set; }
    
    [FieldNumber("238")]
    public Amt? Concession { get; set; }
    
    [FieldNumber("237")]
    public Amt? TotalTakedown { get; set; }
    
    [FieldNumber("118")]
    public Amt? NetMoney { get; set; }
    
    [FieldNumber("77")]
    public FixChar? PositionEffect { get; set; }
    
    [FieldNumber("754")]
    public FixBool? AutoAcceptIndicator { get; set; }
    
    [FieldNumber("58")]
    public FixString? Text { get; set; }
    
    [FieldNumber("354")]
    public Length? EncodedTextLen { get; set; }
    
    [FieldNumber("355")]
    public FixData? EncodedText { get; set; }
    
    [FieldNumber("157")]
    public FixInt? NumDaysInterest { get; set; }
    
    [FieldNumber("158")]
    public Percentage? AccruedInterestRate { get; set; }
    
    [FieldNumber("159")]
    public Amt? AccruedInterestAmt { get; set; }
    
    [FieldNumber("540")]
    public Amt? TotalAccruedInterestAmt (Deprecated) { get; set; }
    
    [FieldNumber("738")]
    public Amt? InterestAtMaturity { get; set; }
    
    [FieldNumber("920")]
    public Amt? EndAccruedInterestAmt { get; set; }
    
    [FieldNumber("921")]
    public Amt? StartCash { get; set; }
    
    [FieldNumber("922")]
    public Amt? EndCash { get; set; }
    
    [FieldNumber("650")]
    public FixBool? LegalConfirm { get; set; }
    
    [FieldNumber("892")]
    public FixInt? TotNoAllocs { get; set; }
    
    [FieldNumber("893")]
    public FixBool? LastFragment { get; set; }

}
