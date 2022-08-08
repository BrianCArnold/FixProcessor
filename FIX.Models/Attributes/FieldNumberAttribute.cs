namespace FIX.Models;

[System.AttributeUsage(System.AttributeTargets.Property, Inherited = false, AllowMultiple = true)]
public sealed class FieldNumberAttribute : System.Attribute
{
    private readonly uint fieldNumber;
    
    public FieldNumberAttribute(uint fieldNumber)
    {
        this.fieldNumber = fieldNumber;
    }
    
    public uint FieldNumber => fieldNumber; 
    
}
