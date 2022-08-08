using System.Collections;

namespace FIX.Models;

public class FixStreamFieldEnumerable : IEnumerable<FixField>, IDisposable
{
    private readonly MemoryStream fixStream;
    private bool isDisposed = false;

    public FixStreamFieldEnumerable(Stream strm)
    {
        fixStream = new MemoryStream();
        strm.CopyTo(fixStream);
        fixStream.Position = 0;
    }
    public IEnumerator<FixField> GetEnumerator()
    {
        if (isDisposed)
        {
            throw new ObjectDisposedException("FixStreamFieldEnumerable Already Disposed");
        }
        var enumeratorStream = new MemoryStream();
        fixStream.CopyTo(enumeratorStream);
        enumeratorStream.Position = 0;
        return new FixStreamFieldEnumerator(enumeratorStream);
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    protected virtual void Dispose(bool disposing)
    {
        if (!isDisposed)
        {
            if (disposing)
            {
                fixStream.Dispose();
            }

            isDisposed = true;
        }
        else 
        {
            throw new ObjectDisposedException("FixStreamFieldEnumerable Already Disposed");
        }
    }

    // // TODO: override finalizer only if 'Dispose(bool disposing)' has code to free unmanaged resources
    // ~FixStreamFieldEnumerable()
    // {
    //     // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
    //     Dispose(disposing: false);
    // }

    public void Dispose()
    {
        // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
        Dispose(disposing: true);
        GC.SuppressFinalize(this);
    }
}
