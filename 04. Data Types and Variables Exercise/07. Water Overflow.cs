using System;

namespace _7._Water_Overflow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());           
            int totalQty = 0;

            for (int i = 1; i <= lines; i++)
            {
                int waterQuantity = int.Parse(Console.ReadLine());

                totalQty += waterQuantity;

                if(totalQty > 255)
                {
                    totalQty -= waterQuantity;
                    Console.WriteLine("Insufficient capacity!");
                }
            }
            Console.WriteLine(totalQty);
        }
    }
}
