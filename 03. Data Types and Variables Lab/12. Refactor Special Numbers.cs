using System;

namespace _12._Refactor_Special_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());          
            bool isSpecial = false;

            for (int num = 1; num <= n; num++)
            {
                int digits = num;
                int sumOfDigits = 0;

                while (digits > 0)
                {
                    sumOfDigits += digits % 10;
                    digits = digits / 10;

                    if (sumOfDigits == 5 || sumOfDigits == 7 || sumOfDigits == 11)
                    {
                        isSpecial = true;
                    }
                    else
                    {
                        isSpecial = false;
                    }
                }

                Console.WriteLine("{0} -> {1}", num, isSpecial);
            }
        }
    }
}
