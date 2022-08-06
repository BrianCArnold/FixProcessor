
namespace FIX.Models;
[MessageCode("W")]
public class MarketDataSnapshotFullRefresh
{
    
    [FieldNumber("268")]
    public NumInGroup NoMDEntries { get; set; }
    
    [FieldNumber("262")]
    public FixString? MDReqID { get; set; }
    
    [FieldNumber("711")]
    public NumInGroup? NoUnderlyings { get; set; }
    
    [FieldNumber("555")]
    public NumInGroup? NoLegs { get; set; }
    
    [FieldNumber("291")]
    public MultipleValueString? FinancialStatus { get; set; }
    
    [FieldNumber("292")]
    public MultipleValueString? CorporateAction { get; set; }
    
    [FieldNumber("451")]
    public PriceOffset? NetChgPrevDay { get; set; }
    
    [FieldNumber("813")]
    public FixInt? ApplQueueDepth { get; set; }
    
    [FieldNumber("814")]
    public FixInt? ApplQueueResolution { get; set; }

}
