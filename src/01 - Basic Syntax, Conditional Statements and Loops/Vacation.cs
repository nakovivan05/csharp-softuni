using System;

namespace SoftUniCSharp.BasicSyntaxConditionalStatementsAndLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            string day = Console.ReadLine();
            double totalPrice = 0.0;
            double pricePerPerson;
            if(type == "Students")
            {
                if(day == "Friday")
                {
                    pricePerPerson = 8.45;
                    totalPrice = pricePerPerson * count;
                }
                else if(day == "Saturday")
                {
                    pricePerPerson = 9.80;
                    totalPrice = pricePerPerson * count;
                }
                else if(day == "Sunday")
                {
                    pricePerPerson = 10.46;
                    totalPrice = pricePerPerson * count;
                }
                if(count >= 30)
                {
                    totalPrice *=  0.85;
                }
            }
            if(type == "Business")
            {
                if (day == "Friday")
                {
                    pricePerPerson = 10.9;
                    if(count >= 100)
                    {
                        totalPrice = (count - 10) * pricePerPerson;
                    }
                    else
                    {
                        totalPrice = pricePerPerson * count;
                    }
                }
                else if (day == "Saturday")
                {
                    pricePerPerson = 15.6;
                    if (count >= 100)
                    {
                        totalPrice = (count - 10) * pricePerPerson;
                    }
                    else
                    {
                        totalPrice = pricePerPerson * count;
                    }
                }
                else if (day == "Sunday")
                {
                    pricePerPerson = 16.0;
                    if (count >= 100)
                    {
                        totalPrice = (count - 10) * pricePerPerson;
                    }
                    else
                    {
                        totalPrice = pricePerPerson * count;
                    }
                }
            }
            if(type == "Regular")
            {
                if (day == "Friday")
                {
                    pricePerPerson = 15.0;
                    totalPrice = pricePerPerson * count;
                }
                else if (day == "Saturday")
                {
                    pricePerPerson = 20.0;
                    totalPrice = pricePerPerson * count;
                }
                else if (day == "Sunday")
                {
                    pricePerPerson = 22.5;
                    totalPrice = pricePerPerson * count;
                }
                if (count >= 10 && count <= 20)
                {
                    totalPrice *= 0.95;
                }
            }
            Console.WriteLine($"Total price: {totalPrice:F2}");
        }
    }
}
