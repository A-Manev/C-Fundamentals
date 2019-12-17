using System;

namespace _03._Floating_Equality
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstFlotingPointNumber = double.Parse(Console.ReadLine());
            double secondFlotingPointNumber = double.Parse(Console.ReadLine());

            double difference = Math.Abs(firstFlotingPointNumber - secondFlotingPointNumber);
            if (difference < 0.000001)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }
    }
}
