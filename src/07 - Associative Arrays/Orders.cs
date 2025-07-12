using System;
using System.Collections.Generic;


namespace SoftUniCSharpAssociativeArrays
{
    public class Orders
    {
        static void Main()
        {
            var prices = new Dictionary<string, double>();
            var quantities = new Dictionary<string,int>();
            string input;
            while ((input = Console.ReadLine()) != "buy")
            {
                string[] productInfo = input.Split(' ').ToArray();
                string productName = productInfo[0];
                double productPrice = double.Parse(productInfo[1]);
                int productQuantity = int.Parse(productInfo[2]);
                if (!prices.ContainsKey(productName))
                {
                    prices[productName] = productPrice;
                    quantities[productName] = productQuantity;
                }
                else
                {
                    prices[productName] = productPrice;
                    quantities[productName] += productQuantity;
                }
                

            }
            foreach(var product in prices)
            {
                string name = product.Key;
                double totalPrice = prices[name] * quantities[name];
                Console.WriteLine($"{name} -> {totalPrice:F2}");
            }
        }
        }
}
