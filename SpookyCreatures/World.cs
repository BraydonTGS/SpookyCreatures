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
                        Write("> See you next time!");
                        break;
                    default:
                        WriteLine();
                        Write("> Please Enter a Valid Choice ");
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
            WriteLine();
            WriteLine(@"          (
           )  )
       ______(____
      (___________)
       /         \
      /           \
     |             |
 ____\             /____
()____'.__     __.'____()
jgs  .'` .'```'. `-.
    ().'`       `'.()

");
            WriteLine("> Enter The Following...");
            WriteLine();
            Write("> Enter a Name: ");
            string monsternName = MonsterCreation.InputName();
            WriteLine();
            Write("> Number of Heads: ");
            double heads = MonsterCreation.GetDouble();
            WriteLine();
            Write("> Number of Eyes: ");
            double eyes = MonsterCreation.GetDouble();
            WriteLine();
            Write("> Number of Legs: ");
            double legs = MonsterCreation.GetDouble();
            WriteLine();
            Write("> Number of Arms: ");
            double arms = MonsterCreation.GetDouble();
            Monster newMonster = MonsterCreation.CreateMonster(monsternName, heads, eyes, legs, arms);
            WriteLine();
            Thread.Sleep(2500);
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

            WriteLine();
            WriteLine($"> What a Monstrosity!!!");
            WriteLine();
            WriteLine($"> {newMonster.GetName()} Emerges from the Cauldron!!! ");
            WriteLine();
            WriteLine($"> Your stomach is grumbling...");
            WriteLine();
            Write("> Press Enter: ");
            ReadKey();
            MonsterMoves(newMonster);
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
            WriteLine("> What Would you like to do? ");
            WriteLine();
            WriteLine("> Eat ");
            WriteLine("> Sleep ");
            WriteLine("> Wake up ");
            WriteLine("> Scare ");
            WriteLine("> Attack ");
            WriteLine("> Exit ");

            WriteLine();
            Write("> Enter Your Selection: ");
            string selection = ReadLine().ToLower();

            switch (selection)
            {
                case "eat":
                    monster.Eat();
                    MonsterMoves(monster);
                    break;
                case "sleep":
                    monster.Sleep();
                    MonsterMoves(monster);
                    break;
                case "scare":
                    monster.Scare();
                    MonsterMoves(monster);
                    break;
                case "wake up":
                    monster.WakeUp();
                    MonsterMoves(monster);
                    break;
                case "attack":
                    monster.Attack();
                    MonsterMoves(monster);
                    break;
                case "exit":
                    Environment.Exit(0);
                    break;
                default:
                    WriteLine("> Invalid Selection Try Again. ");
                    ReadLine();
                    MonsterMoves(monster);
                    break;
            }
            Environment.Exit(0);

        }

    }
}

