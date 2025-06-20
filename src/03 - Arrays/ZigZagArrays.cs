using System;
using System.Linq;


namespace SoftUniCSharpArrays
{
    class ZigZagArrays
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] firstArray = new int[n];
            int[] secondArray = new int[n];
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine();
                int[] twoIntegers = input.Split(' ').Select(int.Parse).ToArray();
                if (i % 2 == 0)
                {
                    firstArray[i] = twoIntegers[0];
                    secondArray[i] = twoIntegers[1];
                }
                else
                {
                    firstArray[i] = twoIntegers[1];
                    secondArray[i] = twoIntegers[0];
                }

            }
            foreach(int integer in firstArray)
            {
                Console.Write(integer + " ");
            }
            Console.WriteLine();
            foreach(int integer in secondArray)
            {
                Console.Write(integer + " ");
            }
        }
    }
}
