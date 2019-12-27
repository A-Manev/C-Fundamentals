using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Remove_Negatives_and_Reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            numbers.RemoveAll(n => n < 0);
            if (numbers.Count > 0)
            {
                numbers.Reverse();
                Console.WriteLine(string.Join(" ", numbers));
            }
            else
            {
                Console.WriteLine("empty");
            }



            //List<int> result = new List<int>();
            //for (int i = 0; i < numbers.Count; i++)
            //{
            //    if (numbers[i] > 0)
            //    {
            //        result.Add(numbers[i]);
            //    }
            //}

            //if (result.Count > 0)
            //{
            //    result.Reverse();
            //    Console.WriteLine(string.Join(" ", result));
            //}
            //else
            //{
            //    Console.WriteLine("empty");
            //}

            //for (int i = 0; i < numbers.Count; i++)
            //{
            //    if (numbers[i] < 0)
            //    {
            //        numbers.Remove(numbers[i]);
            //        i -= 1;
            //    }
            //}
            //numbers.Reverse();
            //if (numbers.Count > 0)
            //{
            //    Console.WriteLine(string.Join(" ", numbers));
            //}
            //else
            //{
            //    Console.WriteLine("empty");
            //}
        }
    }
}
