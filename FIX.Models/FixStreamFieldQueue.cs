using System.Collections;

namespace FIX.Models;

public class FixStreamFieldQueue : IDisposable
{
    
    private readonly MemoryStream fixStream;

    public Queue<FixField> Fields { get; private set; }

    public FixStreamFieldQueue(Stream strm, MessageParserOptions options)
    {
        this.options = options ?? new MessageParserOptions();
        fixStream = new MemoryStream();
        strm.CopyTo(fixStream);
        fixStream.Position = 0;
        this.Fields = new Queue<FixField>(IterateStream());
    }

    private bool completedLastTime = false;
    private bool disposedValue;
    private uint checkSum = 0;
    public byte CheckSum => (byte)(checkSum % 256);

    private IEnumerable<byte> InternalReadUntilSOH()
    {
        var buffer = new byte[1];
        while (true)
        {
            var bytesRead = fixStream.Read(buffer, 0, 1);
            if (bytesRead == 0)
            {
                completedLastTime = true;
                yield break;
            }
            if (buffer[0] == SOHChar)
            {
                yield break;
            }
            yield return buffer[0];
        }
    }
    private byte[] ReadUntilSOH()
    {
        IEnumerable<byte> bytes = InternalReadUntilSOH();
        return bytes.ToArray();
    }
    private readonly MessageParserOptions options;
    private char SOHChar => options.Delimiter;
    private bool treatDelimiterAsSOHForChecksum => options.TreatDelimiterAsSOHForChecksum;

    private IEnumerable<FixField> IterateStream()
    {
        while (true)
        {
            if (completedLastTime)
            {
                yield break;
            }
            var fieldBytes = ReadUntilSOH();
            if (fieldBytes.Length > 0)
            {
                FixField field;
                try 
                {
                    field = new FixField(fieldBytes);
                    if (field.FieldNumber != 10)
                    {
                        checkSum += fieldBytes.Aggregate(0u, (c,n) => c + n) + (treatDelimiterAsSOHForChecksum ? 1u : (ushort)SOHChar);
                    }
                }
                catch (Exception ex)
                {
                    break;
                }
                yield return field;
            }
            else 
            {
                yield break;
            }
        }
    }

    protected virtual void Dispose(bool disposing)
    {
        if (!disposedValue)
        {
            if (disposing)
            {
                fixStream.Dispose();
            }
            disposedValue = true;
        }
    }

    public void Dispose()
    {
        // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
        Dispose(disposing: true);
        GC.SuppressFinalize(this);
    }
}