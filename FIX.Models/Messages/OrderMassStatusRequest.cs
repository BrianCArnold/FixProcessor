
namespace FIX.Models;
[MessageCode("AF")]
public class OrderMassStatusRequest
{
    
    [FieldNumber("584")]
    public FixString MassStatusReqID { get; set; }
    
    [FieldNumber("585")]
    public FixInt MassStatusReqType { get; set; }
    
    [FieldNumber("1")]
    public FixString? Account { get; set; }
    
    [FieldNumber("660")]
    public FixInt? AcctIDSource { get; set; }
    
    [FieldNumber("336")]
    public FixString? TradingSessionID { get; set; }
    
    [FieldNumber("625")]
    public FixString? TradingSessionSubID { get; set; }
    
    [FieldNumber("54")]
    public FixChar? Side { get; set; }

}
