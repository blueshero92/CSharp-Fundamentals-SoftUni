using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._List_Operations
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

            string command;

            while ((command = Console.ReadLine()) != "End")
            {
                string[] splitted = command.Split();

                switch (splitted[0])
                {
                    case "Add": int numberToAdd = int.Parse(splitted[1]);
                                list.Add (numberToAdd);
                        break;
                    case "Insert": int numberToInsert = int.Parse(splitted[1]);
                                   int indexToInsert = int.Parse(splitted[2]);
                        if (indexToInsert < 0 || indexToInsert >= list.Count)
                        {
                            Console.WriteLine("Invalid index");
                            continue;
                        }
                                   list.Insert(indexToInsert, numberToInsert);
                        break;
                    case "Remove": int indexToRemove = int.Parse(splitted[1]);
                        if (indexToRemove < 0 || indexToRemove >= list.Count)
                        {
                            Console.WriteLine("Invalid index");
                            continue;
                        }
                        list.RemoveAt(indexToRemove);
                        break;
                    case "Shift":

                        int count = int.Parse(splitted[2]);

                        count %= list.Count;

                        if (splitted[1] == "left")
                        {
                            
                            List<int> shifted = list.GetRange(0, count);
                            list.RemoveRange(0, count);
                            list.InsertRange(list.Count, shifted);

                        }
                        else if (splitted[1] == "right")
                        {
                            
                            List<int> shifted = list.GetRange(list.Count - count, count);
                            list.RemoveRange(list.Count - count, count);
                            list.InsertRange(0, shifted);
                        }
                        break;
                }
            }

            Console.WriteLine(string.Join (" ", list));
        }
    }
}
