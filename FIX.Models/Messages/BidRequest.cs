
namespace FIX.Models;
[MessageCode("k")]
public class BidRequest
{
    
    [FieldNumber("391")]
    public FixString ClientBidID { get; set; }
    
    [FieldNumber("374")]
    public FixChar BidRequestTransType { get; set; }
    
    [FieldNumber("393")]
    public FixInt TotNoRelatedSym { get; set; }
    
    [FieldNumber("394")]
    public FixInt BidType { get; set; }
    
    [FieldNumber("418")]
    public FixChar BidTradeType { get; set; }
    
    [FieldNumber("419")]
    public FixChar BasisPxType { get; set; }
    
    [FieldNumber("390")]
    public FixString? BidID { get; set; }
    
    [FieldNumber("392")]
    public FixString? ListName { get; set; }
    
    [FieldNumber("395")]
    public FixInt? NumTickets { get; set; }
    
    [FieldNumber("15")]
    public Currency? Currency { get; set; }
    
    [FieldNumber("396")]
    public Amt? SideValue1 { get; set; }
    
    [FieldNumber("397")]
    public Amt? SideValue2 { get; set; }
    
    [FieldNumber("398")]
    public NumInGroup? NoBidDescriptors { get; set; }
    
    [FieldNumber("420")]
    public NumInGroup? NoBidComponents { get; set; }
    
    [FieldNumber("409")]
    public FixInt? LiquidityIndType { get; set; }
    
    [FieldNumber("410")]
    public Percentage? WtAverageLiquidity { get; set; }
    
    [FieldNumber("411")]
    public FixBool? ExchangeForPhysical { get; set; }
    
    [FieldNumber("412")]
    public Amt? OutMainCntryUIndex { get; set; }
    
    [FieldNumber("413")]
    public Percentage? CrossPercent { get; set; }
    
    [FieldNumber("414")]
    public FixInt? ProgRptReqs { get; set; }
    
    [FieldNumber("415")]
    public FixInt? ProgPeriodInterval { get; set; }
    
    [FieldNumber("416")]
    public FixInt? IncTaxInd { get; set; }
    
    [FieldNumber("121")]
    public FixBool? ForexReq { get; set; }
    
    [FieldNumber("417")]
    public FixInt? NumBidders { get; set; }
    
    [FieldNumber("75")]
    public LocalMktDate? TradeDate { get; set; }
    
    [FieldNumber("443")]
    public UTCTimestamp? StrikeTime { get; set; }
    
    [FieldNumber("58")]
    public FixString? Text { get; set; }
    
    [FieldNumber("354")]
    public Length? EncodedTextLen { get; set; }
    
    [FieldNumber("355")]
    public FixData? EncodedText { get; set; }

}
