
namespace FIX.Models;
[MessageCode("B")]
public class News
{
    
    [FieldNumber("148")]
    public FixString Headline { get; set; }
    
    [FieldNumber("33")]
    public NumInGroup NoLinesOfText { get; set; }
    
    [FieldNumber("42")]
    public UTCTimestamp? OrigTime { get; set; }
    
    [FieldNumber("61")]
    public FixChar? Urgency { get; set; }
    
    [FieldNumber("358")]
    public Length? EncodedHeadlineLen { get; set; }
    
    [FieldNumber("359")]
    public FixData? EncodedHeadline { get; set; }
    
    [FieldNumber("215")]
    public NumInGroup? NoRoutingIDs { get; set; }
    
    [FieldNumber("146")]
    public NumInGroup? NoRelatedSym { get; set; }
    
    [FieldNumber("555")]
    public NumInGroup? NoLegs { get; set; }
    
    [FieldNumber("711")]
    public NumInGroup? NoUnderlyings { get; set; }
    
    [FieldNumber("149")]
    public FixString? URLLink { get; set; }
    
    [FieldNumber("95")]
    public Length? RawDataLength { get; set; }
    
    [FieldNumber("96")]
    public FixData? RawData { get; set; }

}
