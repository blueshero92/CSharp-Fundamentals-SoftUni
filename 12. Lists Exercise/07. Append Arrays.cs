using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Append_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] arrayOfStrings = Console.ReadLine().Split('|', StringSplitOptions.RemoveEmptyEntries);            

            List<string> list = new List<string>();

            for (int i = arrayOfStrings.Length - 1; i >= 0; i--)
            {
                string[] array = arrayOfStrings[i].Split(" ", StringSplitOptions.RemoveEmptyEntries);

                list.AddRange(array);
            }

            Console.WriteLine(string.Join(" ", list));
        }
    }
}
