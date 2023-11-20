using System.Collections;
using System.Runtime.CompilerServices;

namespace CSharp12Features.CollectionExpression;

[CollectionBuilder(typeof(LineBufferBuilder), "Create")]
public class MyCollection : IEnumerable<string>
{
    private readonly string[] _buffer = new string[80];

    public MyCollection(ReadOnlySpan<string> buffer)
    {
        int number = (_buffer.Length < buffer.Length) ? _buffer.Length : buffer.Length;
        for (int i = 0; i < number; i++)
        {
            _buffer[i] = buffer[i];
        }
    }

    public IEnumerator<string> GetEnumerator() => _buffer.AsEnumerable().GetEnumerator();
    IEnumerator IEnumerable.GetEnumerator() => _buffer.GetEnumerator();

}

internal static class LineBufferBuilder
{
    internal static MyCollection Create(ReadOnlySpan<string> values) => new MyCollection(values);
}