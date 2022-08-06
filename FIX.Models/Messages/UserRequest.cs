
namespace FIX.Models;
[MessageCode("BE")]
public class UserRequest
{
    
    [FieldNumber("923")]
    public FixString UserRequestID { get; set; }
    
    [FieldNumber("924")]
    public FixInt UserRequestType { get; set; }
    
    [FieldNumber("553")]
    public FixString Username { get; set; }
    
    [FieldNumber("554")]
    public FixString? Password { get; set; }
    
    [FieldNumber("925")]
    public FixString? NewPassword { get; set; }
    
    [FieldNumber("95")]
    public Length? RawDataLength { get; set; }
    
    [FieldNumber("96")]
    public FixData? RawData { get; set; }

}
