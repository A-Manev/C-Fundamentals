using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._List_Operations
{
    class Program
    {
        static void Main()
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            string input = string.Empty;
            while ((input = Console.ReadLine()) != "End")
            {
                string[] tokens = input.Split();
                string command = tokens[0];
                if (command == "Add")
                {
                    int number = int.Parse(tokens[1]);
                    numbers.Add(number);
                }
                else if (command == "Remove")
                {
                    int index = int.Parse(tokens[1]);
                    if (index < 0 || index > numbers.Count)
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                        numbers.RemoveAt(index);
                    }
                }
                else if (command == "Insert")
                {
                    int number = int.Parse(tokens[1]);
                    int index = int.Parse(tokens[2]);
                    if (index < 0 || index > numbers.Count)
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                        numbers.Insert(index, number);
                    }
                }
                else if (command == "Shift")
                {
                    int count = int.Parse(tokens[2]);

                    if (tokens[1] == "right")
                    {
                        for (int i = 0; i < count; i++)
                        {
                            int lastNumber = numbers[numbers.Count - 1];
                            numbers.RemoveAt(numbers.Count - 1);
                            numbers.Insert(0, lastNumber);
                        }
                    }
                    else if (tokens[1] == "left")
                    {
                        for (int i = 0; i < count; i++)
                        {
                            int firstNumber = numbers[0];
                            numbers.RemoveAt(0);
                            numbers.Add(firstNumber);
                        }
                    }
                }
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
