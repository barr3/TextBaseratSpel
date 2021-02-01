using System;

namespace TextBaseratSpel
{

    class Decision {

        private string message; //Message/Story that the user gets shown.
        private string[] alt; //Array for the alternatives the user can choose.
        private string[] altMess; //Array for the the messages that show the users decision.

        //Constructor for making a decision object.
        public Decision(string message, string[] alt, string[] altMess)
        {
            this.message = message;
            this.alt = alt;
            this.altMess = altMess;
        }
        //Calls GetDecision (see below) and types out the corresponding message to show to the user
        //after choosing one of the decisions.

        //Method for writing out the possible options that the player can choose and returns the input.
        public int GetDecision(){
            int input;
            Console.Write("\n");
            Console.WriteLine(message);

            //Try catch used for checking if the input is a
            //integer that corresponds with a possible answer.
            while (true) {
                Console.Write("\n");
                try {
                    for (int i = 0; i < alt.Length; i++) {
                        Console.WriteLine(i + 1 + ": " +  alt[i]);
                    }
                    Console.Write("\n");
                    input = int.Parse(Console.ReadLine());
                    break;

                } catch {
                    Console.Clear();
                    Console.WriteLine("Please choose one of the options.");
                    Console.Write("\n");
                    Console.WriteLine(message);
                }

            }

            int dec = input;

            //Checks if the input from the user is a integer that is not an option.
            while (dec > alt.Length || dec < 1) {
                Console.Clear();
                Console.WriteLine("Please choose one of the options.");
                dec = GetDecision();
            }

            //Prints out the message that shows what decision the player made.
            //Console.Write("\n");
            Console.Clear();
            Console.WriteLine(altMess[dec-1]);

            return dec;

        }

    }

}
