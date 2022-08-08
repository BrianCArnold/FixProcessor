namespace FIX.Models;

[MessageCode("i")]
public class MassQuoteMessage : FixMessage<MassQuoteMessage>
{
    
  [FieldNumber(117)]    
  [RequiredField]
  public FixString QuoteID { get; set; }
    
  [FieldNumber(296)]    
  [FieldChildrenNumbers(302, 311, 312, 309, 305, 310, 313, 314, 315, 316, 317, 436, 435, 308, 306, 362, 363, 307, 364, 365, 367, 304, 295)]    
  [RequiredField]
  public FixInt NoQuoteSets { get; set; }

  [FieldNumberTarget(296)]
  public ICollection<QuoteSetsClass> QuoteSetsCollection { get; set; } = new List<QuoteSetsClass>();
  [FieldNumberTarget(296)]
  public class QuoteSetsClass
  {    
    [FieldNumber(302)]    
    [RequiredField]
    public FixString QuoteSetID { get; set; }
    
    [FieldNumber(311)]    
    [RequiredField]
    public FixString UnderlyingSymbol { get; set; }
    
    [FieldNumber(304)]    
    [RequiredField]
    public FixInt TotQuoteEntries { get; set; }
    
    [FieldNumber(295)]    
    [FieldChildrenNumbers(299, 55, 65, 48, 22, 167, 200, 205, 201, 202, 206, 231, 223, 207, 106, 348, 349, 107, 350, 351, 132, 133, 134, 135, 62, 188, 190, 189, 191, 60, 336, 64, 40, 193, 192, 15)]    
    [RequiredField]
    public FixInt NoQuoteEntries { get; set; }

    [FieldNumberTarget(295)]
    public ICollection<QuoteEntriesClass> QuoteEntriesCollection { get; set; } = new List<QuoteEntriesClass>();
    [FieldNumberTarget(295)]
    public class QuoteEntriesClass
    {    
      [FieldNumber(299)]    
      [RequiredField]
      public FixString QuoteEntryID { get; set; }
    
      [FieldNumber(55)]
      public FixString Symbol { get; set; }
    
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
      public Qty BidSize { get; set; }
    
      [FieldNumber(135)]
      public Qty OfferSize { get; set; }
    
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
    
      [FieldNumber(336)]
      public FixString TradingSessionID { get; set; }
    
      [FieldNumber(64)]
      public LocalMktDate FutSettDate { get; set; }
    
      [FieldNumber(40)]
      public FixChar OrdType { get; set; }
    
      [FieldNumber(193)]
      public LocalMktDate FutSettDate2 { get; set; }
    
      [FieldNumber(192)]
      public Qty OrderQty2 { get; set; }
    
      [FieldNumber(15)]
      public Currency Currency { get; set; }
    }
    
    [FieldNumber(312)]
    public FixString UnderlyingSymbolSfx { get; set; }
    
    [FieldNumber(309)]
    public FixString UnderlyingSecurityID { get; set; }
    
    [FieldNumber(305)]
    public FixString UnderlyingIDSource { get; set; }
    
    [FieldNumber(310)]
    public FixString UnderlyingSecurityType { get; set; }
    
    [FieldNumber(313)]
    public MonthYear UnderlyingMaturityMonthYear { get; set; }
    
    [FieldNumber(314)]
    public DayOfMonth UnderlyingMaturityDay { get; set; }
    
    [FieldNumber(315)]
    public FixInt UnderlyingPutOrCall { get; set; }
    
    [FieldNumber(316)]
    public Price UnderlyingStrikePrice { get; set; }
    
    [FieldNumber(317)]
    public FixChar UnderlyingOptAttribute { get; set; }
    
    [FieldNumber(436)]
    public FixDecimal UnderlyingContractMultiplier { get; set; }
    
    [FieldNumber(435)]
    public FixDecimal UnderlyingCouponRate { get; set; }
    
    [FieldNumber(308)]
    public Exchange UnderlyingSecurityExchange { get; set; }
    
    [FieldNumber(306)]
    public FixString UnderlyingIssuer { get; set; }
    
    [FieldNumber(362)]
    public Length EncodedUnderlyingIssuerLen { get; set; }
    
    [FieldNumber(363)]
    public FixData EncodedUnderlyingIssuer { get; set; }
    
    [FieldNumber(307)]
    public FixString UnderlyingSecurityDesc { get; set; }
    
    [FieldNumber(364)]
    public Length EncodedUnderlyingSecurityDescLen { get; set; }
    
    [FieldNumber(365)]
    public FixData EncodedUnderlyingSecurityDesc { get; set; }
    
    [FieldNumber(367)]
    public UTCTimeStamp QuoteSetValidUntilTime { get; set; }
  }
    
  [FieldNumber(131)]
  public FixString QuoteReqID { get; set; }
    
  [FieldNumber(301)]
  public FixInt QuoteResponseLevel { get; set; }
    
  [FieldNumber(293)]
  public Qty DefBidSize { get; set; }
    
  [FieldNumber(294)]
  public Qty DefOfferSize { get; set; }

}
