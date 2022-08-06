
namespace FIX.Models;
[MessageCode("BD")]
public class NetworkCounterpartySystemStatusResponse
{
    
    [FieldNumber("937")]
    public FixInt NetworkStatusResponseType { get; set; }
    
    [FieldNumber("932")]
    public FixString NetworkResponseID { get; set; }
    
    [FieldNumber("936")]
    public NumInGroup NoCompIDs { get; set; }
    
    [FieldNumber("933")]
    public FixString? NetworkRequestID { get; set; }
    
    [FieldNumber("934")]
    public FixString? LastNetworkResponseID { get; set; }

}
