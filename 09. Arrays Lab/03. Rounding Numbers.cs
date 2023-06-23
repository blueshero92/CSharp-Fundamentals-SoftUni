using System;
using System.Linq;

namespace _03._Rounding_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] array = Console.ReadLine()
                            .Split()
                            .Select(double.Parse)
                            .ToArray();

            double[] rounded = new double[array.Length];

            for(int i = 0; i < array.Length; i++)
            {
                rounded[i] = (int)Math.Round(array[i], MidpointRounding.AwayFromZero);
            }

            for (int j = 0; j < array.Length; j++)
            {
                Console.WriteLine($"{array[j]} => {rounded[j]}");
            }

        }
    }
}
