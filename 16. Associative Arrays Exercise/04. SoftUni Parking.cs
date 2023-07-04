namespace _04._SoftUni_Parking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int commandsCount = int.Parse(Console.ReadLine());

            Dictionary<string, User> database = new Dictionary<string, User>();

            for (int i = 0; i < commandsCount; i++)
            {
                string[] split = Console.ReadLine().Split();
                string username = split[1];

                switch (split[0])
                {
                    case "register": string licensePlate = split[2];
                        User newUser = new User(username, licensePlate);
                        if(database.ContainsKey(username))
                        {
                            Console.WriteLine($"ERROR: already registered with plate number {licensePlate}");
                        }
                        else
                        {
                            database.Add(username, newUser);
                            Console.WriteLine($"{username} registered {licensePlate} successfully");
                        }
                        break;
                    case "unregister":
                        if (database.ContainsKey(username))
                        {
                            database.Remove(username);
                            Console.WriteLine($"{username} unregistered successfully");
                        }
                        else
                        {
                            Console.WriteLine($"ERROR: user {username} not found");
                        }
                        break;
                }
            }

            foreach (KeyValuePair<string, User> kvp in database)
            {
                Console.WriteLine(kvp.Value);
            }

        }
    }

    class User
    {
        public User(string username, string licensePlate)
        {
            Username = username;
            LicensePlate = licensePlate;
        }

        public string Username { get; set; }

        public string LicensePlate { get; set; }

        public override string ToString()
        {
            return $"{Username} => {LicensePlate}";
        }
    }
}