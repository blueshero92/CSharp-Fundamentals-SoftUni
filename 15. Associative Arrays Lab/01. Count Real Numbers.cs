namespace _01._Count_Real_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = Console
                              .ReadLine()
                              .Split()
                              .Select(x => double.Parse(x))
                              .ToArray();

            SortedDictionary <double, int> counts = new SortedDictionary<double, int>();

            foreach (double number in numbers)
            {
                if (counts.ContainsKey(number))
                {
                    counts[number]++;
                }
                else
                {
                    counts.Add(number, 1);
                }
            }

            foreach (var number in counts)
            {
                Console.WriteLine($"{number.Key} -> {number.Value}");
            }
        }
    }
}