
namespace FIX.Models;
[MessageCode("AC")]
public class MultilegOrderCancelReplace
{
    
    [FieldNumber("41")]
    public FixString OrigClOrdID { get; set; }
    
    [FieldNumber("11")]
    public FixString ClOrdID { get; set; }
    
    [FieldNumber("54")]
    public FixChar Side { get; set; }
    
    [FieldNumber("555")]
    public NumInGroup NoLegs { get; set; }
    
    [FieldNumber("60")]
    public UTCTimestamp TransactTime { get; set; }
    
    [FieldNumber("40")]
    public FixChar OrdType { get; set; }
    
    [FieldNumber("37")]
    public FixString? OrderID { get; set; }
    
    [FieldNumber("526")]
    public FixString? SecondaryClOrdID { get; set; }
    
    [FieldNumber("583")]
    public FixString? ClOrdLinkID { get; set; }
    
    [FieldNumber("586")]
    public UTCTimestamp? OrigOrdModTime { get; set; }
    
    [FieldNumber("229")]
    public LocalMktDate? TradeOriginationDate { get; set; }
    
    [FieldNumber("75")]
    public LocalMktDate? TradeDate { get; set; }
    
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
    
    [FieldNumber("70")]
    public FixString? AllocID { get; set; }
    
    [FieldNumber("78")]
    public NumInGroup? NoAllocs { get; set; }
    
    [FieldNumber("63")]
    public FixChar? SettlType { get; set; }
    
    [FieldNumber("64")]
    public LocalMktDate? SettlDate { get; set; }
    
    [FieldNumber("544")]
    public FixChar? CashMargin { get; set; }
    
    [FieldNumber("635")]
    public FixString? ClearingFeeIndicator { get; set; }
    
    [FieldNumber("21")]
    public FixChar? HandlInst { get; set; }
    
    [FieldNumber("18")]
    public MultipleValueString? ExecInst { get; set; }
    
    [FieldNumber("110")]
    public Qty? MinQty { get; set; }
    
    [FieldNumber("111")]
    public Qty? MaxFloor { get; set; }
    
    [FieldNumber("100")]
    public Exchange? ExDestination { get; set; }
    
    [FieldNumber("386")]
    public NumInGroup? NoTradingSessions { get; set; }
    
    [FieldNumber("81")]
    public FixChar? ProcessCode { get; set; }
    
    [FieldNumber("711")]
    public NumInGroup? NoUnderlyings { get; set; }
    
    [FieldNumber("140")]
    public Price? PrevClosePx { get; set; }
    
    [FieldNumber("114")]
    public FixBool? LocateReqd { get; set; }
    
    [FieldNumber("854")]
    public FixInt? QtyType { get; set; }
    
    [FieldNumber("423")]
    public FixInt? PriceType { get; set; }
    
    [FieldNumber("44")]
    public Price? Price { get; set; }
    
    [FieldNumber("99")]
    public Price? StopPx { get; set; }
    
    [FieldNumber("15")]
    public Currency? Currency { get; set; }
    
    [FieldNumber("376")]
    public FixString? ComplianceID { get; set; }
    
    [FieldNumber("377")]
    public FixBool? SolicitedFlag { get; set; }
    
    [FieldNumber("23")]
    public FixString? IOIID { get; set; }
    
    [FieldNumber("117")]
    public FixString? QuoteID { get; set; }
    
    [FieldNumber("59")]
    public FixChar? TimeInForce { get; set; }
    
    [FieldNumber("168")]
    public UTCTimestamp? EffectiveTime { get; set; }
    
    [FieldNumber("432")]
    public LocalMktDate? ExpireDate { get; set; }
    
    [FieldNumber("126")]
    public UTCTimestamp? ExpireTime { get; set; }
    
    [FieldNumber("427")]
    public FixInt? GTBookingInst { get; set; }
    
    [FieldNumber("528")]
    public FixChar? OrderCapacity { get; set; }
    
    [FieldNumber("529")]
    public MultipleValueString? OrderRestrictions { get; set; }
    
    [FieldNumber("582")]
    public FixInt? CustOrderCapacity { get; set; }
    
    [FieldNumber("121")]
    public FixBool? ForexReq { get; set; }
    
    [FieldNumber("120")]
    public Currency? SettlCurrency { get; set; }
    
    [FieldNumber("775")]
    public FixInt? BookingType { get; set; }
    
    [FieldNumber("58")]
    public FixString? Text { get; set; }
    
    [FieldNumber("354")]
    public Length? EncodedTextLen { get; set; }
    
    [FieldNumber("355")]
    public FixData? EncodedText { get; set; }
    
    [FieldNumber("77")]
    public FixChar? PositionEffect { get; set; }
    
    [FieldNumber("203")]
    public FixInt? CoveredOrUncovered { get; set; }
    
    [FieldNumber("210")]
    public Qty? MaxShow { get; set; }
    
    [FieldNumber("847")]
    public FixInt? TargetStrategy { get; set; }
    
    [FieldNumber("848")]
    public FixString? TargetStrategyParameters { get; set; }
    
    [FieldNumber("849")]
    public Percentage? ParticipationRate { get; set; }
    
    [FieldNumber("480")]
    public FixChar? CancellationRights { get; set; }
    
    [FieldNumber("481")]
    public FixChar? MoneyLaunderingStatus { get; set; }
    
    [FieldNumber("513")]
    public FixString? RegistID { get; set; }
    
    [FieldNumber("494")]
    public FixString? Designation { get; set; }
    
    [FieldNumber("563")]
    public FixInt? MultiLegRptTypeReq { get; set; }

}
