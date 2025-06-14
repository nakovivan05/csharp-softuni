using System;


namespace SoftuniCSharpDataTypesAndVariables
{
    class SumDigits
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());
            int sumOfDigits = 0;
            while (num != 0)
            {
                int digit = num % 10;
                sumOfDigits += digit;
                num /= 10;
            }
            Console.WriteLine(sumOfDigits);

        }
    }
}
