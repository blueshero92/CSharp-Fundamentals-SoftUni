using System;

namespace _06._Middle_Characters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
           
            char midChar = text[text.Length / 2];

            PrintMidChar(text, midChar);

        }

        private static void PrintMidChar(string text, char midChar)
        {
            if (text.Length % 2 == 0)
            {
                Console.WriteLine($"{text[text.Length / 2 - 1]}{midChar}");
                Environment.Exit(0);
            }

            Console.WriteLine(midChar);
        }
    }
}
