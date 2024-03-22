using System;

namespace MyGame
{

    public class Enemy
    {
        private string name;
        private float health = 100;
        private float shield = 0;

        static private int powerPickedup;

        static Enemy()
        {
            powerPickedup = 0;
        }

        public Enemy(string name)
        {
            this.name = name;
            health = 100;
            shield = 0;
        }

        public float GetHealth()
        {
            return health;
        }
        public float GetShield()
        {
            return shield;
        }

        public string GetName()
        {
            return name;
        }
        public float GetPowerPickUp()
        {
            return powerPickedup;
        }
        public void SetName(string name)
        {
            int tamanho = 8;

            if(name.Length < 8)
            {
                this.name = name;
            }
            else
            {
                this.name = name.Substring(0, tamanho);
            }
        } 
        public void TakeDamage(float damage)
        {
            shield -= damage;
            if (shield < 0)
            {
                float damageStillToInflict = -shield;
                shield = 0;
                health -= damageStillToInflict;
            } 
            if (health < 0) health = 0;
        }

        public void PickUpPowerUp(PowerUp power, float x)
        { 
            if(power == PowerUp.Health)
            {
                this.health += x;
                this.health = MathF.Floor(100);
            }
            else if (power == PowerUp.Shield)
            {
                this.shield += x;
                this.shield = MathF.Floor(100);
            }
            powerPickedup += 1;
        }  
        
    }
}