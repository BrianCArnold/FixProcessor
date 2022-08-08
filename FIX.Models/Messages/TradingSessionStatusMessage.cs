namespace FIX.Models;

[MessageCode("h")]
public class TradingSessionStatusMessage : FixMessage<TradingSessionStatusMessage>
{
    
  [FieldNumber(336)]    
  [RequiredField]
  public FixString TradingSessionID { get; set; }
    
  [FieldNumber(340)]    
  [RequiredField]
  public FixInt TradSesStatus { get; set; }
    
  [FieldNumber(335)]
  public FixString TradSesReqID { get; set; }
    
  [FieldNumber(338)]
  public FixInt TradSesMethod { get; set; }
    
  [FieldNumber(339)]
  public FixInt TradSesMode { get; set; }
    
  [FieldNumber(325)]
  public FixBool UnsolicitedIndicator { get; set; }
    
  [FieldNumber(341)]
  public UTCTimeStamp TradSesStartTime { get; set; }
    
  [FieldNumber(342)]
  public UTCTimeStamp TradSesOpenTime { get; set; }
    
  [FieldNumber(343)]
  public UTCTimeStamp TradSesPreCloseTime { get; set; }
    
  [FieldNumber(344)]
  public UTCTimeStamp TradSesCloseTime { get; set; }
    
  [FieldNumber(345)]
  public UTCTimeStamp TradSesEndTime { get; set; }
    
  [FieldNumber(387)]
  public Qty TotalVolumeTraded { get; set; }
    
  [FieldNumber(58)]
  public FixString Text { get; set; }
    
  [FieldNumber(354)]
  public Length EncodedTextLen { get; set; }
    
  [FieldNumber(355)]
  public FixData EncodedText { get; set; }

}
