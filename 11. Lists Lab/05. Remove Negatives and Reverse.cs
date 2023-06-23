using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Remove_Negatives_and_Reverse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List <int> integers = Console
                                  .ReadLine()
                                  .Split()
                                  .Select(int.Parse)
                                  .ToList();

            List <int> result = new List<int>();

            for (int i = 0; i < integers.Count; i++)
            {
                
                if (integers[i] > 0) 
                {
                    result.Add(integers[i]);               
                }                

            }

            if (result.Count == 0)
            {
                Console.WriteLine("empty");               
            }
            else
            {
                result.Reverse();

                Console.WriteLine(string.Join(" ", result));
            }
            
        }
    }
}
