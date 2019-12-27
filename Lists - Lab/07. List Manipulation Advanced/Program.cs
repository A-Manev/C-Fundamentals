using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._List_Manipulation_Advanced
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            string input = string.Empty;
            bool changes = false;
            while ((input = Console.ReadLine()) != "end")
            {
                string[] tokens = input.Split();
                string command = tokens[0];
                if (command == "Contains")
                {
                    int number = int.Parse(tokens[1]);
                    if (numbers.Contains(number))
                    {
                        Console.WriteLine("Yes");
                    }
                    else
                    {
                        Console.WriteLine("No such number");
                    }

                }
                else if (command == "PrintEven")
                {
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers[i] % 2 == 0)
                        {
                            Console.Write(numbers[i] + " ");
                        }
                    }
                    Console.WriteLine();
                }
                else if (command == "PrintOdd")
                {
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers[i] % 2 != 0)
                        {
                            Console.Write(numbers[i] + " ");
                        }
                    }
                    Console.WriteLine();
                }
                else if (command == "GetSum")
                {
                    int sum = numbers.Sum();
                    Console.WriteLine(sum);
                }
                else if (command == "Filter")
                {
                    string condition = tokens[1];
                    int number = int.Parse(tokens[2]);
                    switch (condition)
                    {
                        case "<":
                            Console.WriteLine(string.Join(" ", numbers.Where(x => x < number)));
                            break;
                        case ">":
                            Console.WriteLine(string.Join(" ", numbers.Where(x => x > number)));
                            break;
                        case ">=":
                            Console.WriteLine(string.Join(" ", numbers.Where(x => x >= number)));
                            break;
                        case "<=":
                            Console.WriteLine(string.Join(" ", numbers.Where(x => x <= number)));
                            break;
                    }
                }
                else
                {
                    ChangingList(numbers, tokens, command);
                    changes = true;
                }
            }
            if (changes)
            {
                Console.WriteLine(string.Join(" ", numbers));
            }
        }
        static void ChangingList(List<int> numbers, string[] tokens, string command)
        {
            if (command == "Add")
            {
                int index = int.Parse(tokens[1]);
                numbers.Add(index);
            }
            else if (command == "Remove")
            {
                int index = int.Parse(tokens[1]);
                numbers.Remove(index);
            }
            else if (command == "RemoveAt")
            {
                int index = int.Parse(tokens[1]);
                numbers.RemoveAt(index);
            }
            else if (command == "Insert")
            {
                int element = int.Parse(tokens[1]);
                int index = int.Parse(tokens[2]);
                numbers.Insert(index, element);
            }
        }
    }
}
