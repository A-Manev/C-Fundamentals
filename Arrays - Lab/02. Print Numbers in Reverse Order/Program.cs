using System;
using System.Linq;

namespace _02._Print_Numbers_in_Reverse_Order
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalNumbers = int.Parse(Console.ReadLine());

            int[] numbers = new int[totalNumbers];
            for (int i = 0; i < totalNumbers; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine(string.Join(" ", numbers.Reverse()));

            //numbers = numbers.Reverse().ToArray();
            //for (int i = 0; i < numbers.Length; i++)
            //{

            //    Console.Write(numbers[i] + " ");
            //}
        }
    }
}
