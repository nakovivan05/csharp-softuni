using System;

namespace SoftuniCSharpDataTypesAndVariables
{
    class PokeMon
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int countOfTargets = 0;
            int save = n;
            while (n >= m)
            {
                n -= m;
                if(n == save/2 && y!=0)
                {
                    n /= y;
                    
                }
                countOfTargets++;
            }
            Console.WriteLine(n);
            Console.WriteLine(countOfTargets);


        }
    }
}