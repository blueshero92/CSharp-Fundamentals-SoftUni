using System;
using System.Linq;

namespace _09._Palindrome_Integers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string numbers = Console.ReadLine();

            while(numbers != "END")
            {
                IsPalindrome(numbers);

                numbers = Console.ReadLine();
            }
        }

        private static void IsPalindrome(string numbers)
        {
            char[] numbersAsChar = numbers.ToCharArray();
            Array.Reverse(numbersAsChar);
            string reversedNums = new string(numbersAsChar);


            if (numbers == reversedNums)
            {
                Console.WriteLine(true);

            }
            else
            {
                Console.WriteLine(false);

            }
        }
    }
}
