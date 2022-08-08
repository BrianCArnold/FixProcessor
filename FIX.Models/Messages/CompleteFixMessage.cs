namespace FIX.Models
{
    public record FixMessage(StandardHeader Header, IFixMessageComponent Body, StandardTrailer Trailer, IEnumerable<ValidityMessage> ValidityMessages);
    
}