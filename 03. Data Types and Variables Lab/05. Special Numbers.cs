using System;
using System.Diagnostics.CodeAnalysis;

namespace _05._Special_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            bool isSpecial = false;
                

            for (int num = 1; num <= n; num++)
            {
                int sumOfDigits = 0;
                int digits = num;

                while(digits > 0)
                {
                    sumOfDigits += digits % 10;
                    digits /= 10;
                    
                    if (sumOfDigits == 5 || sumOfDigits == 7 || sumOfDigits == 11)
                    {
                        isSpecial = true;
                    }
                    else
                    {
                        isSpecial = false;
                    }
                    
                }

                Console.WriteLine($"{num} -> {isSpecial}");
            }
        }
    }
}
