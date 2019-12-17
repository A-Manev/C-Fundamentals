using System;

namespace _06._Strong_number
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int sevedNumber = number;
            int factorial = 1;
            int sum = 0;

            while (number != 0)
            {
                int digit = number % 10;

                factorial = 1;
                for (int i = 1; i <= digit; i++)
                {
                    factorial  *= i;
                }
                sum += factorial;
                number /= 10;
            }
            if (sum == sevedNumber)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
