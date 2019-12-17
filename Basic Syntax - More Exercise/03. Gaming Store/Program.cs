using System;

namespace _03._Gaming_Store
{
    class Program
    {
        static void Main(string[] args)
        {
            double currentBalance = double.Parse(Console.ReadLine());
            double gamePrice = 0;
            double moneySpend = 0;
            double lastBalance = 0;
            bool gameInStore = true;
            bool someMoney = true;
            string command = string.Empty;
            while ((command = Console.ReadLine()) != "Game Time")
            {
                gameInStore = true;
                switch (command)
                {
                    case "OutFall 4":
                        gamePrice = 39.99;
                        break;
                    case "CS: OG":
                        gamePrice = 15.99;
                        break;
                    case "Zplinter Zell":
                        gamePrice = 19.99;
                        break;
                    case "Honored 2":
                        gamePrice = 59.99;
                        break;
                    case "RoverWatch":
                        gamePrice = 29.99;
                        break;
                    case "RoverWatch Origins Edition":
                        gamePrice = 39.99;
                        break;
                    default:
                        Console.WriteLine("Not Found");
                        gameInStore = false;
                        break;
                }

                currentBalance -= gamePrice;

                if (currentBalance == 0)
                {
                    Console.WriteLine("Out of money!");
                    someMoney = false;
                    break;
                }
                else
                {
                    if (currentBalance < 0)
                    {
                        Console.WriteLine("Too Expensive");
                        lastBalance = gamePrice;
                        currentBalance += lastBalance;
                    }
                    else if (gameInStore == true)
                    {
                        moneySpend += gamePrice;
                        Console.WriteLine($"Bought {command}");
                    }
                }
            }
            if (someMoney = true)
            {
                Console.WriteLine($"Total spent: ${moneySpend:f2}. Remaining: ${currentBalance:f2}");
            }
        }
    }
}
