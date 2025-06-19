using System;
using System.Linq;


namespace SoftUniCSharpArrays
{
    class Train
    {
        static void Main()
        {
            int countOfWagons = int.Parse(Console.ReadLine());
            int countOfPassengers = 0;
            int[]passengers = new int[countOfWagons];
            for(int i = 0; i < countOfWagons; i++)
            {
                int passengersCurrentWagon = int.Parse(Console.ReadLine());
                passengers[i] = passengersCurrentWagon;
            }
            for(int i = 0;i < countOfWagons; i++)
            {
                Console.Write(passengers[i] + " ");
                countOfPassengers += passengers[i];
            }
            Console.WriteLine();
            Console.WriteLine(countOfPassengers);
        }
    }
}
