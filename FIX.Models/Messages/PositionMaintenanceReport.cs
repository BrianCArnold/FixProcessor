
namespace FIX.Models;
[MessageCode("AM")]
public class PositionMaintenanceReport
{
    
    [FieldNumber("721")]
    public FixString PosMaintRptID { get; set; }
    
    [FieldNumber("709")]
    public FixInt PosTransType { get; set; }
    
    [FieldNumber("712")]
    public FixInt PosMaintAction { get; set; }
    
    [FieldNumber("713")]
    public FixString OrigPosReqRefID { get; set; }
    
    [FieldNumber("722")]
    public FixInt PosMaintStatus { get; set; }
    
    [FieldNumber("715")]
    public LocalMktDate ClearingBusinessDate { get; set; }
    
    [FieldNumber("1")]
    public FixString Account { get; set; }
    
    [FieldNumber("581")]
    public FixInt AccountType { get; set; }
    
    [FieldNumber("60")]
    public UTCTimestamp TransactTime { get; set; }
    
    [FieldNumber("710")]
    public FixString? PosReqID { get; set; }
    
    [FieldNumber("723")]
    public FixInt? PosMaintResult { get; set; }
    
    [FieldNumber("716")]
    public FixString? SettlSessID { get; set; }
    
    [FieldNumber("717")]
    public FixString? SettlSessSubID { get; set; }
    
    [FieldNumber("660")]
    public FixInt? AcctIDSource { get; set; }
    
    [FieldNumber("15")]
    public Currency? Currency { get; set; }
    
    [FieldNumber("555")]
    public NumInGroup? NoLegs { get; set; }
    
    [FieldNumber("711")]
    public NumInGroup? NoUnderlyings { get; set; }
    
    [FieldNumber("386")]
    public NumInGroup? NoTradingSessions { get; set; }
    
    [FieldNumber("718")]
    public FixInt? AdjustmentType { get; set; }
    
    [FieldNumber("834")]
    public PriceOffset? ThresholdAmount { get; set; }
    
    [FieldNumber("58")]
    public FixString? Text { get; set; }
    
    [FieldNumber("354")]
    public Length? EncodedTextLen { get; set; }
    
    [FieldNumber("355")]
    public FixData? EncodedText { get; set; }

}
