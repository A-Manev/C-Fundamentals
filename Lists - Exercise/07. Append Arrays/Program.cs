using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Append_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> numbers = Console.ReadLine().Split("|", StringSplitOptions.RemoveEmptyEntries).ToList();

            for (int i = 0; i < numbers.Count / 2; i++)
            {
                string firstLine = numbers[i];
                string lastLIne = numbers[numbers.Count - 1 - i];

                numbers[i] = lastLIne;
                numbers[numbers.Count - 1 - i] = firstLine;
            }

            List<string> result = new List<string>();
            List<string> finalResult = new List<string>();

            for (int i = 0; i < numbers.Count; i++)
            {
                string current = numbers[i];
                result = current.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                for (int j = 0; j < result.Count; j++)
                {
                    finalResult.Add(result[j]);
                }
            }
            Console.WriteLine(string.Join(" ", finalResult));
        }
    }
}
