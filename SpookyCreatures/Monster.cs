using System;
using static System.Console;
namespace SpookyCreatures
{
    public class Monster
    {
        private string MonsterName;
        private double Head;
        private double Eyes;
        private double Arms;
        private double Legs;
        private int Health;
        private bool IsAlive = true;
        private bool IsAwake = true;
        private int Level;
        private bool Hungry;

        public Monster(string name, double head, double eyes, double arms, double legs)
        {
            MonsterName = name;
            Head = head;
            Eyes = eyes;
            Arms = arms;
            Legs = legs;
            Health = 100;
            IsAlive = true;
            IsAwake = true;
            Level = 1;
            Hungry = true;

        }

        public string GetName()
        {
            return MonsterName;
        }

    }
}

