using System;

namespace _04._Centuries_to_Minutes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int centuries = int.Parse(Console.ReadLine());
            long years = centuries * 100;
            float days = years * 365.2422f;
            long hours = (long) days * 24L;
            long minutes = hours * 60;

            Console.WriteLine($"{centuries} centuries = {years} years = {Math.Floor(days)} days = {hours} hours = {minutes} minutes");


        }
    }
}
