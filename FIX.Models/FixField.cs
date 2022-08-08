using System.Text;

namespace FIX.Models;

public class FixField
{
    private const byte equalSign = 0x3d;
    public FixField(byte[] value)
    {
        //"8=FIX.4.2"
        //length = 9 (0-8)
        //index(eq) = 1
        //fieldNumLen = 1
        //valLen = 7
        var eqSign = Array.IndexOf(value, equalSign);
        if (eqSign == -1)
        {
            throw new ArgumentException("Invalid field format");
        }
        ReadOnlySpan<byte> fieldNum = new ReadOnlySpan<byte>(value, 0, eqSign);
        ReadOnlySpan<byte> val = new ReadOnlySpan<byte>(value, eqSign + 1, value.Length - eqSign - 1);
        Span<char> fieldStr = stackalloc char[fieldNum.Length];
        Encoding.UTF8.GetChars(fieldNum, fieldStr);
        FieldNumber = uint.Parse(fieldStr);
        Value = val.ToArray();
    }
    public uint FieldNumber { get; set; }
    public byte[] Value { get; set; }
}
