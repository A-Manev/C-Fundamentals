using System;

namespace _05._Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int allNumbersInTheRange = int.Parse(Console.ReadLine());
            int sumofDigits = 0;

            for (int i = 1; i <= allNumbersInTheRange; i++)
            {
                int num = i;
                while (num != 0)
                {
                    int lastDigit = num % 10;
                    sumofDigits += lastDigit;
                    num = num / 10;
                }
                if (sumofDigits == 5 ||
                    sumofDigits == 7 ||
                    sumofDigits == 11)
                {
                    Console.WriteLine($"{i} -> True");
                }
                else
                {
                    Console.WriteLine($"{i} -> False");
                }
                    sumofDigits = 0;
            }
        }
    }
}
