namespace FIX.Models;

[MessageCode("K")]
public class ListCancelRequestMessage : FixMessageComponent<ListCancelRequestMessage>
{
    
  [FieldNumber(66)]    
  [RequiredField]
  public FixString ListID { get; set; }
    
  [FieldNumber(60)]    
  [RequiredField]
  public UTCTimeStamp TransactTime { get; set; }
    
  [FieldNumber(58)]
  public FixString Text { get; set; }
    
  [FieldNumber(354)]
  public Length EncodedTextLen { get; set; }
    
  [FieldNumber(355)]
  public FixData EncodedText { get; set; }

}
