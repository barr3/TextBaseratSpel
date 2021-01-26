using System;
using System.Collections.Generic;

namespace TextBaseratSpel{

    public class Decision {

        private string message;
        private string[] alt;

        private string[] altMess;

        public Decision(string message, string[] alt, string[] altMess){

            this.message = message;

            for (int i = 0; i < alt.Length; i++) {
                this.alt[i] = alt[i];
            }

            for (int i = 0; i < altMess.Length; i++) {
                this.altMess[i] = altMess[i];
            }

            SetAlt(alt);
            SetAlt(altMess);

        }

        public void SetAlt(string[] alt){
            for (int i = 0; i < alt.Length; i++) {
                this.alt[i] = alt[i];
            }
        }

        public void SetAltMess(string[] altMess){
            for (int i = 0 ; i < altMess.Length; i++) {
                this.altMess[i] = altMess[i];
            }
        }


        public void ShowDecisions(string message, string[] altMess ){

            switch (GetDecision(message, alt)) {
                case 1:
                    Console.WriteLine(altMess[1]);
                    break;
                case 2:
                    Console.WriteLine(altMess[2]);
                    break;
                case 3:
                    Console.WriteLine(altMess[3]);
                    break;
                case 4:
                    Console.WriteLine(altMess[4]);
                    break;
                case 5:
                    Console.WriteLine(altMess[5]);
                    break;
                case 6:
                    Console.WriteLine(altMess[6]);
                    break;
                case 7:
                    Console.WriteLine(altMess[7]);
                    break;
                case 8:
                    Console.WriteLine(altMess[8]);
                    break;
            }


        }


        public  int GetDecision(string message, string[] alt){
            int input;
            int decision = 0;

            Console.WriteLine(message);

            //Try catch used for checking if the input is a
            //integer that corresponds with a possible answer.
            while (true) {

                try {
                    for (int i = 0; i < alt.Length; i++) {
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



        }


    }

}
