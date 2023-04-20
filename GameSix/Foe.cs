using System;

namespace GameSix
{
    public class Foe
    {
        private string name;
        private float health;
        private float shield;

        //Constructor
        public Foe(string name)
        {
            this.name = name;
            health = 100;
            shield = 0;
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
    }
}