
namespace FIX.Models;
[MessageCode("S")]
public class Quote
{
    
    [FieldNumber("117")]
    public FixString QuoteID { get; set; }
    
    [FieldNumber("131")]
    public FixString? QuoteReqID { get; set; }
    
    [FieldNumber("693")]
    public FixString? QuoteRespID { get; set; }
    
    [FieldNumber("537")]
    public FixInt? QuoteType { get; set; }
    
    [FieldNumber("735")]
    public NumInGroup? NoQuoteQualifiers { get; set; }
    
    [FieldNumber("301")]
    public FixInt? QuoteResponseLevel { get; set; }
    
    [FieldNumber("336")]
    public FixString? TradingSessionID { get; set; }
    
    [FieldNumber("625")]
    public FixString? TradingSessionSubID { get; set; }
    
    [FieldNumber("711")]
    public NumInGroup? NoUnderlyings { get; set; }
    
    [FieldNumber("54")]
    public FixChar? Side { get; set; }
    
    [FieldNumber("63")]
    public FixChar? SettlType { get; set; }
    
    [FieldNumber("64")]
    public LocalMktDate? SettlDate { get; set; }
    
    [FieldNumber("193")]
    public LocalMktDate? SettlDate2 { get; set; }
    
    [FieldNumber("192")]
    public Qty? OrderQty2 { get; set; }
    
    [FieldNumber("15")]
    public Currency? Currency { get; set; }
    
    [FieldNumber("1")]
    public FixString? Account { get; set; }
    
    [FieldNumber("660")]
    public FixInt? AcctIDSource { get; set; }
    
    [FieldNumber("581")]
    public FixInt? AccountType { get; set; }
    
    [FieldNumber("555")]
    public NumInGroup? NoLegs { get; set; }
    
    [FieldNumber("132")]
    public Price? BidPx { get; set; }
    
    [FieldNumber("133")]
    public Price? OfferPx { get; set; }
    
    [FieldNumber("645")]
    public Price? MktBidPx { get; set; }
    
    [FieldNumber("646")]
    public Price? MktOfferPx { get; set; }
    
    [FieldNumber("647")]
    public Qty? MinBidSize { get; set; }
    
    [FieldNumber("134")]
    public Qty? BidSize { get; set; }
    
    [FieldNumber("648")]
    public Qty? MinOfferSize { get; set; }
    
    [FieldNumber("135")]
    public Qty? OfferSize { get; set; }
    
    [FieldNumber("62")]
    public UTCTimestamp? ValidUntilTime { get; set; }
    
    [FieldNumber("188")]
    public Price? BidSpotRate { get; set; }
    
    [FieldNumber("190")]
    public Price? OfferSpotRate { get; set; }
    
    [FieldNumber("189")]
    public PriceOffset? BidForwardPoints { get; set; }
    
    [FieldNumber("191")]
    public PriceOffset? OfferForwardPoints { get; set; }
    
    [FieldNumber("631")]
    public Price? MidPx { get; set; }
    
    [FieldNumber("632")]
    public Percentage? BidYield { get; set; }
    
    [FieldNumber("633")]
    public Percentage? MidYield { get; set; }
    
    [FieldNumber("634")]
    public Percentage? OfferYield { get; set; }
    
    [FieldNumber("60")]
    public UTCTimestamp? TransactTime { get; set; }
    
    [FieldNumber("40")]
    public FixChar? OrdType { get; set; }
    
    [FieldNumber("642")]
    public PriceOffset? BidForwardPoints2 { get; set; }
    
    [FieldNumber("643")]
    public PriceOffset? OfferForwardPoints2 { get; set; }
    
    [FieldNumber("656")]
    public FixDecimal? SettlCurrBidFxRate { get; set; }
    
    [FieldNumber("657")]
    public FixDecimal? SettlCurrOfferFxRate { get; set; }
    
    [FieldNumber("156")]
    public FixChar? SettlCurrFxRateCalc { get; set; }
    
    [FieldNumber("13")]
    public FixChar? CommType { get; set; }
    
    [FieldNumber("12")]
    public Amt? Commission { get; set; }
    
    [FieldNumber("582")]
    public FixInt? CustOrderCapacity { get; set; }
    
    [FieldNumber("100")]
    public Exchange? ExDestination { get; set; }
    
    [FieldNumber("528")]
    public FixChar? OrderCapacity { get; set; }
    
    [FieldNumber("423")]
    public FixInt? PriceType { get; set; }
    
    [FieldNumber("58")]
    public FixString? Text { get; set; }
    
    [FieldNumber("354")]
    public Length? EncodedTextLen { get; set; }
    
    [FieldNumber("355")]
    public FixData? EncodedText { get; set; }

}
