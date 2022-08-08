namespace FIX.Models;

public class SeqNum : FixInt
{
    public SeqNum(byte[] value) : base(value)
    {
        if (Value < 0)
        {
            throw new ArgumentException("SeqNum must not be negative");
        }
    }
}
