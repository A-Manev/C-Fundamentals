using System;

namespace _01._Encrypt__Sort_and_Print_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfString = int.Parse(Console.ReadLine());
            int stringSum = 0;
            int[] result = new int[numberOfString];
            for (int i = 0; i < numberOfString; i++)
            {
                stringSum = 0;
                string name = Console.ReadLine();
                for (int j = 0; j < name.Length; j++)
                {
                    int nameLenght = name.Length;
                    int letter = name[j];

                    switch (letter)
                    {
                        case 'a':
                        case 'e':
                        case 'i':
                        case 'o':
                        case 'u':
                        case 'A':
                        case 'E':
                        case 'I':
                        case 'O':
                        case 'U':
                            // vowel letter
                            stringSum += nameLenght * letter;
                            break;
                        default:
                            //consonant letter
                            stringSum += letter / nameLenght;
                            break;
                    }
                }
                result[i] += stringSum;
            }
            Array.Sort(result);
            Console.WriteLine(string.Join("\n", result));
        }
    }
}
