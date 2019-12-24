using System;
using System.Linq;
using System.Collections.Generic;

namespace _07._Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int counter = 1;
            int maxCount = 1;
            int number = numbers[0];

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                int currentNumber = numbers[i];
                int nextNumbers = numbers[i + 1];
                if (currentNumber == nextNumbers)
                {
                    counter++;
                    if (counter > maxCount)
                    {
                        maxCount = counter;
                        number = currentNumber;
                    }
                }
                else
                {
                    counter = 1;
                }
            }
            for (int i = 0; i < maxCount; i++)
            {
                Console.Write($"{number} ");
            }
            Console.WriteLine();
        }
    }
}
