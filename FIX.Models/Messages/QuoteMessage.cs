namespace FIX.Models;

[MessageCode("S")]
public class QuoteMessage : FixMessage<QuoteMessage>
{
    
  [FieldNumber(117)]    
  [RequiredField]
  public FixString QuoteID { get; set; }
    
  [FieldNumber(55)]    
  [RequiredField]
  public FixString Symbol { get; set; }
    
  [FieldNumber(131)]
  public FixString QuoteReqID { get; set; }
    
  [FieldNumber(301)]
  public FixInt QuoteResponseLevel { get; set; }
    
  [FieldNumber(336)]
  public FixString TradingSessionID { get; set; }
    
  [FieldNumber(65)]
  public FixString SymbolSfx { get; set; }
    
  [FieldNumber(48)]
  public FixString SecurityID { get; set; }
    
  [FieldNumber(22)]
  public FixString IDSource { get; set; }
    
  [FieldNumber(167)]
  public FixString SecurityType { get; set; }
    
  [FieldNumber(200)]
  public MonthYear MaturityMonthYear { get; set; }
    
  [FieldNumber(205)]
  public DayOfMonth MaturityDay { get; set; }
    
  [FieldNumber(201)]
  public FixInt PutOrCall { get; set; }
    
  [FieldNumber(202)]
  public Price StrikePrice { get; set; }
    
  [FieldNumber(206)]
  public FixChar OptAttribute { get; set; }
    
  [FieldNumber(231)]
  public FixDecimal ContractMultiplier { get; set; }
    
  [FieldNumber(223)]
  public FixDecimal CouponRate { get; set; }
    
  [FieldNumber(207)]
  public Exchange SecurityExchange { get; set; }
    
  [FieldNumber(106)]
  public FixString Issuer { get; set; }
    
  [FieldNumber(348)]
  public Length EncodedIssuerLen { get; set; }
    
  [FieldNumber(349)]
  public FixData EncodedIssuer { get; set; }
    
  [FieldNumber(107)]
  public FixString SecurityDesc { get; set; }
    
  [FieldNumber(350)]
  public Length EncodedSecurityDescLen { get; set; }
    
  [FieldNumber(351)]
  public FixData EncodedSecurityDesc { get; set; }
    
  [FieldNumber(132)]
  public Price BidPx { get; set; }
    
  [FieldNumber(133)]
  public Price OfferPx { get; set; }
    
  [FieldNumber(134)]
  public Quantity BidSize { get; set; }
    
  [FieldNumber(135)]
  public Quantity OfferSize { get; set; }
    
  [FieldNumber(62)]
  public UTCTimeStamp ValidUntilTime { get; set; }
    
  [FieldNumber(188)]
  public Price BidSpotRate { get; set; }
    
  [FieldNumber(190)]
  public Price OfferSpotRate { get; set; }
    
  [FieldNumber(189)]
  public PriceOffset BidForwardPoints { get; set; }
    
  [FieldNumber(191)]
  public PriceOffset OfferForwardPoints { get; set; }
    
  [FieldNumber(60)]
  public UTCTimeStamp TransactTime { get; set; }
    
  [FieldNumber(64)]
  public LocalMktDate FutSettDate { get; set; }
    
  [FieldNumber(40)]
  public FixChar OrdType { get; set; }
    
  [FieldNumber(193)]
  public LocalMktDate FutSettDate2 { get; set; }
    
  [FieldNumber(192)]
  public Quantity OrderQty2 { get; set; }
    
  [FieldNumber(15)]
  public Currency Currency { get; set; }

}
