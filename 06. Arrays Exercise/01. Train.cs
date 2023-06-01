using System;

namespace _01._Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int wagons = int.Parse(Console.ReadLine());

            int[] passangers = new int[wagons];

            int totalPeople = 0;

            for (int i = 0; i < wagons; i++)
            {
                passangers[i] = int.Parse(Console.ReadLine());

                totalPeople += passangers[i];
            }

            for (int j = 0; j < wagons; j++)
            {
                Console.Write(passangers[j] + " ");
                
            }

            Console.WriteLine();
            Console.WriteLine(totalPeople);

            
        }
    }
}
