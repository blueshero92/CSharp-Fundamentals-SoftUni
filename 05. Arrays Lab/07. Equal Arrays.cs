using System;
using System.Linq;
using System.Reflection;

namespace _07._Equal_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = Console
                           .ReadLine()
                           .Split(" ")
                           .Select(int.Parse)
                           .ToArray();

            int[] array2 = Console
                           .ReadLine()
                           .Split(" ")
                           .Select(int.Parse)
                           .ToArray();
           

           for (int i = 0; i < array1.Length; i++)
            {
                

                if (array1[i] != array2[i])
                {
                    Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
                    Environment.Exit(0);
                }                             
                
            }

            Console.WriteLine($"Arrays are identical. Sum: {array1.Sum()}");

        }
    }
}
