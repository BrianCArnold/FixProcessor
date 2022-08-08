namespace FIX.Models;

[MessageCode("l")]
public class BidResponseMessage : FixMessage<BidResponseMessage>
{
    
  [FieldNumber(420)]    
  [FieldChildrenNumbers(12, 13, 66, 421, 54, 44, 423, 406, 430, 63, 64, 336, 58, 354, 355)]    
  [RequiredField]
  public FixInt NoBidComponents { get; set; }

  [FieldNumberTarget(420)]
  public ICollection<BidComponentsClass> BidComponentsCollection { get; set; } = new List<BidComponentsClass>();
  [FieldNumberTarget(420)]
  public class BidComponentsClass
  {    
    [FieldNumber(12)]    
    [RequiredField]
    public Amt Commission { get; set; }
    
    [FieldNumber(13)]    
    [RequiredField]
    public FixChar CommType { get; set; }
    
    [FieldNumber(66)]
    public FixString ListID { get; set; }
    
    [FieldNumber(421)]
    public FixString Country { get; set; }
    
    [FieldNumber(54)]
    public FixChar Side { get; set; }
    
    [FieldNumber(44)]
    public Price Price { get; set; }
    
    [FieldNumber(423)]
    public FixInt PriceType { get; set; }
    
    [FieldNumber(406)]
    public Amt FairValue { get; set; }
    
    [FieldNumber(430)]
    public FixInt NetGrossInd { get; set; }
    
    [FieldNumber(63)]
    public FixChar SettlmntTyp { get; set; }
    
    [FieldNumber(64)]
    public LocalMktDate FutSettDate { get; set; }
    
    [FieldNumber(336)]
    public FixString TradingSessionID { get; set; }
    
    [FieldNumber(58)]
    public FixString Text { get; set; }
    
    [FieldNumber(354)]
    public Length EncodedTextLen { get; set; }
    
    [FieldNumber(355)]
    public FixData EncodedText { get; set; }
  }
    
  [FieldNumber(390)]
  public FixString BidID { get; set; }
    
  [FieldNumber(391)]
  public FixString ClientBidID { get; set; }

}
