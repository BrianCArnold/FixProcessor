
namespace FIX.Models;
[MessageCode("r")]
public class OrderMassCancelReport
{
    
    [FieldNumber("37")]
    public FixString OrderID { get; set; }
    
    [FieldNumber("530")]
    public FixChar MassCancelRequestType { get; set; }
    
    [FieldNumber("531")]
    public FixChar MassCancelResponse { get; set; }
    
    [FieldNumber("11")]
    public FixString? ClOrdID { get; set; }
    
    [FieldNumber("526")]
    public FixString? SecondaryClOrdID { get; set; }
    
    [FieldNumber("198")]
    public FixString? SecondaryOrderID { get; set; }
    
    [FieldNumber("532")]
    public FixChar? MassCancelRejectReason { get; set; }
    
    [FieldNumber("533")]
    public FixInt? TotalAffectedOrders { get; set; }
    
    [FieldNumber("534")]
    public FixInt? NoAffectedOrders { get; set; }
    
    [FieldNumber("336")]
    public FixString? TradingSessionID { get; set; }
    
    [FieldNumber("625")]
    public FixString? TradingSessionSubID { get; set; }
    
    [FieldNumber("54")]
    public FixChar? Side { get; set; }
    
    [FieldNumber("60")]
    public UTCTimestamp? TransactTime { get; set; }
    
    [FieldNumber("58")]
    public FixString? Text { get; set; }
    
    [FieldNumber("354")]
    public Length? EncodedTextLen { get; set; }
    
    [FieldNumber("355")]
    public FixData? EncodedText { get; set; }

}
