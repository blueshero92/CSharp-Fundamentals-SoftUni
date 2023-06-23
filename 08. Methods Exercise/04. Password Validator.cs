using System;

namespace _04._Password_Validator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();

            bool checkLenght = CheckLength(password);
            bool checkSpecialSymbols = CheckSpecialSymbols(password);
            bool checkDigitsCount = CheckDigitsCount(password);

            if(checkLenght == false)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }
            if(checkSpecialSymbols == false)
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }
            if(checkDigitsCount == false)
            {
                Console.WriteLine("Password must have at least 2 digits");
            }
            if(checkLenght == true && checkSpecialSymbols == true && checkDigitsCount == true)
            {
                Console.WriteLine("Password is valid");
            }
        }

        static bool CheckLength (string password)
        {
            if (password.Length < 6 || password.Length > 10)
            {
                return false;
            }

            return true;
        }

        static bool CheckSpecialSymbols(string password)
        {
            foreach (char symbol in password)
            {
                if (symbol >= 65 && symbol <= 90
                    || symbol >= 97 && symbol <= 122 ||
                    symbol >= 48 && symbol <= 57)
                {
                    continue;
                }
                else
                {
                    return false;
                }
            }
            return true;           
        }

        static bool CheckDigitsCount(string password)
        {
            int count = 0;

            foreach (char digit in password)
            {

                if(digit >= 48 && digit <= 57)
                {
                    count++;
                }
                
            }

            if (count < 2)
            {
                return false;
            }

            return true;
        }
    }
}
