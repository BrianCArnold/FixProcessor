namespace FIX.Models;

[MessageCode("g")]
public class TradingSessionStatusRequestMessage : FixMessageComponent<TradingSessionStatusRequestMessage>
{
    
  [FieldNumber(335)]    
  [RequiredField]
  public FixString TradSesReqID { get; set; }
    
  [FieldNumber(263)]    
  [RequiredField]
  public FixChar SubscriptionRequestType { get; set; }
    
  [FieldNumber(336)]
  public FixString TradingSessionID { get; set; }
    
  [FieldNumber(338)]
  public FixInt TradSesMethod { get; set; }
    
  [FieldNumber(339)]
  public FixInt TradSesMode { get; set; }

}
