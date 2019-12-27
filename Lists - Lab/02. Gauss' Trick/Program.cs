using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Gauss__Trick
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            int size = numbers.Count / 2;
            for (int i = 0; i < size; i++)
            {
                numbers[i] += numbers[numbers.Count - 1];
                numbers.Remove(numbers[numbers.Count - 1]);
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}

//List<int> result = new List<int>();

//for (int i = 0; i < numbers.Count / 2; i++)
//{
//    result.Add(numbers[i] + numbers[numbers.Count - 1 - i]);

//    //numbers.Remove(numbers[numbers.Count - 1]);
//}

//if (numbers.Count % 2 == 1)
//{
//    //result.Add(numbers.Count / 2 + 1);
//    result.Add(numbers[numbers.Count / 2]);
//}
//Console.WriteLine(string.Join(" ", result));