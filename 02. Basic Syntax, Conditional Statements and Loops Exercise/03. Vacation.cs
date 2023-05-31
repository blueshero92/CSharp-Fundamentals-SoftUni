using System;

namespace _03._Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int peopleCount = int.Parse(Console.ReadLine());
            string groupType = Console.ReadLine();
            string day = Console.ReadLine();

            double pricePerperson = 0;

            if (day == "Friday")
            {
                if (groupType == "Students")
                {
                    pricePerperson = 8.45;
                }
                else if (groupType == "Business")
                {
                    pricePerperson = 10.90;
                }
                else
                {
                    pricePerperson = 15;
                }
            }
            if (day == "Saturday")
            {
                if (groupType == "Students")
                {
                    pricePerperson = 9.80;
                }
                else if (groupType == "Business")
                {
                    pricePerperson = 15.60;
                }
                else
                {
                    pricePerperson = 20;
                }
            }
            if (day == "Sunday")
            {
                if (groupType == "Students")
                {
                    pricePerperson = 10.46;
                }
                else if (groupType == "Business")
                {
                    pricePerperson = 16;
                }
                else
                {
                    pricePerperson = 22.50;
                }
            }

            if (peopleCount >= 100 && groupType == "Business")
            {
                peopleCount -= 10;
            }

            double totalPrice = peopleCount * pricePerperson;

            if (peopleCount >= 30 && groupType == "Students")
            {
                totalPrice -= totalPrice * 0.15;
            }
            
            if (peopleCount >= 10 && peopleCount <= 20 && groupType == "Regular")
            {
                totalPrice -= totalPrice * 0.05;
            }

            Console.WriteLine($"Total price: {totalPrice:f2}");
        }
    }
}
