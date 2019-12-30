using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Change_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            string input = string.Empty;
            while ((input = Console.ReadLine()) !="end")
            {
                string[] tokens = input.Split();
                string command = tokens[0];

                if (command == "Delete")
                {
                    int element = int.Parse(tokens[1]);
                    while (numbers.Contains(element))
                    {
                        numbers.Remove(element);
                    }
                }
                else if (command == "Insert")
                {
                    int element = int.Parse(tokens[1]);
                    int index = int.Parse(tokens[2]);
                    numbers.Insert(index, element);
                }
            }
            Console.WriteLine(string.Join(" ",numbers));
        }
    }
}
