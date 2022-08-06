
namespace FIX.Models;
[MessageCode("Q")]
public class DontKnowTrade
{
    
    [FieldNumber("37")]
    public FixString OrderID { get; set; }
    
    [FieldNumber("17")]
    public FixString ExecID { get; set; }
    
    [FieldNumber("127")]
    public FixChar DKReason { get; set; }
    
    [FieldNumber("54")]
    public FixChar Side { get; set; }
    
    [FieldNumber("198")]
    public FixString? SecondaryOrderID { get; set; }
    
    [FieldNumber("711")]
    public NumInGroup? NoUnderlyings { get; set; }
    
    [FieldNumber("555")]
    public NumInGroup? NoLegs { get; set; }
    
    [FieldNumber("32")]
    public Qty? LastQty { get; set; }
    
    [FieldNumber("31")]
    public Price? LastPx { get; set; }
    
    [FieldNumber("58")]
    public FixString? Text { get; set; }
    
    [FieldNumber("354")]
    public Length? EncodedTextLen { get; set; }
    
    [FieldNumber("355")]
    public FixData? EncodedText { get; set; }

}
