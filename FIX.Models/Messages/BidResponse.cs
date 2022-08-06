
namespace FIX.Models;
[MessageCode("l")]
public class BidResponse
{
    
    [FieldNumber("420")]
    public NumInGroup NoBidComponents { get; set; }
    
    [FieldNumber("390")]
    public FixString? BidID { get; set; }
    
    [FieldNumber("391")]
    public FixString? ClientBidID { get; set; }

}
