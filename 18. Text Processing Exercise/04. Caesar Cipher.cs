using System.Text;

namespace _04._Caesar_Cipher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            StringBuilder encryption = new StringBuilder();

            foreach(char c in text) 
            {
                encryption.Append((char)(c + 3));
            }

            Console.Write(encryption.ToString());
        }
    }
}