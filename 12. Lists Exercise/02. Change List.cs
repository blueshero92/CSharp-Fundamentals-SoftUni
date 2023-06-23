using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Change_List
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

            while((command = Console.ReadLine()) != "end")
            {
                string[] arguments = command.Split();

                switch(arguments[0])
                {
                    case "Delete": int deleted = int.Parse(arguments[1]);
                        for (int i = 0; i < list.Count; i++)
                        {
                            if (list[i] == deleted)
                            {
                                list.Remove(deleted);
                            }
                            
                        }                                                               
                        break;

                    case "Insert": int insertedNum = int.Parse(arguments[1]);
                                   int insertIndex = int.Parse(arguments[2]);
                                   list.Insert (insertIndex, insertedNum);
                        break;
                }
            }

            Console.WriteLine (string.Join (" ", list));
        }
    }
}
