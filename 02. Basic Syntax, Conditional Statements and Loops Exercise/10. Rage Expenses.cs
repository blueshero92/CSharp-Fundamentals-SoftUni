using System;

namespace _10._Rage_Expenses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lostGamesCount = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());

            int headsetTrashed = 0;
            int mouseTrashed = 0;
            int keyboardTrashed = 0;
            int displayTrashed = 0;

            if(lostGamesCount >= 2)
            {
                headsetTrashed = lostGamesCount/2;
            }
            if (lostGamesCount >= 3)
            {
                mouseTrashed = lostGamesCount/3;
            }
            if(lostGamesCount >= 6)
            {
                keyboardTrashed = lostGamesCount/6;
            }
            if(keyboardTrashed >= 2)
            {
                displayTrashed = keyboardTrashed/2;
            }

            double totalMoneyNeeded = headsetPrice * headsetTrashed + mousePrice * mouseTrashed + keyboardPrice * keyboardTrashed + displayPrice * displayTrashed;

            Console.WriteLine($"Rage expenses: {totalMoneyNeeded:f2} lv.");

            
        }
    }
}
