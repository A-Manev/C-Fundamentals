using System;
using System.Linq;

namespace _04._Reverse_Array_of_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] texts = Console.ReadLine().Split();

            //3th way
            for (int i = texts.Length - 1; i >= 0; i--)
            {
                Console.Write(texts[i] + " ");
            }
            Console.WriteLine();


            //2nd way
            //texts = texts.Reverse().ToArray();
            //Console.WriteLine(string.Join(" ", texts));


            //1st way
            //for (int i = 0; i < texts.Length / 2; i++)
            //{
            //    string first = texts[i];
            //    string last = texts[texts.Length - i - 1];

            //    texts[i] = last;
            //    texts[texts.Length - i - 1] = first;
            //}
            //Console.WriteLine(string.Join(" ", texts));
        }
    }
}
