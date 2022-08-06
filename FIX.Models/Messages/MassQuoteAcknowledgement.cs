
namespace FIX.Models;
[MessageCode("b")]
public class MassQuoteAcknowledgement
{
    
    [FieldNumber("297")]
    public FixInt QuoteStatus { get; set; }
    
    [FieldNumber("131")]
    public FixString? QuoteReqID { get; set; }
    
    [FieldNumber("117")]
    public FixString? QuoteID { get; set; }
    
    [FieldNumber("300")]
    public FixInt? QuoteRejectReason { get; set; }
    
    [FieldNumber("301")]
    public FixInt? QuoteResponseLevel { get; set; }
    
    [FieldNumber("537")]
    public FixInt? QuoteType { get; set; }
    
    [FieldNumber("1")]
    public FixString? Account { get; set; }
    
    [FieldNumber("660")]
    public FixInt? AcctIDSource { get; set; }
    
    [FieldNumber("581")]
    public FixInt? AccountType { get; set; }
    
    [FieldNumber("58")]
    public FixString? Text { get; set; }
    
    [FieldNumber("354")]
    public Length? EncodedTextLen { get; set; }
    
    [FieldNumber("355")]
    public FixData? EncodedText { get; set; }
    
    [FieldNumber("296")]
    public NumInGroup? NoQuoteSets { get; set; }

}
