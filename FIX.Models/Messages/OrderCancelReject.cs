
namespace FIX.Models;
[MessageCode("9")]
public class OrderCancelReject
{
    
    [FieldNumber("37")]
    public FixString OrderID { get; set; }
    
    [FieldNumber("11")]
    public FixString ClOrdID { get; set; }
    
    [FieldNumber("41")]
    public FixString OrigClOrdID { get; set; }
    
    [FieldNumber("39")]
    public FixChar OrdStatus { get; set; }
    
    [FieldNumber("434")]
    public FixChar CxlRejResponseTo { get; set; }
    
    [FieldNumber("198")]
    public FixString? SecondaryOrderID { get; set; }
    
    [FieldNumber("526")]
    public FixString? SecondaryClOrdID { get; set; }
    
    [FieldNumber("583")]
    public FixString? ClOrdLinkID { get; set; }
    
    [FieldNumber("636")]
    public FixBool? WorkingIndicator { get; set; }
    
    [FieldNumber("586")]
    public UTCTimestamp? OrigOrdModTime { get; set; }
    
    [FieldNumber("66")]
    public FixString? ListID { get; set; }
    
    [FieldNumber("1")]
    public FixString? Account { get; set; }
    
    [FieldNumber("660")]
    public FixInt? AcctIDSource { get; set; }
    
    [FieldNumber("581")]
    public FixInt? AccountType { get; set; }
    
    [FieldNumber("229")]
    public LocalMktDate? TradeOriginationDate { get; set; }
    
    [FieldNumber("75")]
    public LocalMktDate? TradeDate { get; set; }
    
    [FieldNumber("60")]
    public UTCTimestamp? TransactTime { get; set; }
    
    [FieldNumber("102")]
    public FixInt? CxlRejReason { get; set; }
    
    [FieldNumber("58")]
    public FixString? Text { get; set; }
    
    [FieldNumber("354")]
    public Length? EncodedTextLen { get; set; }
    
    [FieldNumber("355")]
    public FixData? EncodedText { get; set; }

}
