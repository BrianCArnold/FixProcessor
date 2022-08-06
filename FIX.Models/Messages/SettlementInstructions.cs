
namespace FIX.Models;
[MessageCode("T")]
public class SettlementInstructions
{
    
    [FieldNumber("777")]
    public FixString SettlInstMsgID { get; set; }
    
    [FieldNumber("160")]
    public FixChar SettlInstMode { get; set; }
    
    [FieldNumber("60")]
    public UTCTimestamp TransactTime { get; set; }
    
    [FieldNumber("791")]
    public FixString? SettlInstReqID { get; set; }
    
    [FieldNumber("792")]
    public FixInt? SettlInstReqRejCode { get; set; }
    
    [FieldNumber("58")]
    public FixString? Text { get; set; }
    
    [FieldNumber("354")]
    public Length? EncodedTextLen { get; set; }
    
    [FieldNumber("355")]
    public FixData? EncodedText { get; set; }
    
    [FieldNumber("11")]
    public FixString? ClOrdID { get; set; }
    
    [FieldNumber("778")]
    public NumInGroup? NoSettlInst { get; set; }

}
