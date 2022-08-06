
namespace FIX.Models;
[MessageCode("F")]
public class OrderCancelRequest
{
    
    [FieldNumber("41")]
    public FixString OrigClOrdID { get; set; }
    
    [FieldNumber("11")]
    public FixString ClOrdID { get; set; }
    
    [FieldNumber("54")]
    public FixChar Side { get; set; }
    
    [FieldNumber("60")]
    public UTCTimestamp TransactTime { get; set; }
    
    [FieldNumber("37")]
    public FixString? OrderID { get; set; }
    
    [FieldNumber("526")]
    public FixString? SecondaryClOrdID { get; set; }
    
    [FieldNumber("583")]
    public FixString? ClOrdLinkID { get; set; }
    
    [FieldNumber("66")]
    public FixString? ListID { get; set; }
    
    [FieldNumber("586")]
    public UTCTimestamp? OrigOrdModTime { get; set; }
    
    [FieldNumber("1")]
    public FixString? Account { get; set; }
    
    [FieldNumber("660")]
    public FixInt? AcctIDSource { get; set; }
    
    [FieldNumber("581")]
    public FixInt? AccountType { get; set; }
    
    [FieldNumber("711")]
    public NumInGroup? NoUnderlyings { get; set; }
    
    [FieldNumber("376")]
    public FixString? ComplianceID { get; set; }
    
    [FieldNumber("58")]
    public FixString? Text { get; set; }
    
    [FieldNumber("354")]
    public Length? EncodedTextLen { get; set; }
    
    [FieldNumber("355")]
    public FixData? EncodedText { get; set; }

}
