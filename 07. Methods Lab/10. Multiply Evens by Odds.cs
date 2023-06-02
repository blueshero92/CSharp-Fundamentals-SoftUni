using System;

namespace _10._Multiply_Evens_by_Odds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = Math.Abs(int.Parse(Console.ReadLine()));

            int digit = 0;
            int evenSum = 0;
            int oddSum = 0;
            
            GetEvenAndOddSums(ref number, ref digit, ref evenSum, ref oddSum);
            GetMultiplySum(evenSum, oddSum);

            Console.WriteLine(GetMultiplySum(evenSum, oddSum));

        }

        static int GetMultiplySum(int evenSum, int oddSum)
        {
            return oddSum * evenSum;
        }

        static void GetEvenAndOddSums(ref int number, ref int digit, ref int evenSum, ref int oddSum)
        {
            while (number > 0)
            {
                digit = number % 10;
                number /= 10;

                if (digit % 2 == 0)
                {
                    evenSum = GetEvenSum(digit, evenSum);
                }
                else
                {
                    oddSum = GetOddSum(digit, oddSum);
                }

            }
            
        }
        static int GetOddSum(int digit, int oddSum)
        {
            oddSum += digit;
            return oddSum;
        }

        static int GetEvenSum(int digit, int evenSum)
        {
            evenSum += digit;
            return evenSum;
        }
    }
}
