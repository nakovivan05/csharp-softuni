using System;

namespace SoftUniCSharpMethods
{
    class PalindromeIntegers
    {
        static void Main()
        {
            string command = "";
            while((command = Console.ReadLine())!= "END")
            {
                int num = int.Parse(command);
                Console.WriteLine(isItPalindrome(num));
            }
        }
        static bool isItPalindrome(int num)
        {
            string number = num.ToString();
            string reversed = "";
            for (int i = number.Length - 1; i >= 0; i--)
            {
                reversed += number[i];
            }
            return reversed == number;
        }
    }
}
