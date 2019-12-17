using System;

namespace _10._Poke_Mon
{
    class Program
    {
        static void Main(string[] args)
        {
            // the poke power the Poke Mon has, N – an integer.
            // the distance between the poke targets, M – an integer.
            // the exhaustionFactor Y – an integer.

            int pokePower = int.Parse(Console.ReadLine()); // N
            int distance = int.Parse(Console.ReadLine()); // M
            int exhaustionFactor = int.Parse(Console.ReadLine());

            int originalPokepowerValue = pokePower;
            int pokedTargrtsCounter = 0;

            while (distance <= pokePower)
            {
                pokePower -= distance;
                //N - > pokePower became EXACTLY 50 % of its original value.
                if (pokePower == (originalPokepowerValue * 0.5))
                {
                    if (exhaustionFactor > 0)
                    {
                        pokePower /= exhaustionFactor;
                    }
                }
                pokedTargrtsCounter++;
            }
            Console.WriteLine((int)pokePower);
            Console.WriteLine(pokedTargrtsCounter);
        }
    }
}
