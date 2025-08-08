using System;
using System.Text.RegularExpressions;


namespace SoftUniCSharpRegularExpressions
{
    class Race
    {
        static void Main()
        {
            string pattern = @"%(?<name>[A-Z][a-z]+)%[^|$%.]*<(?<product>\w+)>[^|$%.]*\|(?<count>\d+)\|[^|$%.]*?(?<price>\d+(\.\d+)?)\$";
            string input;
            double totalIncome = 0;
            while ((input = Console.ReadLine()) != "end of shift")
            {
                Match match = Regex.Match(input, pattern);
                if (match.Success)
                {
                    string customerName = match.Groups["name"].Value;
                    string product = match.Groups["product"].Value;
                    int count = int.Parse(match.Groups["count"].Value);
                    double price = double.Parse(match.Groups["price"].Value);
                    Console.WriteLine($"{customerName}: {product} - {count*price:F2}");
                    totalIncome += price * count;
                }
            }
            Console.WriteLine($"Total income: {totalIncome:F2}");
        }
    }
}
