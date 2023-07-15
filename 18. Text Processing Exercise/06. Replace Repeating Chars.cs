using System.Text;

namespace _06._Replace_Repeating_Chars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            StringBuilder sb = new StringBuilder();

            sb.Append(text[0]);        

            for (int i = 0; i < text.Length - 1; i++)
            {
                if (text[i] != text[i + 1])
                {
                    sb.Append(text[i + 1]);
                }
            }
            Console.WriteLine(sb.ToString());
        }
    }
}