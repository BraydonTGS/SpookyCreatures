using System;
using static System.Console;
namespace SpookyCreatures
{
    public class MonsterCreation
    {

        public static string InputName()
        {
            string? creatureName = ReadLine();
            return creatureName ?? "Monster";
        }

        public static double GetDouble()
        {
            if (Double.TryParse(ReadLine(), out var num))
            {
                return num;
            }
            WriteLine();
            Write("> Please Enter a Number! ");
            return GetDouble();

        }

        public static Monster CreateMonster(string name, double head, double eyes, double arms, double legs)
        {
            Monster newMonster = new Monster(name, head, eyes, arms, legs);
            return newMonster;
        }

    }
}

