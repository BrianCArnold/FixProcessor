namespace FIX.Models
{
    public class ValidityMessage
    {
        public ValidityMessage(MessageLevel messageLevel, string message)
        {
            Level = messageLevel;
            Message = message;
        }

        public string Message { get; set; }
        public MessageLevel Level { get; set; }
    }
}