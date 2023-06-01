using System;

namespace _02._Pounds_To_Dollars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal pounds = decimal.Parse(Console.ReadLine());
            decimal dollars = pounds * 1.31m;

            Console.WriteLine($"{dollars:f3}");
        }
    }
}
