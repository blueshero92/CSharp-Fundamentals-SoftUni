using System.Text;

namespace _01._Valid_Usernames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] usernames = Console.ReadLine().Split(", ");
            
            StringBuilder stringBuilder= new StringBuilder();

            for (int i = 0; i < usernames.Length; i++)
            {
                if (usernames[i].Length < 3 || usernames[i].Length > 16)
                {
                    continue;
                }

                bool isValidUsername = usernames[i].All(c => char.IsLetterOrDigit(c) || c == '-' || c == '_');
                
                if (isValidUsername)
                {
                    stringBuilder.AppendLine(usernames[i]);
                }        
            }
            
            Console.WriteLine(stringBuilder.ToString());
        }
    }
}