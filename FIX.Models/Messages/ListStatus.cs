
namespace FIX.Models;
[MessageCode("N")]
public class ListStatus
{
    
    [FieldNumber("66")]
    public FixString ListID { get; set; }
    
    [FieldNumber("429")]
    public FixInt ListStatusType { get; set; }
    
    [FieldNumber("82")]
    public FixInt NoRpts { get; set; }
    
    [FieldNumber("431")]
    public FixInt ListOrderStatus { get; set; }
    
    [FieldNumber("83")]
    public FixInt RptSeq { get; set; }
    
    [FieldNumber("68")]
    public FixInt TotNoOrders { get; set; }
    
    [FieldNumber("73")]
    public NumInGroup NoOrders { get; set; }
    
    [FieldNumber("444")]
    public FixString? ListStatusText { get; set; }
    
    [FieldNumber("445")]
    public Length? EncodedListStatusTextLen { get; set; }
    
    [FieldNumber("446")]
    public FixData? EncodedListStatusText { get; set; }
    
    [FieldNumber("60")]
    public UTCTimestamp? TransactTime { get; set; }
    
    [FieldNumber("893")]
    public FixBool? LastFragment { get; set; }

}
