using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List <int> wagons = Console
                               .ReadLine ()
                               .Split()
                               .Select(int.Parse)
                               .ToList();

            int maxWagonCapacity = int.Parse(Console.ReadLine());

            string command;
            
            while ((command = Console.ReadLine()) != "end")
            {
                string[] splittedCommand = command.Split();

                if (splittedCommand[0] == "Add")
                {
                    AddWagons(wagons, splittedCommand);

                }
                else
                {
                    AddPassangersToWagon(wagons, maxWagonCapacity, splittedCommand);
                }

            }

            Console.WriteLine (string.Join (" ", wagons));
        }

        static void AddPassangersToWagon(List<int> wagons, int maxWagonCapacity, string[] splittedCommand)
        {
            int incomingPassangers = int.Parse(splittedCommand[0]);

            for (int i = 0; i < wagons.Count; i++)
            {
                if (maxWagonCapacity >= (wagons[i] + incomingPassangers))
                {
                    wagons[i] += incomingPassangers;
                    break;
                }

            }
        }

        static void AddWagons(List<int> wagons, string[] splittedCommand)
        {
            int addedWagon = int.Parse(splittedCommand[1]);
            wagons.Add(addedWagon);
        }
    }
}
