using System;
using System.Linq;
using System.Reflection.Emit;

namespace _07._Max_Sequence_of_Equal_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] array = Console
                          .ReadLine()
                          .Split();                         ;

            int bestCount = 0;
            string bestSymbol = string.Empty;

            for(int i = 0; i < array.Length; i++)
            {
                int count = 0;

                for (int j = i; j < array.Length; j++)
                {
                    if (array[j] == array[i])
                    {
                        count++;
                        
                        if (bestCount < count)
                        {
                            bestCount = count;
                            bestSymbol = array[i];
                        }
                    }
                    else
                    {
                        break;
                    }
                }
                
            }

            for (int k = 0; k < bestCount; k++)
            {
                Console.Write($"{bestSymbol} ");
            }


        }
    }
}
