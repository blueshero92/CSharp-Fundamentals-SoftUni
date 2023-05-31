using System;

namespace _06._Strong_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int nCopy = n;
            int sum = 0;

            while (n > 0)
            {
                int factorial = 1;
                int number = n % 10;
                n = n / 10;

                for (int i = 1; i <= number; i++)
                {
                    factorial = factorial * i;
                }

                sum += factorial;
            }

            if (sum == nCopy)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
