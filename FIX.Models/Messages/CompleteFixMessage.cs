namespace FIX.Models
{
    public record FixMessage(StandardHeader Header, IFixMessageComponent Body, StandardTrailer Trailer, byte CheckSum)
    {
        public bool Validated => CheckSum.ToString("000") == Trailer.CheckSum.Value;
    }
    
}