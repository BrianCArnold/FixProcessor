
namespace FIX.Models;
[MessageCode("V")]
public class MarketDataRequest
{
    
    [FieldNumber("262")]
    public FixString MDReqID { get; set; }
    
    [FieldNumber("263")]
    public FixChar SubscriptionRequestType { get; set; }
    
    [FieldNumber("264")]
    public FixInt MarketDepth { get; set; }
    
    [FieldNumber("267")]
    public NumInGroup NoMDEntryTypes { get; set; }
    
    [FieldNumber("146")]
    public NumInGroup NoRelatedSym { get; set; }
    
    [FieldNumber("265")]
    public FixInt? MDUpdateType { get; set; }
    
    [FieldNumber("266")]
    public FixBool? AggregatedBook { get; set; }
    
    [FieldNumber("286")]
    public MultipleValueString? OpenCloseSettlFlag { get; set; }
    
    [FieldNumber("546")]
    public MultipleValueString? Scope { get; set; }
    
    [FieldNumber("547")]
    public FixBool? MDImplicitDelete { get; set; }
    
    [FieldNumber("386")]
    public NumInGroup? NoTradingSessions { get; set; }
    
    [FieldNumber("815")]
    public FixInt? ApplQueueAction { get; set; }
    
    [FieldNumber("812")]
    public FixInt? ApplQueueMax { get; set; }

}
