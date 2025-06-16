using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            int capacity = 255;
            int n = int.Parse(Console.ReadLine());
            int poured = 0;
            for (int i = 0; i < n; i++)
            {
                int quantity = int.Parse(Console.ReadLine());
                if(poured + quantity > capacity)
                {
                    Console.WriteLine("Insufficient capacity!");
                    continue;
                }
                poured += quantity;
            }
            Console.WriteLine(poured);
        }
    }
}