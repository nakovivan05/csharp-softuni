using System;
using System.Text;


namespace SoftUniCSharpStringsAndTextProcessing
{
    public class CaesarCipher
    {
        static void Main()
        {
            string text = Console.ReadLine();
            StringBuilder sb = new StringBuilder();
            foreach(char c in text)
            {
                sb.Append((char)(c+3));
            }
            Console.WriteLine(sb.ToString());
        }
    }
}