using System;
using System.Linq;


namespace SoftUniCSharpStringsAndTextProcessing
{
    public class ValidUsernames
    {
        static void Main()
        {
            string[]usernames = Console.ReadLine().Split(", ",StringSplitOptions.RemoveEmptyEntries).ToArray();
            foreach (string username in usernames)
            {
                if(isValidUsername(username))
                {
                    Console.WriteLine(username);
                }
            }
        }
        static bool isValidUsername(string username)
        {
            if (username.Length < 3 || username.Length > 16)
            {
                return false;
            }
            foreach (char c in username)
            {
                if (!(char.IsLetterOrDigit(c) || c == '-' || c == '_'))
                {
                    return false;
                }
            }
            return true;
        }
        }
}
