using System.Text.RegularExpressions;

namespace FIX.Models;

public class UTCTimeStamp : FixString
{
    public UTCTimeStamp(byte[] value) : base(value)
    {
        if (!Regex.Match(Value, "^[0-9]{4}(?:1[012]|0[1-9])(?:0[1-9]|[12][0-9]|3[01])-(?:[0-1][0-9]|2[0-3]):(?:[0-5][0-9]):(?:[0-5][0-9]|60)(?:.\\d{3})?$").Success)
        {
            throw new ArgumentException("UTCTimeStamp must be in the format YYYYMMDD-HH:MM:SS or YYYYMMDD-HH:MM:SS.sss");
        }
    }
}