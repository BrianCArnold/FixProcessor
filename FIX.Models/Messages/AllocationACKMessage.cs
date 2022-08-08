namespace FIX.Models;

[MessageCode("P")]
public class AllocationACKMessage : FixMessage<AllocationACKMessage>
{
    
  [FieldNumber(70)]    
  [RequiredField]
  public FixString AllocID { get; set; }
    
  [FieldNumber(75)]    
  [RequiredField]
  public LocalMktDate TradeDate { get; set; }
    
  [FieldNumber(87)]    
  [RequiredField]
  public FixInt AllocStatus { get; set; }
    
  [FieldNumber(109)]
  public FixString ClientID { get; set; }
    
  [FieldNumber(76)]
  public FixString ExecBroker { get; set; }
    
  [FieldNumber(60)]
  public UTCTimeStamp TransactTime { get; set; }
    
  [FieldNumber(88)]
  public FixInt AllocRejCode { get; set; }
    
  [FieldNumber(58)]
  public FixString Text { get; set; }
    
  [FieldNumber(354)]
  public Length EncodedTextLen { get; set; }
    
  [FieldNumber(355)]
  public FixData EncodedText { get; set; }

}
