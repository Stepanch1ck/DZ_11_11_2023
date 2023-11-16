using System.Text;

namespace Tumakov_Lab10
{
    internal class ACipher : ICipher
    {
        public string Encode(string text)
        {
            StringBuilder encodedText = new StringBuilder();
            for (int i = 0; i < text.Length; i++)
            {
                int charIndex = (char)text[i];
                encodedText.Append((char)(charIndex + 1));
            }
            return encodedText.ToString();
        }

        public string Decode(string text)
        {
            StringBuilder decodedText = new StringBuilder();
            for (int i = 0; i < text.Length; i++)
            {
                int charIndex = (char)text[i];
                decodedText.Append((char)(charIndex - 1));
            }
            return decodedText.ToString();

        }
    }
}
