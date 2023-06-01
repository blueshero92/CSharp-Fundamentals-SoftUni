using System;

namespace _04._Printing_Triangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            PrintingTriangle(n);
        }

        static void PrintingTriangle(int n)
        {
            PrintingTriangleTop(n);
            PrintingTriangleBottom(n - 1);
        }

        private static void PrintingTriangleTop(int n)
        {
            for (int row = 1; row <= n; row++)
            {
                for (int col = 1; col <= row; col++)
                {
                    Console.Write(col + " ");
                }

                Console.WriteLine();
            }
        }

        private static void PrintingTriangleBottom(int n)
        {
            for (int row = n; row >= 1; row--)
            {
                for (int col = 1; col <= row; col++)
                {
                    Console.Write(col + " ");
                }

                Console.WriteLine();
            }
        }
    }
}
