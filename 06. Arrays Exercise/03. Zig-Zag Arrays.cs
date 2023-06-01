using System;
using System.Linq;

namespace _03._Zig_Zag_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string [] array1 = new string[n];
            string [] array2 = new string[n];

            bool isFirst = true;

            for (int i = 0; i < n; i++)
            {
                string integers = Console.ReadLine();
                string[] splitted = integers.Split();

                if (isFirst == true)
                {
                    array1[i] = splitted[0];
                    array2[i] = splitted[1];
                }
                else
                {
                    array1[i] = splitted[1];
                    array2[i] = splitted[0];
                }

                isFirst = !isFirst;
            }

            Console.WriteLine(string.Join(" ", array1));
            Console.WriteLine(string.Join(" ", array2));
                                                 
        }
    }
}
