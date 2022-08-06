
namespace FIX.Models;
[MessageCode("C")]
public class Email
{
    
    [FieldNumber("164")]
    public FixString EmailThreadID { get; set; }
    
    [FieldNumber("94")]
    public FixChar EmailType { get; set; }
    
    [FieldNumber("147")]
    public FixString Subject { get; set; }
    
    [FieldNumber("33")]
    public NumInGroup NoLinesOfText { get; set; }
    
    [FieldNumber("42")]
    public UTCTimestamp? OrigTime { get; set; }
    
    [FieldNumber("356")]
    public Length? EncodedSubjectLen { get; set; }
    
    [FieldNumber("357")]
    public FixData? EncodedSubject { get; set; }
    
    [FieldNumber("215")]
    public NumInGroup? NoRoutingIDs { get; set; }
    
    [FieldNumber("146")]
    public NumInGroup? NoRelatedSym { get; set; }
    
    [FieldNumber("711")]
    public NumInGroup? NoUnderlyings { get; set; }
    
    [FieldNumber("555")]
    public NumInGroup? NoLegs { get; set; }
    
    [FieldNumber("37")]
    public FixString? OrderID { get; set; }
    
    [FieldNumber("11")]
    public FixString? ClOrdID { get; set; }
    
    [FieldNumber("95")]
    public Length? RawDataLength { get; set; }
    
    [FieldNumber("96")]
    public FixData? RawData { get; set; }

}
