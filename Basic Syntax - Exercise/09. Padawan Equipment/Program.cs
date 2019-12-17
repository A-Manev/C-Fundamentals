using System;

namespace _09._Padawan_Equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double IvanChoMoney = double.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            double priceOfLightsabers = double.Parse(Console.ReadLine());
            double priceOfRobes = double.Parse(Console.ReadLine());
            double priceOfBelts = double.Parse(Console.ReadLine());

            double totalPriceForLightsabers =
                (students + (Math.Ceiling(students * 0.1))) * priceOfLightsabers;

            double totalPriceForRobes = students * priceOfRobes;

            double totalPriceForBelts = 0;

            if (students < 5)
            {
                totalPriceForBelts += students * priceOfBelts;
            }
            else
            {
                //double numberOfBelts = Math.Floor(students / 6.0);
                totalPriceForBelts = (students - Math.Floor(students / 6.0)) * priceOfBelts;
            }



            double totalPrice = totalPriceForLightsabers + totalPriceForRobes + totalPriceForBelts;

            if (totalPrice <= IvanChoMoney)
            {
                Console.WriteLine($"The money is enough - it would cost {totalPrice:f2}lv.");
            }
            else
            {
                double neededMoney = Math.Abs(IvanChoMoney - totalPrice);
                Console.WriteLine($"Ivan Cho will need {neededMoney:f2}lv more.");
            }
        }

    }
}
