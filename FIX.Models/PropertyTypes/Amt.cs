namespace FIX.Models;

public class Amt : FixDecimal
{
    public Amt(byte[] value) : base(value)
    {
    }
}