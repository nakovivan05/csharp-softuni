using System;
using System.Collections.Generic;

namespace SoftUniCSharpAssociativeArrays
{
    public class MinerTask
    {
        static void Main()
        {
            var quantities = new Dictionary<string, long>();
            var order = new List<string>();
            while (true)
            {
                string resource = Console.ReadLine();
                if(resource == "stop")
                {
                    break;
                }
                long quantity = long.Parse(Console.ReadLine());
                if (!quantities.ContainsKey(resource))
                {
                    quantities[resource] = 0;
                    order.Add(resource);
                }
                quantities[resource] += quantity;
            }
            foreach(var s in order)
            {
                Console.WriteLine($"{s} -> {quantities[s]}");
            }
            
        }
    }
}
