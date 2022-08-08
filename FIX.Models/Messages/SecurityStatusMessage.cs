namespace FIX.Models;

[MessageCode("f")]
public class SecurityStatusMessage : FixMessage<SecurityStatusMessage>
{
    
  [FieldNumber(55)]    
  [RequiredField]
  public FixString Symbol { get; set; }
    
  [FieldNumber(324)]
  public FixString SecurityStatusReqID { get; set; }
    
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
    
  [FieldNumber(15)]
  public Currency Currency { get; set; }
    
  [FieldNumber(336)]
  public FixString TradingSessionID { get; set; }
    
  [FieldNumber(325)]
  public FixBool UnsolicitedIndicator { get; set; }
    
  [FieldNumber(326)]
  public FixInt SecurityTradingStatus { get; set; }
    
  [FieldNumber(291)]
  public FixChar FinancialStatus { get; set; }
    
  [FieldNumber(292)]
  public FixChar CorporateAction { get; set; }
    
  [FieldNumber(327)]
  public FixChar HaltReason { get; set; }
    
  [FieldNumber(328)]
  public FixBool InViewOfCommon { get; set; }
    
  [FieldNumber(329)]
  public FixBool DueToRelated { get; set; }
    
  [FieldNumber(330)]
  public Quantity BuyVolume { get; set; }
    
  [FieldNumber(331)]
  public Quantity SellVolume { get; set; }
    
  [FieldNumber(332)]
  public Price HighPx { get; set; }
    
  [FieldNumber(333)]
  public Price LowPx { get; set; }
    
  [FieldNumber(31)]
  public Price LastPx { get; set; }
    
  [FieldNumber(60)]
  public UTCTimeStamp TransactTime { get; set; }
    
  [FieldNumber(334)]
  public FixInt Adjustment { get; set; }

}
