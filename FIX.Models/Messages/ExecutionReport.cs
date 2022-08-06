
namespace FIX.Models;
[MessageCode("8")]
public class ExecutionReport
{
    
    [FieldNumber("37")]
    public FixString OrderID { get; set; }
    
    [FieldNumber("17")]
    public FixString ExecID { get; set; }
    
    [FieldNumber("150")]
    public FixChar ExecType { get; set; }
    
    [FieldNumber("39")]
    public FixChar OrdStatus { get; set; }
    
    [FieldNumber("54")]
    public FixChar Side { get; set; }
    
    [FieldNumber("151")]
    public Qty LeavesQty { get; set; }
    
    [FieldNumber("14")]
    public Qty CumQty { get; set; }
    
    [FieldNumber("6")]
    public Price AvgPx { get; set; }
    
    [FieldNumber("11")]
    public FixString? ClOrdID { get; set; }
    
    [FieldNumber("10")]
    public FixString? CheckSum { get; set; }
    
    [FieldNumber("2")]
    public FixString? AdvId { get; set; }
    
    [FieldNumber("2")]
    public FixString? AdvId { get; set; }
    
    [FieldNumber("198")]
    public FixString? SecondaryOrderID { get; set; }
    
    [FieldNumber("526")]
    public FixString? SecondaryClOrdID { get; set; }
    
    [FieldNumber("527")]
    public FixString? SecondaryExecID { get; set; }
    
    [FieldNumber("11")]
    public FixString? ClOrdID { get; set; }
    
    [FieldNumber("41")]
    public FixString? OrigClOrdID { get; set; }
    
    [FieldNumber("583")]
    public FixString? ClOrdLinkID { get; set; }
    
    [FieldNumber("693")]
    public FixString? QuoteRespID { get; set; }
    
    [FieldNumber("790")]
    public FixString? OrdStatusReqID { get; set; }
    
    [FieldNumber("584")]
    public FixString? MassStatusReqID { get; set; }
    
    [FieldNumber("911")]
    public FixInt? TotNumReports { get; set; }
    
    [FieldNumber("912")]
    public FixBool? LastRptRequested { get; set; }
    
    [FieldNumber("229")]
    public LocalMktDate? TradeOriginationDate { get; set; }
    
    [FieldNumber("382")]
    public NumInGroup? NoContraBrokers { get; set; }
    
    [FieldNumber("66")]
    public FixString? ListID { get; set; }
    
    [FieldNumber("548")]
    public FixString? CrossID { get; set; }
    
    [FieldNumber("551")]
    public FixString? OrigCrossID { get; set; }
    
    [FieldNumber("549")]
    public FixInt? CrossType { get; set; }
    
    [FieldNumber("19")]
    public FixString? ExecRefID { get; set; }
    
    [FieldNumber("636")]
    public FixBool? WorkingIndicator { get; set; }
    
    [FieldNumber("103")]
    public FixInt? OrdRejReason { get; set; }
    
    [FieldNumber("378")]
    public FixInt? ExecRestatementReason { get; set; }
    
    [FieldNumber("1")]
    public FixString? Account { get; set; }
    
    [FieldNumber("660")]
    public FixInt? AcctIDSource { get; set; }
    
    [FieldNumber("581")]
    public FixInt? AccountType { get; set; }
    
    [FieldNumber("589")]
    public FixChar? DayBookingInst { get; set; }
    
    [FieldNumber("590")]
    public FixChar? BookingUnit { get; set; }
    
    [FieldNumber("591")]
    public FixChar? PreallocMethod { get; set; }
    
    [FieldNumber("63")]
    public FixChar? SettlType { get; set; }
    
    [FieldNumber("64")]
    public LocalMktDate? SettlDate { get; set; }
    
    [FieldNumber("544")]
    public FixChar? CashMargin { get; set; }
    
    [FieldNumber("635")]
    public FixString? ClearingFeeIndicator { get; set; }
    
    [FieldNumber("711")]
    public NumInGroup? NoUnderlyings { get; set; }
    
