
namespace FIX.Models;
[MessageCode("X")]
public class MarketDataIncrementalRefresh
{
    
    [FieldNumber("268")]
    public NumInGroup NoMDEntries { get; set; }
    
    [FieldNumber("262")]
    public FixString? MDReqID { get; set; }
    
    [FieldNumber("813")]
    public FixInt? ApplQueueDepth { get; set; }
    
    [FieldNumber("814")]
    public FixInt? ApplQueueResolution { get; set; }

}
