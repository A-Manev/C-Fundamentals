using System;

namespace _07._Vending_Machine
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = string.Empty;
          
            double totalMoney = 0;
            double lastBalans = 0;
            while ((command = Console.ReadLine()) != "Start")
            {
                double coins = double.Parse(command);
                if (coins == 0.1 || 
                    coins == 0.2 ||
                    coins == 0.5 ||
                    coins == 1   || 
                    coins == 2)
                {
                    totalMoney += coins;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {coins}");
                }
            }

            while ((command = Console.ReadLine()) != "End")
            {

                if (command == "Nuts")
                {
                    totalMoney -= 2;
                    if (totalMoney >= 0)
                    {
                        lastBalans = totalMoney;
                        Console.WriteLine($"Purchased {command}");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                        break;
                    }
                }
                else if (command == "Water")
                {
                    totalMoney -= 0.7;
                    if (totalMoney >= 0)
                    {
                        lastBalans = totalMoney;
                        Console.WriteLine($"Purchased {command}");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                        break;
                    }
                }
                else if (command == "Crisps")
                {
                    totalMoney -= 1.5;
                    if (totalMoney >= 0)
                    {
                        lastBalans = totalMoney;
                        Console.WriteLine($"Purchased {command}");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                        break;
                    }
                }
                else if (command == "Soda")
                {
                    totalMoney -= 0.8;
                    if (totalMoney >= 0)
                    {
                        lastBalans = totalMoney;
                        Console.WriteLine($"Purchased {command}");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                        break;
                    }
                }
                else if (command == "Coke")
                {
                    totalMoney -= 1;
                    if (totalMoney >= 0)
                    {
                        lastBalans = totalMoney;
                        Console.WriteLine($"Purchased {command}");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid product");
                    break;
                }

                
            }

            if (totalMoney >= 0)
            {
                Console.WriteLine($"Change: {totalMoney:f2}");
            }
            else
            {
                Console.WriteLine($"Change: {lastBalans:f2}");
            }

        }
    }
}
