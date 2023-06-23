using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Cards_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> firstPlayerDeck = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> secondPlayerDeck = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            while (firstPlayerDeck.Count > 0 && secondPlayerDeck.Count > 0)
            {
                int firstPlayerCard = firstPlayerDeck[0];
                int secondPlayerCard = secondPlayerDeck[0];

                if (firstPlayerCard > secondPlayerCard)
                {
                    firstPlayerDeck.RemoveAt(0);
                    secondPlayerDeck.RemoveAt(0);
                    firstPlayerDeck.Add(secondPlayerCard);
                    firstPlayerDeck.Add(firstPlayerCard);
                }

                else if (secondPlayerCard > firstPlayerCard)
                {
                    secondPlayerDeck.RemoveAt(0);
                    firstPlayerDeck.RemoveAt(0);
                    secondPlayerDeck.Add(firstPlayerCard);
                    secondPlayerDeck.Add(secondPlayerCard);
                }
                else
                {
                    firstPlayerDeck.RemoveAt(0);
                    secondPlayerDeck.RemoveAt(0);
                }
            }

            if (firstPlayerDeck.Count > 0)
            {
                Console.WriteLine($"First player wins! Sum: {firstPlayerDeck.Sum()}");
            }
            else if (secondPlayerDeck.Count > 0)
            {
                Console.WriteLine($"Second player wins! Sum: {secondPlayerDeck.Sum()}");
            }
        }
    }
}
