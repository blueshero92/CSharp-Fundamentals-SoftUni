using System.Text.RegularExpressions;

namespace _02._Match_Phone_Number
{
    internal class Program
    {
        static void Main()
        {
            string text = Console.ReadLine();

            string pattern = @"(\+359 2 [0-9]{3} [0-9]{4}\b)|(\+359-2-[0-9]{3}-[0-9]{4}\b)";

            Regex regex = new Regex(pattern);

            MatchCollection matches = regex.Matches(text);

            Console.Write(string.Join(", ", matches));

        }
    }
}