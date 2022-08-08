namespace FIX.Models;

[MessageCode("5")]
public class LogoutMessage : FixMessage<LogoutMessage>
{
    
  [FieldNumber(58)]
  public FixString Text { get; set; }
    
  [FieldNumber(354)]
  public Length EncodedTextLen { get; set; }
    
  [FieldNumber(355)]
  public FixData EncodedText { get; set; }

}
