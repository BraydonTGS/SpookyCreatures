using System;
using static System.Console;
namespace SpookyCreatures
{
    public class World
    {
        string userChoice = "Y";

        // Run Method //
        public void Run()
        {
            while (userChoice == "Y")
            {
                Console.Clear(); 


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
                Write("Would you like to Create a Creature(Y/N)? ");
                string userAnswer = ReadLine().ToUpper();
                switch (userAnswer)
                {
                    case "Y":
                        PrintOptions();
                        break;
                    case "N":
                        Write("Next Time...");
                        userChoice = "N"; 
                        break;
                    default:
                        Write("Please Enter Y or N ");
                        break;
                }

                ReadKey();
            }
        }

        public void PrintOptions()
        {
            Console.Clear();
            WriteLine("Okay, Lets Begin");
        }


    }
}

