namespace FIX.Models;

[MessageCode("V")]
public class MarketDataRequestMessage : FixMessage<MarketDataRequestMessage>
{
    
  [FieldNumber(262)]    
  [RequiredField]
  public FixString MDReqID { get; set; }
    
  [FieldNumber(263)]    
  [RequiredField]
  public FixChar SubscriptionRequestType { get; set; }
    
  [FieldNumber(264)]    
  [RequiredField]
  public FixInt MarketDepth { get; set; }
    
  [FieldNumber(267)]    
  [FieldChildrenNumbers(269)]    
  [RequiredField]
  public FixInt NoMDEntryTypes { get; set; }

  [FieldNumberTarget(267)]
  public ICollection<MDEntryTypesClass> MDEntryTypes { get; set; } = new List<MDEntryTypesClass>();
  [FieldNumberTarget(267)]
  public class MDEntryTypesClass
  {    
    [FieldNumber(269)]    
    [RequiredField]
    public FixChar MDEntryType { get; set; }
  }
    
  [FieldNumber(146)]    
  [FieldChildrenNumbers(55, 65, 48, 22, 167, 200, 205, 201, 202, 206, 231, 223, 207, 106, 348, 349, 107, 350, 351, 336)]    
  [RequiredField]
  public FixInt NoRelatedSym { get; set; }

  [FieldNumberTarget(146)]
  public ICollection<RelatedSymClass> RelatedSym { get; set; } = new List<RelatedSymClass>();
  [FieldNumberTarget(146)]
  public class RelatedSymClass
  {    
    [FieldNumber(55)]    
    [RequiredField]
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
    
    [FieldNumber(336)]
    public FixString TradingSessionID { get; set; }
  }
    
  [FieldNumber(265)]
  public FixInt MDUpdateType { get; set; }
    
  [FieldNumber(266)]
  public FixBool AggregatedBook { get; set; }

}
