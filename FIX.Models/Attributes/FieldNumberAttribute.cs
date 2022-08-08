namespace FIX.Models;

[System.AttributeUsage(System.AttributeTargets.Property, Inherited = false, AllowMultiple = true)]
public sealed class FieldNumberAttribute : System.Attribute
{
    // See the attribute guidelines at
    //  http://go.microsoft.com/fwlink/?LinkId=85236
    private readonly uint fieldNumber;
    
    // This is a positional argument
    public FieldNumberAttribute(uint fieldNumber)
    {
        this.fieldNumber = fieldNumber;
    }
    
    public uint FieldNumber
    {
        get { return fieldNumber; }
    }
    
}
