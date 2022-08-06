
namespace FIX.Models;
[MessageCode("AK")]
public class Confirmation
{
    
    [FieldNumber("664")]
    public FixString ConfirmID { get; set; }
    
    [FieldNumber("666")]
    public FixInt ConfirmTransType { get; set; }
    
    [FieldNumber("773")]
    public FixInt ConfirmType { get; set; }
    
    [FieldNumber("665")]
    public FixInt ConfirmStatus { get; set; }
    
    [FieldNumber("60")]
    public UTCTimestamp TransactTime { get; set; }
    
    [FieldNumber("75")]
    public LocalMktDate TradeDate { get; set; }
    
    [FieldNumber("711")]
    public NumInGroup NoUnderlyings { get; set; }
    
    [FieldNumber("555")]
    public NumInGroup NoLegs { get; set; }
    
    [FieldNumber("80")]
    public Qty AllocQty { get; set; }
    
    [FieldNumber("54")]
    public FixChar Side { get; set; }
    
    [FieldNumber("862")]
    public NumInGroup NoCapacities { get; set; }
    
    [FieldNumber("79")]
    public FixString AllocAccount { get; set; }
    
    [FieldNumber("6")]
    public Price AvgPx { get; set; }
    
    [FieldNumber("381")]
    public Amt GrossTradeAmt { get; set; }
    
    [FieldNumber("118")]
    public Amt NetMoney { get; set; }
    
    [FieldNumber("772")]
    public FixString? ConfirmRefID { get; set; }
    
    [FieldNumber("859")]
    public FixString? ConfirmReqID { get; set; }
    
    [FieldNumber("797")]
    public FixBool? CopyMsgIndicator { get; set; }
    
    [FieldNumber("650")]
    public FixBool? LegalConfirm { get; set; }
    
    [FieldNumber("73")]
    public NumInGroup? NoOrders { get; set; }
    
    [FieldNumber("70")]
    public FixString? AllocID { get; set; }
    
    [FieldNumber("793")]
    public FixString? SecondaryAllocID { get; set; }
    
    [FieldNumber("467")]
    public FixString? IndividualAllocID { get; set; }
    
    [FieldNumber("854")]
    public FixInt? QtyType { get; set; }
    
    [FieldNumber("15")]
    public Currency? Currency { get; set; }
    
    [FieldNumber("30")]
    public Exchange? LastMkt { get; set; }
    
    [FieldNumber("661")]
    public FixInt? AllocAcctIDSource { get; set; }
    
    [FieldNumber("798")]
    public FixInt? AllocAccountType { get; set; }
    
    [FieldNumber("74")]
    public FixInt? AvgPxPrecision { get; set; }
    
    [FieldNumber("423")]
    public FixInt? PriceType { get; set; }
    
    [FieldNumber("860")]
    public Price? AvgParPx { get; set; }
    
    [FieldNumber("861")]
    public Price? ReportedPx { get; set; }
    
    [FieldNumber("58")]
    public FixString? Text { get; set; }
    
    [FieldNumber("354")]
    public Length? EncodedTextLen { get; set; }
    
    [FieldNumber("355")]
    public FixData? EncodedText { get; set; }
    
    [FieldNumber("81")]
    public FixChar? ProcessCode { get; set; }
    
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
    
    [FieldNumber("238")]
    public Amt? Concession { get; set; }
    
    [FieldNumber("237")]
    public Amt? TotalTakedown { get; set; }
    
    [FieldNumber("890")]
    public Amt? MaturityNetMoney { get; set; }
    
    [FieldNumber("119")]
    public Amt? SettlCurrAmt { get; set; }
    
    [FieldNumber("120")]
    public Currency? SettlCurrency { get; set; }
    
    [FieldNumber("155")]
    public FixDecimal? SettlCurrFxRate { get; set; }
    
    [FieldNumber("156")]
    public FixChar? SettlCurrFxRateCalc { get; set; }
    
    [FieldNumber("63")]
    public FixChar? SettlType { get; set; }
    
    [FieldNumber("64")]
    public LocalMktDate? SettlDate { get; set; }
    
    [FieldNumber("858")]
    public Amt? SharedCommission { get; set; }
    
    [FieldNumber("136")]
    public NumInGroup? NoMiscFees { get; set; }

}
