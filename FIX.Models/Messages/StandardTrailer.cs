namespace FIX.Models;

public class StandardTrailer : FixMessageComponent<StandardTrailer>
{
    
  [FieldNumber(10)]    
  [RequiredField]
  public FixString CheckSum { get; set; }
    
  [FieldNumber(93)]
  public Length SignatureLength { get; set; }
    
  [FieldNumber(89)]
  public FixData Signature { get; set; }

  public override IEnumerable<ValidityMessage> PopulateMessageFields(FixStreamFieldQueue fields, MessageParserOptions options)
  {
    foreach (var msg in base.PopulateMessageFields(fields, options))
    {
      yield return msg;
    }
    if (options.DisableChecksum != true && (CheckSum == null || CheckSum.Value == null || CheckSum.Value != fields.CheckSum.ToString("000")))
    {
      yield return new ValidityMessage(MessageLevel.Error, $"CheckSum mismatch, expecting {fields.CheckSum.ToString("000")} but got {CheckSum?.Value}");
    }
  }
}
