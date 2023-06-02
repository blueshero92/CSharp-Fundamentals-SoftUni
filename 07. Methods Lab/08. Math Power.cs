using System;

namespace _08._Math_Power
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double baseNum = double.Parse(Console.ReadLine());
            double power = double.Parse(Console.ReadLine());
            Console.WriteLine(PowerNum(baseNum, power));

        }

        static double PowerNum(double baseNum, double power)
        {
            return (Math.Pow(baseNum, power));
        }
    }
}
