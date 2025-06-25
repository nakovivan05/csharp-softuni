using System;
using System.Linq;


namespace SoftUniCSharpMethods
{
    class SmallestOfThreeNumbers
    {
        
        static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int smallest = findSmallestOfThreeNumbers(a, b, c);
            Console.WriteLine(smallest);
        }
        static int findSmallestOfThreeNumbers (int a, int b, int c)
        {
            if (a < b && a < c)
            {
                return a;
            }
            else if (b < c)
            {
                return b;
            }
            else
            {
                return c;
            }
        }
    }
}
