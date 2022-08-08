using System.Text;

namespace FIX.Models;

public class FixChar : IFixType
{
    private char internalValue;
    public FixChar(byte[] value)
    {
        if (value.Length != 1)
        {
            throw new ArgumentException("Value must be a single character");
        }
        internalValue = Encoding.UTF8.GetChars(value)[0];
    }
    public char Value => this.internalValue;
    public override string ToString()
    {
        return internalValue.ToString();
    }
    public static implicit operator char(FixChar value)
    {
        return value.Value;
    }
}
