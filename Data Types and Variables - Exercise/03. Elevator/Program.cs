using System;

namespace _03._Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfPeople = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());

            double result = Math.Ceiling((double)numberOfPeople/ capacity);
            Console.WriteLine(result);
        }
    }
}
