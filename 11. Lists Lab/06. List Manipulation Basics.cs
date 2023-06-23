using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace _06._List_Manipulation_Basics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List <int> list = Console
                              .ReadLine()
                              .Split()
                              .Select(int.Parse)
                              .ToList(); 
            
            string command = Console.ReadLine();

            while(command != "end")
            {                
                
                string[] tokens = command.Split();

                switch (tokens[0])
                {
                    case "Add":int numberToAdd = int.Parse(tokens[1]);
                        list.Add(numberToAdd);
                        break;
                    case "Remove":int numberToRemove = int.Parse(tokens[1]);
                        list.Remove(numberToRemove);
                        break;
                    case "RemoveAt": int indexToRemove = int.Parse(tokens[1]);
                        list.RemoveAt(indexToRemove);
                        break;
                    case "Insert": int numberToInsert = int.Parse(tokens[1]);
                                   int indexToInsert = int.Parse(tokens[2]);
                        list.Insert(indexToInsert, numberToInsert);
                        break;
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", list));
        }
    }
}
