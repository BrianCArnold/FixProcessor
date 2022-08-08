namespace FIX.Models;

[System.AttributeUsage(System.AttributeTargets.Class, Inherited = false, AllowMultiple = true)]
public sealed class MessageCodeAttribute : System.Attribute
{
    // See the attribute guidelines at
    //  http://go.microsoft.com/fwlink/?LinkId=85236
    private readonly string messageCode;
    
    // This is a positional argument
    public MessageCodeAttribute(string messageCode)
    {
        this.messageCode = messageCode;
        
    }
    
    public string MessageCode => messageCode;
    
}