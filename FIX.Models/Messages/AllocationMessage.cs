namespace FIX.Models;

[MessageCode("J")]
public class AllocationMessage : FixMessage<AllocationMessage>
{
    
  [FieldNumber(70)]    
  [RequiredField]
  public FixString AllocID { get; set; }
    
  [FieldNumber(71)]    
  [RequiredField]
  public FixChar AllocTransType { get; set; }
    
  [FieldNumber(73)]    
  [FieldChildrenNumbers(11, 37, 198, 66, 105)]    
  [RequiredField]
  public FixInt NoOrders { get; set; }

  [FieldNumberTarget(73)]
  public ICollection<OrdersClass> Orders { get; set; } = new List<OrdersClass>();
  [FieldNumberTarget(73)]
  public class OrdersClass
  {    
    [FieldNumber(11)]    
    [RequiredField]
    public FixString ClOrdID { get; set; }
    
    [FieldNumber(37)]
    public FixString OrderID { get; set; }
    
    [FieldNumber(198)]
    public FixString SecondaryOrderID { get; set; }
    
    [FieldNumber(66)]
    public FixString ListID { get; set; }
    
    [FieldNumber(105)]
    public FixString WaveNo { get; set; }
  }
    
  [FieldNumber(54)]    
  [RequiredField]
  public FixChar Side { get; set; }
    
  [FieldNumber(55)]    
  [RequiredField]
  public FixString Symbol { get; set; }
    
  [FieldNumber(53)]    
  [RequiredField]
  public Qty Shares { get; set; }
    
  [FieldNumber(6)]    
  [RequiredField]
  public Price AvgPx { get; set; }
    
  [FieldNumber(75)]    
  [RequiredField]
  public LocalMktDate TradeDate { get; set; }
    
  [FieldNumber(78)]    
  [FieldChildrenNumbers(79, 366, 80, 81, 92, 208, 209, 161, 360, 361, 76, 109, 12, 13, 153, 154, 119, 120, 155, 156, 159, 160, 136)]    
  [RequiredField]
  public FixInt NoAllocs { get; set; }

  [FieldNumberTarget(78)]
  public ICollection<AllocsClass> Allocs { get; set; } = new List<AllocsClass>();
  [FieldNumberTarget(78)]
  public class AllocsClass
  {    
    [FieldNumber(79)]    
    [RequiredField]
    public FixString AllocAccount { get; set; }
    
    [FieldNumber(80)]    
    [RequiredField]
    public Qty AllocShares { get; set; }
    
    [FieldNumber(366)]
    public Price AllocPrice { get; set; }
    
    [FieldNumber(81)]
    public FixChar ProcessCode { get; set; }
    
    [FieldNumber(92)]
    public FixString BrokerOfCredit { get; set; }
    
    [FieldNumber(208)]
    public FixBool NotifyBrokerOfCredit { get; set; }
    
    [FieldNumber(209)]
    public FixInt AllocHandlInst { get; set; }
    
    [FieldNumber(161)]
    public FixString AllocText { get; set; }
    
    [FieldNumber(360)]
    public Length EncodedAllocTextLen { get; set; }
    
    [FieldNumber(361)]
    public FixData EncodedAllocText { get; set; }
    
    [FieldNumber(76)]
    public FixString ExecBroker { get; set; }
    
    [FieldNumber(109)]
    public FixString ClientID { get; set; }
    
    [FieldNumber(12)]
    public Amt Commission { get; set; }
    
    [FieldNumber(13)]
    public FixChar CommType { get; set; }
    
    [FieldNumber(153)]
    public Price AllocAvgPx { get; set; }
    
    [FieldNumber(154)]
    public Amt AllocNetMoney { get; set; }
    
    [FieldNumber(119)]
    public Amt SettlCurrAmt { get; set; }
    
    [FieldNumber(120)]
    public Currency SettlCurrency { get; set; }
    
    [FieldNumber(155)]
    public FixDecimal SettlCurrFxRate { get; set; }
    
    [FieldNumber(156)]
    public FixChar SettlCurrFxRateCalc { get; set; }
    
    [FieldNumber(159)]
    public Amt AccruedInterestAmt { get; set; }
    
    [FieldNumber(160)]
    public FixChar SettlInstMode { get; set; }
    
    [FieldNumber(136)]    
    [FieldChildrenNumbers(137, 138, 139)]
    public FixInt NoMiscFees { get; set; }

    [FieldNumberTarget(136)]
    public ICollection<MiscFeesClass> MiscFees { get; set; } = new List<MiscFeesClass>();
    [FieldNumberTarget(136)]
    public class MiscFeesClass
    {    
      [FieldNumber(137)]
      public Amt MiscFeeAmt { get; set; }
    
      [FieldNumber(138)]
      public Currency MiscFeeCurr { get; set; }
    
      [FieldNumber(139)]
      public FixChar MiscFeeType { get; set; }
    }
  }
    
  [FieldNumber(72)]
  public FixString RefAllocID { get; set; }
    
  [FieldNumber(196)]
  public FixString AllocLinkID { get; set; }
    
  [FieldNumber(197)]
  public FixInt AllocLinkType { get; set; }
    
  [FieldNumber(124)]    
  [FieldChildrenNumbers(32, 17, 31, 29)]
  public FixInt NoExecs { get; set; }

  [FieldNumberTarget(124)]
  public ICollection<ExecsClass> Execs { get; set; } = new List<ExecsClass>();
  [FieldNumberTarget(124)]
  public class ExecsClass
  {    
    [FieldNumber(32)]
    public Qty LastShares { get; set; }
    
    [FieldNumber(17)]
    public FixString ExecID { get; set; }
    
    [FieldNumber(31)]
    public Price LastPx { get; set; }
    
    [FieldNumber(29)]
    public FixChar LastCapacity { get; set; }
  }
    
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
    
  [FieldNumber(30)]
  public Exchange LastMkt { get; set; }
    
  [FieldNumber(336)]
  public FixString TradingSessionID { get; set; }
    
  [FieldNumber(15)]
  public Currency Currency { get; set; }
    
  [FieldNumber(74)]
  public FixInt AvgPrxPrecision { get; set; }
    
  [FieldNumber(60)]
  public UTCTimeStamp TransactTime { get; set; }
    
  [FieldNumber(63)]
  public FixChar SettlmntTyp { get; set; }
    
  [FieldNumber(64)]
  public LocalMktDate FutSettDate { get; set; }
    
  [FieldNumber(381)]
  public Amt GrossTradeAmt { get; set; }
    
  [FieldNumber(118)]
  public Amt NetMoney { get; set; }
    
  [FieldNumber(77)]
  public FixChar OpenClose { get; set; }
    
  [FieldNumber(58)]
  public FixString Text { get; set; }
    
  [FieldNumber(354)]
  public Length EncodedTextLen { get; set; }
    
  [FieldNumber(355)]
  public FixData EncodedText { get; set; }
    
  [FieldNumber(157)]
  public FixInt NumDaysInterest { get; set; }
    
  [FieldNumber(158)]
  public FixDecimal AccruedInterestRate { get; set; }

}
