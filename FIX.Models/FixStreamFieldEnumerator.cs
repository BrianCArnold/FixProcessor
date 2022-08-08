using System.Collections;

namespace FIX.Models;

public class FixStreamFieldEnumerator : IEnumerator<FixField>, IDisposable
{
    private readonly MemoryStream fixStream;
    public FixStreamFieldEnumerator(MemoryStream strm)
    {
        this.fixStream = strm;
    }
    private FixField internalCurrent = null;
    FixField IEnumerator<FixField>.Current { get => internalCurrent == null ? throw new IndexOutOfRangeException() : internalCurrent; }

    object IEnumerator.Current => internalCurrent == null ? throw new IndexOutOfRangeException() : internalCurrent.Value;

    private bool completedLastTime = false;
    private bool disposedValue;

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

    private char SOHChar => '\u0001';
    public bool MoveNext()
    {
        if (completedLastTime)
        {
            internalCurrent = null;
            return false;
        }
        var fieldBytes = ReadUntilSOH();
        if (fieldBytes.Length > 0)
        {
            internalCurrent = new FixField(fieldBytes);
            return true;
        }
        else 
        {
            return false;
        }
    }

    public void Reset()
    {
        fixStream.Position = 0;
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