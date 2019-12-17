using System;
using System.Linq;

namespace _06._Even_and_Odd_Subtraction
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int evenNumbersSum = 0;
            int oddNumbersSum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    evenNumbersSum += numbers[i];
                }
                else
                {
                    oddNumbersSum += numbers[i];
                }
            }
            int difference = evenNumbersSum - oddNumbersSum;
            Console.WriteLine(difference);
        }
    }
}
