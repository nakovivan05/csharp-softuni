using System;
using System.Linq;

namespace SoftUniCSharpStringsAndTextProcessing
{
    public class CharacterMultiplier
    {
        static void Main()
        {
            string[]twoNames = Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries).ToArray();
            string nameOne = twoNames[0];
            string nameTwo = twoNames[1];
            int sum = sumOfMultipliedCharacterCodes(nameOne, nameTwo);
            Console.WriteLine(sum);
        }
        static int sumOfMultipliedCharacterCodes(string nameOne, string nameTwo)
        {
            int difference;
            int sum = 0;
            if (nameOne.Length > nameTwo.Length)
            {
                difference = nameOne.Length - nameTwo.Length;
                for(int i = 0; i < nameTwo.Length;i++)
                {
                    sum += (int)nameOne[i] * (int)nameTwo[i];

                } 
                
                for(int i = nameOne.Length - 1; i > nameOne.Length - 1 - difference;i--)
                {
                    sum += (int)nameOne[i];
                }

            }
            else
            {
                difference = nameTwo.Length - nameOne.Length;
                for (int i = 0; i < nameOne.Length; i++)
                {
                    sum += (int)nameOne[i] * (int)nameTwo[i];

                }
                if (difference != 0)
                {
                    for (int i = nameTwo.Length - 1; i > nameTwo.Length - 1 - difference; i--)
                    {
                        sum += (int)nameTwo[i];
                    }
                }
            }
            return sum;

        }
    }
}
