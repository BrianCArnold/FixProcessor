namespace FIX.Models;

[System.AttributeUsage(System.AttributeTargets.Class | System.AttributeTargets.Property, Inherited = false, AllowMultiple = true)]
public sealed class FieldNumberTargetAttribute : System.Attribute
{
    // See the attribute guidelines at
    //  http://go.microsoft.com/fwlink/?LinkId=85236
    private readonly uint fieldNumber;
    
    // This is a positional argument
    public FieldNumberTargetAttribute(uint fieldNumber)
    {
        this.fieldNumber = fieldNumber;
    }
    
    public uint FieldNumber => fieldNumber; 
    
}
