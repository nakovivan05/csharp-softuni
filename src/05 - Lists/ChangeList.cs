using System;
using System.Linq;
using System.Collections.Generic;

namespace SoftUniCSharpLists
{
    class ChangeList
    {
        static void Main()
        {
            List<int> list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            string command = "";
            while ((command = Console.ReadLine()) != "end")
            {
                string[] words = command.Split();
                if (words[0]=="Delete")
                {
                    int element = int.Parse(words[1]);
                    list.RemoveAll(n => n == element);
                }
                else if(words[0]=="Insert")
                {
                    int element = int.Parse(words[1]);
                    int position = int.Parse(words[2]);
                    list.Insert(position,element);
                }
            }
            Console.WriteLine(string.Join(" ", list));

        }
    }
}
