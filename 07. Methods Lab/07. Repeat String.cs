using System;

namespace _07._Repeat_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int repetitions = int.Parse(Console.ReadLine());
            PrintTextNTimes(text, repetitions);
        }

        private static void PrintTextNTimes(string text, int repetitions)
        {
            for (int i = 1; i <= repetitions; i++)
            {
                Console.Write(text);
            }
        }
    }
}
