﻿using System;

namespace SoftuniCSharpDataTypesAndVariables
{
    class IntegerOperations
    {
        static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());
            int result = ((a + b) / c) * d;
            Console.WriteLine($"{result}");
        }
    }
}
