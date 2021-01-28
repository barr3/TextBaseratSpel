using System;

namespace TextBaseratSpel
{

    class Decision {

        private string message;
        private string[] alt;


        private string[] altMess;

        public Decision(string message, string[] alt, string[] altMess)
        {

            this.message = message;

            this.alt = alt;
            this.altMess = altMess;

        }


        private void SetAlt(string[] alt){
            for (int i = 0; i < alt.Length; i++) {
                this.alt[i] = alt[i];
            }
        }

        private void SetAltMess(string[] altMess){
            for (int i = 0 ; i < altMess.Length; i++) {
                this.altMess[i] = altMess[i];
            }
        }



        public int ShowDecisions(){
            int dec = GetDecision();

            while (dec > alt.Length) {
                Console.WriteLine("Vänligen ange ett alternativ");
                dec = GetDecision();
            }

            Console.WriteLine(altMess[dec-1]);

            return dec;

        }

        private int GetDecision(){
            int input;

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
                    Console.Clear();
                    Console.WriteLine("Vänligen välj ett av alternativen");
                    Console.WriteLine(message);
                }

            }

            //returns what decision was made by the user.
            return input;



        }

    }

}
