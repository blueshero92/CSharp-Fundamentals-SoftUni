using System;

namespace _05._Login
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string password = string.Empty;

            for (int i = username.Length - 1; i >= 0; i--)
            {
                password += username[i];
            }

            string input = Console.ReadLine();

            int loginCount = 0;

            while (input != password)
            {
                
                loginCount++;
                
                if (loginCount < 4)
                {
                    Console.WriteLine("Incorrect password. Try again.");
                                     
                }
                else
                {
                    Console.WriteLine($"User {username} blocked!");
                    break;
                }

                input = Console.ReadLine();
                
            }
            if (input == password)
            {
                Console.WriteLine($"User {username} logged in.");
            }
        }
    }
}
