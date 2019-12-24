using System;
using System.Linq;

namespace _04._Array_Rotation
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rotationNumber = int.Parse(Console.ReadLine());
           
            for (int i = 0; i < rotationNumber; i++)
            {
                int firstElement = numbers[0];

                for (int j = 0; j < numbers.Length - 1; j++)
                {
                    numbers[j] = numbers[j + 1];
                }

                numbers[numbers.Length - 1] = firstElement;
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
