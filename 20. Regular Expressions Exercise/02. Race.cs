using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace _02._Race
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>(Console.ReadLine().Split(", "));

            List<Racer> racers = new List<Racer>();

            for (int i = 0; i < names.Count; i++)
            {
                Racer racer = new Racer();
                racer.Name = names[i];
                racer.Distance = 0;
                racers.Add(racer);
            }

            string input;

            string namePattern = @"[A-Za-z]";
            string distancePattern = @"\d";


            while ((input = Console.ReadLine()) != "end of race")
            {
                StringBuilder name = new StringBuilder();
                int distance = 0;

                Regex nameRegex = new Regex(namePattern);

                foreach (Match match in nameRegex.Matches(input))
                {
                    name.Append(match.Value);
                }

                Regex distanceRegex = new Regex(distancePattern);

                foreach(Match digit in distanceRegex.Matches(input))
                {
                    distance += int.Parse(digit.Value);
                }

                Racer foundRacer = racers.FirstOrDefault(r => r.Name == name.ToString());

                if (foundRacer != null)
                {
                    foundRacer.Distance += distance;
                }

            }
                                   

            List<Racer> orderedRacers = racers.OrderByDescending(r => r.Distance).Take(3).ToList();

            Console.WriteLine($"1st place: {orderedRacers[0].Name}");
            Console.WriteLine($"2nd place: {orderedRacers[1].Name}");
            Console.WriteLine($"3rd place: {orderedRacers[2].Name}");


        }
    }
    class Racer
    {      

        public string Name { get; set; }

        public int Distance { get; set; }
    }
}