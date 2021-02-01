using System;

namespace TextBaseratSpel
{

    class Fight
    {
        //Takes 4
        private Player fighter1;
        private Player fighter2;
        private Player fighter3;
        private Player fighter4;
        private int numOfEnemies;

        Random rnd = new Random();

        public Fight(Player fighter1, Player fighter2, Player fighter3, Player fighter4)
        {
            this.fighter1 = fighter1;
            this.fighter2 = fighter2;
            this.fighter3 = fighter3;
            this.fighter4 = fighter4;
            numOfEnemies = 3;

            //If the third enemy already is dead.
            if (fighter4.GetDeathStatus() == true){
                numOfEnemies = 2;
                fighter4 = null;
                //fighter4.SetHealth(0);
            }

        }

        //Runs the fight code. Returns bool depending on if the player survives or not.
        public bool fight(){
            bool isDead;
            bool isPlayersTurn = true;
            bool isFight = true;
            isDead = false;
            while(isFight){
                //Runs if it is the players turn
                if (isPlayersTurn) {
                    //Run Code To make player fight
                    PrintFight();
                    Console.WriteLine("Who do you want to attack? Please type the number of the enemy you want to attack.");

                    int input;
                    while (true) {
                        try {
                            Console.Write("\nEnemy #: ");

                            input = int.Parse(Console.ReadLine());
                            break;
                        } catch {
                            Console.Clear();
                            Console.WriteLine("Please choose one of the options.");
                            Console.Write("\n");
                            PrintFight();
                        }

                    }

                    while (input > numOfEnemies || input <= 0) {
                        Console.Clear();
                        Console.WriteLine("Please choose an enemy");
                        fight();
                    }


                    switch (input) {
                        case 1:
                            attack(fighter2, fighter1);
                            break;
                        case 2:
                            attack(fighter3, fighter1);
                            break;
                        case 3:
                            attack(fighter4, fighter1);
                            break;
                    }

                    isPlayersTurn = false;
                //Runs if it is the enemies' turn
                } else {
                    int attacker;
                    //Maybe fix later
                    if (fighter4 == null) {
                        attacker = rnd.Next(1,2);
                    } else {
                        attacker = rnd.Next(1,3);
                    }

                    switch (attacker) {
                        case 1:
                            attack(fighter1, fighter2);
                            break;
                        case 2:
                            attack(fighter1, fighter3);
                            break;
                        case 3:
                            attack(fighter1, fighter4);
                            break;
                    }

                    isPlayersTurn = true;

                }

                //Call code to signal that the enemy has died.

                if (fighter1.GetDeathStatus() == true) {
                    Console.Clear();
                    //Console.WriteLine("You have died");
                    isFight = false;
                    isDead = true;
                } else if (fighter2.GetDeathStatus() == true
                           && fighter3.GetDeathStatus() == true
                           && fighter4.GetDeathStatus() == true) {
                    Console.Clear();
                    //Console.WriteLine("You have defeated them");
                    isFight = false;
                    isDead = false;
                }

            }

            return isDead;

        }

        //Code that attacks
        public void attack(Player attacked, Player attacker){

            if (attacked.GetHealth() <= 0) {
                Console.WriteLine($"\n{attacked.GetName()} is already dead.\n");
                return;
            }


            int damage = rnd.Next(10,90);

            attacked.SetHealth(attacked.GetHealth()- damage);

            if (attacked.GetHealth() <= 0) {
                Console.WriteLine($"{attacker.GetName()} killed {attacked.GetName()}");
                attacked.SetDeathStatus(true);
            } else {
                Console.WriteLine($"{attacker.GetName()} damaged {attacked.GetName()} for {damage} health points.");
            }

            Console.WriteLine("Press enter to continue");
            Console.ReadLine();
            Console.Clear();

        }

        //Prints the status of all the enemies.
        public void PrintFight(){



            if (fighter2.GetDeathStatus() == false) {
                //if alive
                Console.Write("\n");
                Console.WriteLine("Enemy number 1 is alive. \nHe/She has {0} health", fighter2.GetHealth());

            } else {
                //if dead
                Console.Write("\n");
                Console.WriteLine("Enemy 1 is dead");
            }

            if (fighter3.GetDeathStatus() == false) {
                //if alive
                Console.Write("\n");
                Console.WriteLine("Enemy number 2 is alive. \nHe/She has {0} health", fighter3.GetHealth());
            } else {
                //if dead
                Console.Write("\n");
                Console.WriteLine("Enemy 2 is dead");
            }

            if (fighter4 != null) {

                if (fighter4.GetDeathStatus() == false) {
                    //if alive
                    Console.Write("\n");
                    Console.WriteLine("Enemy number 3 is alive. \nHe/She has {0} health", fighter4.GetHealth());
                } else {
                    //if dead
                    Console.Write("\n");
                    Console.WriteLine("Enemy 3 is dead");
                }

            }

            Console.Write("\n");
        }

    }

}
