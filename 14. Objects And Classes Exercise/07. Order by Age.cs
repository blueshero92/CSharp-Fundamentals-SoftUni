namespace _07._Order_by_Age
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command;

            List<Person> people = new List<Person>();

            while ((command = Console.ReadLine()) != "End")
            {
                string[] split = command.Split();

                string name = split[0];
                string iD = split[1];
                int age = int.Parse(split[2]);

                Person person = new Person(name, iD, age);

                person.Name = name;
                person.ID = iD;
                person.Age = age;

                Person personSameID = people.FirstOrDefault(p => p.ID == iD);

                if (personSameID == null)
                {
                    people.Add(person);
                }
                else
                {
                    personSameID.Name = name;
                    personSameID.Age = age;
                }

            }

            List<Person> orderedList = people.OrderBy(p => p.Age).ToList();

            Console.WriteLine(string.Join(Environment.NewLine, orderedList));
        }
    }

    class Person
    {
        public Person(string name, string iD, int age)
        {
            Name = name;
            ID = iD;
            Age = age;
        }

        public string Name { get; set; }

        public string ID { get; set; }

        public int Age { get; set; }

        public override string ToString()
        {
            return $"{Name} with ID: {ID} is {Age} years old.";
        }
    }
}