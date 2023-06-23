﻿namespace _06._Store_Boxes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;

            List<Box> boxes = new List<Box>();

            while ((input = Console.ReadLine()) != "end")
            {
                string[] data = input.Split();

                string serialNumber = data[0];
                string itemName = data[1];
                int quantity = int.Parse(data[2]);
                decimal itemPrice = decimal.Parse(data[3]);

                Item item = new Item(itemName, itemPrice);
                Box box = new Box(serialNumber, item, quantity);
                boxes.Add(box);

            }

            foreach (Box box in boxes.OrderByDescending(x => x.BoxPrice))
            {
                Console.WriteLine($"{box.SerialNumber}");
                Console.WriteLine($"-- {box.Item.Name} - ${box.Item.Price:f2}: {box.Quantity}");
                Console.WriteLine($"-- ${box.BoxPrice:f2}");

            }

        }

        class Item
        {
            public Item(string name, decimal price)
            {
                Name = name;
                Price = price;
            }

            public string Name { get; set; }

            public decimal Price { get; set; }
        }

        class Box
        {
            public Box(string serialNumber, Item item, int quantity)
            {
                SerialNumber = serialNumber;
                Item = item;
                Quantity = quantity;
            }

            public string SerialNumber { get; set; }

            public Item Item { get; set; }

            public int Quantity { get; set; }

            public decimal BoxPrice
            {
                get => Quantity * Item.Price;
            }
        }
    }
}
