using System;
using static System.Console;
namespace SpookyCreatures
{
    public class MonsterCreation
    {
        // Name //
        public static string InputName()
        {
            string? creatureName = ReadLine();
            return creatureName ?? "Monster";
        }
        // Heads //
        public static double Heads()
        {
            double heads;
            bool results = Double.TryParse(ReadLine(), out heads);
            if (results == false)
            {
                WriteLine();
                Write("> Please Enter a Number! ");
                return Heads();
            }
            return heads;
        }
        // Eyes //
        public static double Eyes()
        {
            double eyes;
            bool results = Double.TryParse(ReadLine(), out eyes);
            if (results == false)
            {
                WriteLine();
                Write("> Please Enter a Number! ");
                return Eyes();
            }
            return eyes;
        }
        // Legs //
        public static double Legs()
        {
            double legs;
            bool results = Double.TryParse(ReadLine(), out legs);
            if (results == false)
            {
                WriteLine();
                Write("> Please Enter a Number! ");
                return Legs();
            }
            return legs;
        }
        // Arms //
        public static double Arms()
        {
            double arms;
            bool results = Double.TryParse(ReadLine(), out arms);
            if (results == false)
            {
                WriteLine();
                Write("> Please Enter a Number! ");
                return Arms();
            }
            return arms;
        }
        // Create a Monster Object //
        public static Monster CreateMonster(string name, double head, double eyes, double arms, double legs)
        {
            Monster newMonster = new Monster(name, head, eyes, arms, legs);
            return newMonster;
        }

    }
}

