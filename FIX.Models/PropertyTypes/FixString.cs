namespace FIX.Models;

public class FixString : IFixType
{
    private string internalValue;
    public FixString(byte[] value)
    {
        internalValue = new string(System.Text.Encoding.UTF8.GetChars(value));
    }
    public string Value => internalValue;
    public static implicit operator string(FixString value)
    {
        return value?.Value;
    }
}
