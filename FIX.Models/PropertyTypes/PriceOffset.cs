namespace FIX.Models;

public class PriceOffset : FixDecimal
{
    public PriceOffset(byte[] value) : base(value)
    {
    }
}