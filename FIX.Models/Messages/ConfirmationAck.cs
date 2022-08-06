
namespace FIX.Models;
[MessageCode("AU")]
public class ConfirmationAck
{
    
    [FieldNumber("664")]
    public FixString ConfirmID { get; set; }
    
    [FieldNumber("75")]
    public LocalMktDate TradeDate { get; set; }
    
    [FieldNumber("60")]
    public UTCTimestamp TransactTime { get; set; }
    
    [FieldNumber("940")]
    public FixInt AffirmStatus { get; set; }
    
    [FieldNumber("774")]
    public FixInt? ConfirmRejReason { get; set; }
    
    [FieldNumber("573")]
    public FixChar? MatchStatus { get; set; }
    
    [FieldNumber("58")]
    public FixString? Text { get; set; }
    
    [FieldNumber("354")]
    public Length? EncodedTextLen { get; set; }
    
    [FieldNumber("355")]
    public FixData? EncodedText { get; set; }

}
