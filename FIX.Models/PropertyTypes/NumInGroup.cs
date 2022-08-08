namespace FIX.Models;

public class NumInGroup : FixInt
{
    public NumInGroup(byte[] value) : base(value)
    {
        if (value.Length < 0)
        {
            throw new ArgumentException("Length must not be negative");
        }
    }
}
