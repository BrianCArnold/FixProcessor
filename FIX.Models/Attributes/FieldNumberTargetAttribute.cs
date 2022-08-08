namespace FIX.Models;

[System.AttributeUsage(System.AttributeTargets.Class | System.AttributeTargets.Property, Inherited = false, AllowMultiple = true)]
public sealed class FieldNumberTargetAttribute : System.Attribute
{
    private readonly uint fieldNumber;
    
    public FieldNumberTargetAttribute(uint fieldNumber)
    {
        this.fieldNumber = fieldNumber;
    }
    
    public uint FieldNumber => fieldNumber; 
    
}
