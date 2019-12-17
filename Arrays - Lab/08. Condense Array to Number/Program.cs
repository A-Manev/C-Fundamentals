using System;
using System.Linq;

namespace _08._Condense_Array_to_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int counter = numbers.Length;
            while (counter > 1)
            {
                for (int i = 0; i < numbers.Length- 1; i++)
                {
                    numbers[i] = numbers[i] + numbers[i + 1];
                }
                counter--;
            }
            Console.WriteLine(numbers[0]); 




            //int[] newNumbersArray = new int[numbers.Length - 1];
            //if (numbers.Length == 1)
            //{
            //    Console.WriteLine(numbers[0]);
            //}
            //else
            //{
            //    for (int i = 0; i < numbers.Length; i++)
            //    {
            //        for (int j = 0; j < newNumbersArray.Length - i; j++)
            //        {
            //            newNumbersArray[j] = numbers[j] + numbers[j + 1];
            //        }
            //        numbers = newNumbersArray;
            //    }
            //    Console.WriteLine(newNumbersArray[0]);
            //}
        }
    }
}
