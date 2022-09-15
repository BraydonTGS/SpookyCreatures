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
            try
            {
                double heads = Convert.ToDouble(ReadLine());
                return heads;
            }
            catch
            {
                WriteLine();
                Write("> Please Enter a Number! ");
                return Heads();

            }
        }
        // Eyes //
        public static double Eyes()
        {
            try
            {
                double eyes = Convert.ToDouble(ReadLine());
                return eyes;
            }
            catch
            {
                WriteLine();
                Write("> Please Enter a Number! ");
                return Eyes();
            }

        }
        // Legs //
        public static double Legs()
        {
            try
            {
                double legs = Convert.ToDouble(ReadLine());
                return legs;
            }
            catch
            {
                WriteLine();
                Write("> Please Enter a Number! ");
                return Legs();
            }

        }
        // Arms //
        public static double Arms()
        {
            try
            {
                double arms = Convert.ToDouble(ReadLine());
                return arms;
            }
            catch
            {
                WriteLine();
                Write("> Please Enter a Number! ");
                return Arms();
            }

        }

        // Create a Monster Object //
        public static Monster CreateMonster(string name, double head, double eyes, double arms, double legs)
        {
            Monster newMonster = new Monster(name, head, eyes, arms, legs);
            return newMonster;
        }




    }
}

