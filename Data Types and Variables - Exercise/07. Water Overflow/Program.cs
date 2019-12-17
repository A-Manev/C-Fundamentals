using System;

namespace _07._Water_Overflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfLines = int.Parse(Console.ReadLine());

            int waterTankCapacity = 0; //leters

            for (int i = 0; i < numberOfLines; i++)
            {
                int liters = int.Parse(Console.ReadLine());
                waterTankCapacity += liters;
                if (waterTankCapacity > 255)
                {
                    Console.WriteLine("Insufficient capacity!");
                    waterTankCapacity -= liters;
                }
            }
            Console.WriteLine(waterTankCapacity);
        }
    }
}
