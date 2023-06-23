using System;
using System.Diagnostics.Tracing;

namespace _02._Vowels_Count
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string phrase = Console.ReadLine();
            int vowelsCount = 0;
            PrintVowelsCount(vowelsCount, phrase);
            
        }

        static void PrintVowelsCount(int vowelsCount, string phrase)
        {            

            for (int i = 0; i < phrase.Length; i++)
            {
                if (phrase[i] == 'a' || phrase[i] == 'e' || phrase[i] == 'i' || phrase[i] == 'o' || phrase[i] == 'u' ||
                    phrase[i] == 'A' || phrase[i] == 'E' || phrase[i] == 'I' || phrase[i] == 'O' || phrase[i] == 'U')
                {
                    vowelsCount++;
                }
            }

            Console.WriteLine(vowelsCount);
        }
    }
}
