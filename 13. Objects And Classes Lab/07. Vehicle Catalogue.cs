using System.Collections.Generic;
using System.Reflection;
using System.Reflection.Metadata;

namespace _07._Vehicle_Catalogue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;

            Catalog catalog = new Catalog ();

            while((input = Console.ReadLine()) != "end")
            {
                string[] tokens = input.Split("/");

                string type = tokens[0];
                string brand = tokens[1];
                string model = tokens[2];
                int attribute = int.Parse(tokens[3]);
                

                if (type == "Car")
                {
                    catalog.Cars.Add(new Car
                    {
                        Brand = brand,
                        Model = model,
                        HorsePower = attribute,
                    });
                }
                else if (type == "Truck")
                {
                    catalog.Trucks.Add(new Truck

                    {
                        Brand = brand,
                        Model = model,
                        Weigth = attribute,
                    });
                }
                                   
            }

            if(catalog.Cars.Count > 0)
            {
                Console.WriteLine("Cars:");

                foreach (Car car in catalog.Cars.OrderBy(x => x.Brand))
                {
                    Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
                }
            }

            if (catalog.Trucks.Count > 0)
            {
                Console.WriteLine("Trucks:");

                foreach (Truck truck in catalog.Trucks.OrderBy(x => x.Brand))
                {
                    Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weigth}kg");
                }
            }

        }
    }
    class Catalog
    {
       
        public Catalog()
        {
            Trucks = new List<Truck>();
            Cars = new List<Car>();
        }

        public List<Truck> Trucks { get; set; }

        public List<Car> Cars { get; set; }

    }
    class Truck
    {
        public string Brand { get; set; }

        public string Model { get; set; }

        public int Weigth { get; set; }
    }

    class Car
    {
        public string Brand { get; set; }

        public string Model { get; set; }

        public int HorsePower { get; set; }
    }


}