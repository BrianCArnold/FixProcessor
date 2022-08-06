
namespace FIX.Models;
[MessageCode("AA")]
public class DerivativeSecurityList
{
    
    [FieldNumber("320")]
    public FixString SecurityReqID { get; set; }
    
    [FieldNumber("322")]
    public FixString SecurityResponseID { get; set; }
    
    [FieldNumber("560")]
    public FixInt SecurityRequestResult { get; set; }
    
    [FieldNumber("393")]
    public FixInt? TotNoRelatedSym { get; set; }
    
    [FieldNumber("893")]
    public FixBool? LastFragment { get; set; }
    
    [FieldNumber("146")]
    public NumInGroup? NoRelatedSym { get; set; }

}
