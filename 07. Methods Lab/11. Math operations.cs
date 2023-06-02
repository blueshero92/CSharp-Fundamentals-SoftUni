using System;

namespace _11._Math_operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            char operaton = char.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            GetResult(a, b, operaton);
        }

        static void GetResult (int a, int b, char operation)
        {
            if (operation == '+')
            {
                AddNumbers(a, b);
            }
            else if (operation == '-')
            {
                SubtractNumbers(a, b);
            }
            else if (operation == '*')
            {
                MultiplyNumbers(a, b);
            }
            else
            {
                DivideNumbers(a, b);
            }
        }

        private static void DivideNumbers(int a, int b)
        {
            Console.WriteLine(a / b);
        }

        private static void MultiplyNumbers(int a, int b)
        {
            Console.WriteLine(a * b);
        }

        private static void SubtractNumbers(int a, int b)
        {
            Console.WriteLine(a - b);
        }

        private static void AddNumbers(int a, int b)
        {
            Console.WriteLine(a + b);
        }
    }
}
