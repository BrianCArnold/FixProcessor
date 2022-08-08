namespace FIX.Models;

[MessageCode("j")]
public class BusinessMessageRejectMessage : FixMessageComponent<BusinessMessageRejectMessage>
{
    
  [FieldNumber(372)]    
  [RequiredField]
  public FixString RefMsgType { get; set; }
    
  [FieldNumber(380)]    
  [RequiredField]
  public FixInt BusinessRejectReason { get; set; }
    
  [FieldNumber(45)]
  public FixInt RefSeqNum { get; set; }
    
  [FieldNumber(379)]
  public FixString BusinessRejectRefID { get; set; }
    
  [FieldNumber(58)]
  public FixString Text { get; set; }
    
  [FieldNumber(354)]
  public Length EncodedTextLen { get; set; }
    
  [FieldNumber(355)]
  public FixData EncodedText { get; set; }

}
