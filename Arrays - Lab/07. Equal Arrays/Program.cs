using System;
using System.Linq;

namespace _07._Equal_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] firstNumbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] secondNumbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int sum = 0;
            for (int i = 0; i < firstNumbers.Length; i++)
            {
                sum += firstNumbers[i];
                if (firstNumbers[i] != secondNumbers[i])
                {
                    Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
                    return;
                }
            }
            Console.WriteLine($"Arrays are identical. Sum: {sum}");
            
            //bool elementsAreEqual = false;
            //int differentIndex = 0;
            //int sum = 0;

            //for (int i = 0; i < firstNumbers.Length; i++)
            //{
            //    if (firstNumbers[i] == secondNumbers[i])
            //    {
            //        elementsAreEqual = true;
            //        sum += firstNumbers[i];
            //    }
            //    else
            //    {
            //        elementsAreEqual = false;
            //        differentIndex = i;
            //        break;
            //    }
            //}

            //if (elementsAreEqual)
            //{
            //    Console.WriteLine($"Arrays are identical. Sum: {sum}");
            //}
            //else
            //{
            //    Console.WriteLine($"Arrays are not identical. Found difference at {differentIndex} index");
            //}
        }
    }
}
