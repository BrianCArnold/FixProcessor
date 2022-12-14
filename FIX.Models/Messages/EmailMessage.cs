namespace FIX.Models;

[MessageCode("C")]
public class EmailMessage : FixMessageComponent<EmailMessage>
{
    
  [FieldNumber(164)]    
  [RequiredField]
  public FixString EmailThreadID { get; set; }
    
  [FieldNumber(94)]    
  [RequiredField]
  public FixChar EmailType { get; set; }
    
  [FieldNumber(147)]    
  [RequiredField]
  public FixString Subject { get; set; }
    
  [FieldNumber(33)]    
  [FieldChildrenNumbers(58, 354, 355)]    
  [RequiredField]
  public FixInt LinesOfText { get; set; }

  [FieldNumberTarget(33)]
  public ICollection<LinesOfTextClass> LinesOfTextCollection { get; set; } = new List<LinesOfTextClass>();
  [FieldNumberTarget(33)]
  public class LinesOfTextClass : FixMessageComponent<LinesOfTextClass>
  {
    protected override bool EmitErrorOnDuplicateField => false;    
    [FieldNumber(58)]    
    [RequiredField]
    public FixString Text { get; set; }
    
    [FieldNumber(354)]
    public Length EncodedTextLen { get; set; }
    
    [FieldNumber(355)]
    public FixData EncodedText { get; set; }
  }
    
  [FieldNumber(42)]
  public UTCTimeStamp OrigTime { get; set; }
    
  [FieldNumber(356)]
  public Length EncodedSubjectLen { get; set; }
    
  [FieldNumber(357)]
  public FixData EncodedSubject { get; set; }
    
  [FieldNumber(215)]    
  [FieldChildrenNumbers(216, 217)]
  public FixInt NoRoutingIDs { get; set; }

  [FieldNumberTarget(215)]
  public ICollection<RoutingIDsClass> RoutingIDsCollection { get; set; } = new List<RoutingIDsClass>();
  [FieldNumberTarget(215)]
  public class RoutingIDsClass : FixMessageComponent<RoutingIDsClass>
  {
    protected override bool EmitErrorOnDuplicateField => false;    
    [FieldNumber(216)]
    public FixInt RoutingType { get; set; }
    
    [FieldNumber(217)]
    public FixString RoutingID { get; set; }
  }
    
  [FieldNumber(146)]    
  [FieldChildrenNumbers(46, 65, 48, 22, 167, 200, 205, 201, 202, 206, 231, 223, 207, 106, 348, 349, 107, 350, 351)]
  public FixInt NoRelatedSym { get; set; }

  [FieldNumberTarget(146)]
  public ICollection<RelatedSymClass> RelatedSymCollection { get; set; } = new List<RelatedSymClass>();
  [FieldNumberTarget(146)]
  public class RelatedSymClass : FixMessageComponent<RelatedSymClass>
  {
    protected override bool EmitErrorOnDuplicateField => false;    
    [FieldNumber(46)]
    public FixString RelatdSym { get; set; }
    
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
  }
    
  [FieldNumber(37)]
  public FixString OrderID { get; set; }
    
  [FieldNumber(11)]
  public FixString ClOrdID { get; set; }
    
  [FieldNumber(95)]
  public Length RawDataLength { get; set; }
    
  [FieldNumber(96)]
  public FixData RawData { get; set; }

}
