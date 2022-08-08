namespace FIX.Models;

public class MessageParserOptions
{
    public char Delimiter { get; set; } = '|';
    public bool TreatDelimiterAsSOHForChecksum { get; set; } = true;
    public bool DisableChecksum { get; set; } = false;
    public bool DisableSequenceCheck { get; set; } = false;
    public bool HideErrors { get; set; } = false;
}
