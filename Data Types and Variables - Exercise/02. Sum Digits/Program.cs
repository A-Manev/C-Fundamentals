using System;
using System.Linq;

namespace _02._Sum_Digits
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            int sumOfDigits = 0;
            for (int i = 0; i < number.Length; i++)
            {
                int digit = int.Parse(number[i].ToString());
                sumOfDigits += digit;
            }
            Console.WriteLine(sumOfDigits);




            //int number = int.Parse(Console.ReadLine());

            //int sumOfDigits = 0;
            //while (number != 0)
            //{
            //    int digit = number % 10;
            //    sumOfDigits += digit;
            //    number /= 10;
            //}
            //Console.WriteLine(sumOfDigits);
        }
    }
}
