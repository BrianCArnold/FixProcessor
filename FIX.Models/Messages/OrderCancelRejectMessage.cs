namespace FIX.Models;

[MessageCode("9")]
public class OrderCancelRejectMessage : FixMessageComponent<OrderCancelRejectMessage>
{
    
  [FieldNumber(37)]    
  [RequiredField]
  public FixString OrderID { get; set; }
    
  [FieldNumber(11)]    
  [RequiredField]
  public FixString ClOrdID { get; set; }
    
  [FieldNumber(41)]    
  [RequiredField]
  public FixString OrigClOrdID { get; set; }
    
  [FieldNumber(39)]    
  [RequiredField]
  public FixChar OrdStatus { get; set; }
    
  [FieldNumber(434)]    
  [RequiredField]
  public FixChar CxlRejResponseTo { get; set; }
    
  [FieldNumber(198)]
  public FixString SecondaryOrderID { get; set; }
    
  [FieldNumber(109)]
  public FixString ClientID { get; set; }
    
  [FieldNumber(76)]
  public FixString ExecBroker { get; set; }
    
  [FieldNumber(66)]
  public FixString ListID { get; set; }
    
  [FieldNumber(1)]
  public FixString Account { get; set; }
    
  [FieldNumber(60)]
  public UTCTimeStamp TransactTime { get; set; }
    
  [FieldNumber(102)]
  public FixInt CxlRejReason { get; set; }
    
  [FieldNumber(58)]
  public FixString Text { get; set; }
    
  [FieldNumber(354)]
  public Length EncodedTextLen { get; set; }
    
  [FieldNumber(355)]
  public FixData EncodedText { get; set; }

}
