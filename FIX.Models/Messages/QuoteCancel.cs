
namespace FIX.Models;
[MessageCode("Z")]
public class QuoteCancel
{
    
    [FieldNumber("117")]
    public FixString QuoteID { get; set; }
    
    [FieldNumber("298")]
    public FixInt QuoteCancelType { get; set; }
    
    [FieldNumber("131")]
    public FixString? QuoteReqID { get; set; }
    
    [FieldNumber("301")]
    public FixInt? QuoteResponseLevel { get; set; }
    
    [FieldNumber("1")]
    public FixString? Account { get; set; }
    
    [FieldNumber("660")]
    public FixInt? AcctIDSource { get; set; }
    
    [FieldNumber("581")]
    public FixInt? AccountType { get; set; }
    
    [FieldNumber("336")]
    public FixString? TradingSessionID { get; set; }
    
    [FieldNumber("625")]
    public FixString? TradingSessionSubID { get; set; }
    
    [FieldNumber("295")]
    public NumInGroup? NoQuoteEntries { get; set; }

}
