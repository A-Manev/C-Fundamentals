using System;
using System.Linq;

namespace _08._Magic_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int integersSum = int.Parse(Console.ReadLine());

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    for (int j = 1; j <= numbers.Length - i - 1; j++)
            //    {
            //        int twoNumbersSum = numbers[i] + numbers[j + i];
            //        if (twoNumbersSum == integersSum)
            //        {
            //            Console.WriteLine($"{numbers[i]} {numbers[j + i]}");
            //        }
            //    }
            //}


            for (int i = 0; i < numbers.Length; i++)
            {
                int currnetNumber = numbers[i];
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    int nextNumber = numbers[j];
                    int sum = currnetNumber + nextNumber;
                    if (sum == integersSum)
                    {
                        Console.WriteLine($"{currnetNumber} {nextNumber}");
                    }
                }
            }
        }
    }
}
