using System;

namespace _01._Integer_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int fisrtInteger = int.Parse(Console.ReadLine());
            int secondInteger = int.Parse(Console.ReadLine());
            int thirdInteger = int.Parse(Console.ReadLine());
            int fourthInteger = int.Parse(Console.ReadLine());

            int result = (fisrtInteger + secondInteger) / thirdInteger * fourthInteger;
            Console.WriteLine(result);
        }
    }
}
