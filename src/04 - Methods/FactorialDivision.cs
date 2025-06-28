using System;


namespace SoftUniCSharpMethods
{
    class FactorialDivision
    {
        static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            divideFactorialsOfTwoIntegers(a, b);
        }
        static void  divideFactorialsOfTwoIntegers(int a, int b)
        {
            long factorialA = 1;
            long factorialB = 1;
            while(a>0)
            {
                factorialA *= a;
                a--;
            }
            while(b>0)
            {
                factorialB *= b;
                b--;
            }
            Console.WriteLine($"{(double)factorialA / factorialB:F2}");
        }
    }
}
