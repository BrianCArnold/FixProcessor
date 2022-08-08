namespace FIX.Models;

[MessageCode("k")]
public class BidRequestMessage : FixMessage<BidRequestMessage>
{
    
  [FieldNumber(391)]    
  [RequiredField]
  public FixString ClientBidID { get; set; }
    
  [FieldNumber(374)]    
  [RequiredField]
  public FixChar BidRequestTransType { get; set; }
    
  [FieldNumber(393)]    
  [RequiredField]
  public FixInt TotalNumSecurities { get; set; }
    
  [FieldNumber(394)]    
  [RequiredField]
  public FixInt BidType { get; set; }
    
  [FieldNumber(418)]    
  [RequiredField]
  public FixChar TradeType { get; set; }
    
  [FieldNumber(419)]    
  [RequiredField]
  public FixChar BasisPxType { get; set; }
    
  [FieldNumber(390)]
  public FixString BidID { get; set; }
    
  [FieldNumber(392)]
  public FixString ListName { get; set; }
    
  [FieldNumber(395)]
  public FixInt NumTickets { get; set; }
    
  [FieldNumber(15)]
  public Currency Currency { get; set; }
    
  [FieldNumber(396)]
  public Amt SideValue1 { get; set; }
    
  [FieldNumber(397)]
  public Amt SideValue2 { get; set; }
    
  [FieldNumber(398)]    
  [FieldChildrenNumbers(399, 400, 401, 404, 441, 402, 403, 405, 406, 407, 408)]
  public FixInt NoBidDescriptors { get; set; }

  [FieldNumberTarget(398)]
  public ICollection<BidDescriptorsClass> BidDescriptors { get; set; } = new List<BidDescriptorsClass>();
  [FieldNumberTarget(398)]
  public class BidDescriptorsClass
  {    
    [FieldNumber(399)]
    public FixInt BidDescriptorType { get; set; }
    
    [FieldNumber(400)]
    public FixString BidDescriptor { get; set; }
    
    [FieldNumber(401)]
    public FixInt SideValueInd { get; set; }
    
    [FieldNumber(404)]
    public Amt LiquidityValue { get; set; }
    
    [FieldNumber(441)]
    public FixInt LiquidityNumSecurities { get; set; }
    
    [FieldNumber(402)]
    public FixDecimal LiquidityPctLow { get; set; }
    
    [FieldNumber(403)]
    public FixDecimal LiquidityPctHigh { get; set; }
    
    [FieldNumber(405)]
    public FixDecimal EFPTrackingError { get; set; }
    
    [FieldNumber(406)]
    public Amt FairValue { get; set; }
    
    [FieldNumber(407)]
    public FixDecimal OutsideIndexPct { get; set; }
    
    [FieldNumber(408)]
    public Amt ValueOfFutures { get; set; }
  }
    
  [FieldNumber(420)]    
  [FieldChildrenNumbers(66, 54, 336, 430, 63, 64, 1)]
  public FixInt NoBidComponents { get; set; }

  [FieldNumberTarget(420)]
  public ICollection<BidComponentsClass> BidComponents { get; set; } = new List<BidComponentsClass>();
  [FieldNumberTarget(420)]
  public class BidComponentsClass
  {    
    [FieldNumber(66)]
    public FixString ListID { get; set; }
    
    [FieldNumber(54)]
    public FixChar Side { get; set; }
    
    [FieldNumber(336)]
    public FixString TradingSessionID { get; set; }
    
    [FieldNumber(430)]
    public FixInt NetGrossInd { get; set; }
    
    [FieldNumber(63)]
    public FixChar SettlmntTyp { get; set; }
    
    [FieldNumber(64)]
    public LocalMktDate FutSettDate { get; set; }
    
    [FieldNumber(1)]
    public FixString Account { get; set; }
  }
    
  [FieldNumber(409)]
  public FixInt LiquidityIndType { get; set; }
    
  [FieldNumber(410)]
  public FixDecimal WtAverageLiquidity { get; set; }
    
  [FieldNumber(411)]
  public FixBool ExchangeForPhysical { get; set; }
    
  [FieldNumber(412)]
  public Amt OutMainCntryUIndex { get; set; }
    
  [FieldNumber(413)]
  public FixDecimal CrossPercent { get; set; }
    
  [FieldNumber(414)]
  public FixInt ProgRptReqs { get; set; }
    
  [FieldNumber(415)]
  public FixInt ProgPeriodInterval { get; set; }
    
  [FieldNumber(416)]
  public FixInt IncTaxInd { get; set; }
    
  [FieldNumber(121)]
  public FixBool ForexReq { get; set; }
    
  [FieldNumber(417)]
  public FixInt NumBidders { get; set; }
    
  [FieldNumber(75)]
  public LocalMktDate TradeDate { get; set; }
    
  [FieldNumber(443)]
  public UTCTimeStamp StrikeTime { get; set; }
    
  [FieldNumber(58)]
  public FixString Text { get; set; }
    
  [FieldNumber(354)]
  public Length EncodedTextLen { get; set; }
    
  [FieldNumber(355)]
  public FixData EncodedText { get; set; }

}
