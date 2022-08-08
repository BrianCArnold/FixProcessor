namespace FIX.Models;

[System.AttributeUsage(System.AttributeTargets.Property, Inherited = false, AllowMultiple = true)]
public sealed class FieldChildrenNumbersAttribute : System.Attribute
{
    // See the attribute guidelines at
    //  http://go.microsoft.com/fwlink/?LinkId=85236
    private readonly uint[] children;
    
    // This is a positional argument
    public FieldChildrenNumbersAttribute(params uint[] fieldNumbers)
    {
        this.children = fieldNumbers;
    }
    
    public uint[] Children => children;
    
}
