using System;

namespace _02._Common_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] arrayOne = Console
                                .ReadLine()
                                .Split();

            string[] arrayTwo = Console
                               .ReadLine()
                               .Split();

            for (int i = 0; i < arrayTwo.Length; i++)
            {
                for (int j = 0; j < arrayOne.Length; j++)
                {
                    if (arrayOne[j] == arrayTwo[i])
                    {
                        Console.Write(arrayTwo[i] + " ");
                    }
                }
            }
        }
    }
}
