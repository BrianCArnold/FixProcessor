namespace FIX.Models;

[MessageCode("E")]
public class NewOrderListMessage : FixMessageComponent<NewOrderListMessage>
{
    
  [FieldNumber(66)]    
  [RequiredField]
  public FixString ListID { get; set; }
    
  [FieldNumber(394)]    
  [RequiredField]
  public FixInt BidType { get; set; }
    
  [FieldNumber(68)]    
  [RequiredField]
  public FixInt TotNoOrders { get; set; }
    
  [FieldNumber(73)]    
  [FieldChildrenNumbers(11, 67, 160, 109, 76, 1, 78, 63, 64, 21, 18, 110, 111, 100, 386, 81, 55, 65, 48, 22, 167, 200, 205, 201, 202, 206, 231, 223, 207, 106, 348, 349, 107, 350, 351, 140, 54, 401, 114, 60, 38, 152, 40, 44, 99, 15, 376, 377, 23, 117, 59, 168, 432, 126, 427, 12, 13, 47, 121, 120, 58, 354, 355, 193, 192, 77, 203, 204, 210, 211, 388, 389, 439, 440)]    
  [RequiredField]
  public FixInt NoOrders { get; set; }

  [FieldNumberTarget(73)]
  public ICollection<OrdersSubcomponent> OrdersCollection { get; set; } = new List<OrdersSubcomponent>();
  [FieldNumberTarget(73)]
  public class OrdersSubcomponent : FixMessageComponent<OrdersSubcomponent>
  {
    protected override bool EmitErrorOnDuplicateField => false;    
    [FieldNumber(11)]    
    [RequiredField]
    public FixString ClOrdID { get; set; }
    
    [FieldNumber(67)]    
    [RequiredField]
    public FixInt ListSeqNo { get; set; }
    
    [FieldNumber(55)]    
    [RequiredField]
    public FixString Symbol { get; set; }
    
    [FieldNumber(54)]    
    [RequiredField]
    public FixChar Side { get; set; }
    
    [FieldNumber(160)]
    public FixChar SettlInstMode { get; set; }
    
    [FieldNumber(109)]
    public FixString ClientID { get; set; }
    
    [FieldNumber(76)]
    public FixString ExecBroker { get; set; }
    
    [FieldNumber(1)]
    public FixString Account { get; set; }
    
    [FieldNumber(78)]    
    [FieldChildrenNumbers(79, 80)]
    public FixInt NoAllocs { get; set; }

    [FieldNumberTarget(78)]
    public ICollection<AllocsSubcomponent> AllocsCollection { get; set; } = new List<AllocsSubcomponent>();
    [FieldNumberTarget(78)]
    public class AllocsSubcomponent : FixMessageComponent<AllocsSubcomponent>
    {
      protected override bool EmitErrorOnDuplicateField => false;    
      [FieldNumber(79)]
      public FixString AllocAccount { get; set; }
    
      [FieldNumber(80)]
      public Quantity AllocShares { get; set; }
    }
    
    [FieldNumber(63)]
    public FixChar SettlmntTyp { get; set; }
    
    [FieldNumber(64)]
    public LocalMktDate FutSettDate { get; set; }
    
    [FieldNumber(21)]
    public FixChar HandlInst { get; set; }
    
    [FieldNumber(18)]
    public MultipleValueString ExecInst { get; set; }
    
    [FieldNumber(110)]
    public Quantity MinQty { get; set; }
    
    [FieldNumber(111)]
    public Quantity MaxFloor { get; set; }
    
    [FieldNumber(100)]
    public Exchange ExDestination { get; set; }
    
    [FieldNumber(386)]    
    [FieldChildrenNumbers(336)]
    public FixInt NoTradingSessions { get; set; }

    [FieldNumberTarget(386)]
    public ICollection<TradingSessionsSubcomponent> TradingSessionsCollection { get; set; } = new List<TradingSessionsSubcomponent>();
    [FieldNumberTarget(386)]
    public class TradingSessionsSubcomponent : FixMessageComponent<TradingSessionsSubcomponent>
    {
      protected override bool EmitErrorOnDuplicateField => false;    
      [FieldNumber(336)]
      public FixString TradingSessionID { get; set; }
    }
    
