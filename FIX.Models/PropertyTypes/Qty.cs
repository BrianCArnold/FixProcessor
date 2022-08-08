namespace FIX.Models;

public class Qty : FixDecimal
{
    public Qty(byte[] value) : base(value)
    {
    }
}
