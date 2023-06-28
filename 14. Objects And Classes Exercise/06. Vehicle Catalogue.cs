namespace _06._Vehicle_Catalogue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command;
            
            List<Vehicle> catalogue = new List<Vehicle>();

            while ((command = Console.ReadLine()) != "End")
            {
                string[] split = command.Split();                

                string type = split[0];
                string model = split[1];
                string color = split[2];
                decimal horsepower = decimal.Parse(split[3]);

                catalogue.Add(new Vehicle(type, model, color, horsepower));

            }                                 

            decimal totalCarsHorsePower = 0;
            decimal totalTruckHorsePower = 0;

            while ((command= Console.ReadLine()) != "Close the Catalogue")
            {
                string vehicleModel = command;

                Vehicle found = catalogue.FirstOrDefault(v => v.Model == vehicleModel);

                if (found != null)
                {
                    Console.WriteLine(found);
                }
              
            }

            decimal averageHP = catalogue
            .Where(vehicle => vehicle.Type == Type.Car)
            .Select(vehicle => vehicle.Horsepower)
            .DefaultIfEmpty()
            .Average();
            Console.WriteLine($"Cars have average horsepower of: {averageHP:F2}.");

            averageHP = catalogue
                .Where(vehicle => vehicle.Type == Type.Truck)
                .Select(vehicle => vehicle.Horsepower)
                .DefaultIfEmpty()
                .Average();
            Console.WriteLine($"Trucks have average horsepower of: {averageHP:F2}.");

        }
    }

    enum Type
    {
        Car, 
        Truck
    }

    class Vehicle
    {
        public Vehicle(string type, string model, string color, decimal horsepower)
        {
            Type = type == "car" ? Type.Car : Type.Truck;
            Model = model;
            Color = color;
            Horsepower = horsepower;
        }

        public Type Type { get; set; }

        public string Model { get; set; }

        public string Color { get; set; }

        public decimal Horsepower { get; set; }

        public override string ToString()
        {
            return $"Type: {Type}\n" +
                   $"Model: {Model}\n" +
                   $"Color: {Color}\n" +
                   $"Horsepower: {Horsepower}";
        }

    }
}