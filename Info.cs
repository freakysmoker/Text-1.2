using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Info
    {
        
        public static Map ma = new Map();
        public static Weapons wep = new Weapons();
        public static Playstatus pla = new Playstatus();
        public static Caves cav = new Caves();
        public static Cities cit = new Cities();
        public static Enemies ene = new Enemies();
        public static Quests que = new Quests();
        public static Armor arm = new Armor();
        public static Drops dro = new Drops();
        public static Battles bat = new Battles();



        //RELATED TO QUEST: HEX'S PROBLEM 1
        static public string quest1name;
        static public int talkedwhex;//talked with hex for the first time    
        static public int questgiven1;//quest has been given by hex
        static public int questcompleted1;//quest by hex has been completed
        static public int questsemicompleted1;//almost done the hex quest
        static public int talkedtomerchant1;//threatened the merchant
        static public int talkedtomerchant2;//made deal with merchant
        static public int killedmerchant;//killed the merchant during quest
        static public int sword;//weapon to kill merchant with. Non-reusable or visible.
        static public int receivedgold;//got gold from merchant
        static public int madedeal;//made a deal with the merchant


        //RELATED TO QUEST: MATERIALS 2
        static public string quest2name;
        static public int questgiven2;//player has accepted quest
        static public int questcompleted2;//player has brought 5 rat tails
        static public int questsemicompleted2;//player has acquired 5 rat tails
        static public int rattails;//number of item: rat tails
        


        //RELATED TO QUEST: MISSING FRIEND 3
        static public string quest3name;
        static public int questgiven3;
        static public int questcompleted3;
        static public int questsemicompleted3;
        static public int killedman;
        static public int questfailed3;
        static public int openedchest;
         
        //RELATED TO QUEST: HELPING HAND 4
        static public string quest4name;
        static public int questgiven4;
        static public int questcompleted4;
        static public int questsemicompleted4;
        static public int questfailed4;



        //RELATED TO QUEST: ASSASINATION 5
        static public string quest5name;
        static public int questgiven5;
        static public int questcompleted5;
        static public int questsemicompleted5;
        static public int killedguard;


        //RELATED TO QUEST: FROM RAGS TO RICHES 6
        static public string quest6name;
        static public int questgiven6;
        static public int questcompleted6;
        static public int questfailed6;





        //RELATED TO MAP EXPLORATION
        static public string cavemoorname;
        static public string stonecityname;
        static public int location;//current player's location
        static public int fight;//curent player's enemy
        static public int discoveredCavemoor;//player has visited cave moor
        static public int discoveredStoneCity;//player has visited stone city

        //RELATED TO STATUS MODIFIERS
        static public int onstrpot = 0;
        static public int totalplayermaxstr;
        static public int enhancedstr;

        //RELATED TO PLAYER STATUS
        static public bool alive = true;//player is alive
        static public string name;//player's name
        static public string karmadescription;//karma status visible to the player
        static public double playerhp = 20;//player HP
        static public double playermaxhp = 20;
        static public int playermaxstrength;// player str + weapon str
        static public int playermaxattack; //player atk + weapon atk
        static public int playerattack = 1; //how hard player's min hit does
        static public int playerstrength = 1;//how hard player hits
        static public int playerdefence = 1;//player's defence
        static public int karma;//numeric karma, invisible to the player
        static public int playerlevel;
        static public int playerxptolevel;
        static public int playerremainingxptolevel;
        static public int playerxp;//player's experience
        static public int sum;//amount of player stat improvement after level up
        static public int playerbasecritical = 1;//player's base crit chance
        



        //RELATED TO PLAYER'S WEAPONRY AND ARMOR
        static public string weaponname;
        static public string helmname;
        static public string chestname;
        static public string legname;
        static public int weaponattack;// how hard weapon's min hit does
        static public int weaponstrength; //how hard a weapon hits
        static public int armordefence;//how much ANY armor protects the player by adding all armors
        static public int helmarmor;//helm defence rating   
        static public int chestarmor;//chest defence rating
        static public int legarmor;//leg defence rating
        static public int hashelm;
        static public int haschest;
        static public int haslegs;
        static public int numberofleatherhelms;
        static public int numberofleatherchest;
        static public int numberofleatherlegs;
        static public int numberofironspears;
        static public int numberofironchest;
        static public int numberofbronzedaggers;//number of daggers player has
        static public int numberofbronzeswords;//number of swords player has
        static public int numberofironlegs;
        static public int numberofironhelms;



        //RELATED TO PLAYER'S INVENTORY
        static public int potions;//number of potions obtained by player
        static public int strengthpotions;//number of strength potions obtained by player
        static public int hasweapon;//player has ANY weapon 
        static public int gold;//how much gold player has





        //RELATED TO BATTLE INFORMATION
        static public int h;//how much player finally hits after calculations
        static public int n;//how much enemy hits after calculations
        static public int enemyattack;//attack rating of any enemy
        static public int enemystrength;//strength rating of any enemy
        static public int playercritchance;//chance player has to hit a critical
        static public int finalcriticalchance;//player's final crit chance
        static public int enemygreet = 1;


        //RELATED TO ENEMY INFORMATION
        static public string enemyname;
        static public int enemyhp;
        static public int enemymaxhp;
      

        //RELATED TO STONECITY ACTIONS
        static public int guardisout;
        
       




    }
}
