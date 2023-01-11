namespace FIX.Models;

[MessageCode("R")]
public class QuoteRequestMessage : FixMessageComponent<QuoteRequestMessage>
{
    
  [FieldNumber(131)]    
  [RequiredField]
  public FixString QuoteReqID { get; set; }
    
  [FieldNumber(146)]    
  [FieldChildrenNumbers(55, 65, 48, 22, 167, 200, 205, 201, 202, 206, 231, 223, 207, 106, 348, 349, 107, 350, 351, 140, 303, 336, 54, 38, 64, 40, 193, 192, 126, 60, 15)]    
  [RequiredField]
  public FixInt NoRelatedSym { get; set; }

  [FieldNumberTarget(146)]
  public ICollection<RelatedSymSubcomponent> RelatedSymCollection { get; set; } = new List<RelatedSymSubcomponent>();
  [FieldNumberTarget(146)]
  public class RelatedSymSubcomponent : FixMessageComponent<RelatedSymSubcomponent>
  {
    protected override bool EmitErrorOnDuplicateField => false;    
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
    
    [FieldNumber(140)]
    public Price PrevClosePx { get; set; }
    
    [FieldNumber(303)]
    public FixInt QuoteRequestType { get; set; }
    
    [FieldNumber(336)]
    public FixString TradingSessionID { get; set; }
    
    [FieldNumber(54)]
    public FixChar Side { get; set; }
    
    [FieldNumber(38)]
    public Quantity OrderQty { get; set; }
    
    [FieldNumber(64)]
    public LocalMktDate FutSettDate { get; set; }
    
    [FieldNumber(40)]
    public FixChar OrdType { get; set; }
    
    [FieldNumber(193)]
    public LocalMktDate FutSettDate2 { get; set; }
    
    [FieldNumber(192)]
    public Quantity OrderQty2 { get; set; }
    
    [FieldNumber(126)]
    public UTCTimeStamp ExpireTime { get; set; }
    
    [FieldNumber(60)]
    public UTCTimeStamp TransactTime { get; set; }
    
    [FieldNumber(15)]
    public Currency Currency { get; set; }
  }

}