    [FieldNumber(81)]
    public FixChar ProcessCode { get; set; }
    
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
    
    [FieldNumber(401)]
    public FixInt SideValueInd { get; set; }
    
    [FieldNumber(114)]
    public FixBool LocateReqd { get; set; }
    
    [FieldNumber(60)]
    public UTCTimeStamp TransactTime { get; set; }
    
    [FieldNumber(38)]
    public Quantity OrderQty { get; set; }
    
    [FieldNumber(152)]
    public Quantity CashOrderQty { get; set; }
    
    [FieldNumber(40)]
    public FixChar OrdType { get; set; }
    
    [FieldNumber(44)]
    public Price Price { get; set; }
    
    [FieldNumber(99)]
    public Price StopPx { get; set; }
    
    [FieldNumber(15)]
    public Currency Currency { get; set; }
    
    [FieldNumber(376)]
    public FixString ComplianceID { get; set; }
    
    [FieldNumber(377)]
    public FixBool SolicitedFlag { get; set; }
    
    [FieldNumber(23)]
    public FixString IOIid { get; set; }
    
    [FieldNumber(117)]
    public FixString QuoteID { get; set; }
    
    [FieldNumber(59)]
    public FixChar TimeInForce { get; set; }
    
    [FieldNumber(168)]
    public UTCTimeStamp EffectiveTime { get; set; }
    
    [FieldNumber(432)]
    public LocalMktDate ExpireDate { get; set; }
    
    [FieldNumber(126)]
    public UTCTimeStamp ExpireTime { get; set; }
    
    [FieldNumber(427)]
    public FixInt GTBookingInst { get; set; }
    
    [FieldNumber(12)]
    public Amt Commission { get; set; }
    
    [FieldNumber(13)]
    public FixChar CommType { get; set; }
    
    [FieldNumber(47)]
    public FixChar Rule80A { get; set; }
    
    [FieldNumber(121)]
    public FixBool ForexReq { get; set; }
    
    [FieldNumber(120)]
    public Currency SettlCurrency { get; set; }
    
    [FieldNumber(58)]
    public FixString Text { get; set; }
    
    [FieldNumber(354)]
    public Length EncodedTextLen { get; set; }
    
    [FieldNumber(355)]
    public FixData EncodedText { get; set; }
    
    [FieldNumber(193)]
    public LocalMktDate FutSettDate2 { get; set; }
    
    [FieldNumber(192)]
    public Quantity OrderQty2 { get; set; }
    
    [FieldNumber(77)]
    public FixChar OpenClose { get; set; }
    
    [FieldNumber(203)]
    public FixInt CoveredOrUncovered { get; set; }
    
    [FieldNumber(204)]
    public FixInt CustomerOrFirm { get; set; }
    
    [FieldNumber(210)]
    public Quantity MaxShow { get; set; }
    
    [FieldNumber(211)]
    public PriceOffset PegDifference { get; set; }
    
    [FieldNumber(388)]
    public FixChar DiscretionInst { get; set; }
    
    [FieldNumber(389)]
    public PriceOffset DiscretionOffset { get; set; }
    
    [FieldNumber(439)]
    public FixString ClearingFirm { get; set; }
    
    [FieldNumber(440)]
    public FixString ClearingAccount { get; set; }
  }
    
  [FieldNumber(390)]
  public FixString BidID { get; set; }
    
  [FieldNumber(391)]
  public FixString ClientBidID { get; set; }
    
  [FieldNumber(414)]
  public FixInt ProgRptReqs { get; set; }
    
  [FieldNumber(415)]
  public FixInt ProgPeriodInterval { get; set; }
    
  [FieldNumber(433)]
  public FixChar ListExecInstType { get; set; }
    
  [FieldNumber(69)]
  public FixString ListExecInst { get; set; }
    
  [FieldNumber(352)]
  public Length EncodedListExecInstLen { get; set; }
    
  [FieldNumber(353)]
  public FixData EncodedListExecInst { get; set; }

}
