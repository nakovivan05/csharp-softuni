using System;
using System.Linq;


namespace SoftUniCSharpMethods
{
    class VowelsCount
    {
        static void Main()
        {
            string word = Console.ReadLine();
            int foundVowels = findCountOfVowels(word);
            Console.WriteLine(foundVowels);
        }
        static int findCountOfVowels(string word)
        {
            char[] vowels = { 'a', 'e', 'o', 'u', 'i', 'A', 'E', 'O', 'U', 'I' };
            int foundVowels = 0;
            for(int i = 0; i < word.Length; i++)
            {
                for(int j = 0; j<vowels.Length;j++)
                {
                    if(word[i] == vowels[j])
                    {
                        foundVowels++;
                        break;
                    }
                }
            }
            return foundVowels;
        }
    }
}
