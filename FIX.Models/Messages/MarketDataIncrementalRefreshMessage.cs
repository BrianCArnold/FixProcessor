namespace FIX.Models;

[MessageCode("X")]
public class MarketDataIncrementalRefreshMessage : FixMessage<MarketDataIncrementalRefreshMessage>
{
    
  [FieldNumber(268)]    
  [FieldChildrenNumbers(279, 285, 269, 278, 280, 55, 65, 48, 22, 167, 200, 205, 201, 202, 206, 231, 223, 207, 106, 348, 349, 107, 350, 351, 291, 292, 270, 15, 271, 272, 273, 274, 275, 336, 276, 277, 282, 283, 284, 286, 59, 432, 126, 110, 18, 287, 37, 299, 288, 289, 346, 290, 387, 58, 354, 355)]    
  [RequiredField]
  public FixInt NoMDEntries { get; set; }

  [FieldNumberTarget(268)]
  public ICollection<MDEntriesClass> MDEntries { get; set; } = new List<MDEntriesClass>();
  [FieldNumberTarget(268)]
  public class MDEntriesClass
  {    
    [FieldNumber(279)]    
    [RequiredField]
    public FixChar MDUpdateAction { get; set; }
    
    [FieldNumber(285)]
    public FixChar DeleteReason { get; set; }
    
    [FieldNumber(269)]
    public FixChar MDEntryType { get; set; }
    
    [FieldNumber(278)]
    public FixString MDEntryID { get; set; }
    
    [FieldNumber(280)]
    public FixString MDEntryRefID { get; set; }
    
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
    
    [FieldNumber(291)]
    public FixChar FinancialStatus { get; set; }
    
    [FieldNumber(292)]
    public FixChar CorporateAction { get; set; }
    
    [FieldNumber(270)]
    public Price MDEntryPx { get; set; }
    
    [FieldNumber(15)]
    public Currency Currency { get; set; }
    
    [FieldNumber(271)]
    public Qty MDEntrySize { get; set; }
    
    [FieldNumber(272)]
    public UTCDate MDEntryDate { get; set; }
    
    [FieldNumber(273)]
    public UTCTimeOnly MDEntryTime { get; set; }
    
    [FieldNumber(274)]
    public FixChar TickDirection { get; set; }
    
    [FieldNumber(275)]
    public Exchange MDMkt { get; set; }
    
    [FieldNumber(336)]
    public FixString TradingSessionID { get; set; }
    
    [FieldNumber(276)]
    public MultipleValueString QuoteCondition { get; set; }
    
    [FieldNumber(277)]
    public MultipleValueString TradeCondition { get; set; }
    
    [FieldNumber(282)]
    public FixString MDEntryOriginator { get; set; }
    
    [FieldNumber(283)]
    public FixString LocationID { get; set; }
    
    [FieldNumber(284)]
    public FixString DeskID { get; set; }
    
    [FieldNumber(286)]
    public FixChar OpenCloseSettleFlag { get; set; }
    
    [FieldNumber(59)]
    public FixChar TimeInForce { get; set; }
    
    [FieldNumber(432)]
    public LocalMktDate ExpireDate { get; set; }
    
    [FieldNumber(126)]
    public UTCTimeStamp ExpireTime { get; set; }
    
    [FieldNumber(110)]
    public Qty MinQty { get; set; }
    
    [FieldNumber(18)]
    public MultipleValueString ExecInst { get; set; }
    
    [FieldNumber(287)]
    public FixInt SellerDays { get; set; }
    
    [FieldNumber(37)]
    public FixString OrderID { get; set; }
    
    [FieldNumber(299)]
    public FixString QuoteEntryID { get; set; }
    
    [FieldNumber(288)]
    public FixString MDEntryBuyer { get; set; }
    
    [FieldNumber(289)]
    public FixString MDEntrySeller { get; set; }
    
    [FieldNumber(346)]
    public FixInt NumberOfOrders { get; set; }
    
    [FieldNumber(290)]
    public FixInt MDEntryPositionNo { get; set; }
    
    [FieldNumber(387)]
    public Qty TotalVolumeTraded { get; set; }
    
    [FieldNumber(58)]
    public FixString Text { get; set; }
    
    [FieldNumber(354)]
    public Length EncodedTextLen { get; set; }
    
    [FieldNumber(355)]
    public FixData EncodedText { get; set; }
  }
    
  [FieldNumber(262)]
  public FixString MDReqID { get; set; }

}
