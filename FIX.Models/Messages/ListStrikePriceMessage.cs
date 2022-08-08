namespace FIX.Models;

[MessageCode("m")]
public class ListStrikePriceMessage : FixMessageComponent<ListStrikePriceMessage>
{
    
  [FieldNumber(66)]    
  [RequiredField]
  public FixString ListID { get; set; }
    
  [FieldNumber(422)]    
  [RequiredField]
  public FixInt TotNoStrikes { get; set; }
    
  [FieldNumber(428)]    
  [FieldChildrenNumbers(55, 65, 48, 22, 167, 200, 205, 201, 202, 206, 231, 223, 207, 106, 348, 349, 107, 350, 351, 140, 11, 54, 44, 15, 58, 354, 355)]    
  [RequiredField]
  public FixInt NoStrikes { get; set; }

  [FieldNumberTarget(428)]
  public ICollection<StrikesClass> StrikesCollection { get; set; } = new List<StrikesClass>();
  [FieldNumberTarget(428)]
  public class StrikesClass : FixMessageComponent<StrikesClass>
  {
    protected override bool EmitErrorOnDuplicateField => false;    
    [FieldNumber(55)]    
    [RequiredField]
    public FixString Symbol { get; set; }
    
    [FieldNumber(44)]    
    [RequiredField]
    public Price Price { get; set; }
    
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
    
    [FieldNumber(11)]
    public FixString ClOrdID { get; set; }
    
    [FieldNumber(54)]
    public FixChar Side { get; set; }
    
    [FieldNumber(15)]
    public Currency Currency { get; set; }
    
    [FieldNumber(58)]
    public FixString Text { get; set; }
    
    [FieldNumber(354)]
    public Length EncodedTextLen { get; set; }
    
    [FieldNumber(355)]
    public FixData EncodedText { get; set; }
  }

}
