using System;
using System.Text;

namespace Tumakov_Lab10
{
    internal class BCipher : ICipher
    {
        private static readonly char[] alphabet = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯабвгдеёжзийклмнопрстуфхцчшщъыьэюя .,!?:;()".ToCharArray();

        public string Encode(string text)
        {
            StringBuilder encodedText = new StringBuilder();
            for (int i = 0; i < text.Length; i++)
            {
                char currentChar = text[i];
                int charIndex = Array.IndexOf(alphabet, currentChar);
                if (charIndex >= 0 && charIndex < alphabet.Length)
                {
                    encodedText.Append(alphabet[charIndex + 1]);
                }
            }
            return encodedText.ToString();
        }

        public string Decode(string text)
        {
            StringBuilder decodedText = new StringBuilder();
            for (int i = 0; i < text.Length; i++)
            {
                char currentChar = text[i];
                int charIndex = Array.IndexOf(alphabet, currentChar);
                if (charIndex >= 0 && charIndex < alphabet.Length)
                {
                    decodedText.Append(alphabet[charIndex - 1]);
                }
            }
            return decodedText.ToString();
        }
    }
}
