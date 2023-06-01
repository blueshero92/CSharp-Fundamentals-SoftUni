using System;

namespace _11._Refractor_Volume_Of_Pyramid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal length = 0;
            decimal width = 0;
            decimal height = 0;
            decimal volume = 0;

            Console.Write("Length: ");
            length = decimal.Parse(Console.ReadLine());
            Console.Write("Width: ");
            width = decimal.Parse(Console.ReadLine());
            Console.Write("Height: ");
            height = decimal.Parse(Console.ReadLine());
            volume = (length * width * height) / 3;
            Console.WriteLine($"Pyramid Volume: {volume:f2}");
        }
    }
}
