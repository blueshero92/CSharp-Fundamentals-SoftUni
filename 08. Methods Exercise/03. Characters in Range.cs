using System;

namespace _03._Characters_in_Range
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char char1 = char.Parse(Console.ReadLine());
            char char2 = char.Parse(Console.ReadLine());
            GetChars(char1, char2);
            GetCharsSwappedInitials (char1, char2);
        }

        private static void GetCharsSwappedInitials(char char1, char char2)
        {
            if (char1 > char2)
            {
                for (int j = char2 + 1; j < char1; j++)
                {
                    Console.Write($"{(char)j} ");
                }
            }
        }

        private static void GetChars(char char1, char char2)
        {
            for (int i = char1 + 1; i < char2; i++)
            {
                Console.Write($"{(char)i} ");
            }
        }
    }
}
