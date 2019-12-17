using System;

namespace _10._Rage_Expenses
{
    class Program
    {
        static void Main(string[] args)
        {
            int lostGamesCounter = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());

            int trashedHeadserCounter = 0;
            int trashedMouseCounter = 0;
            int trashedKeyboardCounter = 0;
            int trashedDisplayCounter = 0;

            for (int i = 1; i <= lostGamesCounter; i++)
            {
                if (i % 12 == 0)
                {
                    trashedDisplayCounter++;
                }
                if (i % 6 == 0)
                {
                    trashedKeyboardCounter++;
                }
                if (i % 3 == 0)
                {
                    trashedMouseCounter++;
                }
                if (i % 2 == 0)
                {
                    trashedHeadserCounter++;
                }
            }
            double totalPrice = (headsetPrice * trashedHeadserCounter) +
                (mousePrice * trashedMouseCounter) +
                (keyboardPrice * trashedKeyboardCounter) +
                (displayPrice * trashedDisplayCounter);
            Console.WriteLine($"Rage expenses: {totalPrice:f2} lv.");
        }
    }
}
