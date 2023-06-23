﻿using System;
using System.Collections.Generic;

namespace _03._House_Party
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int commands = int.Parse(Console.ReadLine());

            List<string> guests = new List<string>();

            for (int i = 0; i < commands; i++)
            {
                string[] arguments = Console.ReadLine().Split(' ');

                string name = arguments[0];

                if (arguments[2] == "going!")
                {

                    if (guests.Contains(name))
                    {
                        Console.WriteLine($"{name} is already in the list!");
                    }

                    else
                    {
                        guests.Add(name);
                    }                  
                   
                }

                else if (arguments[2] == "not")
                {
                    if (guests.Contains(name))
                    {
                        guests.Remove(name);
                    }
                    else
                    {
                        Console.WriteLine($"{name} is not in the list!");
                    }
                }
            }

            for (int i = 0; i < guests.Count; i++)
            {
                Console.WriteLine(guests[i]);
            }
        }
    }
}
