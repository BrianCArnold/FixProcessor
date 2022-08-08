namespace FIX.Models;

public class TagNum : FixInt
{
    public TagNum(byte[] value) : base(value)
    {
        if (Value < 0)
        {
            throw new ArgumentException("SeqNum must not be negative");
        }
    }
}