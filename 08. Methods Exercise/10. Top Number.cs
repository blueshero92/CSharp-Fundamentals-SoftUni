using System;

namespace _10._Top_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());            

            for(int i = 1; i <= n; i++)
            {                
                if (IsTopNumber(i))
                {
                    Console.WriteLine(i);
                }
                
            }
         
        }

        static bool IsTopNumber(int num)
        {
            if (CheckSumOfDigits(num) && CheckForOddDigit(num))
            {
                return true;
            }
            

            return false;
        }

        private static bool CheckForOddDigit(int num)
        {
            while (num > 0)
            {
                int digit = num % 10;
                num = num / 10;

                if (digit % 2 != 0)
                {
                    return true;
                }
            }
            return false;
        }

        static bool CheckSumOfDigits(int num)
        {
            int sumOfDigits = 0;

            while (num > 0)
            {
                
                int digit = num % 10;
                sumOfDigits += digit;
                num = num / 10;             
               
            }
            return sumOfDigits % 8 == 0;
        }
    }
}
