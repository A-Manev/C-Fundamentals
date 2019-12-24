using System;
using System.Linq;

namespace _02._Common_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstArray = Console.ReadLine().Split().ToArray();
            string[] secondArray = Console.ReadLine().Split().ToArray();

            foreach (var word in secondArray)
            {
                if (firstArray.Contains(word))
                {
                    Console.Write($"{word} ");
                }
            }

            //for (int i = 0; i < secondArray.Length; i++)
            //{
            //    string word = firstArray[i];

            //    if (secondArray.Contains(word))
            //    {
            //        Console.Write($"{word} ");
            //    }
            //}
        }
    }
}
