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
        public override string ToString()
        {
            return string.Format("{0} - {1}", Level, Message);
        }
    }
}