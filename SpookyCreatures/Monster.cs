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
        private bool IsAlive = true;

        public Monster(string name, double head, double eyes, double arms, double legs)
        {
            MonsterName = name;
            Head = head;
            Eyes = eyes;
            Arms = arms;
            Legs = legs;
            IsAlive = true;
        }

        public string GetName()
        {
            return MonsterName;
        }

    }
}

