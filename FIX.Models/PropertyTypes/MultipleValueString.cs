namespace FIX.Models;

public class MultipleValueString : FixString
{
    public MultipleValueString(byte[] value) : base(value)
    {
    }
    public IEnumerable<string> Values
    {
        get
        {
            return base.Value.Split(',');
        }
    }
}