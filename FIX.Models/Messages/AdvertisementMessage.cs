namespace FIX.Models;

[MessageCode("7")]
public class AdvertisementMessage : FixMessageComponent<AdvertisementMessage>
{
    
  [FieldNumber(2)]    
  [RequiredField]
  public FixString AdvId { get; set; }
    
  [FieldNumber(5)]    
  [RequiredField]
  public FixString AdvTransType { get; set; }
    
  [FieldNumber(55)]    
  [RequiredField]
  public FixString Symbol { get; set; }
    
  [FieldNumber(4)]    
  [RequiredField]
  public Char AdvSide { get; set; }
    
  [FieldNumber(53)]    
  [RequiredField]
  public Quantity Shares { get; set; }
    
  [FieldNumber(3)]
  public FixString AdvRefID { get; set; }
    
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
    
  [FieldNumber(75)]
  public LocalMktDate TradeDate { get; set; }
    
  [FieldNumber(60)]
  public UTCTimeStamp TransactTime { get; set; }
    
  [FieldNumber(58)]
  public FixString Text { get; set; }
    
  [FieldNumber(354)]
  public Length EncodedTextLen { get; set; }
    
  [FieldNumber(355)]
  public FixData EncodedText { get; set; }
    
  [FieldNumber(149)]
  public FixString URLLink { get; set; }
    
  [FieldNumber(30)]
  public Exchange LastMkt { get; set; }
    
  [FieldNumber(336)]
  public FixString TradingSessionID { get; set; }

}
