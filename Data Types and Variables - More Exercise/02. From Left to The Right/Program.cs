using System;
using System.Linq;
using System.Numerics;

namespace _02._From_Left_to_The_Right
{
    class Program
    {
        static void Main(string[] args)
        {
            byte numberOfLines = byte.Parse(Console.ReadLine());
            long digitSum = 0;
            for (int i = 0; i < numberOfLines; i++)
            {
                 digitSum = 0;
                long[] numbers = Console.ReadLine().Split().Select(long.Parse).ToArray();

                if (numbers[0] > numbers[1])
                {
                    long number = numbers[0];
                    while (number != 0)
                    {
                        long digit = number % 10;
                        digitSum += digit;
                        number /= 10;
                    }
                }
                else
                {
                    long number = numbers[1];
                    while (number != 0)
                    {
                        long digit = number % 10;
                        digitSum += Math.Abs(digit);
                        number /= 10;
                    }
                }
                Console.WriteLine(Math.Abs(digitSum));
            }
        }
    }
}
