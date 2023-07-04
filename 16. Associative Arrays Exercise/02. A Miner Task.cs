namespace _02._A_Miner_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string resource;

            Dictionary<string, int> resourcesQuantity = new Dictionary<string, int>();

            while ((resource = Console.ReadLine()) != "stop")
            {
                
                int quantity = int.Parse(Console.ReadLine());               

                if (!resourcesQuantity.ContainsKey(resource))
                {
                    resourcesQuantity.Add(resource, quantity);
                }
                else
                {
                    resourcesQuantity[resource] += quantity;
                }
            }

            foreach (KeyValuePair<string, int> kvp in resourcesQuantity)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}