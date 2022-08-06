
namespace FIX.Models;
[MessageCode("BG")]
public class CollateralInquiryAck
{
    
    [FieldNumber("909")]
    public FixString CollInquiryID { get; set; }
    
    [FieldNumber("945")]
    public FixInt CollInquiryStatus { get; set; }
    
    [FieldNumber("946")]
    public FixInt? CollInquiryResult { get; set; }
    
    [FieldNumber("938")]
    public NumInGroup? NoCollInquiryQualifier { get; set; }
    
    [FieldNumber("911")]
    public FixInt? TotNumReports { get; set; }
    
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
