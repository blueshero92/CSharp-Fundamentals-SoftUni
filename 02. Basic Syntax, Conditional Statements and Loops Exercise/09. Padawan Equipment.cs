using System;

namespace _09._Padawan_Equipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int padawans = int.Parse(Console.ReadLine());
            double lightsaberPrice = double.Parse(Console.ReadLine());
            double robePrice = double.Parse(Console.ReadLine());
            double beltPrice = double.Parse(Console.ReadLine());

            double totalLightsaberPrice = lightsaberPrice * (Math.Ceiling(padawans + padawans * 0.10));
            double totalRobePrice = robePrice * padawans;
            double totalBeltPrice = 0;

            if(padawans >= 6)
            {
                int freeBelts = padawans / 6;
                totalBeltPrice = beltPrice * (padawans - freeBelts);
            }
            else
            {
                totalBeltPrice = beltPrice * padawans;
            }
            
            double totalPrice = totalBeltPrice + totalLightsaberPrice + totalRobePrice;

            if (budget >= totalPrice)
            {
                Console.WriteLine($"The money is enough - it would cost {totalPrice:f2}lv.");
            }
            else
            {
                Console.WriteLine($"John will need {totalPrice - budget:f2}lv more.");
            }
            
        }
    }
}
