namespace _03._Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Product> products = new Dictionary<string, Product>();

            string command;

            while ((command = Console.ReadLine()) != "buy")
            {
                string[] arguments = command.Split();

                string name = arguments[0];
                double price = double.Parse(arguments[1]);
                int quantity = int.Parse(arguments[2]);

                Product product = new Product(name, price, quantity);

                if (products.ContainsKey(name))
                {
                    products[name].Update(price, quantity);
                }
                else
                {
                    products.Add(name, product);               
                }

            }

            foreach (KeyValuePair<string, Product> pair in products)
            {
                Console.WriteLine(pair.Value);
            }
        }
    }

    class Product
    {
        public Product(string name, double price, int quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
        }

        public string Name { get; set; }

        public double Price { get; set; }

        public int Quantity { get; set; }

        public void Update(double price, int quantity)
        {
            Price = price;
            Quantity += quantity;
        }

        public override string ToString()
        {
            return $"{Name} -> {Price * Quantity:f2}";
        }
    }
}