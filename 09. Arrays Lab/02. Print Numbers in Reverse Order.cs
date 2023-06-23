using System;

namespace _02._Print_Numbers_in_Reverse_Order
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numbers = int.Parse(Console.ReadLine());

            int[] numbersArray = new int[numbers];

            for (int num = 0; num < numbersArray.Length; num++)
            {
                numbersArray[num] = int.Parse(Console.ReadLine());              
            }

            for (int i = numbersArray.Length - 1; i >= 0; i--)
            {
                Console.Write($"{numbersArray[i]} ");
            }
            
        }
    }
}
