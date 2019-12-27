using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Merging_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstNumbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> secondNumbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> result = new List<int>();
            for (int i = 0; i < Math.Max(firstNumbers.Count, secondNumbers.Count); i++)
            {
                if (i < firstNumbers.Count)
                {
                    result.Add(firstNumbers[i]);
                }
                if (i < secondNumbers.Count)
                {
                    result.Add(secondNumbers[i]);
                }
            }

            //int start = Math.Min(firstNumbers.Count, secondNumbers.Count);
            //int end = Math.Max(firstNumbers.Count, secondNumbers.Count);

            //for (int i = start; i < end; i++)
            //{
            //    if (firstNumbers.Count > secondNumbers.Count)
            //    {
            //        result.Add(firstNumbers[i]);
            //    }
            //    else
            //    {
            //        result.Add(secondNumbers[i]);
            //    }
            //}
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
