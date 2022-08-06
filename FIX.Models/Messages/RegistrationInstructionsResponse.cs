
namespace FIX.Models;
[MessageCode("p")]
public class RegistrationInstructionsResponse
{
    
    [FieldNumber("513")]
    public FixString RegistID { get; set; }
    
    [FieldNumber("514")]
    public FixChar RegistTransType { get; set; }
    
    [FieldNumber("508")]
    public FixString RegistRefID { get; set; }
    
    [FieldNumber("506")]
    public FixChar RegistStatus { get; set; }
    
    [FieldNumber("11")]
    public FixString? ClOrdID { get; set; }
    
    [FieldNumber("1")]
    public FixString? Account { get; set; }
    
    [FieldNumber("660")]
    public FixInt? AcctIDSource { get; set; }
    
    [FieldNumber("507")]
    public FixInt? RegistRejReasonCode { get; set; }
    
    [FieldNumber("496")]
    public FixString? RegistRejReasonText { get; set; }

}
