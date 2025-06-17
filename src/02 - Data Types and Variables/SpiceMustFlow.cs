using System;

namespace SoftuniCSharpDataTypesAndVariables
{
    class SpiceMustFlow
    {
        static void Main()
        {
            int startingYield = int.Parse(Console.ReadLine());
            int amountOfSpice = 0;
            int countOfDays = 0;
            while(startingYield >= 100)
            {
                countOfDays++;
                amountOfSpice += startingYield;
                amountOfSpice -= 26;
                startingYield -= 10;
            }
            if(amountOfSpice>=26)
            {
                amountOfSpice -= 26;
            }
            else
            {
                amountOfSpice = 0;
            }
            Console.WriteLine(countOfDays);
            Console.WriteLine(amountOfSpice);

        }
    }
}