    [FieldNumber("854")]
    public FixInt? QtyType { get; set; }
    
    [FieldNumber("40")]
    public FixChar? OrdType { get; set; }
    
    [FieldNumber("423")]
    public FixInt? PriceType { get; set; }
    
    [FieldNumber("44")]
    public Price? Price { get; set; }
    
    [FieldNumber("99")]
    public Price? StopPx { get; set; }
    
    [FieldNumber("839")]
    public Price? PeggedPrice { get; set; }
    
    [FieldNumber("845")]
    public Price? DiscretionPrice { get; set; }
    
    [FieldNumber("847")]
    public FixInt? TargetStrategy { get; set; }
    
    [FieldNumber("848")]
    public FixString? TargetStrategyParameters { get; set; }
    
    [FieldNumber("849")]
    public Percentage? ParticipationRate { get; set; }
    
    [FieldNumber("850")]
    public FixDecimal? TargetStrategyPerformance { get; set; }
    
    [FieldNumber("15")]
    public Currency? Currency { get; set; }
    
    [FieldNumber("376")]
    public FixString? ComplianceID { get; set; }
    
    [FieldNumber("377")]
    public FixBool? SolicitedFlag { get; set; }
    
    [FieldNumber("59")]
    public FixChar? TimeInForce { get; set; }
    
    [FieldNumber("168")]
    public UTCTimestamp? EffectiveTime { get; set; }
    
    [FieldNumber("432")]
    public LocalMktDate? ExpireDate { get; set; }
    
    [FieldNumber("126")]
    public UTCTimestamp? ExpireTime { get; set; }
    
    [FieldNumber("18")]
    public MultipleValueString? ExecInst { get; set; }
    
    [FieldNumber("528")]
    public FixChar? OrderCapacity { get; set; }
    
    [FieldNumber("529")]
    public MultipleValueString? OrderRestrictions { get; set; }
    
    [FieldNumber("582")]
    public FixInt? CustOrderCapacity { get; set; }
    
    [FieldNumber("32")]
    public Qty? LastQty { get; set; }
    
    [FieldNumber("652")]
    public Qty? UnderlyingLastQty { get; set; }
    
    [FieldNumber("31")]
    public Price? LastPx { get; set; }
    
    [FieldNumber("651")]
    public Price? UnderlyingLastPx { get; set; }
    
    [FieldNumber("669")]
    public Price? LastParPx { get; set; }
    
    [FieldNumber("194")]
    public Price? LastSpotRate { get; set; }
    
    [FieldNumber("195")]
    public PriceOffset? LastForwardPoints { get; set; }
    
    [FieldNumber("30")]
    public Exchange? LastMkt { get; set; }
    
    [FieldNumber("336")]
    public FixString? TradingSessionID { get; set; }
    
    [FieldNumber("625")]
    public FixString? TradingSessionSubID { get; set; }
    
    [FieldNumber("943")]
    public FixString? TimeBracket { get; set; }
    
    [FieldNumber("29")]
    public FixChar? LastCapacity { get; set; }
    
    [FieldNumber("424")]
    public Qty? DayOrderQty { get; set; }
    
    [FieldNumber("425")]
    public Qty? DayCumQty { get; set; }
    
    [FieldNumber("426")]
    public Price? DayAvgPx { get; set; }
    
    [FieldNumber("427")]
    public FixInt? GTBookingInst { get; set; }
    
    [FieldNumber("75")]
    public LocalMktDate? TradeDate { get; set; }
    
    [FieldNumber("60")]
    public UTCTimestamp? TransactTime { get; set; }
    
    [FieldNumber("113")]
    public FixBool? ReportToExch { get; set; }
    
    [FieldNumber("381")]
    public Amt? GrossTradeAmt { get; set; }
    
    [FieldNumber("157")]
    public FixInt? NumDaysInterest { get; set; }
    
    [FieldNumber("230")]
    public LocalMktDate? ExDate { get; set; }
    
