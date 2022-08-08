namespace FIX.Models;

public class LocalMktDate : UTCDateOnly
{
    public LocalMktDate(byte[] value) : base(value)
    {
    }
}
