using System;
using System.Linq;


namespace SoftUniCSharpArrays
{
    class CommonElements
    {
        static void Main()
        {
            string[] firstArray = Console.ReadLine().Split(' ');
            string[] secondArray = Console.ReadLine().Split(' ');
            foreach (string item in firstArray)
            {
                foreach (string item2 in secondArray)
                {
                    if(item == item2)
                    {
                        Console.Write(item + " ");
                        break;
                    }
                }
            }
        }
    }
}
