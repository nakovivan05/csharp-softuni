using System;


namespace SoftUniCSharpMethods
{
    class CharactersInRange
    {
        static void Main()
        {
            char start = char.Parse(Console.ReadLine());
            char end = char.Parse(Console.ReadLine());
            showCharactersInGivenRange(start, end);
        }
        static void showCharactersInGivenRange(char start, char end)
        {
            if (start < end)
            {
                for(int i = start + 1; i < end;i++)
                {
                    Console.Write((char)i + " ");
                }
            }
            else
            {
                char swap;
                swap = start;
                start = end;
                end = swap;
                for (int i = start + 1; i < end; i++)
                {
                    Console.Write((char)i + " ");
                }
            }
        }
    }
}
