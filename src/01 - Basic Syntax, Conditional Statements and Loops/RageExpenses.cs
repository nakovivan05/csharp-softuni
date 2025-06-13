using System;

namespace SoftUniCSharp.BasicSyntaxConditionalStatementsAndLoops
{
    class Program
    {
        static void Main()
        {
            int lostGames = int.Parse(Console.ReadLine());
            double priceHeadset = double.Parse(Console.ReadLine());
            double priceMouse = double.Parse(Console.ReadLine());
            double priceKeyboard = double.Parse(Console.ReadLine());
            double priceDisplay = double.Parse(Console.ReadLine());
            double expenses = (lostGames / 2) * priceHeadset + (lostGames/3)*priceMouse + (lostGames/6)*priceKeyboard + (lostGames/12)*priceDisplay;
            Console.WriteLine($"Rage expenses: {expenses:F2} lv.");
        }
    }
}
