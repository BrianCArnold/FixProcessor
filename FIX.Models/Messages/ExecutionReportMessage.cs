namespace FIX.Models;

[MessageCode("8")]
public class ExecutionReportMessage : FixMessage<ExecutionReportMessage>
{
    
  [FieldNumber(37)]    
  [RequiredField]
  public FixString OrderID { get; set; }
    
  [FieldNumber(17)]    
  [RequiredField]
  public FixString ExecID { get; set; }
    
  [FieldNumber(20)]    
  [RequiredField]
  public FixChar ExecTransType { get; set; }
    
  [FieldNumber(150)]    
  [RequiredField]
  public FixChar ExecType { get; set; }
    
  [FieldNumber(39)]    
  [RequiredField]
  public FixChar OrdStatus { get; set; }
    
  [FieldNumber(55)]    
  [RequiredField]
  public FixString Symbol { get; set; }
    
  [FieldNumber(54)]    
  [RequiredField]
  public FixChar Side { get; set; }
    
  [FieldNumber(151)]    
  [RequiredField]
  public Quantity LeavesQty { get; set; }
    
  [FieldNumber(14)]    
  [RequiredField]
  public Quantity CumQty { get; set; }
    
  [FieldNumber(6)]    
  [RequiredField]
  public Price AvgPx { get; set; }
    
  [FieldNumber(198)]
  public FixString SecondaryOrderID { get; set; }
    
  [FieldNumber(11)]
  public FixString ClOrdID { get; set; }
    
  [FieldNumber(41)]
  public FixString OrigClOrdID { get; set; }
    
  [FieldNumber(109)]
  public FixString ClientID { get; set; }
    
  [FieldNumber(76)]
  public FixString ExecBroker { get; set; }
    
  [FieldNumber(382)]    
  [FieldChildrenNumbers(375, 337, 437, 438)]
  public FixInt NoContraBrokers { get; set; }

  [FieldNumberTarget(382)]
  public ICollection<ContraBrokersClass> ContraBrokersCollection { get; set; } = new List<ContraBrokersClass>();
  [FieldNumberTarget(382)]
  public class ContraBrokersClass
  {    
    [FieldNumber(375)]
    public FixString ContraBroker { get; set; }
    
    [FieldNumber(337)]
    public FixString ContraTrader { get; set; }
    
    [FieldNumber(437)]
    public Quantity ContraTradeQty { get; set; }
    
    [FieldNumber(438)]
    public UTCTimeStamp ContraTradeTime { get; set; }
  }
    
  [FieldNumber(66)]
  public FixString ListID { get; set; }
    
  [FieldNumber(19)]
  public FixString ExecRefID { get; set; }
    
  [FieldNumber(103)]
  public FixInt OrdRejReason { get; set; }
    
  [FieldNumber(378)]
  public FixInt ExecRestatementReason { get; set; }
    
  [FieldNumber(1)]
  public FixString Account { get; set; }
    
  [FieldNumber(63)]
  public FixChar SettlmntTyp { get; set; }
    
  [FieldNumber(64)]
  public LocalMktDate FutSettDate { get; set; }
    
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
    
  [FieldNumber(211)]
  public PriceOffset PegDifference { get; set; }
    
  [FieldNumber(388)]
  public FixChar DiscretionInst { get; set; }
    
  [FieldNumber(389)]
  public PriceOffset DiscretionOffset { get; set; }
    
  [FieldNumber(15)]
  public Currency Currency { get; set; }
    
  [FieldNumber(376)]
  public FixString ComplianceID { get; set; }
    
  [FieldNumber(377)]
  public FixBool SolicitedFlag { get; set; }
    
  [FieldNumber(59)]
  public FixChar TimeInForce { get; set; }
    
  [FieldNumber(168)]
  public UTCTimeStamp EffectiveTime { get; set; }
    
  [FieldNumber(432)]
  public LocalMktDate ExpireDate { get; set; }
    
  [FieldNumber(126)]
  public UTCTimeStamp ExpireTime { get; set; }
    
  [FieldNumber(18)]
  public MultipleValueString ExecInst { get; set; }
    
  [FieldNumber(47)]
  public FixChar Rule80A { get; set; }
    
  [FieldNumber(32)]
  public Quantity LastShares { get; set; }
    
  [FieldNumber(31)]
  public Price LastPx { get; set; }
    
  [FieldNumber(194)]
  public Price LastSpotRate { get; set; }
    
  [FieldNumber(195)]
  public PriceOffset LastForwardPoints { get; set; }
    
  [FieldNumber(30)]
  public Exchange LastMkt { get; set; }
    
  [FieldNumber(336)]
  public FixString TradingSessionID { get; set; }
    
  [FieldNumber(29)]
  public FixChar LastCapacity { get; set; }
    
  [FieldNumber(424)]
  public Quantity DayOrderQty { get; set; }
    
  [FieldNumber(425)]
  public Quantity DayCumQty { get; set; }
    
  [FieldNumber(426)]
  public Price DayAvgPx { get; set; }
    
  [FieldNumber(427)]
  public FixInt GTBookingInst { get; set; }
    
  [FieldNumber(75)]
  public LocalMktDate TradeDate { get; set; }
    
  [FieldNumber(60)]
  public UTCTimeStamp TransactTime { get; set; }
    
  [FieldNumber(113)]
  public FixBool ReportToExch { get; set; }
    
  [FieldNumber(12)]
  public Amt Commission { get; set; }
    
  [FieldNumber(13)]
  public FixChar CommType { get; set; }
    
  [FieldNumber(381)]
  public Amt GrossTradeAmt { get; set; }
    
  [FieldNumber(119)]
  public Amt SettlCurrAmt { get; set; }
    
  [FieldNumber(120)]
  public Currency SettlCurrency { get; set; }
    
  [FieldNumber(155)]
  public FixDecimal SettlCurrFxRate { get; set; }
    
  [FieldNumber(156)]
  public FixChar SettlCurrFxRateCalc { get; set; }
    
  [FieldNumber(21)]
  public FixChar HandlInst { get; set; }
    
  [FieldNumber(110)]
  public Quantity MinQty { get; set; }
    
  [FieldNumber(111)]
  public Quantity MaxFloor { get; set; }
    
  [FieldNumber(77)]
  public FixChar OpenClose { get; set; }
    
  [FieldNumber(210)]
  public Quantity MaxShow { get; set; }
    
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
    
  [FieldNumber(439)]
  public FixString ClearingFirm { get; set; }
    
  [FieldNumber(440)]
  public FixString ClearingAccount { get; set; }
    
  [FieldNumber(442)]
  public FixChar MultiLegReportingType { get; set; }

}
