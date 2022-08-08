namespace FIX.Models;

[System.AttributeUsage(System.AttributeTargets.Class, Inherited = false, AllowMultiple = true)]
public sealed class MessageCodeAttribute : System.Attribute
{
    private readonly string messageCode;
    
    public MessageCodeAttribute(string messageCode)
    {
        this.messageCode = messageCode;
        
    }
    
    public string MessageCode => messageCode;
    
}