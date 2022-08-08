namespace FIX.Models;

[MessageCode("2")]
public class ResendRequestMessage : FixMessageComponent<ResendRequestMessage>
{
    
  [FieldNumber(7)]    
  [RequiredField]
  public FixInt BeginSeqNo { get; set; }
    
  [FieldNumber(16)]    
  [RequiredField]
  public FixInt EndSeqNo { get; set; }

}
