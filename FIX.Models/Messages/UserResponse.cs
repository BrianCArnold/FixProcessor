
namespace FIX.Models;
[MessageCode("BF")]
public class UserResponse
{
    
    [FieldNumber("923")]
    public FixString UserRequestID { get; set; }
    
    [FieldNumber("553")]
    public FixString Username { get; set; }
    
    [FieldNumber("926")]
    public FixInt? UserStatus { get; set; }
    
    [FieldNumber("927")]
    public FixString? UserStatusText { get; set; }

}
