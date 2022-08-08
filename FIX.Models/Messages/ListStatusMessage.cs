namespace FIX.Models;

[MessageCode("N")]
public class ListStatusMessage : FixMessageComponent<ListStatusMessage>
{
    
  [FieldNumber(66)]    
  [RequiredField]
  public FixString ListID { get; set; }
    
  [FieldNumber(429)]    
  [RequiredField]
  public FixInt ListStatusType { get; set; }
    
  [FieldNumber(82)]    
  [RequiredField]
  public FixInt NoRpts { get; set; }
    
  [FieldNumber(431)]    
  [RequiredField]
  public FixInt ListOrderStatus { get; set; }
    
  [FieldNumber(83)]    
  [RequiredField]
  public FixInt RptSeq { get; set; }
    
  [FieldNumber(68)]    
  [RequiredField]
  public FixInt TotNoOrders { get; set; }
    
  [FieldNumber(73)]    
  [FieldChildrenNumbers(11, 14, 39, 151, 84, 6, 103, 58, 354, 355)]    
  [RequiredField]
  public FixInt NoOrders { get; set; }

  [FieldNumberTarget(73)]
  public ICollection<OrdersClass> OrdersCollection { get; set; } = new List<OrdersClass>();
  [FieldNumberTarget(73)]
  public class OrdersClass : FixMessageComponent<OrdersClass>
  {
    protected override bool EmitErrorOnDuplicateField => false;    
    [FieldNumber(11)]    
    [RequiredField]
    public FixString ClOrdID { get; set; }
    
    [FieldNumber(14)]    
    [RequiredField]
    public Quantity CumQty { get; set; }
    
    [FieldNumber(39)]    
    [RequiredField]
    public FixChar OrdStatus { get; set; }
    
    [FieldNumber(151)]    
    [RequiredField]
    public Quantity LeavesQty { get; set; }
    
    [FieldNumber(84)]    
    [RequiredField]
    public Quantity CxlQty { get; set; }
    
    [FieldNumber(6)]    
    [RequiredField]
    public Price AvgPx { get; set; }
    
    [FieldNumber(103)]
    public FixInt OrdRejReason { get; set; }
    
    [FieldNumber(58)]
    public FixString Text { get; set; }
    
    [FieldNumber(354)]
    public Length EncodedTextLen { get; set; }
    
    [FieldNumber(355)]
    public FixData EncodedText { get; set; }
  }
    
  [FieldNumber(444)]
  public FixString ListStatusText { get; set; }
    
  [FieldNumber(445)]
  public Length EncodedListStatusTextLen { get; set; }
    
  [FieldNumber(446)]
  public FixData EncodedListStatusText { get; set; }
    
  [FieldNumber(60)]
  public UTCTimeStamp TransactTime { get; set; }

}
