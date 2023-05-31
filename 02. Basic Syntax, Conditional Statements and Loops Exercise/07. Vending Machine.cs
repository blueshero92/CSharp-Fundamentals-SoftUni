using System;

namespace _07._Vending_Machine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            string input = Console.ReadLine();
            double coin = 0;
            string product = string.Empty;

            double totalMoney = 0;
            double price = 0;

            while (input != "Start")
            {
                coin = double.Parse(input);

                if (coin != 0.1 && coin != 0.2 && coin != 0.5 && coin != 1 && coin != 2)
                {
                    Console.WriteLine($"Cannot accept {coin}");                  
                }
                else
                {
                    totalMoney += coin;
                }                

                input = Console.ReadLine();

            }

            input = Console.ReadLine();
            
            while (input != "End")
            {               

                if (input != "Nuts" && input != "Water" && input != "Coke" && input != "Crisps" && input != "Soda")
                {
                    Console.WriteLine("Invalid product");
                }

                switch (input)
                {
                    case "Nuts":
                        price = 2.0;
                        break;
                    case "Water":
                        price = 0.7;
                        break;
                    case "Crisps":
                        price = 1.5;
                        break;
                    case "Soda":
                        price = 0.8;
                        break;
                    case "Coke":
                        price = 1;
                        break;

                }

                if (input == "Nuts" || input == "Water" || input == "Coke" || input == "Crisps" || input == "Soda")
                {
                    if (totalMoney >= price)
                    {
                        Console.WriteLine($"Purchased {input.ToLower()}");
                        totalMoney -= price;
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                        
                    }
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"Change: {totalMoney:f2}");
        }
    }
}
