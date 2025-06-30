using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftUniCSharpLists
{
    class Train
    {
        static void Main()
        {
            List<int> wagons = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int maxCapacityOfWagon = int.Parse(Console.ReadLine());
            string command = "";
            while ((command = Console.ReadLine()) != "end")
            {
                string [] words = command.Split();
                if (words[0] == "Add")
                {
                    wagons.Add(int.Parse(words[1]));
                }
                else
                {
                    int passengers = int.Parse(words[0]);
                    for (int i = 0; i < wagons.Count; i++)
                    {
                        if (wagons[i] + passengers <= maxCapacityOfWagon)
                        {
                            wagons[i] += passengers;
                            break;
                        }
                    }
                }
            }
            Console.WriteLine(string.Join(" ", wagons));

        }
    }
}
