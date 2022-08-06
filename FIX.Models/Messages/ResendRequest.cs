
namespace FIX.Models;
[MessageCode("2")]
public class ResendRequest
{
    
    [FieldNumber("7")]
    public SeqNum BeginSeqNo { get; set; }
    
    [FieldNumber("16")]
    public SeqNum EndSeqNo { get; set; }

}
