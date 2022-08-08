namespace FIX.Models;

[MessageCode("1")]
public class TestRequestMessage : FixMessageComponent<TestRequestMessage>
{
    
  [FieldNumber(112)]    
  [RequiredField]
  public FixString TestReqID { get; set; }

}
