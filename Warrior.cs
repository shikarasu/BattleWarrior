using System;

namespace BattleWarrior
{
    internal class Warrior
    {
        public string Name { get; set; } = "Warrior";
        public double Health { get; set; } = 0;
        private double AttkMax { get; set; } = 0;
        private double BlockMax { get; set; } = 0;

        readonly Random rnd = new Random();

        public Warrior(string name = "Warrior", double health = 0, double attkMax = 0, double blockMax = 0)
        {
            Name = name;
            Health = health;
            AttkMax = attkMax;
            BlockMax = blockMax;
        }

        public double Attack()
        {
            return rnd.Next(1, (int) AttkMax);
        }

        public double Block()
        {
            return rnd.Next(1, (int) BlockMax);
        }
    }
}