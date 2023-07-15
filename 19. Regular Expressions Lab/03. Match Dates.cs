using System.Text.RegularExpressions;

namespace _03._Match_Dates
{
    internal class Program
    {
        static void Main()
        {
            string dates = Console.ReadLine();

            string pattern = @"((?<Day>[0-9]{2})/(?<Month>[A-Z][a-z]+)/(?<Year>[0-9]{4}))|((?<Day>[0-9]{2})-(?<Month>[A-Z][a-z]+)-(?<Year>[0-9]{4}))|((?<Day>[0-9]{2})\.(?<Month>[A-Z][a-z]+)\.(?<Year>[0-9]{4}))";

            Regex regex = new Regex(pattern);

            MatchCollection matches = regex.Matches(dates);

            foreach (Match match in matches)
            {
                Console.WriteLine($"Day: {match.Groups["Day"].Value}, Month: {match.Groups["Month"].Value}, Year: {match.Groups["Year"].Value}");
            }
        }
    }
}