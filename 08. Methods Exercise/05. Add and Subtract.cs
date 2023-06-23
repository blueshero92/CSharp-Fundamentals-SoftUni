using System;

namespace _05._Add_and_Subtract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
                     
            Console.WriteLine(SubtractNumbers(a, b, c));
        }

        static int SumNumbers (int a, int b)
        {
            return a + b;
        }

        static int SubtractNumbers (int a,int b, int c)
        {
           
            return SumNumbers(a, b) - c;
        }
    }
}
