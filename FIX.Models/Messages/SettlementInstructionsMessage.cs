namespace FIX.Models;

[MessageCode("T")]
public class SettlementInstructionsMessage : FixMessageComponent<SettlementInstructionsMessage>
{
    
  [FieldNumber(162)]    
  [RequiredField]
  public FixString SettlInstID { get; set; }
    
  [FieldNumber(163)]    
  [RequiredField]
  public FixChar SettlInstTransType { get; set; }
    
  [FieldNumber(214)]    
  [RequiredField]
  public FixString SettlInstRefID { get; set; }
    
  [FieldNumber(160)]    
  [RequiredField]
  public FixChar SettlInstMode { get; set; }
    
  [FieldNumber(165)]    
  [RequiredField]
  public FixChar SettlInstSource { get; set; }
    
  [FieldNumber(79)]    
  [RequiredField]
  public FixString AllocAccount { get; set; }
    
  [FieldNumber(60)]    
  [RequiredField]
  public UTCTimeStamp TransactTime { get; set; }
    
  [FieldNumber(166)]
  public FixString SettlLocation { get; set; }
    
  [FieldNumber(75)]
  public LocalMktDate TradeDate { get; set; }
    
  [FieldNumber(70)]
  public FixString AllocID { get; set; }
    
  [FieldNumber(30)]
  public Exchange LastMkt { get; set; }
    
  [FieldNumber(336)]
  public FixString TradingSessionID { get; set; }
    
  [FieldNumber(54)]
  public FixChar Side { get; set; }
    
  [FieldNumber(167)]
  public FixString SecurityType { get; set; }
    
  [FieldNumber(168)]
  public UTCTimeStamp EffectiveTime { get; set; }
    
  [FieldNumber(109)]
  public FixString ClientID { get; set; }
    
  [FieldNumber(76)]
  public FixString ExecBroker { get; set; }
    
  [FieldNumber(169)]
  public FixInt StandInstDbType { get; set; }
    
  [FieldNumber(170)]
  public FixString StandInstDbName { get; set; }
    
  [FieldNumber(171)]
  public FixString StandInstDbID { get; set; }
    
  [FieldNumber(172)]
  public FixInt SettlDeliveryType { get; set; }
    
  [FieldNumber(173)]
  public FixString SettlDepositoryCode { get; set; }
    
  [FieldNumber(174)]
  public FixString SettlBrkrCode { get; set; }
    
  [FieldNumber(175)]
  public FixString SettlInstCode { get; set; }
    
  [FieldNumber(176)]
  public FixString SecuritySettlAgentName { get; set; }
    
  [FieldNumber(177)]
  public FixString SecuritySettlAgentCode { get; set; }
    
  [FieldNumber(178)]
  public FixString SecuritySettlAgentAcctNum { get; set; }
    
  [FieldNumber(179)]
  public FixString SecuritySettlAgentAcctName { get; set; }
    
  [FieldNumber(180)]
  public FixString SecuritySettlAgentContactName { get; set; }
    
  [FieldNumber(181)]
  public FixString SecuritySettlAgentContactPhone { get; set; }
    
  [FieldNumber(182)]
  public FixString CashSettlAgentName { get; set; }
    
  [FieldNumber(183)]
  public FixString CashSettlAgentCode { get; set; }
    
  [FieldNumber(184)]
  public FixString CashSettlAgentAcctNum { get; set; }
    
  [FieldNumber(185)]
  public FixString CashSettlAgentAcctName { get; set; }
    
  [FieldNumber(186)]
  public FixString CashSettlAgentContactName { get; set; }
    
  [FieldNumber(187)]
  public FixString CashSettlAgentContactPhone { get; set; }

}
