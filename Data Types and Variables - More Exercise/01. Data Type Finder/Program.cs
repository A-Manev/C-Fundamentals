using System;
using System.Linq;

namespace _01._Data_Type_Finder
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = string.Empty;
            while ((command = Console.ReadLine()) != "END")
            {
                int intValue;
                double doubleValue;
                char charValue;
                bool boolValue;

                if (int.TryParse(command, out intValue))
                {
                    Console.WriteLine($"{intValue} is integer type");
                }
                else if (double.TryParse(command, out doubleValue))
                {
                    Console.WriteLine($"{command} is floating point type");
                }
                else if (char.TryParse(command, out charValue))
                {
                    Console.WriteLine($"{command} is character type");
                }
                else if (bool.TryParse(command, out boolValue))
                {
                    Console.WriteLine($"{command} is boolean type");
                }
                else
                {
                    Console.WriteLine($"{command} is string type");
                }
            }
        }
    }
}
