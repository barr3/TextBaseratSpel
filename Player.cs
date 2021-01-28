using System;

namespace TextBaseratSpel
{
    //Class for player
    class Player
    {
        private int health;
        private int gold;
        private string[] inventory;

        //Constructor for the player class
        public Player(int health, int gold, string[] inventory)
        {
            this.health = health;
            this.gold = gold;
            this.inventory = inventory;
        }
        //Method for showing all the stats of the player
        public void ShowStats(){

            Console.WriteLine("You have " + health + " health.");
            Console.WriteLine("You have " + gold + " gold pieces.");
            Console.WriteLine("Your inventory is as follows: ");

            //Writes the players inventory
            if (inventory.Length == 0) {
                Console.WriteLine("Your inventory is empty");
            } else {
                for (int i = 0; i < inventory.Length; i++) {
                    Console.WriteLine(inventory[i] + "\n");
                }
            }

        }
        //Getter for the players' gold.
        public int GetGold(){
            return gold;
        }
        //Setter for the players' gold.
        public void SetGold(int gold){
            this.gold = gold;
        }
        //Getter for the players' health.
        public int GetHealth(){
            return health;
        }
        //Setter for the players' health.
        public void SetHealth(int health){
            this.health = health;
        }
        //Method for adding items to the inventory.
        //Might get rid of the inventory system alltogether.
        /*
        public void AddItem(string item){
            item = inventory[-1];
        }*/

    }

}
