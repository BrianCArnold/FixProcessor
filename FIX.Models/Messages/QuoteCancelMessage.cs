namespace FIX.Models;

[MessageCode("Z")]
public class QuoteCancelMessage : FixMessageComponent<QuoteCancelMessage>
{
    
  [FieldNumber(117)]    
  [RequiredField]
  public FixString QuoteID { get; set; }
    
  [FieldNumber(298)]    
  [RequiredField]
  public FixInt QuoteCancelType { get; set; }
    
  [FieldNumber(295)]    
  [FieldChildrenNumbers(55, 65, 48, 22, 167, 200, 205, 201, 202, 206, 231, 223, 207, 106, 348, 349, 107, 350, 351, 311)]    
  [RequiredField]
  public FixInt NoQuoteEntries { get; set; }

  [FieldNumberTarget(295)]
  public ICollection<QuoteEntriesSubcomponent> QuoteEntriesCollection { get; set; } = new List<QuoteEntriesSubcomponent>();
  [FieldNumberTarget(295)]
  public class QuoteEntriesSubcomponent : FixMessageComponent<QuoteEntriesSubcomponent>
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
    
    [FieldNumber(311)]
    public FixString UnderlyingSymbol { get; set; }
  }
    
  [FieldNumber(131)]
  public FixString QuoteReqID { get; set; }
    
  [FieldNumber(301)]
  public FixInt QuoteResponseLevel { get; set; }
    
  [FieldNumber(336)]
  public FixString TradingSessionID { get; set; }

}
