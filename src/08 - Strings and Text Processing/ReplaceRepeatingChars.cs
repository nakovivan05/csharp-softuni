using System;
using System.Text;


namespace SoftUniCSharpStringsAndTextProcessing
{
    public class MultiplyBigNumber
    {
        static void Main()
        {
            string text = Console.ReadLine();
            StringBuilder sb = new StringBuilder();
            char previousChar = text[0];
            sb.Append(previousChar);
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i]!=previousChar)
                {
                    sb.Append(text[i]);
                    previousChar = text[i];
                }
            }
            Console.WriteLine(sb.ToString());
        }
    }
}
