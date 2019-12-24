using System;
using System.Linq;

namespace _06._Equal_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            bool elementExist = true;
            
            for (int i = 0; i < numbers.Length; i++)
            {
                int rightSum = 0;
                int leftSum = 0;
                //int currentNumber = numbers[i];
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    rightSum += numbers[j];
                }
                for (int k = 0; k < i; k++)
                {
                    leftSum += numbers[k];
                }
                if (rightSum == leftSum)
                {
                    Console.WriteLine(i);
                    elementExist = false;
                    break;
                }
            }
            if (elementExist)
            {
                Console.WriteLine("no");
            }
        }
    }
}
