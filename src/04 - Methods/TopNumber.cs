using System;

namespace SoftUniCSharpMethods
{
    class TopNumber
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                if(isItTopNumber(i))
                {
                    Console.WriteLine(i);
                }
            }
        }
        static bool isItTopNumber(int num)
        {
            int sumOfDigits = 0;
            bool hasOddDigit = false;
            char[] oddDigits = { '1','3','5','7','9' };
            string number = num.ToString();
            while (num > 0)
            {
                int digit = num % 10;
                sumOfDigits += digit;
                num /= 10;
            }
            
            for (int i = 0; i < number.Length; i++)
            {
                for (int j = 0; j < oddDigits.Length; j++)
                {
                    if (number[i] == oddDigits[j])
                    {
                        hasOddDigit = true;
                        break;
                    }
                }
            }
            return sumOfDigits%8==0 && hasOddDigit;
        }
    }
}
