using System;

namespace _12._Even_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            while (true)
            {
                if (number % 2 == 0)
                {
                    if (number < 0)
                    {
                        number *= -1;
                    }
                    Console.WriteLine($"The number is: {number}");
                    break;
                    //Console.WriteLine($"The number is: {Math.Abs(number)}");
                }
                else
                {
                    Console.WriteLine("Please write an even number.");
                }
                number = int.Parse(Console.ReadLine());
            }
        }
    }
}
