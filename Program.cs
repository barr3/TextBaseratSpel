using System;

namespace TextBaseratSpel
{
    class Program
    {
        //private static int input;

        static void Main(string[] args){

            //GetDecision("Message", new string[] {"alt1", "alt2", "alt4"...);

           // DecisionChooser(1);



            Decision decision1 = new Decision("Vill du slakta draken?",
                                              new string[]{ "Ja", "Nej", "Korv", "Basketboll", "Bruh"},
                                              new string[]{"Du valde att slakta draken",
                                                           "Du valde att inte slakta draken",
                                                           "Du valde korv",
                                                           "Du valde basketboll",
                                                           "Du valde bruh"});






            // switch (GetDecision("Vill du slakta draken?", new string[] {"Ja", "Nej", "Kanske", "Falukorv"})) {
            //     case 1:
            //         Console.WriteLine("Du valde att slakta draken");
            //         break;
            //     case 2:
            //         Console.WriteLine("Du valde att inte slakta draken");
            //         break;
            //     case 3:
            //         Console.WriteLine("Du valde att kanske slakta draken");
            //         break;

            //     case 4:
            //         Console.WriteLine("Du valde att äta falukorv");
            //         break;
            // }

        }

        /*
        static void DecisionChooser(int decision){

            switch (decision) {
                case 1:
                    Decision1();
                    break;
                case 2:
                    Decision2();
                    break;
                default:
                    break;
            }



        } */

        //Puts the first decision in a method.
        /*static void Decision1(){

            switch (GetDecision("Vill du slakta draken?", new string[] {"Ja", "Nej", "Kanske", "Falukorv"})) {
                case 1:
                    Console.WriteLine("Du valde att slakta draken");
                    break;
                case 2:
                    Console.WriteLine("Du valde att inte slakta draken");
                    break;
                case 3:
                    Console.WriteLine("Du valde att kanske slakta draken");
                    break;

                case 4:
                    Console.WriteLine("Du valde att äta falukorv");
                    break;
            }

        } */

        //Second decision
        /*static void Decision2(){



        } */




        //Takes message and possible answers and displays them.
        /*static int GetDecision(string message, string[] alt){
            int input;
            int decision = 0;
            int numberOfDecisions = alt.Length;


            Console.WriteLine(message);

            //Try catch used for checking if the input is a
            //integer the corresponds with a possible answer.
            while (true) {

                try {
                    for (int i = 0; i < numberOfDecisions; i++) {
                         Console.WriteLine(i + 1 + ": " +  alt[i]);
                    }


                    input = int.Parse(Console.ReadLine());

                    break;

                } catch {
                    Console.WriteLine("du gjorde fel, prova igen");
                    Console.WriteLine(message);

                }



            }

            //returns what decision was made by the user.
            switch (input) {
                case 1:
                    decision = 1;
                    break;
                case 2:
                    decision = 2;
                    break;
                case 3:
                    decision = 3;
                    break;
                case 4:
                    decision = 4;
                    break;
                case 5:
                    decision = 5;
                    break;
                case 6:
                    decision = 6;
                    break;
                case 7:
                    decision = 7;
                    break;
                case 8:
                    decision = 8;
                    break;
                default:
                    //Fixa default
                    Console.WriteLine("fixa default");
                    break;
            }

            return decision;



        } */
    }

}
