namespace FIX.Models;

[MessageCode("0")]
public class HeartbeatMessage : FixMessage<HeartbeatMessage>
{
    
  [FieldNumber(112)]
  public FixString TestReqID { get; set; }

}
