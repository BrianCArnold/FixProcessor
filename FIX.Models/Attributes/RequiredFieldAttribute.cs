namespace FIX.Models;

[System.AttributeUsage(System.AttributeTargets.Property, Inherited = false, AllowMultiple = true)]
public sealed class RequiredFieldAttribute : System.Attribute
{
    public RequiredFieldAttribute()
    {
    }
}
