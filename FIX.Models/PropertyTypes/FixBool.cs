using System.Text;

namespace FIX.Models;

public class FixBool : IFixType
{
    private bool internalValue;
    public FixBool(byte[] value)
    {
        var strValue = Encoding.UTF8.GetString(value);
        if (strValue != "Y" && strValue != "N")
        {
            throw new ArgumentException("Value must be Y or N");
        }
        internalValue = strValue == "Y" ? true : false;
    }
    public bool Value => this.internalValue;
    public override string ToString()
    {
        return internalValue ? bool.TrueString : bool.FalseString;
    }
    public static implicit operator bool(FixBool value)
    {
        return value.Value;
    }
}
