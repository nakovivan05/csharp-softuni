using System;


namespace SoftUniCSharpMethods
{
    class MiddleCharacters
    {
        static void Main()
        {
            string word = Console.ReadLine();
            findMiddleCharacter(word);
        }
        static void findMiddleCharacter(string word)
        {
            if(word.Length % 2 == 0)
            {
                Console.Write($"{word[word.Length / 2 - 1]}{word[word.Length / 2]}");
            }
            else
            {
                Console.Write(word[word.Length / 2]);
            }
        }
    }
}
