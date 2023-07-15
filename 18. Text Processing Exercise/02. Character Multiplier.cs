namespace _02._Character_Multiplier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] strings = Console.ReadLine().Split();

            string str1 = strings[0];
            string str2 = strings[1];

            Console.WriteLine(Sum(str1, str2));

        }

        private static decimal Sum(string str1, string str2)
        {
            int length = Math.Max(str1.Length, str2.Length);

            decimal sum = 0;

            for (int i = 0; i < length; i++)
            {

                if (i < str1.Length && i < str2.Length)
                {
                    sum += str1[i] * str2[i];
                }
                else if (i < str1.Length)
                {
                    sum += str1[i];
                }
                else if (i < str2.Length)
                {
                    sum += str2[i];
                }

            }

            return sum;
        }
    }
}