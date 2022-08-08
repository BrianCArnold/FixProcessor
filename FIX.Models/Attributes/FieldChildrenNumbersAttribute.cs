namespace FIX.Models;

[System.AttributeUsage(System.AttributeTargets.Property, Inherited = false, AllowMultiple = true)]
public sealed class FieldChildrenNumbersAttribute : System.Attribute
{
    private readonly uint[] children;
    
    public FieldChildrenNumbersAttribute(params uint[] fieldNumbers)
    {
        this.children = fieldNumbers;
    }
    
    public uint[] Children => children;
    
}
