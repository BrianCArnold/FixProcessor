
namespace FIX.Models;
[MessageCode("i")]
public class MassQuote
{
    
    [FieldNumber("117")]
    public FixString QuoteID { get; set; }
    
    [FieldNumber("296")]
    public NumInGroup NoQuoteSets { get; set; }
    
    [FieldNumber("131")]
    public FixString? QuoteReqID { get; set; }
    
    [FieldNumber("537")]
    public FixInt? QuoteType { get; set; }
    
    [FieldNumber("301")]
    public FixInt? QuoteResponseLevel { get; set; }
    
    [FieldNumber("1")]
    public FixString? Account { get; set; }
    
    [FieldNumber("660")]
    public FixInt? AcctIDSource { get; set; }
    
    [FieldNumber("581")]
    public FixInt? AccountType { get; set; }
    
    [FieldNumber("293")]
    public Qty? DefBidSize { get; set; }
    
    [FieldNumber("294")]
    public Qty? DefOfferSize { get; set; }

}
