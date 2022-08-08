namespace FIX.Models;

public class FixInt : IFixType
{
    private long internalValue;
    public FixInt(byte[] value)
    {
        var strValue = System.Text.Encoding.UTF8.GetChars(value);
        internalValue = long.Parse(strValue);
    }
    public long Value => internalValue;
}
