
namespace FIX.Models;
[MessageCode("0")]
public class Heartbeat
{
    
    [FieldNumber("112")]
    public FixString? TestReqID { get; set; }

}
