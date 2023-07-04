namespace _07._Company_Users
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command;

            Dictionary<string, Company> companies = new Dictionary<string, Company>();

            while ((command = Console.ReadLine()) != "End")
            {
                string[] splitted = command.Split(" -> ");

                string companyName = splitted[0];
                string employeeID = splitted[1];

                Company company = new Company(companyName);

                if (!companies.ContainsKey(companyName))
                {
                    companies.Add(companyName, company);
                }

                //companies[companyName].AddEmployeeID(employeeID);

                if (!companies[companyName].EmployeeID.Contains(employeeID))
                {
                    companies[companyName].EmployeeID.Add(employeeID);
                }
                                                
            }

            foreach (KeyValuePair <string, Company> kvp in companies)
            {
                Console.WriteLine(kvp.Value);
            }
        }
    }

    class Company
    {
        public Company(string name)
        {
            Name = name;
            EmployeeID = new List<string>();
        }

        public string Name { get; set; }

        public List<string> EmployeeID { get; set; }


        public override string ToString()
        {
            string result = $"{Name}\n"; 
                
            foreach(string employee in EmployeeID)
            {
                result += $"-- {employee}\n";
            }

            return result.Trim();
        }

        //public void AddEmployeeID(string employeeID)
        //{
        //    if (!EmployeeID.Contains(employeeID))
        //    {
        //        EmployeeID.Add(employeeID);
        //    }
           
        //}

    }
}