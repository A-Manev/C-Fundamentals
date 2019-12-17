using System;
using System.Numerics;

namespace _11._Snowballs
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberOfsnowballs = int.Parse(Console.ReadLine());

            var snowballSnow = 0;
            var snowballTime = 0;
            var snowballQuality = 0;

            var snowballSnowMaxValue = 0;
            var snowballTimeMaxValue = 0;
            var snowballQualityMaxValue = 0;

            BigInteger snowballValue = 0;
            BigInteger maxValue = 0;
            for (int i = 0; i < numberOfsnowballs; i++)
            {
                 snowballSnow = int.Parse(Console.ReadLine());
                 snowballTime = int.Parse(Console.ReadLine());
                 snowballQuality = int.Parse(Console.ReadLine());

               
                snowballValue = BigInteger.Pow((BigInteger)snowballSnow / snowballTime, snowballQuality);

                if (snowballValue > maxValue)
                {
                    maxValue = snowballValue;
                    snowballSnowMaxValue = snowballSnow;
                    snowballTimeMaxValue = snowballTime;
                    snowballQualityMaxValue = snowballQuality;
                }
            }
            Console.WriteLine($"{snowballSnowMaxValue} : {snowballTimeMaxValue} = {maxValue} ({snowballQualityMaxValue})");
        }
    }
}
