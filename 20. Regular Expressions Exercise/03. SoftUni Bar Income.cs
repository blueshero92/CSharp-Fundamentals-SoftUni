using System.Text.RegularExpressions;

namespace _03._SoftUni_Bar_Income
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;

            string pattern = @"%(?<name>[A-Z][a-z]+)%[^|$%.]*?<(?<product>\w+)>[^|$%.]*?\|(?<quantity>\d+)\|([^|$%.]*?)(?<price>\d+|\d+\.\d+)\$";

            List <Order> orders = new List <Order> ();

            while((input = Console.ReadLine()) != "end of shift")
            {
                Regex regex = new Regex(pattern);
                MatchCollection matches = regex.Matches(input);

                foreach (Match match in matches)
                {
                    string customerName = match.Groups["name"].Value;
                    string productName = match.Groups["product"].Value;
                    int quantity = int.Parse(match.Groups["quantity"].Value);
                    double price = double.Parse(match.Groups["price"].Value);

                    Order order = new Order (customerName, productName, quantity, price);
                    orders.Add (order);
                }
            }

            double totalIncome = 0;

            foreach (Order order in orders)
            {
                Console.WriteLine ($"{order.Customer}: {order.Product} - {order.TotalPrice():f2}");
                totalIncome += order.TotalPrice();
            }

            Console.WriteLine($"Total income: {totalIncome:f2}");
        }

    }

    class Order
    {
        public Order(string customer, string product, int quantity, double price)
        {
            Customer = customer;
            Product = product;
            Quantity = quantity;
            Price = price;
        }

        public string Customer { get; set; }

        public string Product { get; set; }

        public int Quantity { get; set; }

        public double Price { get; set; }

        public double TotalPrice()
        {
            return Price * Quantity;
        }
    }
}