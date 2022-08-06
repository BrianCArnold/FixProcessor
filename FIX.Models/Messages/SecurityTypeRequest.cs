
namespace FIX.Models;
[MessageCode("v")]
public class SecurityTypeRequest
{
    
    [FieldNumber("320")]
    public FixString SecurityReqID { get; set; }
    
    [FieldNumber("58")]
    public FixString? Text { get; set; }
    
    [FieldNumber("354")]
    public Length? EncodedTextLen { get; set; }
    
    [FieldNumber("355")]
    public FixData? EncodedText { get; set; }
    
    [FieldNumber("336")]
    public FixString? TradingSessionID { get; set; }
    
    [FieldNumber("625")]
    public FixString? TradingSessionSubID { get; set; }
    
    [FieldNumber("460")]
    public FixInt? Product { get; set; }
    
    [FieldNumber("167")]
    public FixString? SecurityType { get; set; }
    
    [FieldNumber("762")]
    public FixString? SecuritySubType { get; set; }

}
