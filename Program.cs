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
            int[] decisionStorer = new int[5];

            //First Decision, at the bar.
            Decision barDecision = new Decision(
                "You are sitting at a bar with your friends. You overhear someone shouting about a dart competition. What do you want to do?",
                new string[] {"Order a beer", "Walk away", "Join the dart competition"},
                new string[] {"You ordered a beer. You paid 1 gold coin for your beer and then you were thrown out because you had a little to much to drink.",
                              "You walked out from the bar.",
                              "You joined the dart competition. The fee for joining the competition was 2 gold pieces."
                }
            );
            switch (decisionStorer[0] = barDecision.ShowDecisions()) {
                case 1:
                    player.SetGold(player.GetGold() - 1);
                    break;
                case 2:
                    break;
                case 3:
                    player.SetGold(player.GetGold()-2);

                    Decision dartComp = new Decision(
                        "Win the dart competition",
                        new string[] {"Number one", "Option 2"},
                        new string[] {"You won the dart competition, the prize was 5 gold coins. You decide to go outside since you need some fresh air and because you are feeling tired.",
                                      "You lost the dart competition, you decide to go home."
                        }

                    );
                    //Checks wether the player won or lost the dart competion.
                    //Used for adding gold to the player, but also for the next decision
                    if (dartComp.ShowDecisions() == 1) {
                        player.SetGold(player.GetGold() + 5);
                        decisionStorer[1] = 1;
                    } else {
                        decisionStorer[1] = 2;
                    }
                    break;
            }
            AfterDecision();
            player.ShowStats();

            //Second Decision, after the bar scene.
            string sleepOrNotString;
            if (decisionStorer[0] == 1) {
                sleepOrNotString = "After stumbling out of the bar, a mysterious man walks up to you and gives you a piece of paper. You look at the paper and when you look up again, the man is gone.";
            }
            else if (decisionStorer[0] == 2) {
                sleepOrNotString = "After walking out of the bar, a mysterious man walks up to you and gives you a piece of paper. You look at the paper and when you look up again, the man is gone.";
            }
            else{

                if (decisionStorer[1] == 1) {
                    sleepOrNotString = "After winning the dart competition, the organizer gave you not only 5 gold pieces, but also a mysterious piece of paper.";
                } else {
                    sleepOrNotString = "After losing the dart competision, you walk outside to go home. Suddenly a mysterious man walks up to you and gives you a piece of paper. You look at the paper and when you look up again, the man is gone.";
                }

            }
            Decision sleepOrNot = new Decision(sleepOrNotString +"\nThe piece of paper said: \nMagic treasure in the cave under the tower of swallows. \nWhat do you do?",
                                               new string[] {"Go home and sleep", "Go to the tower of the swallows."},
                                               new string[] {"You chose to go home and sleep.", "You chose to go to the tower of swallows without sleeping"});

            decisionStorer[2] = sleepOrNot.ShowDecisions();
            AfterDecision();
            player.ShowStats();


            //Insert code to digest information from decision 2


            //Third decision





            //End of Program
            Console.ReadLine();

        }

        static void AfterDecision(){
            Console.WriteLine("\nPress enter to continue");
            Console.ReadLine();
            Console.Clear();
        }

    }

}
