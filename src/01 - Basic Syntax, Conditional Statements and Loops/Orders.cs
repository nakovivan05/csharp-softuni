using System;

namespace SoftUniCSharp.BasicSyntaxConditionalStatementsAndLoops
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            double totalPrice = 0;
            for(int i = 0; i < n; i++)
            {
                double priceCapsule = double.Parse(Console.ReadLine());
                int days = int.Parse(Console.ReadLine());
                int countCapsules = int.Parse(Console.ReadLine());
                double price = (days * countCapsules) * priceCapsule;
                totalPrice += price;
                Console.WriteLine($"The price for the coffee is: ${price:F2}");
            }
            Console.WriteLine($"Total: ${totalPrice:F2}");
        }
    }
}
