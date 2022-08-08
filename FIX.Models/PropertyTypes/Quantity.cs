namespace FIX.Models;

public class Quantity : FixDecimal
{
    public Quantity(byte[] value) : base(value)
    {
    }
}
