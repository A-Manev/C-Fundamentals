using System;
using System.Collections.Generic;

namespace _03._House_Party
{
    class Program
    {
        static void Main()
        {
            int numberOfCommands = int.Parse(Console.ReadLine());
            List<string> guests = new List<string>();

            for (int i = 0; i < numberOfCommands; i++)
            {
                string[] command = Console.ReadLine().Split();

                if (command[2] != "not")
                {
                    string name = command[0];
                    if (guests.Contains(name))
                    {
                        Console.WriteLine($"{name} is already in the list!");
                    }
                    else
                    {
                        guests.Add(name);
                    }
                }
                else
                {
                    string name = command[0];
                    if (!(guests.Contains(name)))
                    {
                        Console.WriteLine($"{name} is not in the list!");
                    }
                    else
                    {
                        guests.Remove(name);
                    }

                }
            }
            Console.WriteLine(string.Join("\n", guests));
        }
    }
}
