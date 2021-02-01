using System;

namespace TextBaseratSpel
{
    class Program
    {

        static void Main(string[] args){


            while (true) {

                //Start of program
                Player player = new Player(200, 10, "You", false);
                Console.Clear();
                player.ShowStats();
                int[] decisionStorer = new int[5];


                Player enemy1 = new Player(50, 0, "Enemy 1", false);
                Player enemy2 = new Player(50, 0, "Enemy 2", false);
                Player enemy3 = new Player(50, 0, "Enemy 3", false);


                //First Decision, at the bar.
                Decision barDecision = new Decision(
                    "You are sitting at a bar with your friends. You overhear someone shouting about a dart competition. What do you want to do?",
                    new string[] {"Order a beer", "Walk away", "Join the dart competition"},
                    new string[] {"You ordered a beer. You paid 1 gold coin for your beer and then you were thrown out because you had a little to much to drink.",
                                  "You walked out from the bar.",
                                  "You joined the dart competition. The fee for joining the competition was 2 gold pieces."
                    }
                );
                switch (decisionStorer[0] = barDecision.GetDecision()) {
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
                        if (dartComp.GetDecision() == 1) {
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

                //Switch for
                switch (decisionStorer[0]) {
                    case 1:
                        sleepOrNotString = "After stumbling out of the bar, a mysterious man walks up to you and gives you a piece of paper. You look at the paper and when you look up again, the man is gone.";
                        break;
                    case 2:
                        sleepOrNotString = "After walking out of the bar, a mysterious man walks up to you and gives you a piece of paper. You look at the paper and when you look up again, the man is gone.";
                        break;
                    case 3:
                        if (decisionStorer[1] == 1) {
                            sleepOrNotString = "After winning the dart competition, the organizer gave you not only 5 gold pieces, but also a mysterious piece of paper.";
                        } else {
                            sleepOrNotString = "After losing the dart competision, you walk outside to go home. Suddenly a mysterious man walks up to you and gives you a piece of paper. You look at the paper and when you look up again, the man is gone.";
                        }
                        break;
                    default:
                        sleepOrNotString = "";
                        break;
                }

                Decision sleepOrNot = new Decision(sleepOrNotString +"\nThe piece of paper said: \nMagic treasure in the cave under the tower of swallows. \nWhat do you do?",
                                                   new string[] {"Go home and sleep", "Go to the tower of the swallows."},
                                                   new string[] {"You chose to go home and sleep.", "You chose to go to the tower of swallows without sleeping"});

                decisionStorer[2] = sleepOrNot.GetDecision();
                AfterDecision();
                player.ShowStats();


                //Insert code to digest information from decision 2
                string fightScene;

                switch (decisionStorer[2]) {
                    case 2:
                        //Went home and slept
                        fightScene = "You walk to the tower of swallows. Once you arrive in the cave under the tower of swallows, you see a gang of three bandits. You sneak up on one of the bandits and strangle him. You succeed in killing him, but doing so you awake the others. \n'Prepare to fight' - One of the awoken bandits says. What do you say?";
                        enemy3.SetDeathStatus(true);
                        break;
                    case 1:
                        //Didnt sleep
                        fightScene = "After sleeping, you walk to the tower of swallows. Once you arrive in the cave under the tower of swallows, you see a gang of three bandits. They notice you while you walk in. \n'What are you doing here sneaking around? Prepare to die.' - One of the bandits says. What do you answer?";
                        break;
                    default:
                        fightScene ="";
                        break;
                }

                //Third decision/fight

                Decision FightScene = new Decision(fightScene, new string[] {"Please forgive me.", "No, you will die."}, new string[]{"The bandits didn't care. Prepare for a fight", "The bandits readied their swords."}) ;
                FightScene.GetDecision();
                //Fight fight1 = new Fight(new Player[] {player, enemy1, enemy2, enemy3});
                Fight fight1 = new Fight(player, enemy1, enemy2, enemy3);
                if (fight1.fight() == true) {
                    Console.WriteLine("You have lost the game. Press escape to exit, press any other key to play again");
                    if (Console.ReadKey(true).Key == ConsoleKey.Escape) {
                        break;
                    }

                    //Console.WriteLine("Bro you are dead ngl");
                }
                    //Console.WriteLine("Bro not dead");



                //Fourth Decision

                Decision afterWin = new Decision("After defeating the bandits, you find the treasure chest. In the chest you find 1000 gold coins. Do you want to go home and rest or party and celebrate the win?", new string[]{"I want to rest", "I want to party."}, new string[]{"You chose to rest.", "You chose to party"});
                string partyOrNot;

                switch (afterWin.GetDecision()) {
                    case 1:
                        partyOrNot = "You wake up 1000 gold coins richer. You look at your clock on the wall and see that it is way too early. What do you do.";
                        player.SetGold(player.GetGold() + 1000);
                        break;
                    case 2:
                        partyOrNot = "You wake up feeling a little tired. You look for the 1000 gold coins you found yesterday but you can't find them. You look up at the clock and see that it is way too early to be awake. What do you do?";
                        break;
                    default:
                        partyOrNot ="";
                        break;
                }
                AfterDecision();
                player.ShowStats();



                //Fifth decision
                Decision victory = new Decision(partyOrNot, new string[]{"Go to bed", "Sleep"}, new string[]{"You go back to bed, feeling lucky that you are even alive, because that is the real win.", "You go back to bed, feeling lucky that you are even alive, because that is the real win"});
                victory.GetDecision();

                AfterDecision();
                //Breaks loop is escape is pressed.
                Console.WriteLine("You have won the game. Press escape to exit, press any other key to play again");
                if (Console.ReadKey(true).Key == ConsoleKey.Escape) {
                    break;
                }

            }

        }

        static void AfterDecision(){
            Console.WriteLine("\nPress enter to continue");
            Console.ReadLine();
            Console.Clear();
        }

    }

}
