
namespace FIX.Models;
[MessageCode("t")]
public class CrossOrderCancelReplaceRequest
{
    
    [FieldNumber("548")]
    public FixString CrossID { get; set; }
    
    [FieldNumber("551")]
    public FixString OrigCrossID { get; set; }
    
    [FieldNumber("549")]
    public FixInt CrossType { get; set; }
    
    [FieldNumber("550")]
    public FixInt CrossPrioritization { get; set; }
    
    [FieldNumber("552")]
    public NumInGroup NoSides { get; set; }
    
    [FieldNumber("60")]
    public UTCTimestamp TransactTime { get; set; }
    
    [FieldNumber("40")]
    public FixChar OrdType { get; set; }
    
    [FieldNumber("37")]
    public FixString? OrderID { get; set; }
    
    [FieldNumber("711")]
    public NumInGroup? NoUnderlyings { get; set; }
    
    [FieldNumber("555")]
    public NumInGroup? NoLegs { get; set; }
    
    [FieldNumber("63")]
    public FixChar? SettlType { get; set; }
    
    [FieldNumber("64")]
    public LocalMktDate? SettlDate { get; set; }
    
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
    
    [FieldNumber("140")]
    public Price? PrevClosePx { get; set; }
    
    [FieldNumber("114")]
    public FixBool? LocateReqd { get; set; }
    
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

}
