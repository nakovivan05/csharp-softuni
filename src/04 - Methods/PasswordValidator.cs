using System;


namespace SoftUniCSharpMethods
{
    class PasswordValidator
    {
        static void Main()
        {
            string password = Console.ReadLine();
            if (isPasswordLengthValid(password) && isPasswordCharactersValid(password) && isPasswordDigitsValid(password))
            {
                Console.WriteLine("Password is valid");
            }
            else
            {
                if (!isPasswordLengthValid(password))
                {
                    Console.WriteLine("Password must be between 6 and 10 characters");
                }
                if (!isPasswordCharactersValid(password))
                {
                    Console.WriteLine("Password must consist only of letters and digits");
                }
                if(!isPasswordDigitsValid(password))
                {
                    Console.WriteLine("Password must have at least 2 digits");
                }
            }
        }
        static bool isPasswordLengthValid(string password)
        {
            return password.Length >= 6 && password.Length <= 10;
        }
        static bool isPasswordCharactersValid(string password)
        {
            foreach (char letter in password)
            {
                if (!char.IsLetterOrDigit(letter))
                {
                    return false;
                    
                }
                
            }
            return true;
        }
        static bool isPasswordDigitsValid(string password)
        {
            int countOfDigits = 0;
            foreach (char letter in password)
            {
                if(char.IsDigit(letter))
                {
                    countOfDigits++;
                }
            }
            return countOfDigits >= 2;
        }

    }
}