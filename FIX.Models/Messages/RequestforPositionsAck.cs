
namespace FIX.Models;
[MessageCode("AO")]
public class RequestforPositionsAck
{
    
    [FieldNumber("721")]
    public FixString PosMaintRptID { get; set; }
    
    [FieldNumber("728")]
    public FixInt PosReqResult { get; set; }
    
    [FieldNumber("729")]
    public FixInt PosReqStatus { get; set; }
    
    [FieldNumber("1")]
    public FixString Account { get; set; }
    
    [FieldNumber("581")]
    public FixInt AccountType { get; set; }
    
    [FieldNumber("710")]
    public FixString? PosReqID { get; set; }
    
    [FieldNumber("727")]
    public FixInt? TotalNumPosReports { get; set; }
    
    [FieldNumber("325")]
    public FixBool? UnsolicitedIndicator { get; set; }
    
    [FieldNumber("660")]
    public FixInt? AcctIDSource { get; set; }
    
    [FieldNumber("15")]
    public Currency? Currency { get; set; }
    
    [FieldNumber("555")]
    public NumInGroup? NoLegs { get; set; }
    
    [FieldNumber("711")]
    public NumInGroup? NoUnderlyings { get; set; }
    
    [FieldNumber("725")]
    public FixInt? ResponseTransportType { get; set; }
    
    [FieldNumber("726")]
    public FixString? ResponseDestination { get; set; }
    
    [FieldNumber("58")]
    public FixString? Text { get; set; }
    
    [FieldNumber("354")]
    public Length? EncodedTextLen { get; set; }
    
    [FieldNumber("355")]
    public FixData? EncodedText { get; set; }

}
