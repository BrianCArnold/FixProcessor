
namespace FIX.Models;
[MessageCode("H")]
public class OrderStatusRequest
{
    
    [FieldNumber("11")]
    public FixString ClOrdID { get; set; }
    
    [FieldNumber("54")]
    public FixChar Side { get; set; }
    
    [FieldNumber("37")]
    public FixString? OrderID { get; set; }
    
    [FieldNumber("526")]
    public FixString? SecondaryClOrdID { get; set; }
    
    [FieldNumber("583")]
    public FixString? ClOrdLinkID { get; set; }
    
    [FieldNumber("790")]
    public FixString? OrdStatusReqID { get; set; }
    
    [FieldNumber("1")]
    public FixString? Account { get; set; }
    
    [FieldNumber("660")]
    public FixInt? AcctIDSource { get; set; }
    
    [FieldNumber("711")]
    public NumInGroup? NoUnderlyings { get; set; }

}
