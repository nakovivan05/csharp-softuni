using System;
using System.Linq;


namespace SoftUniCSharpArrays
{
    class TopIntegers
    {
        static void Main()
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            for (int i = 0; i < arr.Length; i++)
            {
                bool isGreater = true;
                if (i != arr.Length - 1)
                {
                    for (int j = i + 1; j < arr.Length; j++)
                    {
                        if (arr[j] >= arr[i])
                        {
                            isGreater = false;
                            break;
                        }
                    }
                    if (isGreater)
                    {
                        Console.Write(arr[i] + " ");
                    }
                }
                else
                {
                    Console.Write(arr[i] + " ");
                }
            }
        }
        
    }
}