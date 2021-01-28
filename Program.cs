using System;

namespace TextBaseratSpel
{
    class Program
    {

        static void Main(string[] args){

            //Start of program
            Player player = new Player(100, 10, new string[] {});
            Console.Clear();
            player.ShowStats();

            /*

            Decision decision1 = new Decision(
                "Vill du slakta draken?",
                new string[] { "Ja", "Nej", "Korv", "Basketboll", "Bruh" },
                new string[] { "Du valde att slakta draken", "Du valde att inte slakta draken",
                               "Du valde korv", "Du valde basketboll", "Du valde bruh" });
            decision1.ShowDecisions(); */

            //Decision testDec = new Decision("Do you want to remove 50 health points?", new string[] {"Yes", "No"}, new string[] {"You have removed health", "You have not"});

            /*
            switch (testDec.ShowDecisions()) {
                case 1:
                    //int health = player.GetHealth();
                    player.SetHealth(player.GetHealth() - 50);
                    player.ShowStats();
                    break;
                case 2:
                    break;
            } */




            //End of Program
            Console.ReadLine();

        }


    }

}
