
namespace FIX.Models;
[MessageCode("BA")]
public class CollateralReport
{
    
    [FieldNumber("908")]
    public FixString CollRptID { get; set; }
    
    [FieldNumber("910")]
    public FixInt CollStatus { get; set; }
    
    [FieldNumber("909")]
    public FixString? CollInquiryID { get; set; }
    
    [FieldNumber("911")]
    public FixInt? TotNumReports { get; set; }
    
    [FieldNumber("912")]
    public FixBool? LastRptRequested { get; set; }
    
    [FieldNumber("1")]
    public FixString? Account { get; set; }
    
    [FieldNumber("581")]
    public FixInt? AccountType { get; set; }
    
    [FieldNumber("11")]
    public FixString? ClOrdID { get; set; }
    
    [FieldNumber("37")]
    public FixString? OrderID { get; set; }
    
    [FieldNumber("198")]
    public FixString? SecondaryOrderID { get; set; }
    
    [FieldNumber("526")]
    public FixString? SecondaryClOrdID { get; set; }
    
    [FieldNumber("124")]
    public NumInGroup? NoExecs { get; set; }
    
    [FieldNumber("897")]
    public NumInGroup? NoTrades { get; set; }
    
    [FieldNumber("64")]
    public LocalMktDate? SettlDate { get; set; }
    
    [FieldNumber("53")]
    public Qty? Quantity { get; set; }
    
    [FieldNumber("854")]
    public FixInt? QtyType { get; set; }
    
    [FieldNumber("15")]
    public Currency? Currency { get; set; }
    
    [FieldNumber("555")]
    public NumInGroup? NoLegs { get; set; }
    
    [FieldNumber("711")]
    public NumInGroup? NoUnderlyings { get; set; }
    
    [FieldNumber("899")]
    public Amt? MarginExcess { get; set; }
    
    [FieldNumber("900")]
    public Amt? TotalNetValue { get; set; }
    
    [FieldNumber("901")]
    public Amt? CashOutstanding { get; set; }
    
    [FieldNumber("54")]
    public FixChar? Side { get; set; }
    
    [FieldNumber("136")]
    public NumInGroup? NoMiscFees { get; set; }
    
    [FieldNumber("44")]
    public Price? Price { get; set; }
    
    [FieldNumber("423")]
    public FixInt? PriceType { get; set; }
    
    [FieldNumber("159")]
    public Amt? AccruedInterestAmt { get; set; }
    
    [FieldNumber("920")]
    public Amt? EndAccruedInterestAmt { get; set; }
    
    [FieldNumber("921")]
    public Amt? StartCash { get; set; }
    
    [FieldNumber("922")]
    public Amt? EndCash { get; set; }
    
    [FieldNumber("336")]
    public FixString? TradingSessionID { get; set; }
    
    [FieldNumber("625")]
    public FixString? TradingSessionSubID { get; set; }
    
    [FieldNumber("716")]
    public FixString? SettlSessID { get; set; }
    
    [FieldNumber("717")]
    public FixString? SettlSessSubID { get; set; }
    
    [FieldNumber("715")]
    public LocalMktDate? ClearingBusinessDate { get; set; }
    
    [FieldNumber("58")]
    public FixString? Text { get; set; }
    
    [FieldNumber("354")]
    public Length? EncodedTextLen { get; set; }
    
    [FieldNumber("355")]
    public FixData? EncodedText { get; set; }

}
