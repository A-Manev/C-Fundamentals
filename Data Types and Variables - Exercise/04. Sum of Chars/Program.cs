using System;

namespace _04._Sum_of_Chars
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfCharacters = int.Parse(Console.ReadLine());

            int sum = 0;
            for (int i = 0; i < numberOfCharacters; i++)
            {
                string character = Console.ReadLine();
                char symbol = char.Parse(character);
                sum += symbol;
            }
            Console.WriteLine($"The sum equals: {sum}");
        }
    }
}
