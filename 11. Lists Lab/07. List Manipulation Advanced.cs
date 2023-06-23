using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._List_Manipulation_Advanced
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

            bool isChanged = false;

            while(command != "end")
            {
                string[] tokens = command.Split();

                switch (tokens[0])
                {
                    case "Add":
                        int numberToAdd = int.Parse(tokens[1]);
                        isChanged = true;
                        list.Add(numberToAdd);
                        break;
                    case "Remove":
                        int numberToRemove = int.Parse(tokens[1]);
                        isChanged = true;
                        list.Remove(numberToRemove);
                        break;
                    case "RemoveAt":
                        int indexToRemove = int.Parse(tokens[1]);
                        isChanged = true;
                        list.RemoveAt(indexToRemove);
                        break;
                    case "Insert":
                        int numberToInsert = int.Parse(tokens[1]);
                        int indexToInsert = int.Parse(tokens[2]);
                        isChanged = true;
                        list.Insert(indexToInsert, numberToInsert);
                        break;
                    case "Contains": int containsNumber = int.Parse(tokens[1]);
                        
                        if (list.Contains(containsNumber))
                        {
                            Console.WriteLine("Yes");
                        }
                        else
                        {
                            Console.WriteLine("No such number");
                        }
                        break;
                    case "PrintEven":                       
                        List <int> numbersEven = list.Where (x => x % 2 == 0).ToList();
                        Console.WriteLine(string.Join(" ", numbersEven));  
                        break;
                    case "PrintOdd":
                        List<int> numbersOdd = list.Where(x => x % 2 != 0).ToList();
                        Console.WriteLine(string.Join(" ", numbersOdd));
                        break;
                    case "GetSum":
                        Console.WriteLine(list.Sum());
                        break;
                    case "Filter": string condition = (tokens[1]);
                                   int number = int.Parse(tokens[2]);
                        if(condition == "<")
                        {
                            List<int> smallerNumbers = list.Where(x => x < number).ToList();
                            Console.WriteLine(string.Join (" ", smallerNumbers));
                        }
                        else if (condition == "<=")
                        {
                            List<int> smallerOrEqualNumbers = list.Where(x => x <= number).ToList();
                            Console.WriteLine(string.Join(" ", smallerOrEqualNumbers));
                        }
                        else if (condition == ">")
                        {
                            List<int> biggerNumbers = list.Where(x => x > number).ToList();
                            Console.WriteLine(string.Join(" ", biggerNumbers));
                        }
                        else if (condition == ">=")
                        {
                            List<int> biggerOrEqualNumbers = list.Where(x => x >= number).ToList();
                            Console.WriteLine(string.Join(" ", biggerOrEqualNumbers));
                        }
                        break;
                }

                command = Console.ReadLine();
            }

            if (isChanged)
            {
                Console.WriteLine(string.Join(" ", list));
            }
            
        }
    }
}
