using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;

namespace blaisePascal.EnemyOrPlayer.Domain
{
    public class Player
    {

        private int _health;
        private int _experience;
        private int _level;

        public int Health
        {
            get { return _health; }
            private set
            {
                if (value < 0)
                {
                    _health = 0;
                }
                else if (value > MaxHealth)
                {
                    _health = MaxHealth;
                }
                else
                {
                    _health = value;
                }
            }
        }
        public int Level
        {
            get { return _level; }
            private set
            {
                if (value < 1)
                {
                    _level = 1;
                }
                else
                {
                    _level = value;
                }
            }
        }
        public int Experience
        {
            get { return _experience; }
            private set
            {
                if (value < 0)
                {
                    _experience = 0;
                }
                else if (value > 100)
                {
                    _experience = 100;
                }

                {
                    _experience = value;
                }
            }
        }
        public int MaxHealth { get; private set; }
        public Boolean IsAlive { get; private set; }
        public int Gold { get; private set; }
        public string Name { get; set; }


        public Player(string name)
        {
            Name = name;
            Level = 1;
            Experience = 0;
            MaxHealth = 100;
            Health = MaxHealth;
            IsAlive = true;
            Gold = 0;



        }
        public void AddExperience(int amount)
        {
            if (amount < 0)
            {
                throw new ArgumentException("Experience amount cannot be negative.");
            }
            Experience += amount;
            if (Experience >= 100)
            {
                Level += 1;
                Experience = 0;
            }
        }

        public void ResetExperience()
        {
            Experience = 0;
        }
        public void TakeDamage(int amount)
        {
            if (amount < 0)
            {
                throw new ArgumentException("Damage amount cannot be negative.");
            }
            Health -= amount;
            if (Health <= 0)
            {

                IsAlive = false;
            }
        }
        public void Heal(int amount)
        {
            if (amount < 0)
            {
                throw new ArgumentException("Heal amount cannot be negative.");
            }
            if (Health + amount <= MaxHealth)
            {
                Health += amount;
            }

        }
        public void AddGold(int amount)
        {
            if (amount < 0)
            {
                throw new ArgumentException("Gold amount cannot be negative.");
            }
            Gold += amount;
        }
        public void ResetHealth()
        {
            Health = MaxHealth;
            IsAlive = true;
        }
    }
}
