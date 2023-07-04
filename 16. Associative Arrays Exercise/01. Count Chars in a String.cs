namespace _01._Count_Chars_in_a_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Dictionary<char, int> chars = new Dictionary<char, int>();

            foreach (char character in input) 
            {
                if (character == ' ')
                {
                    continue;
                }

                if (!chars.ContainsKey(character))
                {
                    chars.Add(character, 1);
                }
                else
                {
                    chars[character]++;
                }
            }

            foreach (KeyValuePair<char, int> pair in chars)
            {
                Console.WriteLine($"{pair.Key} -> {pair.Value}");
            }
        }
    }
}