namespace FIX.Models;

[MessageCode("A")]
public class LogonMessage : FixMessage<LogonMessage>
{
    
  [FieldNumber(98)]    
  [RequiredField]
  public FixInt EncryptMethod { get; set; }
    
  [FieldNumber(108)]    
  [RequiredField]
  public FixInt HeartBtInt { get; set; }
    
  [FieldNumber(95)]
  public Length RawDataLength { get; set; }
    
  [FieldNumber(96)]
  public FixData RawData { get; set; }
    
  [FieldNumber(141)]
  public FixBool ResetSeqNumFlag { get; set; }
    
  [FieldNumber(383)]
  public FixInt MaxMessageSize { get; set; }
    
  [FieldNumber(384)]    
  [FieldChildrenNumbers(372, 385)]
  public FixInt NoMsgTypes { get; set; }

  [FieldNumberTarget(384)]
  public ICollection<MsgTypesClass> MsgTypesCollection { get; set; } = new List<MsgTypesClass>();
  [FieldNumberTarget(384)]
  public class MsgTypesClass
  {    
    [FieldNumber(372)]
    public FixString RefMsgType { get; set; }
    
    [FieldNumber(385)]
    public FixChar MsgDirection { get; set; }
  }

}
