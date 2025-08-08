using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace SoftUniCSharpRegularExpressions
{
    class Furniture
    {
        static void Main()
        {
            string input;
            string pattern = @"[>]{2}(?<name>[A-Z][a-zA-z]+)[<]{2}(?<price>[0-9]+\.*[0-9]*)\!(?<quantity>[0-9]+)";
            List<string> furniture = new List<string>();
            double totalPrice = 0;
            while ((input = Console.ReadLine()) != "Purchase")
            {
                Match match = Regex.Match(input,pattern);
                if(match.Success)
                {
                    string name = match.Groups["name"].Value;
                    double price = double.Parse(match.Groups["price"].Value);
                    int quantity = int.Parse(match.Groups["quantity"].Value);
                    furniture.Add(name);
                    totalPrice += price * quantity;
                }
            }
            Console.WriteLine("Bought furniture:");
            foreach (string f in furniture)
            {
                Console.WriteLine(f);
            }
            Console.WriteLine($"Total money spend: {totalPrice:F2}");

        }
    }
}