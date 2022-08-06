
namespace FIX.Models;
[MessageCode("7")]
public class Advertisement
{
    
    [FieldNumber("2")]
    public FixString AdvId { get; set; }
    
    [FieldNumber("5")]
    public FixString AdvTransType { get; set; }
    
    [FieldNumber("4")]
    public FixChar AdvSide { get; set; }
    
    [FieldNumber("53")]
    public Qty Quantity { get; set; }
    
    [FieldNumber("3")]
    public FixString? AdvRefID { get; set; }
    
    [FieldNumber("555")]
    public NumInGroup? NoLegs { get; set; }
    
    [FieldNumber("711")]
    public NumInGroup? NoUnderlyings { get; set; }
    
    [FieldNumber("854")]
    public FixInt? QtyType { get; set; }
    
    [FieldNumber("44")]
    public Price? Price { get; set; }
    
    [FieldNumber("15")]
    public Currency? Currency { get; set; }
    
    [FieldNumber("75")]
    public LocalMktDate? TradeDate { get; set; }
    
    [FieldNumber("60")]
    public UTCTimestamp? TransactTime { get; set; }
    
    [FieldNumber("58")]
    public FixString? Text { get; set; }
    
    [FieldNumber("354")]
    public Length? EncodedTextLen { get; set; }
    
    [FieldNumber("355")]
    public FixData? EncodedText { get; set; }
    
    [FieldNumber("149")]
    public FixString? URLLink { get; set; }
    
    [FieldNumber("30")]
    public Exchange? LastMkt { get; set; }
    
    [FieldNumber("336")]
    public FixString? TradingSessionID { get; set; }
    
    [FieldNumber("625")]
    public FixString? TradingSessionSubID { get; set; }

}
