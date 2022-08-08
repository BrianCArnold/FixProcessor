namespace FIX.Models;

[MessageCode("Y")]
public class MarketDataRequestRejectMessage : FixMessage<MarketDataRequestRejectMessage>
{
    
  [FieldNumber(262)]    
  [RequiredField]
  public FixString MDReqID { get; set; }
    
  [FieldNumber(281)]
  public FixChar MDReqRejReason { get; set; }
    
  [FieldNumber(58)]
  public FixString Text { get; set; }
    
  [FieldNumber(354)]
  public Length EncodedTextLen { get; set; }
    
  [FieldNumber(355)]
  public FixData EncodedText { get; set; }

}
