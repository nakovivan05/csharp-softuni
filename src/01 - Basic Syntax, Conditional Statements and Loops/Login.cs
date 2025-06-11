using System;

namespace SoftUniCSharp.BasicSyntaxConditionalStatementsAndLoops
{
    class Program
    {
        static void Main()
        {
            int count = 0;
            string username = Console.ReadLine();
            string reversed = "";
            
            for (int i = username.Length - 1; i >= 0; i--)
            {
                reversed += username[i];
            }
            while(true)
            {
                count++;
                string attempt = Console.ReadLine();
                if (attempt == reversed)
                {
                    Console.WriteLine($"User {username} logged in.");
                    break;
                }
                if (count == 4)
                {
                    Console.WriteLine($"User {username} blocked!");
                    break;
                }
                Console.WriteLine("Incorrect password. Try again.");
             
            }
        }
    }
}
