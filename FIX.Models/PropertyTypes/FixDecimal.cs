using System.Text;

namespace FIX.Models;

public class FixDecimal : IFixType
{
    private Decimal internalValue;
    public FixDecimal(byte[] value)
    {
        var strValue = Encoding.UTF8.GetChars(value);
        internalValue = decimal.Parse(strValue);
    }
    public Decimal Value => internalValue;
    public static implicit operator Decimal(FixDecimal value)
    {
        return value.Value;
    }
}
