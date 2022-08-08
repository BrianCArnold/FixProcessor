namespace Tests.FIX.Models
{
    public static class Extensions
    {
        public static string ChangeStringToUseSOHChar(this string srcString)
            => srcString.Replace('|', (char)0x01);
    }
}