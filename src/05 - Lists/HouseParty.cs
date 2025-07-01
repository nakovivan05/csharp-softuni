using System;
using System.Linq;
using System.Collections.Generic;

namespace SoftUniCSharpLists
{
    class HouseParty
    {
        static void Main()
        {
            int numberOfCommands = int.Parse(Console.ReadLine());
            List<string> names = new List<string>();
            for (int i = 0; i < numberOfCommands; i++)
            {
                string input = Console.ReadLine();
                string[] command = input.Split();
                if (command[2] == "not")
                {
                    if (names.Contains(command[0]))
                    {
                        names.Remove(command[0]);
                    }
                    else
                    {
                        Console.WriteLine($"{command[0]} is not in the list!");
                    }
                }
                else
                {
                    if (!names.Contains(command[0]))
                    {
                        names.Add(command[0]);

                    }
                    else
                    {
                        Console.WriteLine($"{command[0]} is already in the list!");
                    }

                }
            }
            for (int i = 0; i < names.Count; i++)
            {
                Console.WriteLine(names[i]);
            }
        }

    }

}