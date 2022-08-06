
namespace FIX.Models;
[MessageCode("AH")]
public class RFQRequest
{
    
    [FieldNumber("644")]
    public FixString RFQReqID { get; set; }
    
    [FieldNumber("146")]
    public NumInGroup NoRelatedSym { get; set; }
    
    [FieldNumber("263")]
    public FixChar? SubscriptionRequestType { get; set; }

}
