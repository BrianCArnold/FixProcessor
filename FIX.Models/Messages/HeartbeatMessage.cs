namespace FIX.Models;

[MessageCode("0")]
public class HeartbeatMessage : FixMessageComponent<HeartbeatMessage>
{
    
  [FieldNumber(112)]
  public FixString TestReqID { get; set; }

}
