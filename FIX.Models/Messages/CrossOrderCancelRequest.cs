
namespace FIX.Models;
[MessageCode("u")]
public class CrossOrderCancelRequest
{
    
    [FieldNumber("548")]
    public FixString CrossID { get; set; }
    
    [FieldNumber("551")]
    public FixString OrigCrossID { get; set; }
    
    [FieldNumber("549")]
    public FixInt CrossType { get; set; }
    
    [FieldNumber("550")]
    public FixInt CrossPrioritization { get; set; }
    
    [FieldNumber("552")]
    public NumInGroup NoSides { get; set; }
    
    [FieldNumber("60")]
    public UTCTimestamp TransactTime { get; set; }
    
    [FieldNumber("37")]
    public FixString? OrderID { get; set; }
    
    [FieldNumber("711")]
    public NumInGroup? NoUnderlyings { get; set; }
    
    [FieldNumber("555")]
    public NumInGroup? NoLegs { get; set; }

}
