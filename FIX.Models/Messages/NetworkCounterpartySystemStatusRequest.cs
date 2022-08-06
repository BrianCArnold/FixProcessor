
namespace FIX.Models;
[MessageCode("BC")]
public class NetworkCounterpartySystemStatusRequest
{
    
    [FieldNumber("935")]
    public FixInt NetworkRequestType { get; set; }
    
    [FieldNumber("933")]
    public FixString NetworkRequestID { get; set; }
    
    [FieldNumber("936")]
    public NumInGroup? NoCompIDs { get; set; }

}
