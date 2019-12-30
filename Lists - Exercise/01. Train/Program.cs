using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Train
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> wagons = Console.ReadLine().Split().Select(int.Parse).ToList();
            int maxCapacity = int.Parse(Console.ReadLine());
            string input = string.Empty;

            while ((input = Console.ReadLine()) != "end")
            {
                string[] tokens = input.Split();
                string command = tokens[0];
                if (command == "Add")
                {
                    int passengers = int.Parse(tokens[1]);
                    wagons.Add(passengers);
                }
                else
                {
                    int passengers = int.Parse(tokens[0]);
                    for (int i = 0; i < wagons.Count; i++)
                    {
                        if (wagons[i] + passengers <= maxCapacity)
                        {
                            wagons[i] += passengers;
                            break;
                        }
                    }

                }
            }
            Console.WriteLine(string.Join(" ", wagons));
        }
    }
}
