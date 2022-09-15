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
        // Getters // 

        public string GetName()
        {
            return MonsterName;
        }

        // Methods // 
        public void Eat()
        {
            WriteLine($"> {GetName()} is eating... ");
            Console.ReadLine();
            Hungry = false;
        }
        public void Sleep()
        {
            WriteLine($"> {GetName()} is sleeping zzzz ");
            Console.ReadLine();
            IsAwake = false;
        }
        public void Scare()
        {
            WriteLine($"> BOOOOOOOOOOOOOOOOOOOO!!!!!");
            Console.ReadLine();

        }
        public void Attack()
        {
            WriteLine($"> {MonsterName} lashes forward!!!");
            Health -= 10;
            Console.ReadLine();

        }

    }
}

