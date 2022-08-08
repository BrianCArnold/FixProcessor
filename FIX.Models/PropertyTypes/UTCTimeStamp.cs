namespace FIX.Models;

public class UTCTimeStamp : FixString
{
    public UTCTimeStamp(byte[] value) : base(value)
    {
    }
}