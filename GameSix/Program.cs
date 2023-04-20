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
            //Print all foes' names one by one
            for (int i = 0; i < FoesAvailable; i++)
            {
                Console.WriteLine("Foe " + (i + 1) + ": " + foes[i].GetName());
            }

             //PickupPowerUp test
            foes[0].PickupPowerUp(PowerUp.Health, 34.12f);
            foes[0].PickupPowerUp(PowerUp.Shield, 61.36f);

            //TakeDamage test
            foes[0].TakeDamage(44.47f);

            //Print all foes' health and shield
            for (int i = 0; i < FoesAvailable; i++)
            {
                Console.WriteLine(" Foe " + (i + 1) + ": " + foes[i].GetName() + " has " +
                foes[i].GetHealth() + " health and " + foes[i].GetShield() + " shield.");
            }

<<<<<<< HEAD
            // Print the power up count
            Console.WriteLine("Number of power ups: " + Foe.GetNumberOfPowerUps());

            Console.WriteLine("Merci d’utiliser ce programme!");
=======
            Console.WriteLine("Obrigado por ter usado este pograma!");
>>>>>>> 4e78279da843b0dd76694cf0f72b6070c0bf3c56
        }
    }
}