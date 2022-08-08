namespace FIX.Models;

public class StandardHeader : FixMessageComponent<StandardHeader>
{
    
  [FieldNumber(8)]    
  [RequiredField]
  public FixString BeginString { get; set; }
    
  [FieldNumber(9)]    
  [RequiredField]
  public FixInt BodyLength { get; set; }
    
  [FieldNumber(35)]    
  [RequiredField]
  public FixString MsgType { get; set; }
    
  [FieldNumber(49)]    
  [RequiredField]
  public FixString SenderCompID { get; set; }
    
  [FieldNumber(56)]    
  [RequiredField]
  public FixString TargetCompID { get; set; }
    
  [FieldNumber(34)]    
  [RequiredField]
  public FixInt MsgSeqNum { get; set; }
    
  [FieldNumber(52)]    
  [RequiredField]
  public UTCTimeStamp SendingTime { get; set; }
    
  [FieldNumber(115)]
  public FixString OnBehalfOfCompID { get; set; }
    
  [FieldNumber(128)]
  public FixString DeliverToCompID { get; set; }
    
  [FieldNumber(90)]
  public Length SecureDataLen { get; set; }
    
  [FieldNumber(91)]
  public FixData SecureData { get; set; }
    
  [FieldNumber(50)]
  public FixString SenderSubID { get; set; }
    
  [FieldNumber(142)]
  public FixString SenderLocationID { get; set; }
    
  [FieldNumber(57)]
  public FixString TargetSubID { get; set; }
    
  [FieldNumber(143)]
  public FixString TargetLocationID { get; set; }
    
  [FieldNumber(116)]
  public FixString OnBehalfOfSubID { get; set; }
    
  [FieldNumber(144)]
  public FixString OnBehalfOfLocationID { get; set; }
    
  [FieldNumber(129)]
  public FixString DeliverToSubID { get; set; }
    
  [FieldNumber(145)]
  public FixString DeliverToLocationID { get; set; }
    
  [FieldNumber(43)]
  public FixBool PossDupFlag { get; set; }
    
  [FieldNumber(97)]
  public FixBool PossResend { get; set; }
    
  [FieldNumber(122)]
  public UTCTimeStamp OrigSendingTime { get; set; }
    
  [FieldNumber(212)]
  public Length XmlDataLen { get; set; }
    
  [FieldNumber(213)]
  public FixData XmlData { get; set; }
    
  [FieldNumber(347)]
  public FixString MessageEncoding { get; set; }
    
  [FieldNumber(369)]
  public FixInt LastMsgSeqNumProcessed { get; set; }
    
  [FieldNumber(370)]
  public UTCTimeStamp OnBehalfOfSendingTime { get; set; }

}
