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
            if (IsAwake && Hungry)
            {
                WriteLine();
                Write($"> {GetName()} is eating... You are no longer hungry. ");
                ReadLine();
                Hungry = false;
            }
            else if (!IsAwake)
            {
                WriteLine();
                Write($"> {GetName()} is sound asleep zzzzzz. You can't eat when you are sleeping. ");
                ReadLine();
            }
            else if (!Hungry)
            {

                WriteLine();
                Write($"> {GetName()} is not hungry right now. ");
                ReadLine();
            }

        }
        public void Sleep()
        {
            if (IsAwake)
            {
                WriteLine();
                Write($"> {GetName()} is sleeping zzzz ");
                ReadLine();
                IsAwake = false;
                Health += 10;

            }
            else
            {
                WriteLine();
                Write($"> {GetName()} is already asleep zzzz ");
                ReadLine();
            }

        }

        public void WakeUp()
        {
            if (!IsAwake)
            {
                WriteLine();
                Write($"> {GetName()} is awake! Your stomach starts to grumble... ");
                ReadLine();
                IsAwake = true;
                Hungry = true;
            }
            else
            {
                WriteLine();
                Write($"> {GetName()} is already awake! ");
                ReadLine();
            }
        }

        public void Scare()
        {
            if (!IsAwake)
            {
                WriteLine();
                Write($"> {GetName()} is sound asleep zzzzzz. You can't scare when you are sleeping. ");
                ReadLine();
            }
            else if (!Hungry && IsAwake)
            {
                WriteLine();
                WriteLine($"> BOOOOOOOOOOOOOOOOOOOO!!!!! That was a big scare!!!");
                WriteLine();
                Write("Your stomach starts to grumble");

                ReadLine();
                Hungry = true;
            }
            else if (Hungry)
            {
                WriteLine();
                Write($"> {GetName()} can't scare on an empty stomach... ");
                ReadLine();
            }

        }
        public void Attack()
        {
            WriteLine();
            Write($"> {GetName()} lashes forward!!!");
            Health -= 10;
            ReadLine();

        }

    }
}

