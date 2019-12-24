using System;
using System.Linq;

namespace _03._Zig_Zag_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOflines = int.Parse(Console.ReadLine());

            int[] firstArray = new int[numberOflines];
            int[] secondArray = new int[numberOflines];

            for (int i = 0; i < numberOflines; i++)
            {
                int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
                if (i % 2 == 0)
                {
                    firstArray[i] = numbers[0];
                    secondArray[i] = numbers[1];
                }
                else
                {
                    secondArray[i] = numbers[0];
                    firstArray[i] = numbers[1];
                }
            }
            Console.WriteLine(string.Join(" ", firstArray));
            Console.WriteLine(string.Join(" ", secondArray));
        }
    }
}
