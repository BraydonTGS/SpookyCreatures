using System;
using static System.Console;
namespace SpookyCreatures
{
    public class World
    {
        bool userChoice = true;

        // Run Method //
        public void Run()
        {
            while (userChoice == true)
            {
                Clear();
                WriteLine(@"                                              ,           ^'^  _
                                              )               (_) ^'^
         _/\_                    .---------. ((        ^'^
         (('>                    )`'`'`'`'`( ||                 ^'^
    _    /^|                    /`'`'`'`'`'`\||           ^'^
    =>--/__|m---               /`'`'`'`'`'`'`\|
         ^^           ,,,,,,, /`'`'`'`'`'`'`'`\      ,
                     .-------.`|`````````````|`  .   )
                    / .^. .^. \|  ,^^, ,^^,  |  / \ ((
                   /  |_| |_|  \  |__| |__|  | /,-,\||
        _         /_____________\ |"")| |  |  |/ |_| \|
       ("")         |  __   __  |  '==' '=='  /_______\     _
      (' ')        | /  \ /  \ |   _______   |,^, ,^,|    ("")
       \  \        | |--| |--| |  ((--.--))  ||_| |_||   (' ')
     _  ^^^ _      | |__| |(""| |  ||  |  ||  |,-, ,-,|   /  /
   ,' ',  ,' ',    |           |  ||  |  ||  ||_| |_||   ^^^
.,,|RIP|,.|RIP|,.,,'==========='==''=='==''=='=======',,....,,,,.,ldb
");
                WriteLine("");
                Write("> Would you like to Create a Monster(Y/N)? ");
                string userAnswer = ReadLine().ToUpper();
                switch (userAnswer)
                {
                    case "Y":
                        userChoice = true;
                        GetUserInput();
                        break;
                    case "N":
                        userChoice = false;
                        WriteLine();
                        Write("See you next time!");
                        break;
                    default:
                        WriteLine();
                        Write("Please Enter a Valid Choice ");
                        break;
                }
                ReadKey();

            }
        }
        // User Input // 
        public void GetUserInput()
        {
            userChoice = false;

            Clear();
            WriteLine(@"            _.------.                        .----.__
           /         \_.       ._           /---.__  \
          |  O    O   |\\___  //|          /       `\ |
          |  .vvvvv.  | )   `(/ |         | o     o  \|
          /  |     |  |/      \ |  /|   ./| .vvvvv.  |\
         /   `^^^^^'  / _   _  `|_ ||  / /| |     |  | \
       ./  /|         | O)  O   ) \|| //' | `^vvvv'  |/\\
      /   / |         \        /  | | ~   \          |  \\
      \  /  |        / \ Y   /'   | \     |          |   ~
       `'   |  _     |  `._/' |   |  \     7        /
         _.-'-' `-'-'|  |`-._/   /    \ _ /    .    |
    __.-'            \  \   .   / \_.  \ -|_/\/ `--.|_
 --'                  \  \ |   /    |  |              `-
                       \uU \UU/     |  /   :F_P:");

            WriteLine("Enter The Following...");
            WriteLine();
            Write("> Name: ");
            string monsternName = MonsterCreation.InputName();
            WriteLine();
            Write("> Number of Heads: ");
            double heads = MonsterCreation.Heads();
            WriteLine();
            Write("> Number of Eyes: ");
            double eyes = MonsterCreation.Eyes();
            WriteLine();
            Write("> Number of Legs: ");
            double legs = MonsterCreation.Legs();
            WriteLine();
            Write("> Number of Arms: ");
            double arms = MonsterCreation.Arms();
            WriteLine();
            WriteLine("What a Monstrosity!!!");
            Thread.Sleep(2500);
            Monster newMonster = MonsterCreation.CreateMonster(monsternName, heads, eyes, legs, arms);
            MonsterMoves(newMonster);
            ReadKey();
        }

        public void MonsterMoves(Monster monster)
        {
            Clear();
            WriteLine(@"                                  ,--,  ,.-.
               ,                   \,       '-,-`,'-.' | ._
              /|           \    ,   |\         }  )/  / `-,',
              [ ,          |\  /|   | |        /  \|  |/`  ,`
              | |       ,.`  `,` `, | |  _,...(   (      .',
              \  \  __ ,-` `  ,  , `/ |,'      Y     (   /_L\
               \  \_\,``,   ` , ,  /  |         )         _,/
                \  '  `  ,_ _`_,-,<._.<        /         /
                 ', `>.,`  `  `   ,., |_      |         /
                   \/`  `,   `   ,`  | /__,.-`    _,   `\
               -,-..\  _  \  `  /  ,  / `._) _,-\`       \
                \_,,.) /\    ` /  / ) (-,, ``    ,        |
               ,` )  | \_\       '-`  |  `(               \
              /  /```(   , --, ,' \   |`<`    ,            |
             /  /_,--`\   <\  V /> ,` )<_/)  | \      _____)
       ,-, ,`   `   (_,\ \    |   /) / __/  /   `----`
      (-, \           ) \ ('_.-._)/ /,`    /
      | /  `          `/ \\ V   V, /`     /
   ,--\(        ,     <_/`\\     ||      /
  (   ,``-     \/|         \-A.A-`|     /
 ,>,_ )_,..(    )\          -,,_-`  _--`
(_ \|`   _,/_  /  \_            ,--`
 \( `   <.,../`     `-.._   _,-`");

            WriteLine();
            WriteLine($"{monster.GetName()}is approaching ... ");
            ReadKey();

        }

    }
}

