using System;

namespace _09._Spice_Must_Flow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int yield = int.Parse(Console.ReadLine());

            int daysCount = 0;
            int spice = 0;

            while (yield >= 100)
            {
                daysCount++;
                spice += yield;
                yield -= 10;
                spice -= 26;
            }

            spice -= 26;

            if (spice < 0)
            {
                spice = 0;
            }

            Console.WriteLine(daysCount);
            Console.WriteLine(spice);
        }
    }
}
