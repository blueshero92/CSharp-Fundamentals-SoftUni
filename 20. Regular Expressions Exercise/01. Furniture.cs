using System.Text.RegularExpressions;

namespace _01._Furniture
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;

            string pattern = @">>(?<name>[A-Za-z]+)<<(?<price>\d+|\d+\.\d+)!(?<quantity>\d+)";

            List<Furniture> furnitures = new List<Furniture>();

            double totalMoney = 0;

            while ((input = Console.ReadLine()) != "Purchase")
            {
                Regex regex = new Regex(pattern);
                MatchCollection matches = regex.Matches(input);

                foreach (Match match in matches)
                {
                    string name = match.Groups["name"].Value;
                    double price = double.Parse(match.Groups["price"].Value);
                    int quantity = int.Parse(match.Groups["quantity"].Value);

                    Furniture furniture = new Furniture(name, price, quantity);
                    furnitures.Add(furniture);

                    totalMoney += furniture.TotalPrice();
                }
            }

            Console.WriteLine("Bought furniture:");

            foreach (Furniture furniture in furnitures)
            {
                Console.WriteLine(furniture.Name);
            }

            Console.WriteLine($"Total money spend: {totalMoney:f2}");
        }

    }

    class Furniture
    {
        public Furniture(string name, double price, int quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
        }

        public string Name { get; set; }

        public double Price { get; set; }

        public int Quantity { get; set; }

        public double TotalPrice()
        {
            return Price * Quantity;
        }
    }
}