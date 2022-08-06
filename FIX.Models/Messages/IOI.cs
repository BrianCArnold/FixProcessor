
namespace FIX.Models;
[MessageCode("6")]
public class IOI
{
    
    [FieldNumber("23")]
    public FixString IOIID { get; set; }
    
    [FieldNumber("28")]
    public FixChar IOITransType { get; set; }
    
    [FieldNumber("54")]
    public FixChar Side { get; set; }
    
    [FieldNumber("27")]
    public FixString IOIQty { get; set; }
    
    [FieldNumber("26")]
    public FixString? IOIRefID { get; set; }
    
    [FieldNumber("711")]
    public NumInGroup? NoUnderlyings { get; set; }
    
    [FieldNumber("854")]
    public FixInt? QtyType { get; set; }
    
    [FieldNumber("15")]
    public Currency? Currency { get; set; }
    
    [FieldNumber("555")]
    public NumInGroup? NoLegs { get; set; }
    
    [FieldNumber("423")]
    public FixInt? PriceType { get; set; }
    
    [FieldNumber("44")]
    public Price? Price { get; set; }
    
    [FieldNumber("62")]
    public UTCTimestamp? ValidUntilTime { get; set; }
    
    [FieldNumber("25")]
    public FixChar? IOIQltyInd { get; set; }
    
    [FieldNumber("130")]
    public FixBool? IOINaturalFlag { get; set; }
    
    [FieldNumber("199")]
    public NumInGroup? NoIOIQualifiers { get; set; }
    
    [FieldNumber("58")]
    public FixString? Text { get; set; }
    
    [FieldNumber("354")]
    public Length? EncodedTextLen { get; set; }
    
    [FieldNumber("355")]
    public FixData? EncodedText { get; set; }
    
    [FieldNumber("60")]
    public UTCTimestamp? TransactTime { get; set; }
    
    [FieldNumber("149")]
    public FixString? URLLink { get; set; }
    
    [FieldNumber("215")]
    public NumInGroup? NoRoutingIDs { get; set; }

}
