using System;

namespace _06._Balanced_Brackets
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfLines = int.Parse(Console.ReadLine());
            int openingBracketCounter = 0;
            int closingBrackrtCounter = 0;

            for (int i = 0; i < numberOfLines; i++)
            {
                string command = Console.ReadLine();

                if (command == "(")
                {
                    openingBracketCounter++;
                }
                if (command == ")")
                {
                    closingBrackrtCounter++;
                }
                if (closingBrackrtCounter > openingBracketCounter)
                {
                    Console.WriteLine("UNBALANCED");
                    return;
                }
            }
            if (openingBracketCounter == closingBrackrtCounter)
            {
                Console.WriteLine("BALANCED");
            }
            else
            {
                Console.WriteLine("UNBALANCED");
            }
        }
    }
}
