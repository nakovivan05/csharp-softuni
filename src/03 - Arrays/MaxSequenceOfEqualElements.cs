using System;
using System.Linq;


namespace SoftUniCSharpArrays
{
    class MaxSequenceOfEqualElements
    {
        static void Main()
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int num = 0;
            int maxStreak = 0;
            int currentStreak = 1;
            for (int i = 1; i < arr.Length; i++)
            {
                
                if (arr[i] == arr[i - 1])
                {
                    currentStreak++;
                }
                else
                {
                    currentStreak = 1;
                }
                if (currentStreak > maxStreak)
                {
                    maxStreak = currentStreak;
                    num = arr[i];
                }
            }
            for (int i = 0; i < maxStreak; i++)
            {
                Console.Write(num + " ");
            }
        }
    }
}
