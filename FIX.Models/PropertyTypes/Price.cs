namespace FIX.Models;

public class Price : FixDecimal
{
    public Price(byte[] value) : base(value)
    {
    }
}