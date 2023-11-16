

namespace Tumakov_Lab10
{
    internal interface ICipher
    {
        string Encode(string text);
        string Decode(string text);
    }
}
