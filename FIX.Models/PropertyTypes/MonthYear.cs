using System.Text.RegularExpressions;

namespace FIX.Models;

public class MonthYear : FixString
{
    public MonthYear(byte[] value) : base(value)
    {
        if (!Regex.Match(Value, "^[0-9]{4}(?:1[012]|0[1-9])$").Success)
        {
            throw new ArgumentException("MonthYear must be in the format YYYYMM");
        }
    }
}