namespace FIX.Models
{
    public record FixMessage(StandardHeader Header, IFixMessageComponent Body, StandardTrailer Trailer, byte CheckSum, bool BodyValid)
    {
        public bool CheckSumValid => Trailer?.CheckSum != null && CheckSum.ToString("000") == Trailer.CheckSum;

        public bool MessageValid => CheckSumValid && BodyValid;

    }
    
}