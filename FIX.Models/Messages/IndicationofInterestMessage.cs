namespace FIX.Models;

[MessageCode("6")]
public class IndicationofInterestMessage : FixMessageComponent<IndicationofInterestMessage>
{
    
  [FieldNumber(23)]    
  [RequiredField]
  public FixString IOIid { get; set; }
    
  [FieldNumber(28)]    
  [RequiredField]
  public FixChar IOITransType { get; set; }
    
  [FieldNumber(55)]    
  [RequiredField]
  public FixString Symbol { get; set; }
    
  [FieldNumber(54)]    
  [RequiredField]
  public FixChar Side { get; set; }
    
  [FieldNumber(27)]    
  [RequiredField]
  public FixString IOIShares { get; set; }
    
  [FieldNumber(26)]
  public FixString IOIRefID { get; set; }
    
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
    
  [FieldNumber(44)]
  public Price Price { get; set; }
    
  [FieldNumber(15)]
  public Currency Currency { get; set; }
    
  [FieldNumber(62)]
  public UTCTimeStamp ValidUntilTime { get; set; }
    
  [FieldNumber(25)]
  public FixChar IOIQltyInd { get; set; }
    
  [FieldNumber(130)]
  public FixBool IOINaturalFlag { get; set; }
    
  [FieldNumber(199)]    
  [FieldChildrenNumbers(104)]
  public FixInt NoIOIQualifiers { get; set; }

  [FieldNumberTarget(199)]
  public ICollection<IOIQualifiersSubcomponent> IOIQualifiersCollection { get; set; } = new List<IOIQualifiersSubcomponent>();
  [FieldNumberTarget(199)]
  public class IOIQualifiersSubcomponent : FixMessageComponent<IOIQualifiersSubcomponent>
  {
    protected override bool EmitErrorOnDuplicateField => false;    
    [FieldNumber(104)]
    public FixChar IOIQualifier { get; set; }
  }
    
  [FieldNumber(58)]
  public FixString Text { get; set; }
    
  [FieldNumber(354)]
  public Length EncodedTextLen { get; set; }
    
  [FieldNumber(355)]
  public FixData EncodedText { get; set; }
    
  [FieldNumber(60)]
  public UTCTimeStamp TransactTime { get; set; }
    
  [FieldNumber(149)]
  public FixString URLLink { get; set; }
    
  [FieldNumber(215)]    
  [FieldChildrenNumbers(216, 217)]
  public FixInt NoRoutingIDs { get; set; }

  [FieldNumberTarget(215)]
  public ICollection<RoutingIDsSubcomponent> RoutingIDsCollection { get; set; } = new List<RoutingIDsSubcomponent>();
  [FieldNumberTarget(215)]
  public class RoutingIDsSubcomponent : FixMessageComponent<RoutingIDsSubcomponent>
  {
    protected override bool EmitErrorOnDuplicateField => false;    
    [FieldNumber(216)]
    public FixInt RoutingType { get; set; }
    
    [FieldNumber(217)]
    public FixString RoutingID { get; set; }
  }
    
  [FieldNumber(218)]
  public PriceOffset SpreadToBenchmark { get; set; }
    
  [FieldNumber(219)]
  public FixChar Benchmark { get; set; }

}
