using System;

namespace _03._Calculations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string calculation = Console.ReadLine();
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            if (calculation == "add")
            {
                Add(a, b);
            }
            else if (calculation == "subtract")
            {
                Subtract(a, b);
            }
            else if (calculation == "multiply")
            {
                Multiply(a, b);
            }
            else
            {
                Divide(a, b);
            }
        }

        static void Add(int a, int b)
        {
            int result = a + b;
            Console.WriteLine(result);
        }
        static void Subtract (int a, int b)
        {
            int result = a - b;
            Console.WriteLine(result);
        }
        static void Multiply (int a, int b)
        {
            int result = a * b;
            Console.WriteLine(result);
        }
        static void Divide (int a, int b)
        {
            int result =  a / b;
            Console.WriteLine(result);
        }


    }
}
