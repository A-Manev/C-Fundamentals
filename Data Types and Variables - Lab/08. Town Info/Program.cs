using System;

namespace _08._Town_Info
{
    class Program
    {
        static void Main(string[] args)
        {
            string townName = Console.ReadLine();
            decimal population = decimal.Parse(Console.ReadLine());
            int area = int.Parse(Console.ReadLine());

            string result = $"Town {townName} has population of {population} and area {area} square km.";
            Console.WriteLine(result);
        }
    }
}
