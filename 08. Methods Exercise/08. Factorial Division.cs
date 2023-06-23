using System;

namespace _08._Factorial_Division
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double firsNum = long.Parse(Console.ReadLine());
            double secondNum = long.Parse(Console.ReadLine());
            Console.WriteLine($"{FindFactoral(firsNum) / FindFactoral(secondNum):f2}");
            
        }

        static double FindFactoral (double num)
        {
            double factorial = 1;

            for (double i = num; i > 1; i--)
            {
                factorial *= i;
            }

            return factorial;
            
        }
    }
}
