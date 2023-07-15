namespace _01._Reverse_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command;

            string result = string.Empty;

            while ((command = Console.ReadLine()) != "end")
            {                

                for (int i = command.Length - 1; i >= 0; i--)
                {
                    result += command[i];
                }

                Console.WriteLine($"{command} = {result}");
            }
                           
        }
    }
}