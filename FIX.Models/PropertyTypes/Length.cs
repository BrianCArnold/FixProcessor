namespace FIX.Models;

public class Length : FixInt
{
    public Length(byte[] value) : base(value)
    {
        if (value.Length < 0)
        {
            throw new ArgumentException("Length must not be negative");
        }
    }
}