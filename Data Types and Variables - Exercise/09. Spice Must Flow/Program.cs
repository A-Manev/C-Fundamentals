using System;

namespace _09._Spice_Must_Flow
{
    class Program
    {
        static void Main(string[] args)
        {
            int startingYield = int.Parse(Console.ReadLine());

            int workersConsume = startingYield;
            int dayCounter = 0;
            int totalAmount = 0;
            while (!(startingYield < 100))
            {
                startingYield -= 10;
                workersConsume -= 26;
                totalAmount += workersConsume;

                workersConsume = startingYield;
                dayCounter++;

            }
            if (startingYield >= 0)
            {
                totalAmount -= 26;
                if (totalAmount < 0)
                {
                    Console.WriteLine(dayCounter);
                    totalAmount += 26;
                    Console.WriteLine(totalAmount);
                }
                else
                {
                    Console.WriteLine(dayCounter);
                    Console.WriteLine(totalAmount);
                }
            }
        }
    }
}
