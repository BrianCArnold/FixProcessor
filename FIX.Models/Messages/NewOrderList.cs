
namespace FIX.Models;
[MessageCode("E")]
public class NewOrderList
{
    
    [FieldNumber("66")]
    public FixString ListID { get; set; }
    
    [FieldNumber("394")]
    public FixInt BidType { get; set; }
    
    [FieldNumber("68")]
    public FixInt TotNoOrders { get; set; }
    
    [FieldNumber("73")]
    public NumInGroup NoOrders { get; set; }
    
    [FieldNumber("390")]
    public FixString? BidID { get; set; }
    
    [FieldNumber("391")]
    public FixString? ClientBidID { get; set; }
    
    [FieldNumber("414")]
    public FixInt? ProgRptReqs { get; set; }
    
    [FieldNumber("415")]
    public FixInt? ProgPeriodInterval { get; set; }
    
    [FieldNumber("480")]
    public FixChar? CancellationRights { get; set; }
    
    [FieldNumber("481")]
    public FixChar? MoneyLaunderingStatus { get; set; }
    
    [FieldNumber("513")]
    public FixString? RegistID { get; set; }
    
    [FieldNumber("433")]
    public FixChar? ListExecInstType { get; set; }
    
    [FieldNumber("69")]
    public FixString? ListExecInst { get; set; }
    
    [FieldNumber("352")]
    public Length? EncodedListExecInstLen { get; set; }
    
    [FieldNumber("353")]
    public FixData? EncodedListExecInst { get; set; }
    
    [FieldNumber("765")]
    public Percentage? AllowableOneSidednessPct { get; set; }
    
    [FieldNumber("766")]
    public Amt? AllowableOneSidednessValue { get; set; }
    
    [FieldNumber("767")]
    public Currency? AllowableOneSidednessCurr { get; set; }
    
    [FieldNumber("893")]
    public FixBool? LastFragment { get; set; }

}
