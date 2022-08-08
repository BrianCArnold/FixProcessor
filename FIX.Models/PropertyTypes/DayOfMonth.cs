namespace FIX.Models;

public class DayOfMonth : FixInt
{
    public DayOfMonth(byte[] value) : base(value)
    {
        if (base.Value > 31)
        {
            throw new ArgumentOutOfRangeException(nameof(value), "DayOfMonth must be between 1 and 31");
        }
    }
}