
namespace FIX.Models;
[MessageCode("4")]
public class SequenceReset
{
    
    [FieldNumber("36")]
    public SeqNum NewSeqNo { get; set; }
    
    [FieldNumber("123")]
    public FixBool? GapFillFlag { get; set; }

}
