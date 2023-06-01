using System;

namespace _10._Poke_Mon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long powerN = long.Parse(Console.ReadLine());
            int distanceM = int.Parse(Console.ReadLine());
            int exaustionY = int.Parse(Console.ReadLine());

            long powerCopy = powerN;

            int pokesCount = 0;

            while (powerN >= distanceM)
            {
                powerN -= distanceM;
                pokesCount++;

                if (powerN == powerCopy*0.5 && exaustionY != 0)
                {
                    powerN /= exaustionY;                    
                }

            }

            Console.WriteLine(powerN);
            Console.WriteLine(pokesCount);
        }
    }
}
