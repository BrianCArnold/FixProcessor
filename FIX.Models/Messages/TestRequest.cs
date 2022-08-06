
namespace FIX.Models;
[MessageCode("1")]
public class TestRequest
{
    
    [FieldNumber("112")]
    public FixString TestReqID { get; set; }

}
