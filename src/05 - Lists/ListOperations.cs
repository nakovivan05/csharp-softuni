using System;
using System.Linq;
using System.Collections.Generic;

namespace SoftUniCSharpLists
{
    class ListOperations
    {
        static void Main()
        {
            string list = Console.ReadLine();
            List<int> numbers = list.Split(' ').Select(int.Parse).ToList();
            string command = "";
            while ((command = Console.ReadLine()) != "End")
            {
                string[] action = command.Split();
                if (action[0] == "Add")
                {
                    numbers.Add(int.Parse(action[1]));

                }
                else if (action[0] == "Insert")
                {
                    if (int.Parse(action[2]) < 0 || int.Parse(action[2]) >= numbers.Count)
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                        numbers.Insert(int.Parse(action[2]), int.Parse(action[1]));
                    }
                }
                else if (action[0] == "Remove")
                {
                    if (int.Parse(action[1]) < 0 || int.Parse(action[1]) >= numbers.Count)
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                        numbers.RemoveAt(int.Parse(action[1]));
                    }

                }
                else if (action[0] == "Shift" && action[1]=="left")
                {
                    int count = int.Parse(action[2]);
                    for (int i = 0; i < count; i++)
                    {
                        int first = numbers[0];
                        for(int j = 0; j<numbers.Count()-1;j++)
                        {
                            numbers[j] = numbers[j+1];
                        }
                        numbers[numbers.Count()-1] = first;
                    }

                }
                else if (action[0] == "Shift" && action[1] == "right")
                {
                    int count = int.Parse(action[2]);
                    for (int i = 0; i < count; i++)
                    {
                        int last = numbers[numbers.Count()-1];
                        for (int j = numbers.Count() - 1; j > 0; j--)
                        {
                            numbers[j] = numbers[j - 1];
                        }
                        numbers[0] = last;
                    }

                }
            }
            Console.WriteLine(string.Join(' ',numbers));
        }
    }
}