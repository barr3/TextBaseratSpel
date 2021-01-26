using System;

namespace TextBaseratSpel
{
    class Program
    {

        static void Main(string[] args){


        Decision decision1 = new Decision(
            "Vill du slakta draken?",
            new string[] { "Ja", "Nej", "Korv", "Basketboll", "Bruh" },
            new string[] { "Du valde att slakta draken", "Du valde att inte slakta draken",
                           "Du valde korv", "Du valde basketboll", "Du valde bruh" });


        Console.WriteLine(decision1.ShowDecisions());

        }


    }

}
