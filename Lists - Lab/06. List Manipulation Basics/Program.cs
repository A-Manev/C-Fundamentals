using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._List_Manipulation_Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            string input = string.Empty;
            while ((input = Console.ReadLine()) != "end")
            {
                string[] command = input.Split().ToArray();

                if (command[0] == "Add")
                {
                    int index = int.Parse(command[1]);
                    numbers.Add(index);
                }
                else if (command[0] == "Remove")
                {
                    int index = int.Parse(command[1]);
                    numbers.Remove(index);
                }
                else if (command[0] == "RemoveAt")
                {
                    int index = int.Parse(command[1]);
                    numbers.RemoveAt(index);
                }
                else if (command[0] == "Insert")
                {
                    int element = int.Parse(command[1]);
                    int index = int.Parse(command[2]);
                    numbers.Insert(index, element);
                }
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
        
    }
}
