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

}