    [FieldNumber("158")]
    public Percentage? AccruedInterestRate { get; set; }
    
    [FieldNumber("159")]
    public Amt? AccruedInterestAmt { get; set; }
    
    [FieldNumber("738")]
    public Amt? InterestAtMaturity { get; set; }
    
    [FieldNumber("920")]
    public Amt? EndAccruedInterestAmt { get; set; }
    
    [FieldNumber("921")]
    public Amt? StartCash { get; set; }
    
    [FieldNumber("922")]
    public Amt? EndCash { get; set; }
    
    [FieldNumber("258")]
    public FixBool? TradedFlatSwitch { get; set; }
    
    [FieldNumber("259")]
    public LocalMktDate? BasisFeatureDate { get; set; }
    
    [FieldNumber("260")]
    public Price? BasisFeaturePrice { get; set; }
    
    [FieldNumber("238")]
    public Amt? Concession { get; set; }
    
    [FieldNumber("237")]
    public Amt? TotalTakedown { get; set; }
    
    [FieldNumber("118")]
    public Amt? NetMoney { get; set; }
    
    [FieldNumber("119")]
    public Amt? SettlCurrAmt { get; set; }
    
    [FieldNumber("120")]
    public Currency? SettlCurrency { get; set; }
    
    [FieldNumber("155")]
    public FixDecimal? SettlCurrFxRate { get; set; }
    
    [FieldNumber("156")]
    public FixChar? SettlCurrFxRateCalc { get; set; }
    
    [FieldNumber("21")]
    public FixChar? HandlInst { get; set; }
    
    [FieldNumber("110")]
    public Qty? MinQty { get; set; }
    
    [FieldNumber("111")]
    public Qty? MaxFloor { get; set; }
    
    [FieldNumber("77")]
    public FixChar? PositionEffect { get; set; }
    
    [FieldNumber("210")]
    public Qty? MaxShow { get; set; }
    
    [FieldNumber("775")]
    public FixInt? BookingType { get; set; }
    
    [FieldNumber("58")]
    public FixString? Text { get; set; }
    
    [FieldNumber("354")]
    public Length? EncodedTextLen { get; set; }
    
    [FieldNumber("355")]
    public FixData? EncodedText { get; set; }
    
    [FieldNumber("193")]
    public LocalMktDate? SettlDate2 { get; set; }
    
    [FieldNumber("192")]
    public Qty? OrderQty2 { get; set; }
    
    [FieldNumber("641")]
    public PriceOffset? LastForwardPoints2 { get; set; }
    
    [FieldNumber("442")]
    public FixChar? MultiLegReportingType { get; set; }
    
    [FieldNumber("480")]
    public FixChar? CancellationRights { get; set; }
    
    [FieldNumber("481")]
    public FixChar? MoneyLaunderingStatus { get; set; }
    
    [FieldNumber("513")]
    public FixString? RegistID { get; set; }
    
    [FieldNumber("494")]
    public FixString? Designation { get; set; }
    
    [FieldNumber("483")]
    public UTCTimestamp? TransBkdTime { get; set; }
    
    [FieldNumber("515")]
    public UTCTimestamp? ExecValuationPoint { get; set; }
    
    [FieldNumber("484")]
    public FixChar? ExecPriceType { get; set; }
    
    [FieldNumber("485")]
    public FixDecimal? ExecPriceAdjustment { get; set; }
    
    [FieldNumber("638")]
    public FixInt? PriorityIndicator { get; set; }
    
    [FieldNumber("639")]
    public PriceOffset? PriceImprovement { get; set; }
    
    [FieldNumber("851")]
    public FixInt? LastLiquidityInd { get; set; }
    
    [FieldNumber("518")]
    public NumInGroup? NoContAmts { get; set; }
    
    [FieldNumber("555")]
    public NumInGroup? NoLegs { get; set; }
    
    [FieldNumber("797")]
    public FixBool? CopyMsgIndicator { get; set; }
    
    [FieldNumber("136")]
    public NumInGroup? NoMiscFees { get; set; }

}
