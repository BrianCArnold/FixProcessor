namespace FIX.Models;

public class UTCDateOnly : FixString
{
    public UTCDateOnly(byte[] value) : base(value)
    {
    }
}