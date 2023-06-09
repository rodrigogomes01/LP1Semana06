using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameSixFriday
{
    public class Foe
    {
        private string name;
        private float health;
        private float shield;

        private static int NumberOfPowerUps;

        //Constructor
        public Foe(string name)
        {
            this.name = name;
            health = 100;
            shield = 0;
            NumberOfPowerUps = 0;
        }
        public string GetName()
        {
            return name;
        }
        public string GetShield()
        {
            return name;
        }
        public string GetHealth()
        {
            return name;
        }

        public static int GetNumberofPowerUps()
        {
            return NumberOfPowerUps;
        }
            
        //Change the name of the enemy
        public void SetName(string name)
        {
            //Get the name without spaces and remove them
            this.name = name;
            name = name.Trim();
        }
        public void TakeDamage(float damage)
        {
            shield -= damage;
            if (shield < 0)
            {
                float damageStillToInflict = -shield;
                shield = 0;
                health -= damageStillToInflict;
                if (health < 0) health = 0;
            }
        }
        public void PickupPowerUp(PowerUp power_up, float amount)
        {
            if (power_up == PowerUp.Health)
            {
                health += amount;
                if (health > 100) health = 100;
            }
            else if (power_up == PowerUp.Shield)
            {
                shield += amount;
                if (shield > 100) shield = 100;
            }
        }
    }
}