namespace FIX.Models;

[MessageCode("4")]
public class SequenceResetMessage : FixMessage<SequenceResetMessage>
{
    
  [FieldNumber(36)]    
  [RequiredField]
  public FixInt NewSeqNo { get; set; }
    
  [FieldNumber(123)]
  public FixBool GapFillFlag { get; set; }

}
