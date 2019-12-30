using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Cards_Game
{
    class Program
    {
        static void Main()
        {
            List<int> firstPlayerHand = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> secondPlayerHand = Console.ReadLine().Split().Select(int.Parse).ToList();

            for (int i = 0; i < Math.Min(firstPlayerHand.Count, secondPlayerHand.Count); i++)
            {
                int firstPlayerCard = firstPlayerHand[0];
                int secondPlayerCard = secondPlayerHand[0];

                if (firstPlayerCard == secondPlayerCard)
                {
                    firstPlayerHand.Remove(firstPlayerCard);
                    secondPlayerHand.Remove(secondPlayerCard);
                    i = -1;
                }
                else if (firstPlayerCard > secondPlayerCard)
                {
                    firstPlayerHand.Remove(firstPlayerCard);
                    secondPlayerHand.Remove(secondPlayerCard);
                    firstPlayerHand.Add(firstPlayerCard);
                    firstPlayerHand.Add(secondPlayerCard);
                    i = -1;
                }
                else if (firstPlayerCard < secondPlayerCard)
                {
                    firstPlayerHand.Remove(firstPlayerCard);
                    secondPlayerHand.Remove(secondPlayerCard);
                    secondPlayerHand.Add(secondPlayerCard);
                    secondPlayerHand.Add(firstPlayerCard);
                    i = -1;
                }
            }

            if (firstPlayerHand.Count > secondPlayerHand.Count)
            {
                Console.WriteLine($"First player wins! Sum: {firstPlayerHand.Sum()}");
            }
            else
            {
                Console.WriteLine($"Second player wins! Sum: {secondPlayerHand.Sum()}");
            }
        }
    }
}
