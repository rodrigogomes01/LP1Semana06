using System;

namespace GameSix
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ask user for the number of foes
            Console.Write("How many foes? ");
            int FoesAvailable = int.Parse(Console.ReadLine());

            //Sort foes in an array
            Foe[] foes = new Foe[FoesAvailable];

            //Ask the user for each foe's name
            for (int i = 0; i < FoesAvailable; i++)
            {
                Console.Write("Foe name " + (i + 1) + ": ");
                string name = Console.ReadLine();
                foes[i] = new Foe(name);
            }
        }
    }
}
