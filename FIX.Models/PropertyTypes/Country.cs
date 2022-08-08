namespace FIX.Models;

public class Country : FixString
{
    public Country(byte[] value) : base(value)
    {
    }
}