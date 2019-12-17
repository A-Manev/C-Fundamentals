using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;

namespace _01._Sort_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOne = int.Parse(Console.ReadLine());
            int numberTwo = int.Parse(Console.ReadLine());
            int numberThree = int.Parse(Console.ReadLine());

            int[] numbers = {numberOne, numberTwo, numberThree};
            Array.Sort(numbers);
            Array.Reverse(numbers);
            Console.WriteLine(string.Join(Environment.NewLine, numbers));


        }
    }
}
