﻿using System;
using System.Linq;


namespace SoftUniCSharpArrays
{
    class MagicSum
    {
        static void Main()
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int num = int.Parse(Console.ReadLine());
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] + arr[j] == num)
                    {
                        Console.WriteLine($"{arr[i]} {arr[j]}");
                        
                    }
                }
            }
        }
    }
}
