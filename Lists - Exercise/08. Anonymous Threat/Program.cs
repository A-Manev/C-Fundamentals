using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._Anonymous_Threat
{
    class Program
    {
        static void Main()
        {
            List<string> text = Console.ReadLine().Split().ToList();
            string input = string.Empty;
            while ((input = Console.ReadLine()) != "3:1")
            {
                string[] tokens = input.Split();
                string command = tokens[0];

                if (command == "merge")
                {
                    int startIndex = int.Parse(tokens[1]);
                    int endIndex = int.Parse(tokens[2]);
                    Merge(text, startIndex, endIndex);
                }
                else if (command == "divide")
                {
                    int index = int.Parse(tokens[1]);
                    int partitions = int.Parse(tokens[2]);
                    Divide(text, index, partitions);
                }
            }
            Console.WriteLine(string.Join(" ", text));
        }

        static void Merge(List<string> text, int startIndex, int endIndex)
        {
            string sumOfString = string.Empty;
            if (startIndex < 0 || startIndex > text.Count)
            {
                startIndex = 0;
            }
            if (endIndex > text.Count - 1 || endIndex < 0)
            {
                endIndex = text.Count - 1;
            }
            //for (int i = startIndex; i <= endIndex; i++)
            //{
            //    sumOfString += text[i];
            //}
            //text.RemoveRange(startIndex, endIndex - startIndex + 1);
            //text.Insert(startIndex, sumOfString);

            for (int i = startIndex; i < endIndex; i++)
            {
                text[startIndex] += text[i + 1];
                text.RemoveAt(i + 1);
                i--;
                endIndex--;
            }
        }

        static void Divide(List<string> text, int index, int partitions)
        {
            if (index >= 0 && index < text.Count)
            {
                string wordForDivide = text[index];
                text.RemoveAt(index);
                int element = wordForDivide.Length / partitions;
                List<string> newElements = new List<string>();

                string splitedWord = string.Empty;
                for (int i = 1; i < partitions; i++)
                {
                    splitedWord = wordForDivide.Substring(0, element);
                    wordForDivide = wordForDivide.Substring(element);
                    newElements.Add(splitedWord);
                }
                newElements.Add(wordForDivide);
                text.InsertRange(index, newElements);
            }
        }
    }
}

