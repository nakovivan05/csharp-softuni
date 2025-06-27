using System;


namespace SoftUniCSharpMethods
{
    class AddAndSubstarct
    {
        static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int result = substract(findSum(a, b), c);
            Console.WriteLine(result);
        }
        static int findSum(int a, int b)
        {
            return a + b;
        }
        static int substract(int a, int b)
        {
            return a - b;
        }
    }
}
