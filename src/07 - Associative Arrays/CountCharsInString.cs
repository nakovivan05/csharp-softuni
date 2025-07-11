using System;
using System.Collections.Generic;


namespace SoftUniCSharpAssociativeArrays
{
    class CountCharsInString
    {
        static void Main()
        {
            string input = Console.ReadLine();
            var counts = new Dictionary<char, int>();
            var order = new List<char>();
            foreach (char c in input)
            {
                if (c == ' ')
                {
                    continue;
                }
                if (!counts.ContainsKey(c))
                {
                    counts[c] = 0;
                    order.Add(c);
                }
                counts[c]++;
            }
            foreach (char c in order)
            {
                Console.WriteLine($"{c} -> {counts[c]}");
            }
        }
    }
}
