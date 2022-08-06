
namespace FIX.Models;
[MessageCode("o")]
public class RegistrationInstructions
{
    
    [FieldNumber("513")]
    public FixString RegistID { get; set; }
    
    [FieldNumber("514")]
    public FixChar RegistTransType { get; set; }
    
    [FieldNumber("508")]
    public FixString RegistRefID { get; set; }
    
    [FieldNumber("11")]
    public FixString? ClOrdID { get; set; }
    
    [FieldNumber("1")]
    public FixString? Account { get; set; }
    
    [FieldNumber("660")]
    public FixInt? AcctIDSource { get; set; }
    
    [FieldNumber("493")]
    public FixString? RegistAcctType { get; set; }
    
    [FieldNumber("495")]
    public FixInt? TaxAdvantageType { get; set; }
    
    [FieldNumber("517")]
    public FixChar? OwnershipType { get; set; }
    
    [FieldNumber("473")]
    public NumInGroup? NoRegistDtls { get; set; }
    
    [FieldNumber("510")]
    public NumInGroup? NoDistribInsts { get; set; }

}
