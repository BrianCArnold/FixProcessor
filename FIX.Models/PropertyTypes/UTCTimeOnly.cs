using System.Text.RegularExpressions;

namespace FIX.Models;

public class UTCTimeOnly : FixString
{
    public UTCTimeOnly(byte[] value) : base(value)
    {
        if (!Regex.Match(Value, "^(?:[0-1][0-9]|2[0-3]):(?:[0-5][0-9]):(?:[0-5][0-9]|60)(?:.\\d{3})?$").Success)
        {
            throw new ArgumentException("UTCTime must be in the format HH:MM:SS or HH:MM:SS.sss");
        }
    }
}
