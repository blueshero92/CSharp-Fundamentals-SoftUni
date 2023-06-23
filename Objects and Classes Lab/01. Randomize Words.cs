namespace _01._Randomize_Words
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split().ToArray();

            Random random = new Random();

            for (int i = 0; i < input.Length; i++)
            {
                int randomIndex = random.Next(0, input.Length);

                string currentIndexValue = input[i];
                string randomIndexValue = input[randomIndex];

                input[i] = randomIndexValue;
                input[randomIndex] = currentIndexValue;
            }

            Console.WriteLine(string.Join(Environment.NewLine, input));
        }
    }
}