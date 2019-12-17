using System;

namespace _09._Chars_to_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstCharacter = Console.ReadLine();
            string secondCharacter = Console.ReadLine();
            string thirdCharacter = Console.ReadLine();

            string result = $"{firstCharacter}{secondCharacter}{thirdCharacter}";
            Console.WriteLine(result);
        }
    }
}
