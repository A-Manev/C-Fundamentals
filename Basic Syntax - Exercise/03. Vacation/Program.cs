using System;

namespace _03._Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            string typeOfTheGroup = Console.ReadLine();
            string dayOfWeek = Console.ReadLine();
            double toralPrice = 0;
            switch (typeOfTheGroup)
            {
                case "Students":
                    if (dayOfWeek == "Friday")
                    {
                        toralPrice = people * 8.45;
                    }
                    else if (dayOfWeek == "Saturday")
                    {
                        toralPrice = people * 9.80;
                    }
                    else if (dayOfWeek == "Sunday")
                    {
                        toralPrice = people * 10.46;
                    }
                    if (people >= 30)
                    {
                        toralPrice *= 0.85;
                    }
                    break;
                case "Business":
                    if (dayOfWeek == "Friday")
                    {
                        toralPrice = people * 10.90;
                        if (people >= 100)
                        {
                            toralPrice = (people - 10) * 10.90;
                        }
                    }
                    else if (dayOfWeek == "Saturday")
                    {
                        toralPrice = people * 15.60;
                        if (people >= 100)
                        {
                            toralPrice = (people - 10) * 15.60;
                        }
                    }
                    else if (dayOfWeek == "Sunday")
                    {
                        toralPrice = people * 16;
                        if (people >= 100)
                        {
                            toralPrice = (people - 10) * 16;
                        }
                    }
                    break;
                case "Regular":
                    if (dayOfWeek == "Friday")
                    {
                        toralPrice = people * 15;
                    }
                    else if (dayOfWeek == "Saturday")
                    {
                        toralPrice = people * 20;
                    }
                    else if (dayOfWeek == "Sunday")
                    {
                        toralPrice = people * 22.50;
                    }
                    if (people >= 10 && people <= 20)
                    {
                        toralPrice *= 0.95;
                    }
                    break;
            }
            Console.WriteLine($"Total price: {toralPrice:f2}");

        }
    }
}
