namespace FIX.Models;

public class FixData : IFixType
{
    private byte[] internalValue;
    public FixData(byte[] value)
    {
        this.internalValue = value;
    }
    public byte[] Value => this.internalValue;
    public override string ToString()
    {
        return Convert.ToBase64String(this.internalValue);
    }
    public static implicit operator byte[](FixData value)
    {
        return value.Value;
    }
}
