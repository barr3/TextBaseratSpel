using System;

namespace TextBaseratSpel
{
    //Class for player
    class Player
    {
        private string name;
        private int health;
        private int gold;
        private bool isDead;
        //private string[] inventory;

        //Constructor for the player class
        public Player(int health, int gold, string name, bool isDead)
        {
            this.health = health;
            this.gold = gold;
            this.name = name;
            this.isDead = isDead;
        }
        //Method for showing all the stats of the player
        public void ShowStats(){

            Console.WriteLine("You have " + health + " health.");
            Console.WriteLine("You have " + gold + " gold pieces.");


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

        //Setter for isDead
        public void SetDeathStatus(bool isDead){
            this.isDead = isDead;
        }

        public bool GetDeathStatus(){
            return isDead;
        }

        public string GetName(){
            return name;
        }

        //Method for adding items to the inventory.
        //Might get rid of the inventory system alltogether.
        /*
        public void AddItem(string item){
            item = inventory[-1];
        }*/


    }

}
