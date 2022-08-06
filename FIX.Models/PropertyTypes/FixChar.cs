namespace FIX.Models;

public class FixChar
{
    private char internalValue;
    public FixChar(string value)
    {
        if (value.Length != 1)
        {
            throw new ArgumentException("Value must be a single character");
        }
        internalValue = value[0];
    }
    public char Value { get; set; }
}
public class FixBool
{
    private bool internalValue;
    public FixBool(string value)
    {
        if (value != "Y" && value != "N")
        {
            throw new ArgumentException("Value must be Y or N");
        }
        internalValue = value == "Y";
    }
    public bool Value { get; set; }
}
public class FixData
{
    private byte[] internalValue;
    public FixData(string value)
    {

    }
    public byte[] Value { get; set; }
}
public class FixDecimal
{
    private Decimal internalValue;
    public FixDecimal(string value)
    {

    }
    public Decimal Value { get; set; }
}
public class Amt
{
    private decimal internalValue;
    public Amt(string value)
    {

    }
    public decimal Value { get; set; }
}
public class Percentage
{
    private decimal internalValue;
    public Percentage(string value)
    {

    }
    public decimal Value { get; set; }
}
public class Price
{
    private decimal internalValue;
    public Price(string value)
    {

    }
    public decimal Value { get; set; }
}
public class PriceOffset
{
    private decimal internalValue;
    public PriceOffset(string value)
    {

    }
    public decimal Value { get; set; }
}
public class Qty
{
    private decimal internalValue;
    public Qty(string value)
    {

    }
    public decimal Value { get; set; }
}
public class FixInt
{
    private long internalValue;
    public FixInt(string value)
    {

    }
    public long Value { get; set; }
}
public class DayOfMonth
{
    private long internalValue;
    public DayOfMonth(string value)
    {

    }
    public long Value { get; set; }
}
public class Length
{
    private long internalValue;
    public Length(string value)
    {

    }
    public long Value { get; set; }
}
public class NumInGroup
{
    private long internalValue;
    public NumInGroup(string value)
    {

    }
    public long Value { get; set; }
}
public class SeqNum
{
    private long internalValue;
    public SeqNum(string value)
    {

    }
    public long Value { get; set; }
}
public class TagNum
{
    private long internalValue;
    public TagNum(string value)
    {

    }
    public long Value { get; set; }
}
public class FixString
{
    private string internalValue;
    public FixString(string value)
    {

    }
    public string Value { get; set; }
}
public class Country
{
    private string internalValue;
    public Country(string value)
    {

    }
    public string Value { get; set; }
}
public class Currency
{
    private string internalValue;
    public Currency(string value)
    {

    }
    public string Value { get; set; }
}
public class Exchange
{
    private string internalValue;
    public Exchange(string value)
    {

    }
    public string Value { get; set; }
}
public class LocalMktDate
{
    private string internalValue;
    public LocalMktDate(string value)
    {

    }
    public string Value { get; set; }
}
public class MonthYear
{
    private string internalValue;
    public MonthYear(string value)
    {

    }
    public string Value { get; set; }
}
public class MultipleValueString
{
    private string internalValue;
    public MultipleValueString(string value)
    {

    }
    public string Value { get; set; }
}
public class UTCDateOnly
{
    private string internalValue;
    public UTCDateOnly(string value)
    {

    }
    public string Value { get; set; }
}
public class UTCTimeOnly
{
    private string internalValue;
    public UTCTimeOnly(string value)
    {

    }
    public string Value { get; set; }
}
public class UTCTimeStamp
{
    private string internalValue;
    public UTCTimeStamp(string value)
    {

    }
    public string Value { get; set; }
}