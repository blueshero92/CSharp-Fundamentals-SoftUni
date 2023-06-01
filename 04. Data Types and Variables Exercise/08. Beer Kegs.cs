using System;

namespace _8._Beer_Kegs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int kegs = int.Parse(Console.ReadLine());

            double volume = 0;

            int biggestHeight = 0;
            double biggestRadius = 0;
            string biggestModel = string.Empty;

            double biggestVolume = Math.PI * biggestRadius*biggestRadius * biggestHeight;

            for (int keg = 1; keg <= kegs; keg++)
            {
                string kegModel = Console.ReadLine();
                double kegRadius = double.Parse(Console.ReadLine());
                int kegHeigth = int.Parse(Console.ReadLine());

                volume = Math.PI * kegRadius * kegRadius * kegHeigth;

                if(biggestVolume < volume)
                {
                    biggestVolume = volume;
                    biggestModel = kegModel;
                }

            }
            Console.WriteLine(biggestModel);
        }
    }
}
