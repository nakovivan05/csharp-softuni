﻿using System;
using System.Linq;


namespace SoftUniCSharpArrays
{
    class EqualSums
    {
        static void Main()
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int index = 0;
            bool isEqual = false;
            for (int i = 0; i < arr.Length; i++)
            {
                int leftSum = 0;
                int rightSum = 0;
                if (i != 0)
                {
                    for (int j = i - 1; j >= 0; j--)
                    {
                        leftSum += arr[j];
                    }
                    
                }
                if(i!=arr.Length-1)
                {
                    for(int j = i+1; j < arr.Length; j++)
                    {
                        rightSum += arr[j];
                    }
                }
                if (leftSum == rightSum)
                {
                    isEqual = true;
                    index = i;
                    break;
                }
                
            }
            if (isEqual)
            {
                Console.WriteLine(index);
            }
            else
            {
                Console.WriteLine("no");
            }

        }
    }
}