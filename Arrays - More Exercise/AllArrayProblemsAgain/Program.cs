using System;
using System.Linq;

namespace AllArrayProblemsAgain
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string input = Console.ReadLine();
            int[] num = new int[input.Length];

            for (int i = 0; i < input.Length; i++)
            {
                num[i] = int.Parse(input[i].ToString());
            }
            Array.Sort(num);
            Array.Reverse(num);
            Console.WriteLine(string.Join("", num));
        }
    }
}
