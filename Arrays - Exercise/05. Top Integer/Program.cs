using System;
using System.Linq;

namespace _05._Top_Integer
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                bool isTopInteger = true;
                int currentNumber = numbers[i];
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    int nextInteger = numbers[j];
                    if (currentNumber <= nextInteger)
                    {
                        isTopInteger = false;
                        break;
                    }
                }
                if (isTopInteger)
                {
                    Console.Write(currentNumber + " ");
                }
            }
            Console.WriteLine(numbers[numbers.Length - 1]);
        }
    }
}
