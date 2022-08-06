
namespace FIX.Models;
[MessageCode("h")]
public class TradingSessionStatus
{
    
    [FieldNumber("336")]
    public FixString TradingSessionID { get; set; }
    
    [FieldNumber("340")]
    public FixInt TradSesStatus { get; set; }
    
    [FieldNumber("335")]
    public FixString? TradSesReqID { get; set; }
    
    [FieldNumber("625")]
    public FixString? TradingSessionSubID { get; set; }
    
    [FieldNumber("338")]
    public FixInt? TradSesMethod { get; set; }
    
    [FieldNumber("339")]
    public FixInt? TradSesMode { get; set; }
    
    [FieldNumber("325")]
    public FixBool? UnsolicitedIndicator { get; set; }
    
    [FieldNumber("567")]
    public FixInt? TradSesStatusRejReason { get; set; }
    
    [FieldNumber("341")]
    public UTCTimestamp? TradSesStartTime { get; set; }
    
    [FieldNumber("342")]
    public UTCTimestamp? TradSesOpenTime { get; set; }
    
    [FieldNumber("343")]
    public UTCTimestamp? TradSesPreCloseTime { get; set; }
    
    [FieldNumber("344")]
    public UTCTimestamp? TradSesCloseTime { get; set; }
    
    [FieldNumber("345")]
    public UTCTimestamp? TradSesEndTime { get; set; }
    
    [FieldNumber("387")]
    public Qty? TotalVolumeTraded { get; set; }
    
    [FieldNumber("58")]
    public FixString? Text { get; set; }
    
    [FieldNumber("354")]
    public Length? EncodedTextLen { get; set; }
    
    [FieldNumber("355")]
    public FixData? EncodedText { get; set; }

}
