using System.Text.RegularExpressions;

namespace FIX.Models;

public class UTCDateOnly : FixString
{
    public UTCDateOnly(byte[] value) : base(value)
    {
        #warning The specification I'm using says that valid values are anything of the format of YYYYMMDD, where MM is 01-12 and DD is 01-31. This allows "20000231", which is an impossible date, but it matches the spec on onixs.biz.
        if (!Regex.Match(Value, "^[0-9]{4}(?:1[012]|0[1-9])(?:0[1-9]|[12][0-9]|3[01])$").Success)
        {
            throw new ArgumentException("UTCDate must be in the format YYYYMMDD");
        }
    }
}