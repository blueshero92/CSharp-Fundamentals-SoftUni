using System;

namespace _11._Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int orders = int.Parse(Console.ReadLine());

            double totalPrice = 0;

            for (int order = 1; order <= orders; order++)
            {
                double pricePerCapsule = double.Parse(Console.ReadLine());
                int days = int.Parse(Console.ReadLine());
                int capsules = int.Parse(Console.ReadLine());

                double orderPrice = days * capsules * pricePerCapsule;

                Console.WriteLine($"The price for the coffee is: ${orderPrice:f2}");

                totalPrice += orderPrice;
            }
            Console.WriteLine($"Total: ${totalPrice:f2}");

            
        }
    }
}
