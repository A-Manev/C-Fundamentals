using System;

namespace _05._Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string correctPassord = Console.ReadLine();

            string passoword = string.Empty;
            int counter = 0;

            for (int i = username.Length - 1; i >= 0; i--)
            {
                passoword += username[i];
            }

            while (true)
            {
                if (correctPassord == passoword)
                {
                    Console.WriteLine($"User {username} logged in.");
                    break;
                }
                else
                {
                counter++;
                    if (counter == 4)
                    {
                        Console.WriteLine($"User {username} blocked!");
                        break;
                    }
                    Console.WriteLine("Incorrect password. Try again.");
                    correctPassord = Console.ReadLine();
                }
            }
            
        }
    }
}
