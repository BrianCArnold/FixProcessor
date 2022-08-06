
namespace FIX.Models;
[MessageCode("AW")]
public class AssignmentReport
{
    
    [FieldNumber("833")]
    public FixString AsgnRptID { get; set; }
    
    [FieldNumber("581")]
    public FixInt AccountType { get; set; }
    
    [FieldNumber("730")]
    public Price SettlPrice { get; set; }
    
    [FieldNumber("731")]
    public FixInt SettlPriceType { get; set; }
    
    [FieldNumber("732")]
    public Price UnderlyingSettlPrice { get; set; }
    
    [FieldNumber("744")]
    public FixChar AssignmentMethod { get; set; }
    
    [FieldNumber("746")]
    public Amt OpenInterest { get; set; }
    
    [FieldNumber("747")]
    public FixChar ExerciseMethod { get; set; }
    
    [FieldNumber("716")]
    public FixString SettlSessID { get; set; }
    
    [FieldNumber("717")]
    public FixString SettlSessSubID { get; set; }
    
    [FieldNumber("715")]
    public LocalMktDate ClearingBusinessDate { get; set; }
    
    [FieldNumber("832")]
    public FixInt? TotNumAssignmentReports { get; set; }
    
    [FieldNumber("912")]
    public FixBool? LastRptRequested { get; set; }
    
    [FieldNumber("1")]
    public FixString? Account { get; set; }
    
    [FieldNumber("15")]
    public Currency? Currency { get; set; }
    
    [FieldNumber("555")]
    public NumInGroup? NoLegs { get; set; }
    
    [FieldNumber("711")]
    public NumInGroup? NoUnderlyings { get; set; }
    
    [FieldNumber("834")]
    public PriceOffset? ThresholdAmount { get; set; }
    
    [FieldNumber("432")]
    public LocalMktDate? ExpireDate { get; set; }
    
    [FieldNumber("745")]
    public Qty? AssignmentUnit { get; set; }
    
    [FieldNumber("58")]
    public FixString? Text { get; set; }
    
    [FieldNumber("354")]
    public Length? EncodedTextLen { get; set; }
    
    [FieldNumber("355")]
    public FixData? EncodedText { get; set; }

}
