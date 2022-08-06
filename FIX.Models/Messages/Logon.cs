
namespace FIX.Models;
[MessageCode("A")]
public class Logon
{
    
    [FieldNumber("98")]
    public FixInt EncryptMethod { get; set; }
    
    [FieldNumber("108")]
    public FixInt HeartBtInt { get; set; }
    
    [FieldNumber("95")]
    public Length? RawDataLength { get; set; }
    
    [FieldNumber("96")]
    public FixData? RawData { get; set; }
    
    [FieldNumber("141")]
    public FixBool? ResetSeqNumFlag { get; set; }
    
    [FieldNumber("789")]
    public SeqNum? NextExpectedMsgSeqNum { get; set; }
    
    [FieldNumber("383")]
    public Length? MaxMessageSize { get; set; }
    
    [FieldNumber("384")]
    public NumInGroup? NoMsgTypes { get; set; }
    
    [FieldNumber("464")]
    public FixBool? TestMessageIndicator { get; set; }
    
    [FieldNumber("553")]
    public FixString? Username { get; set; }
    
    [FieldNumber("554")]
    public FixString? Password { get; set; }

}
