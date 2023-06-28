namespace _05._Teamwork_Projects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int teamsCount = int.Parse(Console.ReadLine());

            List<Team> teams = new List<Team>();

            for (int i = 0; i < teamsCount; i++)
            {
                string[] command = Console.ReadLine().Split("-");

                string creator = command[0];
                string teamName = command[1];

                Team team = new Team(teamName, creator);

                Team existingTeam = teams.Find(x => x.Name == teamName);
                Team alreadyCreator = teams.Find(x => x.Creator == creator || x.Members.Contains(creator));

                if (existingTeam != null)
                {
                    Console.WriteLine($"Team {teamName} was already created!");
                    continue;
                }

                if (alreadyCreator != null)
                {
                    Console.WriteLine($"{creator} cannot create another team!");
                    continue;
                }



                teams.Add(team);
                Console.WriteLine($"Team {teamName} has been created by {creator}!");


            }

            string command2;

            while ((command2 = Console.ReadLine()) != "end of assignment")
            {
                string[] splitted = command2.Split("->");

                string member = splitted[0];
                string teamName = splitted[1];

                Team found = teams.Find(x => x.Name == teamName);

                if (found == null)
                {
                    Console.WriteLine($"Team {teamName} does not exist!");
                    continue;
                }

                Team foundTeam = teams.Find(x => x.Members.Contains(member) || x.Creator == member);

                if (foundTeam != null)
                {
                    Console.WriteLine($"Member {member} cannot join team {teamName}!");
                    continue;
                }

                teams.Find(x => x.Name == teamName).Members.Add(member);

            }

            List<Team> orderedTeams = teams.Where(x => x.Members.Count > 0)
                                           .OrderByDescending(x => x.Members.Count())
                                           .ThenBy(x => x.Name)
                                           .ToList();

            //Console.WriteLine(string.Join(Environment.NewLine, orderedTeams));
            orderedTeams.ForEach(team => Console.WriteLine(team));

            List<Team> zeroMembersTeams = teams.Where(x => x.Members.Count <= 0)
                                               .OrderBy(x => x.Name)
                                               .ToList();

            Console.WriteLine($"Teams to disband:");

            foreach (Team team in zeroMembersTeams)
            {
                Console.WriteLine(team.Name);
            }
        }
    }

    class Team
    {
        public Team(string name, string creator)
        {
            Name = name;
            Creator = creator;
            Members = new List<string>();
        }

        public string Name { get; set; }

        public string Creator { get; set; }

        public List<string> Members { get; set; }

        public override string ToString()
        {
            return $"{Name}\n- {Creator}\n-- {string.Join(Environment.NewLine + "-- ", Members.OrderBy(x => x).ToList())}";
        }
    }
}