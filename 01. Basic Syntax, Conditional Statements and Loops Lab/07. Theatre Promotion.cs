using System;

namespace _07._Theatre_Promotion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string day = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());

            int ticketPrice = 0;

            if(day == "Weekday")
            {
                if (age <= 18)
                {
                    ticketPrice = 12;
                }
                else if (age <= 64)
                {
                    ticketPrice = 18;
                }
                else
                {
                    ticketPrice = 12;
                }
            }
            else if (day == "Weekend")
            {
                if (age <= 18)
                {
                    ticketPrice = 15;
                }
                else if (age <= 64)
                {
                    ticketPrice = 20;
                }
                else
                {
                    ticketPrice = 15;
                }
            }
            else
            {
                if (age <= 18)
                {
                    ticketPrice = 5;
                }
                else if (age <= 64)
                {
                    ticketPrice = 12;
                }
                else
                {
                    ticketPrice = 10;
                }
            }
            if (age < 0 || age > 122)
            {
                Console.WriteLine("Error!");
            }
            else
            {
                Console.WriteLine($"{ticketPrice}$");
            }
        }
    }
}
