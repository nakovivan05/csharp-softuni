using System;


namespace SoftUniCSharpMethods
{
    class CommonElements
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            createSquareMatrix(n);
        }
        static void createSquareMatrix(int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(n + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
