using System;

namespace TextBaseratSpel
{
    class Program
    {
        //private static int input;

        static void Main(string[] args){

            //GetDecision("Message", new string[] {"alt1", "alt2", "alt4"...);
            DrawCave();

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

        }


        static void DrawCave(){

            Console.WriteLine("_____________________________________________________________");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("_____________________________________________________________");

        }




        static int GetDecision(string message, string[] alt){
            int input;
            int decision = 0;
            int numberOfDecisions = alt.Length;


            Console.WriteLine(message);


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


            // Console.WriteLine(input);


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



        }
    }

}
