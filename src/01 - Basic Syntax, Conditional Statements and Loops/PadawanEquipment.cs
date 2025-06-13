using System;

namespace SoftUniCSharp.BasicSyntaxConditionalStatementsAndLoops
{
    class Program
    {
        static void Main()
        {
            double money = double.Parse(Console.ReadLine());
            int count = int.Parse(Console.ReadLine());
            double priceLightsaber = double.Parse(Console.ReadLine());
            double priceRobe = double.Parse(Console.ReadLine());
            double priceBelt = double.Parse(Console.ReadLine());
            double totalPriceLightsabers = Math.Ceiling(count + count * 0.1) * priceLightsaber;
            double totalPriceRobes = count * priceRobe;
            double totalPriceBelts = (count - count / 6) * priceBelt;
            double totalPrice = totalPriceLightsabers + totalPriceRobes + totalPriceBelts;
            if(totalPrice <= money)
            {
                Console.WriteLine($"The money is enough - it would cost {totalPrice:F2}lv.");
            }
            else
            {
                Console.WriteLine($"John will need {totalPrice - money:F2}lv more.");
            }
        }
    }
}
