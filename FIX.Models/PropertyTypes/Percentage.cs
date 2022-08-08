namespace FIX.Models;

public class Percentage : FixDecimal
{
    public Percentage(byte[] value) : base(value)
    {
        if (Value < 0.0m || Value > 1.0m)
        {
            throw new ArgumentOutOfRangeException("Percentage must be between 0.0 and 1.0");
        }
    }
}
