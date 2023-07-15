using System.Text;

namespace _07._String_Explosion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            StringBuilder stringBuilder = new StringBuilder();

            int strength = 0;

            for (int i = 0; i < text.Length; i++)
            {

                if (strength == 0 || text[i] == '>')
                {
                    stringBuilder.Append(text[i]);
                }

                if (text[i] != '>')
                {
                    strength--;
                }

                if (strength < 0)
                {
                    strength = 0;
                }

                if (text[i] == '>')
                {
                    strength += (text[i + 1]) - '0';
                }
            }

            Console.WriteLine(stringBuilder.ToString());

        }
    }
}