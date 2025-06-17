using System;

namespace SoftuniCSharpDataTypesAndVariables
{
    class BeerKegs
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            double maxVolume = 0;
            string biggestKeg = "";
            for (int i = 0; i < n; i++)
            {
                string model = Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());
                double volume = Math.PI * radius*radius*height;
                if(volume > maxVolume)
                {
                    maxVolume = volume;
                    biggestKeg = model;
                }
            }
            Console.WriteLine(biggestKeg);
        }
    }
}
