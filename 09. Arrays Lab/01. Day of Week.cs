﻿using System;

namespace _1._Day_of_Week
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int day = int.Parse(Console.ReadLine());

            string[] days = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

            
                if (day < 1 || day > 7)
                {
                    Console.WriteLine("Invalid day!");
                }
                else
                {
                    Console.WriteLine(days[day - 1]);
                }
                                                  
        }
    }
}
