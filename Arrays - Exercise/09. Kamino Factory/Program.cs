using System;
using System.Collections.Generic;
using System.Linq;

namespace _09._Kamino_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            int DNALength = int.Parse(Console.ReadLine());

            string command = string.Empty;

            while ((command = Console.ReadLine()) != "Clone them!")
            {
                int[] currentDnaSample = command.
                    Split("!".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
            }
        }
    }
}
