using System;

namespace _04._Refactoring_Prime_Checker
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberInRange = int.Parse(Console.ReadLine());

            for (int i = 2; i <= numberInRange; i++)
            {
                bool range = true;

                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        range = false;
                        break;
                    }
                }
                if (range)
                {
                    Console.WriteLine($"{i} -> true");
                }
                else
                {
                    Console.WriteLine($"{i} -> false");
                }
            }
        }
    }
}
