
namespace FIX.Models;
[MessageCode("m")]
public class ListStrikePrice
{
    
    [FieldNumber("66")]
    public FixString ListID { get; set; }
    
    [FieldNumber("422")]
    public FixInt TotNoStrikes { get; set; }
    
    [FieldNumber("428")]
    public NumInGroup NoStrikes { get; set; }
    
    [FieldNumber("893")]
    public FixBool? LastFragment { get; set; }
    
    [FieldNumber("711")]
    public NumInGroup? NoUnderlyings { get; set; }

}
