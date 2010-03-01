using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ConsoleApplication1
{
    class Playstatus : Info
    {

        public void OnStrPotion()
        {
            if (onstrpot == 0)
            {
                enhancedstr = 0;
            }
            else
                if (onstrpot == 1)
                {
                    enhancedstr = 5;
                }
        }//check if player is on a strength potion


        public void Death()
        {
            if (playerhp <= 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("\nYou've been killed!");
                Thread.Sleep(2000);
                alive = false;
            }


        }//check if player has died

        
        public void Leveling()
        {
            if (playerlevel == 0)
            {
                playerlevel = 1;
            }
            if (playerlevel == 1)
            {
                playerxptolevel = 50;
            }
            else
                if (playerlevel == 2)
                {
                    playerxptolevel = 125;
                }
                else
                    if (playerlevel == 3)
                    {
                        playerxptolevel = 237;
                    }
                    else  
                    if (playerlevel == 4)
                    {
                        playerxptolevel = 405;
                    }
                    else
                        if (playerlevel == 5)
                        {
                            playerxptolevel = 650;
                        }
                        else
                            if (playerlevel == 6)
                            {
                                playerxptolevel = 1035;
                            }
                            else
                                if (playerlevel == 7)
                                {
                                    playerxptolevel = 1600;
                                }
                                else
                                    if (playerlevel == 8)
                                    {
                                        playerxptolevel = 2400;
                                    }
                                    else
                                        if (playerlevel == 9)
                                        {
                                            playerxptolevel = 3750;
                                        }
                                        else
                                            if (playerlevel == 10)
                                            {
                                                playerxptolevel = 5200;
                                            }

            
            playerremainingxptolevel = playerxptolevel - playerxp;
            if (playerxp >= playerxptolevel)
            {
                playerlevel = playerlevel + 1;
                playermaxhp = playermaxhp + 5;
                playerhp = playermaxhp;
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("You've gone up a level!\n");
                
                Thread.Sleep(2000);
                while (alive)
                {
                    Console.Clear();
                    Console.WriteLine("How many attributes would you like to improve?           Max: 3\n");
                    Console.WriteLine("Press Zero to put no points down\n");
                    Console.Write("Strength: ");
                    int upstr = int.Parse(Console.ReadLine());
                    Console.Write("\nCritical: ");
                    int upcrit = int.Parse(Console.ReadLine());
                    Console.Write("\nDefence: ");
                    int updef = int.Parse(Console.ReadLine());
                    sum = upstr + upcrit + updef;
                    if (sum > 3)
                    {
                        Console.WriteLine("\nYou've exeeded the limit.");
                        Thread.Sleep(1500);
                    }
                    else
                        if (sum < 3)
                        {
                            Console.WriteLine("Not enough improvements demanded.");
                            Thread.Sleep(1500);
                        }
                    if (sum == 3)
                    {
                        Console.WriteLine("\nAccept the following improvements?   y/n\n");
                        Console.WriteLine("Strength: {1} + {0}\n", upstr, playerstrength);
                        Console.WriteLine("Critical: {1} + {0}\n", upcrit, playerbasecritical);
                        Console.WriteLine("Defence:  {1} + {0}\n", updef, playerdefence);
                        string acceptall = Console.ReadLine();
                        if (acceptall == "y")
                        {
                            playerstrength = playerstrength + upstr;
                            playerbasecritical = playerbasecritical + upcrit;
                            playerdefence = playerdefence + updef;
                            Console.WriteLine("Your Attributes have improved!\n");
                            Thread.Sleep(2000);
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.White;
                            break;
                        }
                       
                            
                    }
                }


            }



        }//check if player has leveled up


        public void Items()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("                 Items");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Type the item you want to use, Or Press Any key to go back");
            Console.WriteLine("__________________________________________________________");
            if (potions > 0)
            {
                Console.WriteLine("Potion:  {0}\n", potions);
            }
            if (rattails > 0)
            {
                Console.WriteLine("Rat tails:  {0}\n", rattails);
            }
            if (strengthpotions > 0)
            {
                Console.WriteLine("Strength Potion: {0}\n", strengthpotions);
            }
            string chooseitem = Console.ReadLine();
            switch (chooseitem.ToLower())
            {
                case "strength potions":
                case "strength potion":
                    if (strengthpotions == 0)
                    {
                        Console.WriteLine("You have no potions in your Inventory");
                        Thread.Sleep(1500);
                        break;
                    }
                    else
                        if (strengthpotions > 0)
                        {
                            Console.WriteLine("Would you like to use the strength potion?   y/n");
                            string usespot = Console.ReadLine();
                            switch (usespot.ToLower())
                            {
                                case "y":
                                    onstrpot = 1;
                                    break;
                                case "n":
                                    break;
                            }
                        }
                    break;
                case "potions":
                case "potion":
                    if (potions == 0)
                    {
                        Console.WriteLine("You have no potions in your Inventory");
                        Thread.Sleep(1500);
                        break;
                    }
                    else
                        if (potions > 0)
                        {
                            Console.WriteLine("Would you like to use a potion?      y/n");
                            string askusepotion = Console.ReadLine();
                            switch (askusepotion.ToLower())
                            {
                                case "y":
                                    if (playerhp == playermaxhp)
                                    {
                                        Console.WriteLine("You do not need the potion right now.");
                                        Thread.Sleep(1500);
                                    }
                                    else
                                        usepotion();
                                    break;
                                case "n":
                                    break;
                            }
                        }
                    break;
                case "rat tails":
                case "rat tail":
                    if (rattails == 0)
                    {
                        Console.WriteLine("You have no rat tails");
                        Thread.Sleep(1500);
                        break;
                    }
                    else
                        if (rattails > 0)
                        {
                            Console.WriteLine("You can't use this item here");
                            Thread.Sleep(1500);
                            break;
                        }
                    break;
            }
        }//player wants to check inventory


        public void Karmastatus()//karma status
        {
            Console.Write("Karma: ");
            if (karma == 0)
            {
                karmadescription = "Neutral";
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.Write("{0}", karmadescription);
            }
            else
                if (karma >= 1 & karma <= 5)
                {
                    karmadescription = "Good";
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write("{0}", karmadescription);
                }
                else
                    if (karma >= -5 & karma < 0)
                    {
                        karmadescription = "bad";
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.Write("{0}", karmadescription);
                    }
                    else
                        if (karma > 5 & karma <= 10)
                        {
                            karmadescription = "White Knight";
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write("{0}", karmadescription);
                        }
                        else
                            if (karma >= -10 & karma < -5)
                            {
                                karmadescription = "Devil";
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.Write("{0}", karmadescription);
                            }
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.White;


        }


        public void usepotion()//go here when player uses a potion
        {
            playerhp = playerhp + 10;

            if (playerhp > playermaxhp)
            {
                playerhp = playermaxhp;
            }
            potions = potions - 1;
            Console.WriteLine("You've used one potion, your HP has been replenished to {0}", playerhp);
        }


        public void Sleep()//player sleeps at an inn
        {
            playerhp = playermaxhp;
            Thread.Sleep(1000);
            Console.WriteLine("\n You sleep soundly, fully replenishing your HP.\n");
            Thread.Sleep(2000);
           
        }

        
        public void Screen()//all status
        {

            while (alive)
            {
                Console.Clear();
                Leveling();
                pla.OnStrPotion();
                arm.Armorrating();
                wep.Weaponcalculation();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\n                     {0}'s Status", name);
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("__________________________________________________________");
                decimal one_percent = (decimal)(playermaxhp / 100.0);
                decimal value = (decimal)playerhp;
                Console.Write("Health:  ");
                if (value > (one_percent * 61))
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("{0}/{1} HP", playerhp, playermaxhp);
                }
                else if (value >= (one_percent * 26) && value <= (one_percent * 60))
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("{0}/{1} HP", playerhp, playermaxhp);
                }
                else if (value <= (one_percent * 25))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("{0}/{1} HP", playerhp, playermaxhp);
                }
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("         Level {0}\n", playerlevel);
                Console.WriteLine("Experience:  {0}/{1}      {2} Xp left to level Up", playerxp, playerxptolevel, playerremainingxptolevel);

                Console.Write("\nStrength: {0}", playerstrength);
                
                    if (playermaxstrength > playerstrength)
                    {
                        Console.Write(" + ");
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        totalplayermaxstr = weaponstrength + enhancedstr;
                        Console.Write("{0}", totalplayermaxstr);
                        Console.ForegroundColor = ConsoleColor.White;
                    }

                    Console.Write("\nAttack:   {0}", playerattack);
                
                    if (weaponattack > 0)
                    {
                        Console.Write(" + ");
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.Write("{0}", weaponattack);
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                
                    Console.Write("\nDefence:  {0}", playerdefence);
                
                    if (armordefence > 0)
                    {
                        Console.Write(" + ");
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.Write("{0}", armordefence);
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                
                    Console.Write("\nCritical: {0}", playerbasecritical);
                
                    if (playercritchance > 0)
                    {
                        Console.Write(" + ");
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.Write("{0}", playercritchance);
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                Console.WriteLine("\nGold: {0}", gold);
                Karmastatus();
                Console.WriteLine("__________________________________________________________");
                Console.WriteLine("1. View Quest Log");
                Console.WriteLine("2. View Items");
                Console.WriteLine("3. View Equipment");
                Console.WriteLine("__________________________________________________________");
                Console.WriteLine("Press Any key to go back");
                string status = Console.ReadLine();
                if (status == "1")
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("                 Quests\n\n");
                    Console.ForegroundColor = ConsoleColor.White;
                    que.QuestsName();
                    Console.Write("   Hex's Problem:         {0}", quest1name);
                    Console.Write("   Materials:             {0}", quest2name);
                    Console.Write("   Missing Friend:        {0}", quest3name);
                    Console.Write("   Helping Hand:          {0}", quest4name);
                    Console.Write("   Assasination:          {0}", quest5name);
                    Console.Write("   From Rags to Riches:   {0}", quest6name);
                    Console.WriteLine("\n\nPress Any key to go back");
                    Console.ReadLine();
                }
                else
                    if (status == "2")
                    {
                        Items();
                    }
                    else
                        if (status == "3")
                        {
                            Console.Clear();
                            wep.WeaponNames();
                            arm.ArmorNames();
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("              Equipped Items");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("_________________________________________________");
                            Console.WriteLine("Head:      {0}", helmname);
                            Console.WriteLine("Chest:     {0}", chestname);
                            Console.WriteLine("Weapon:    {0}", weaponname);
                            Console.WriteLine("Leggings:  {0}", legname);
                            Console.WriteLine("_________________________________________________");
                            arm.Armorrating();
                            Console.WriteLine("Weapon Damage:  {0}", weaponstrength);
                            Console.WriteLine("Weapon Attack:  {0}", weaponattack);
                            Console.WriteLine("Defence Rating: {0}", armordefence);
                            Console.WriteLine("_________________________________________________\n");
                            Console.WriteLine("1. Weapons");
                            Console.WriteLine("2. Armor");
                            Console.WriteLine("\nPress Any key to go back");
                            string what = Console.ReadLine();
                            if (what == "1")
                            {
                                Console.WriteLine("Select the weapon you wish to Equip or press Any key to go back");
                                Console.WriteLine("____________________________________________________________________");
                                if (numberofbronzedaggers > 0)
                                {
                                    Console.WriteLine("Bronze dagger  |   Strength: +3    Attack: +1     Critical: +10\n");
                                }
                                if (numberofbronzeswords > 0)
                                {
                                    Console.WriteLine("Bronze Sword   |   Strength: +5    Attack: +0     Critical: +0\n");
                                }
                                if (numberofironspears > 0)
                                {
                                    Console.WriteLine("Iron Spear     |   Strength: +3    Attack: +1     Critical: +5\n");
                                }
                                Console.WriteLine("____________________________________________________________________");
                                string equipweapon = Console.ReadLine();
                                switch (equipweapon.ToLower())
                                {
                                    case "bronze dagger":
                                    case "bronze daggers":
                                        if (numberofbronzedaggers > 0)
                                        {
                                            Console.WriteLine("You've equipped the Bronze Dagger");
                                            Thread.Sleep(1000);
                                            wep.EquipBronzeDagger();
                                        }
                                        break;
                                    case "bronze sword":
                                    case "bronze swords":
                                        if (numberofbronzeswords > 0)
                                        {
                                            Console.WriteLine("You've equipped the Bronze Sword");
                                            Thread.Sleep(1000);
                                            wep.EquipBronzeSword();
                                        }
                                        break;
                                    case "iron spear":
                                    case "iron spears":
                                        if (numberofironspears > 0)
                                        {
                                            Console.WriteLine("You've equipped the Iron Spear");
                                            Thread.Sleep(1000);
                                            wep.EquipIronSpear();
                                        }
                                        break;
                                }

                            }
                            else
                                if (what == "2")
                                {
                                    Console.WriteLine("Select the Armor you wish to equip or press Any key to go back");
                                    Console.WriteLine("____________________________________________________________________");
                                    if (numberofleatherhelms > 0)
                                    {
                                        Console.WriteLine("\nLeather Helmet       |      Defence: +1");
                                    }
                                    if (numberofleatherlegs > 0)
                                    {
                                        Console.WriteLine("\nLeather Leggings     |      Defence: +1");
                                    }
                                    if (numberofleatherchest > 0)
                                    {
                                        Console.WriteLine("\nLeather Chest        |      Defence: +1");
                                    }
                                    if (numberofironhelms > 0)
                                    {
                                        Console.WriteLine("\nIron Helmet          |      Defence: +2");
                                    }
                                    if (numberofironchest > 0)
                                    {
                                        Console.WriteLine("\nIron Chest           |      Defence: +2");
                                    }
                                    if (numberofironlegs > 0)
                                    {
                                        Console.WriteLine("\nIron Leggings        |      Defence: +2");
                                    }
                                    Console.WriteLine("____________________________________________________________________");
                                    string whatarmorwear = Console.ReadLine();
                                    switch (whatarmorwear.ToLower())
                                    {
                                        case "leather helm":
                                        case "leather helmet":
                                            if (numberofleatherhelms > 0)
                                            {
                                                Console.WriteLine("You've equipped the Leather Helmet");
                                                Thread.Sleep(1000);
                                                arm.EquipLeatherHelm();
                                            }
                                            break;
                                        case "leather leggings":
                                        case "leather legging":
                                        case "leather leg":
                                        case "leather legs":
                                            if (numberofleatherlegs > 0)
                                            {
                                                Console.WriteLine("You've equipped the Leather Leggings");
                                                Thread.Sleep(1000);
                                                arm.EquipLeatherLeg();
                                            }
                                            break;
                                        case "leather chest":
                                            if (numberofleatherchest > 0)
                                            {
                                                Console.WriteLine("You've equipped the Leather Chest");
                                                Thread.Sleep(1000);
                                                arm.EquipLeatherChest();
                                            }
                                            break;
                                        case "iron helm":
                                        case "iron helmet":
                                            if (numberofironhelms > 0)
                                            {
                                                Console.WriteLine("You've equipped the Iron Helmet");
                                                Thread.Sleep(1000);
                                                arm.EquipIronHelm();
                                            }
                                            break;
                                        case "iron leggings":
                                        case "iron legging":
                                        case "iron leg":
                                        case "iron legs":
                                            if (numberofironlegs > 0)
                                            {
                                                Console.WriteLine("You've equipped the Iron Leggings");
                                                Thread.Sleep(1000);
                                                arm.EquipIronLeg();
                                            }
                                            break;
                                        case "iron chest":
                                            if (numberofironchest > 0)
                                            {
                                                Console.WriteLine("You've equipped the Iron Chest");
                                                Thread.Sleep(1000);
                                                arm.EquipIronChest();
                                            }
                                            break;
                                    }
                                }
                        }
                        else
                        {
                            Console.Clear();
                            ma.Locations();
                        }
            }
        }
    }
}
