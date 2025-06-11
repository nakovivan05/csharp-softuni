using System;

namespace SoftUniCSharp.BasicSyntaxConditionalStatementsAndLoops
{
    class Program
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());
            int sum = 0;
            int save = num;
            while (num != 0)
            {
                int digit = num % 10;
                int factoriel = 1;
                for(int i = 1; i <= digit; i++)
                {
                    factoriel *= i;
                }
                sum += factoriel;
                num /= 10;
            }
            if(save == sum)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
