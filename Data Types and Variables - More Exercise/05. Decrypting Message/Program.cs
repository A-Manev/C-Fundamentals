using System;

namespace _05._Decrypting_Message
{
    class Program
    {
        static void Main(string[] args)
        {
            int key = int.Parse(Console.ReadLine());
            int numberOfLines = int.Parse(Console.ReadLine());
            int counter = numberOfLines;
            string message = string.Empty;
            while (counter > 0)
            {
                message += ((char)(char.Parse(Console.ReadLine()) + key)).ToString();
                counter--;
            }
            Console.WriteLine(message);
        }
    }
}
            //int key = int.Parse(Console.ReadLine());
            //int numberOfLines = int.Parse(Console.ReadLine());
            //string[] word = new string[numberOfLines];

            //for (int i = 0; i < word.Length; i++)
            //{
            //    char letter = char.Parse(Console.ReadLine());
            //    letter += (char)key;
            //    word[i] += letter.ToString();
            //}
            //Console.Write(string.Join("", word));
