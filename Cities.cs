using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ConsoleApplication1
{
    class Cities : Info
    {
        public void Shang()
        {
            location = 1;

            Console.WriteLine("You're standing in front of Shang Castle's Entrance Gate.\n");
            while (alive)
            {
                
                Console.WriteLine("location: Castle Entrance\n");//current player location
                Console.WriteLine("1. Talk to Gatekeeper");//talk to hex
                Console.WriteLine("2. Visit Town Square");//go to Town Square
                Console.WriteLine("3. View Status Screen");//view status screen
                if (questcompleted1 == 1)
                {
                    Console.WriteLine("4. Leave Shang Castle");
                }
                string what = Console.ReadLine();
                Console.Clear();
                if (what == "1")//talk to hex
                {
                    que.Hexquest();
                }
                else
                    if (what == "2")//player goes to Town Square
                    {
                        Console.WriteLine("     You walk towards the crowded and noisy Town Square\n");

                        Console.Clear();

                        while (alive)
                        {
                            Console.Clear();
                            Console.WriteLine("Location: Town Square\n");
                            Console.WriteLine("1. Visit the General shop");
                            Console.WriteLine("2. Visit the Weapons shop");
                            Console.WriteLine("3. Visit the Armor shop");
                            Console.WriteLine("4. Visit the Pawnshop");
                            Console.WriteLine("5. Visit Sun's Inn");
                            Console.WriteLine("\nPress Any key to go back");
                            string what2 = Console.ReadLine();
                            Console.Clear();
                            if (what2 == "1" & receivedgold == 1)
                            {
                                Console.WriteLine("I should go back and talk to hex");
                                Thread.Sleep(1500);

                            }
                            else
                                if (what2 == "1")
                                {
                                    Console.WriteLine("You enter the General store.\n");
                                    Thread.Sleep(1500);
                                    Console.WriteLine("Clerk: Hello, what can i do for you today?\n");
                                    while (alive)
                                    {
                                        Console.WriteLine("1. Buy Items");
                                        Console.WriteLine("2. Sell Items");
                                        Console.WriteLine("\nPress Any key to go back");
                                        string generalstore = Console.ReadLine();
                                        Console.Clear();
                                        if (generalstore == "1")
                                        {
                                            Console.WriteLine("Clerk: Certainly, here's my products\n");
                                            Console.WriteLine("1. Potions       10 Gold each");
                                            string generalbuy = Console.ReadLine();
                                            if (generalbuy == "1")
                                            {
                                                Console.Write("Clerk: How many would you like?          ");
                                                Console.ForegroundColor = ConsoleColor.Yellow;
                                                Console.Write("Current gold: {0}\n", gold);
                                                Console.ForegroundColor = ConsoleColor.White;
                                                int howmanypotgeneral1 = int.Parse(Console.ReadLine());
                                                if (howmanypotgeneral1 * 10 > gold)
                                                {
                                                    Console.WriteLine("Clerk: You don't have enough gold to buy that many.");
                                                }
                                                else
                                                    if (howmanypotgeneral1 * 10 <= gold)
                                                    {
                                                        Console.WriteLine("Clerk: Certainly, here you go.");
                                                        gold = gold - howmanypotgeneral1 * 10;
                                                        potions = potions + howmanypotgeneral1;
                                                    }
                                            }
                                        }
                                        else
                                            if (generalstore == "2")
                                            {
                                                Console.WriteLine("Clerk: Lets see what you have\n");


                                            }
                                            else
                                            {
                                                break;
                                            }
                                    }
                                }
                                else
                                    if (what2 == "2" & receivedgold == 1)
                                    {
                                        Console.WriteLine("I should go back and talk to hex");
                                        Thread.Sleep(1500);
                                    }
                                    else
                                        if (what2 == "2")
                                        {
                                            Console.WriteLine("You enter the Weapons shop\n");
                                            Thread.Sleep(1000);
                                            Console.WriteLine("Blacksmith: Welcome.\n");
                                            while (alive)
                                            {
                                                Console.WriteLine("1. Buy Weapons.");
                                                Console.WriteLine("2. Sell Weapons.");
                                                Console.WriteLine("\nPress Any key to go back");
                                                string blacksmith = Console.ReadLine();
                                                Console.Clear();
                                                if (blacksmith == "1")
                                                {
                                                    Console.Write("Blacksmith: Take a look at my merchandise            ");
                                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                                    Console.Write("Current gold: {0}\n", gold);
                                                    Console.ForegroundColor = ConsoleColor.White;
                                                    Console.WriteLine("1. Bronze dagger    attack: +1  strength: +4     25 gold\n");
                                                    Console.WriteLine("2. Bronze Sword     attack: +0  strength: +7    40 gold");
                                                    string black = Console.ReadLine();
                                                    if (black == "1" & gold >= 25)
                                                    {
                                                        gold = gold - 25;
                                                        numberofbronzedaggers = numberofbronzedaggers + 1;
                                                        Console.WriteLine("Blacksmith: Would you like to equip it?  y/n");
                                                        string equipask = Console.ReadLine();
                                                        if (equipask == "y")
                                                        {
                                                            wep.EquipBronzeDagger();
                                                        }
                                                        Console.WriteLine("Blacksmith: Thank you for your business.\n");
                                                    }
                                                    else
                                                        if (black == "1" & gold < 25)
                                                        {
                                                            Console.WriteLine("Blacksmith: You don't have enough money.");
                                                            Thread.Sleep(1000);
                                                            Console.Clear();
                                                        }
                                                        else
                                                            if (black == "2" & gold >= 40)
                                                            {
                                                                numberofbronzeswords = numberofbronzeswords + 1;
                                                                gold = gold - 40;
                                                                Console.WriteLine("Blacksmith: Would you like to equip it?  y/n");
                                                                string equipswordask = Console.ReadLine();
                                                                if (equipswordask == "y")
                                                                {
                                                                    wep.EquipBronzeSword();
                                                                }
                                                                Console.WriteLine("Blacksmith: Thank you for your business.\n");

                                                            }
                                                            else
                                                                if (black == "2" & gold < 40)
                                                                {
                                                                    Console.WriteLine("Blacksmith: You don't have enough money.");
                                                                    Thread.Sleep(1000);
                                                                    Console.Clear();
                                                                }
                                                }



                                                else
                                                    if (blacksmith == "2")
                                                    {
                                                        Console.Write("Blacksmith: Let's take a look at what you have.          ");
                                                        Console.ForegroundColor = ConsoleColor.Yellow;
                                                        Console.Write("Current gold: {0}\n", gold);
                                                        Console.ForegroundColor = ConsoleColor.White;
                                                        Console.WriteLine("\nType the name of the Item you wish to sell, Or Press Any key to go back");
                                                        Console.WriteLine("_________________________________________________________________________");
                                                        if (numberofbronzedaggers > 0)
                                                        {
                                                            Console.WriteLine("Bronze Dagger =  10 Gold     x {0}", numberofbronzedaggers);
                                                        }
                                                        if (numberofbronzeswords > 0)
                                                        {
                                                            Console.WriteLine("Bronze Sword  =  20 Gold     x {0}", numberofbronzeswords);
                                                        }
                                                        if (numberofironspears > 0)
                                                        {
                                                            Console.WriteLine("Iron Spear    =  15 Gold     x {0}", numberofironspears);
                                                        }
                                                        string sellweaponone = Console.ReadLine();
                                                        switch (sellweaponone.ToLower())
                                                        {
                                                            case "bronze dagger":
                                                                if (numberofbronzedaggers > 0)
                                                                {
                                                                    Console.WriteLine("How many would you like to sell?");
                                                                    int hm = int.Parse(Console.ReadLine());
                                                                    if (hm > numberofbronzedaggers)
                                                                    {
                                                                        Console.WriteLine("Not enough bronze daggers");
                                                                        break;
                                                                    }
                                                                    else
                                                                    {
                                                                        Console.WriteLine("Blacksmith: Thank you");
                                                                        numberofbronzedaggers = numberofbronzedaggers - hm;
                                                                        gold = hm * 10 + gold;
                                                                        break;
                                                                    }
                                                                }
                                                                break;
                                                            case "bronze sword":
                                                                if (numberofbronzeswords > 0)
                                                                {
                                                                    Console.WriteLine("How many would you like to sell?");
                                                                    int hm = int.Parse(Console.ReadLine());
                                                                    if (hm > numberofbronzeswords)
                                                                    {
                                                                        Console.WriteLine("Not enough bronze swords");
                                                                        break;
                                                                    }
                                                                    else
                                                                    {
                                                                        Console.WriteLine("Blacksmith: Thank you");
                                                                        numberofbronzeswords = numberofbronzeswords - hm;
                                                                        gold = hm * 20 + gold;
                                                                        break;
                                                                    }
                                                                }
                                                                break;
                                                            case "iron spear":
                                                                if (numberofironspears > 0)
                                                                {
                                                                    Console.WriteLine("How many would you like to sell?");
                                                                    int hm = int.Parse(Console.ReadLine());
                                                                    if (hm > numberofironspears)
                                                                    {
                                                                        Console.WriteLine("Not enough spears");
                                                                        break;
                                                                    }
                                                                    else
                                                                    {
                                                                        Console.WriteLine("Blacksmith: Thank you");
                                                                        numberofironspears = numberofironspears - hm;
                                                                        gold = hm * 15 + gold;
                                                                        break;
                                                                    }
                                                                }
                                                                break;
                                                        }
                                                        wep.CheckForWeapon();
                                                    }
                                                    else
                                                        break;
                                            }
                                        }
                                        else
                                            if (what2 == "3" & receivedgold == 1)
                                            {
                                                Console.WriteLine("I should go back and talk to hex");
                                                Thread.Sleep(1500);
                                            }
                                            else
                                                if (what2 == "3")
                                                {
                                                    Console.WriteLine("You enter the Armor shop\n");
                                                    Thread.Sleep(1000);
                                                    Console.WriteLine("Armorer: Welcome.\n");
                                                    while (alive)
                                                    {
                                                        Console.WriteLine("1. Buy Armor.");
                                                        Console.WriteLine("2. Sell Armor.");
                                                        if (questcompleted2 == 0)
                                                        {
                                                            Console.WriteLine("3. Quest.");
                                                        }
                                                        Console.WriteLine("\nPress Any key to go back");
                                                        string armorer = Console.ReadLine();
                                                        Console.Clear();
                                                        if (armorer == "1")
                                                        {
                                                            Console.Write("Armorer: Take a look at my merchandise.           ");
                                                            Console.ForegroundColor = ConsoleColor.Yellow;
                                                            Console.Write("Current gold: {0}\n", gold);
                                                            Console.ForegroundColor = ConsoleColor.White;
                                                            Console.WriteLine("1. Leather Helm          15 gold");
                                                            Console.WriteLine("2. Leather Chest Armor   30 gold");
                                                            Console.WriteLine("3. Leather Leggings      15 gold");
                                                            Console.WriteLine("\nPress Any key to go back");
                                                            string buyarmor = Console.ReadLine();
                                                            if (buyarmor == "1" & gold >= 15)
                                                            {
                                                                Console.WriteLine("Armorer: Would you like to equip it?    y/n");
                                                                string equipask1 = Console.ReadLine();
                                                                if (equipask1 == "y")
                                                                {
                                                                    arm.EquipLeatherHelm();
                                                                }
                                                                gold = gold - 15;
                                                                numberofleatherhelms = numberofleatherhelms + 1;
                                                                Console.WriteLine("Armorer: Thank you for your business\n");
                                                            }
                                                            else
                                                                if (buyarmor == "1" & gold < 15)
                                                                {
                                                                    Console.WriteLine("Armorer: You don't have enough money.");
                                                                    Thread.Sleep(1000);
                                                                    Console.Clear();
                                                                }
                                                                else
                                                                    if (buyarmor == "2" & gold >= 30)
                                                                    {
                                                                        Console.WriteLine("Armorer: Would you like to equip it?    y/n");
                                                                        string equipask2 = Console.ReadLine();
                                                                        if (equipask2 == "y")
                                                                        {
                                                                            arm.EquipLeatherChest();
                                                                        }
                                                                        gold = gold - 30;
                                                                        numberofleatherchest = numberofleatherchest + 1;
                                                                        Console.WriteLine("Armorer: Thank you for your business\n");
                                                                    }
                                                                    else
                                                                        if (buyarmor == "2" & gold < 30)
                                                                        {
                                                                            Console.WriteLine("Armorer: You don't have enough money.");
                                                                            Thread.Sleep(1000);
                                                                            Console.Clear();
                                                                        }
                                                                        else
                                                                            if (buyarmor == "3" & gold >= 15)
                                                                            {
                                                                                Console.WriteLine("Armorer: Would you like to equip it?    y/n");
                                                                                string equipask3 = Console.ReadLine();
                                                                                if (equipask3 == "y")
                                                                                {
                                                                                    arm.EquipLeatherLeg();
                                                                                }
                                                                                gold = gold - 15;
                                                                                numberofleatherlegs = numberofleatherlegs + 1;
                                                                                Console.WriteLine("Armorer: Thank you for your business\n");
                                                                            }
                                                                            else
                                                                                if (buyarmor == "3" & gold < 15)
                                                                                {
                                                                                    Console.WriteLine("Armorer: You don't have enough money.");
                                                                                    Thread.Sleep(1000);
                                                                                    Console.Clear();
                                                                                }
                                                        }
                                                        else
                                                            if (armorer == "2")
                                                            {
                                                                Console.WriteLine("Armorer: What would you like to sell?");
                                                                Console.WriteLine("\nType the name of the Item you wish to sell, Or Press Any key to go back");
                                                                Console.WriteLine("_________________________________________________________________________");
                                                                if (rattails > 0)
                                                                {
                                                                    Console.WriteLine("Rat tails         = 5 Gold    x {0}", rattails);
                                                                }
                                                                if (numberofleatherhelms > 0)
                                                                {
                                                                    Console.WriteLine("Leather Helm      = 5 Gold    x {0}", numberofleatherhelms);
                                                                }
                                                                if (numberofleatherlegs > 0)
                                                                {
                                                                    Console.WriteLine("Leather Leggings  = 5 Gold    x {0}", numberofleatherlegs);
                                                                }
                                                                if (numberofleatherchest > 0)
                                                                {
                                                                    Console.WriteLine("Leather Chest     = 10 Gold   x {0}", numberofleatherchest);
                                                                }
                                                                if (numberofironhelms > 0)
                                                                {
                                                                    Console.WriteLine("Iron Helm         = 10 Gold   x {0}", numberofironhelms);
                                                                }
                                                                if (numberofironlegs > 0)
                                                                {
                                                                    Console.WriteLine("Iron Leggings     = 10 Gold   x {0}", numberofironlegs);
                                                                }
                                                                if (numberofironchest > 0)
                                                                {
                                                                    Console.WriteLine("Iron Chest        = 20 Gold   x {0}", numberofironchest);
                                                                }
                                                                string whatkindarmor = Console.ReadLine();
                                                                switch (whatkindarmor.ToLower())
                                                                {
                                                                    case "rat tails":
                                                                    case "rat tail":
                                                                        if (rattails > 0)
                                                                        {
                                                                            Console.WriteLine("How many would you like to sell?");
                                                                            int hm = int.Parse(Console.ReadLine());
                                                                            if (hm > rattails)
                                                                            {
                                                                                Console.WriteLine("Not enough Rat tails");
                                                                                break;
                                                                            }
                                                                            else
                                                                            {
                                                                                Console.WriteLine("Blacksmith: Thank you");
                                                                                rattails = rattails - hm;
                                                                                gold = hm * 5 + gold;
                                                                                break;
                                                                            }
                                                                        }
                                                                        break;
                                                                    case "leather helm":
                                                                    case "leather helmet":
                                                                    case "leather helms":
                                                                    case "leather helmets":
                                                                        if (numberofleatherhelms > 0)
                                                                        {
                                                                            Console.WriteLine("How many would you like to sell?");
                                                                            int hm = int.Parse(Console.ReadLine());
                                                                            if (hm > numberofleatherhelms)
                                                                            {
                                                                                Console.WriteLine("Not enough leather helmets");
                                                                                break;
                                                                            }
                                                                            else
                                                                            {
                                                                                Console.WriteLine("Blacksmith: Thank you");
                                                                                numberofleatherhelms = numberofleatherhelms - hm;
                                                                                gold = hm * 5 + gold;
                                                                                break;
                                                                            }
                                                                        }
                                                                        break;
                                                                    case "leather leggings":
                                                                    case "leather legging":
                                                                    case "leather leg":
                                                                    case "leather legs":
                                                                        if (numberofleatherlegs > 0)
                                                                        {
                                                                            Console.WriteLine("How many would you like to sell?");
                                                                            int hm = int.Parse(Console.ReadLine());
                                                                            if (hm > numberofleatherlegs)
                                                                            {
                                                                                Console.WriteLine("Not enough leather leggings");
                                                                                break;
                                                                            }
                                                                            else
                                                                            {
                                                                                Console.WriteLine("Blacksmith: Thank you");
                                                                                numberofleatherlegs = numberofleatherlegs - hm;
                                                                                gold = hm * 5 + gold;
                                                                                break;
                                                                            }
                                                                        }
                                                                        break;
                                                                    case "leather chest":
                                                                    case "leather chests":
                                                                        if (numberofleatherchest > 0)
                                                                        {
                                                                            Console.WriteLine("How many would you like to sell?");
                                                                            int hm = int.Parse(Console.ReadLine());
                                                                            if (hm > numberofleatherchest)
                                                                            {
                                                                                Console.WriteLine("Not enough leather Chests");
                                                                                break;
                                                                            }
                                                                            else
                                                                            {
                                                                                Console.WriteLine("Blacksmith: Thank you");
                                                                                numberofleatherchest = numberofleatherchest - hm;
                                                                                gold = hm * 10 + gold;
                                                                                break;
                                                                            }
                                                                        }
                                                                        break;
                                                                    case "iron helm":
                                                                    case "iron helmet":
                                                                    case "iron helms":
                                                                    case "iron helmets":
                                                                        if (numberofironhelms > 0)
                                                                        {
                                                                            Console.WriteLine("How many would you like to sell?");
                                                                            int hm = int.Parse(Console.ReadLine());
                                                                            if (hm > numberofironhelms)
                                                                            {
                                                                                Console.WriteLine("Not enough Iron helmets");
                                                                                break;
                                                                            }
                                                                            else
                                                                            {
                                                                                Console.WriteLine("Blacksmith: Thank you");
                                                                                numberofironhelms = numberofironhelms - hm;
                                                                                gold = hm * 10 + gold;
                                                                                break;
                                                                            }
                                                                        }
                                                                        break;
                                                                    case "iron leggings":
                                                                    case "iron legging":
                                                                    case "iron leg":
                                                                    case "iron legs":
                                                                        if (numberofironlegs > 0)
                                                                        {
                                                                            Console.WriteLine("How many would you like to sell?");
                                                                            int hm = int.Parse(Console.ReadLine());
                                                                            if (hm > numberofironlegs)
                                                                            {
                                                                                Console.WriteLine("Not enough Iron leggings");
                                                                                break;
                                                                            }
                                                                            else
                                                                            {
                                                                                Console.WriteLine("Blacksmith: Thank you");
                                                                                numberofironlegs = numberofironlegs - hm;
                                                                                gold = hm * 10 + gold;
                                                                                break;
                                                                            }
                                                                        }
                                                                        break;
                                                                    case "iron chest":
                                                                    case "iron chests":
                                                                        if (numberofironchest > 0)
                                                                        {
                                                                            Console.WriteLine("How many would you like to sell?");
                                                                            int hm = int.Parse(Console.ReadLine());
                                                                            if (hm > numberofironchest)
                                                                            {
                                                                                Console.WriteLine("Not enough Iron Chests");
                                                                                break;
                                                                            }
                                                                            else
                                                                            {
                                                                                Console.WriteLine("Blacksmith: Thank you");
                                                                                numberofironchest = numberofironchest - hm;
                                                                                gold = hm * 20 + gold;
                                                                                break;
                                                                            }
                                                                        }
                                                                        break;
                                                                }
                                                            }
                                                            else
                                                                if (armorer == "3" & questcompleted2 == 0)
                                                                {
                                                                    que.Materials();
                                                                }
                                                                else
                                                                {
                                                                    break;
                                                                }
                                                    }
                                                }
                                                else
                                                    if (what2 == "4" & killedmerchant == 0)
                                                    {
                                                        if (talkedtomerchant1 == 1 & questcompleted1 == 0)
                                                        {
                                                            Console.WriteLine("As you step into the Pawnshop you notice there's no costumers around\n");//player goes to the pawnshop
                                                            Thread.Sleep(4000);
                                                            Console.Clear();
                                                        }
                                                        while (alive)
                                                        {
                                                            Console.WriteLine("Merchant: Hello, what can i help you with?\n");
                                                            Console.WriteLine("1. Buy Items");
                                                            Console.WriteLine("2. Sell Items");
                                                            if (questgiven1 == 1 & questcompleted1 == 0 & questsemicompleted1 == 0)
                                                            {
                                                                Console.WriteLine("3. Ask about the gold");//go here if quest was given by hex
                                                            }
                                                            Console.WriteLine("\nPress Any key to go back");
                                                            string compone = Console.ReadLine();
                                                            Console.Clear();
                                                            if (compone == "1")
                                                            {
                                                                Console.Write("Merchant: Take a look at my fine wares");//player buys items COMPLETE LATER
                                                                Console.ForegroundColor = ConsoleColor.Yellow;
                                                                Console.Write("             Current Gold: {0}\n", gold);
                                                                Console.ForegroundColor = ConsoleColor.White;
                                                                if (madedeal == 1)
                                                                {
                                                                    Console.WriteLine("1. Iron Chest Plate   30 Gold");
                                                                    Console.WriteLine("2. Iron Spear         30 Gold");
                                                                    Console.WriteLine("\nPress Any key to go back");
                                                                    string buycheap = Console.ReadLine();
                                                                    if (buycheap == "1")
                                                                    {
                                                                        if (gold >= 30)
                                                                        {

                                                                            Console.WriteLine("\nWould you like to equip it?");
                                                                            string equipironchestc = Console.ReadLine();
                                                                            if (equipironchestc == "y")
                                                                            {
                                                                                arm.EquipIronChest();
                                                                            }
                                                                            Console.WriteLine("Merchant: Thank you for your business\n");
                                                                            numberofironchest = numberofironchest + 1;
                                                                            gold = gold - 30;
                                                                        }
                                                                        if (gold < 30)
                                                                        {
                                                                            Console.WriteLine("Merchant: You don't have enough gold");
                                                                        }
                                                                    }
                                                                    else
                                                                        if (buycheap == "2")
                                                                        {
                                                                            if (gold >= 30)
                                                                            {
                                                                                Console.WriteLine("\nWould you like to equip it?");
                                                                                string equipironspearc = Console.ReadLine();
                                                                                if (equipironspearc == "y")
                                                                                {
                                                                                    wep.EquipIronSpear();
                                                                                }
                                                                                Console.WriteLine("Merchant: Thank you for your business\n");
                                                                                numberofironspears = numberofironspears + 1;
                                                                                gold = gold - 30;
                                                                            }
                                                                            if (gold < 30)
                                                                            {
                                                                                Console.WriteLine("Merchant: You don't have enough gold");
                                                                            }
                                                                        }
                                                                }
                                                                else
                                                                    if (madedeal == 0)
                                                                    {
                                                                        Console.WriteLine("1. Iron Chest Plate   50 Gold");
                                                                        Console.WriteLine("2. Iron Spear         50 Gold");
                                                                        Console.WriteLine("\nPress Any key to go back");
                                                                        string buycheap = Console.ReadLine();
                                                                        if (buycheap == "1")
                                                                        {
                                                                            if (gold >= 50)
                                                                            {
                                                                                numberofironchest = numberofironchest + 1;
                                                                                gold = gold - 50;
                                                                                Console.WriteLine("\nWould you like to equip it?");
                                                                                string equipironchest = Console.ReadLine();
                                                                                if (equipironchest == "y")
                                                                                {
                                                                                    arm.EquipIronChest();
                                                                                }
                                                                                Console.WriteLine("Merchant: Thank you for your business\n");
                                                                            }
                                                                            if (gold < 50)
                                                                            {
                                                                                Console.WriteLine("Merchant: You don't have enough gold");
                                                                            }
                                                                        }
                                                                        else
                                                                            if (buycheap == "2")
                                                                            {
                                                                                if (gold >= 50)
                                                                                {
                                                                                    numberofironspears = numberofironspears + 1;
                                                                                    gold = gold - 50;
                                                                                    Console.WriteLine("\nWould you like to equip it? y/n");
                                                                                    string equipironspear = Console.ReadLine();
                                                                                    if (equipironspear == "y")
                                                                                    {
                                                                                        wep.EquipIronSpear();
                                                                                    }
                                                                                    Console.WriteLine("Merchant: Thank you for your business\n");
                                                                                }
                                                                                if (gold < 50)
                                                                                {
                                                                                    Console.WriteLine("Merchant: You don't have enough gold");
                                                                                }
                                                                            }
                                                                    }

                                                            }
                                                            else
                                                                if (compone == "2")
                                                                {
                                                                    Console.WriteLine("Merchant: Sure, let's take a look.");//player sells items COMPLETE LATER
                                                                }
                                                                else
                                                                    if (compone == "3" & questgiven1 == 1)//player asks about gold
                                                                    {
                                                                        if (talkedtomerchant1 == 0 & questcompleted1 == 0 & questsemicompleted1 == 0)
                                                                        {
                                                                            Console.WriteLine("Merchant: uh.. I don't know what you're talking about, you must have me confused for someone else.\n");
                                                                            Console.WriteLine("1. I don't have time for your games, either give me the gold or die");
                                                                            Console.WriteLine("2. Don't worry, maybe we can work something out.");
                                                                            string choice = Console.ReadLine();
                                                                            if (choice == "1" & sword == 0)
                                                                            {
                                                                                Console.WriteLine("Merchant: Ha ha ha, You are threatening me? you look as dangerous as a duck, getout of here.");
                                                                                Thread.Sleep(4500);
                                                                                talkedtomerchant1 = 1;
                                                                                break;
                                                                            }
                                                                            else
                                                                                if (choice == "2")
                                                                                {
                                                                                    Console.WriteLine("Merchant: Really? Well, i do owe him some gold but the old fart is so old i doubt he'll last more than a couple months, there's no point in paying a dying man is there?\n");
                                                                                    Console.ForegroundColor = ConsoleColor.Red;
                                                                                    Console.WriteLine("1. I completely agree with you.");
                                                                                    Console.ForegroundColor = ConsoleColor.White;
                                                                                    Console.ForegroundColor = ConsoleColor.Green;
                                                                                    Console.WriteLine("2. Hah! so you DID owe him, pay the gold back before i tell the guards!");
                                                                                    Console.ForegroundColor = ConsoleColor.White;
                                                                                    string choice3 = Console.ReadLine();
                                                                                    if (choice3 == "1")
                                                                                    {
                                                                                        Console.WriteLine("Merchant: You know what, you're not as bad as i thought, how about you tell old Hex you tried your best to get his gold but couldn't, and in return i'll give you a discount in all my merchandise.");
                                                                                        Console.ForegroundColor = ConsoleColor.Red;
                                                                                        Console.WriteLine("1. Sounds like a plan.");
                                                                                        Console.ForegroundColor = ConsoleColor.White;
                                                                                        Console.WriteLine("2. Forget it, i'm not dealing with such a cold hearted person.");
                                                                                        string choicethree = Console.ReadLine();
                                                                                        Console.Clear();
                                                                                        if (choicethree == "1")
                                                                                        {
                                                                                            Console.WriteLine("Merchant: Great, i'll give you 25 gold just for incentive.");
                                                                                            gold = gold + 25;
                                                                                            Thread.Sleep(2000);
                                                                                            questsemicompleted1 = 1;
                                                                                            talkedtomerchant2 = 1;
                                                                                            karma = karma - 1;
                                                                                            break;
                                                                                        }
                                                                                        else
                                                                                            if (choicethree == "2")
                                                                                            {
                                                                                                Console.WriteLine("Merchant: Suit yourself.");
                                                                                                break;
                                                                                            }

                                                                                    }
                                                                                    else
                                                                                        if (choice3 == "2")
                                                                                        {
                                                                                            Console.WriteLine("Merchant: Oh, fine. But you watch, in a few months he'll be gone and my gold could have been better spent elsewhere.\n");
                                                                                            gold = gold + 100;
                                                                                            karma = karma + 1;
                                                                                            questsemicompleted1 = 1;
                                                                                            talkedtomerchant1 = 1;
                                                                                            receivedgold = 1;
                                                                                            Console.ForegroundColor = ConsoleColor.Green;
                                                                                            Console.WriteLine("Received 100 gold");
                                                                                            Console.ForegroundColor = ConsoleColor.White;
                                                                                            Console.WriteLine("\nPress Any key to go back.");
                                                                                            Console.ReadLine();
                                                                                            break;
                                                                                        }

                                                                                }
                                                                        }
                                                                        if (talkedtomerchant1 == 1 & sword == 0)
                                                                        {
                                                                            Console.WriteLine("Merchant: You again eh? Ha ha. hey funny guy, get out of here before you make me real mad.");
                                                                            break;
                                                                        }
                                                                        else
                                                                            if (talkedtomerchant1 == 1 & sword == 1)
                                                                            {
                                                                                Console.WriteLine("Merchant: You again huh? I told you, i'm not giving you, or him anything.\n");
                                                                                Console.ForegroundColor = ConsoleColor.Red;
                                                                                Console.WriteLine("1. I will not ask you again, pal.");
                                                                                Console.ForegroundColor = ConsoleColor.White;
                                                                                Console.WriteLine("2. *Quickly wield the Dagger and push him against the wall.*");
                                                                                string choice1 = Console.ReadLine();
                                                                                Console.Clear();
                                                                                if (choice1 == "1")
                                                                                {
                                                                                    Console.WriteLine("Merchant: Good, that is all i wanted. Now get out of here.\n");
                                                                                    Thread.Sleep(1500);
                                                                                    Console.ForegroundColor = ConsoleColor.Cyan;
                                                                                    Console.WriteLine("As you leave the shop and he turns around you clickly wield the dagger and thrust it in the back of his neck, killing him instantly.");
                                                                                    Console.ForegroundColor = ConsoleColor.White;
                                                                                    Thread.Sleep(2500);
                                                                                    questsemicompleted1 = 1;
                                                                                    karma = karma - 2;
                                                                                    killedmerchant = 1;
                                                                                    gold = gold + 100;
                                                                                    receivedgold = 1;
                                                                                    Console.ForegroundColor = ConsoleColor.Green;
                                                                                    Console.WriteLine("\n\n         Received 100 gold");
                                                                                    Console.ForegroundColor = ConsoleColor.White;
                                                                                    Console.WriteLine("\nPress Any key to go back");
                                                                                    Console.ReadLine();
                                                                                    break;
                                                                                }
                                                                                else
                                                                                    if (choice1 == "2")
                                                                                    {
                                                                                        Console.WriteLine("Merchant: Ahhh! a mercenary! Okay here, Take the gold, please don't kill me!\n");
                                                                                        Console.ForegroundColor = ConsoleColor.Red;
                                                                                        Console.WriteLine("1. Kill him anyways");
                                                                                        Console.ForegroundColor = ConsoleColor.Green;
                                                                                        Console.WriteLine("2. Take the gold and leave");
                                                                                        Console.ForegroundColor = ConsoleColor.White;
                                                                                        string choice2 = Console.ReadLine();
                                                                                        if (choice2 == "1")
                                                                                        {
                                                                                            Console.WriteLine("{0}: I doubt anyone will miss you, say your final prayers.\nHeh, as if they'll help you now.", name);
                                                                                            questsemicompleted1 = 1;
                                                                                            karma = karma - 2;
                                                                                            gold = gold + 100;
                                                                                            killedmerchant = 1;
                                                                                            receivedgold = 1;
                                                                                            Console.ForegroundColor = ConsoleColor.Green;
                                                                                            Console.WriteLine("\n\n             Received 100 gold");
                                                                                            Console.ForegroundColor = ConsoleColor.White;
                                                                                            Console.WriteLine("\nPress Any key to go back");
                                                                                            Console.ReadLine();
                                                                                            Console.Clear();
                                                                                            break;
                                                                                        }
                                                                                        else
                                                                                            if (choice2 == "2")
                                                                                            {
                                                                                                Console.WriteLine("{0}: Smart choice, pleasure making your acquaintance\n", name);
                                                                                                questsemicompleted1 = 1;
                                                                                                karma = karma + 1;
                                                                                                gold = gold + 100;
                                                                                                receivedgold = 1;
                                                                                                Console.ForegroundColor = ConsoleColor.Green;
                                                                                                Console.WriteLine("\n\n         Received 100 gold");
                                                                                                Console.ForegroundColor = ConsoleColor.White;
                                                                                                Console.WriteLine("\nPress Any key to go back");
                                                                                                Console.ReadLine();
                                                                                                Console.Clear();
                                                                                                break;
                                                                                            }
                                                                                    }
                                                                            }
                                                                    }
                                                                    else
                                                                    {
                                                                        break;
                                                                    }
                                                        }

                                                    }
                                                    else
                                                        if (what2 == "4" & killedmerchant == 1)
                                                        {
                                                            Console.WriteLine("Guards are not letting anyone in the pawnshop.");
                                                            Thread.Sleep(2000);

                                                        }
                                                        else
                                                            if (what2 == "5" & receivedgold == 1)
                                                            {
                                                                Console.WriteLine("I should go back and talk to hex");
                                                                Thread.Sleep(1500);

                                                            }
                                                            else
                                                                if (what2 == "5")
                                                                {
                                                                    Console.WriteLine("You step into Sun's Inn.\n");
                                                                    while (alive)
                                                                    {
                                                                        Console.WriteLine("1. Ask for a bed");
                                                                        if (questcompleted4 == 0)
                                                                        {
                                                                            Console.WriteLine("2. Talk to suspicious man");
                                                                        }
                                                                        if (killedguard == 0)
                                                                        {
                                                                            Console.WriteLine("3. Talk to guard");
                                                                        }
                                                                        Console.WriteLine("\nPress Any key to go back");
                                                                        string bar = Console.ReadLine();
                                                                        Console.Clear();
                                                                        if (bar == "1")
                                                                        {
                                                                            Console.WriteLine("Welcome to Sun's Inn, a bed costs 10 gold.");
                                                                            Console.WriteLine("1. Pay");
                                                                            Console.WriteLine("2. Decline");
                                                                            string barone = Console.ReadLine();
                                                                            if (barone == "1")
                                                                            {
                                                                                if (gold >= 10)
                                                                                {
                                                                                    Console.WriteLine("\n Thank you. Hope you have a nice stay.");
                                                                                    pla.Sleep();
                                                                                    Thread.Sleep(1500);
                                                                                    Console.Clear();
                                                                                    Thread.Sleep(1500);
                                                                                }
                                                                                else
                                                                                    if (gold < 10)
                                                                                    {
                                                                                        Console.WriteLine("You don't have enough gold.");
                                                                                    }
                                                                            }
                                                                        }

                                                                        else
                                                                            if (bar == "2" & questgiven6 == 1)
                                                                            {
                                                                                Console.WriteLine("Man: Do what i told you. Visit Kosh in Stone City and tell him the password.");
                                                                                Thread.Sleep(1500);
                                                                                break;
                                                                            }
                                                                        if (bar == "2" & questcompleted4 == 0)
                                                                        {
                                                                            if (questgiven5 == 1 & questcompleted5 == 0)
                                                                            {
                                                                                Console.WriteLine("Man: Don't let him see you talking to me or he'll know, stupid. Get out of here");
                                                                                Thread.Sleep(1500);
                                                                                break;
                                                                            }
                                                                            if (playerlevel < 2)
                                                                            {
                                                                                Console.WriteLine("Man: I don't even know you and I can already tell you've never fought once in   your life, I don't speak to the likes of you");
                                                                                Thread.Sleep(3500);
                                                                            }
                                                                            if (playerlevel >= 2)
                                                                            {
                                                                                que.Assasination();
                                                                            }
                                                                        }
                                                                        else
                                                                            if (bar == "3" & questcompleted5 == 0)
                                                                            {
                                                                                if (playerlevel < 2)
                                                                                {
                                                                                    Console.WriteLine("Guard: Keep moving, peasant.");
                                                                                    Thread.Sleep(1500);

                                                                                }
                                                                                if (playerlevel >= 2)
                                                                                {
                                                                                    que.HelpingHand();
                                                                                }
                                                                            }
                                                                            else
                                                                            {
                                                                                break;
                                                                            }
                                                                    }
                                                                }
                                                                else
                                                                {
                                                                    break;
                                                                }
                        }
                    }
                    else
                        if (what == "3")//player views status
                        {
                            pla.Screen();
                        }
                        else
                            if (what == "4" & questcompleted1 == 1)
                            {
                                if (questcompleted1 == 1 & hasweapon == 0)
                                {
                                    Console.WriteLine("You should consider investing on a weapon. Visit the Weapon store in the Town Square.", name);
                                    Thread.Sleep(1500);
                                    continue;
                                }
                                Console.WriteLine("You open the Gate and Walk to the Wild\n");
                                Thread.Sleep(2000);
                                ma.SoutheastWarren();
                            }
            }
        }

        public void Stonecity()
        {
            location = 4;
            Console.WriteLine("You stand before Stone City\n");
            while (alive)
            {
                Console.WriteLine("Location: Stone City\n");
                Console.WriteLine("1. Visit Bad Omen Inn");
                Console.WriteLine("2. Visit Town Square");
                Console.WriteLine("3. Walk towards the Castle");
                Console.WriteLine("4. View Status Screen");
                Console.WriteLine("5. Leave Stone City");
                string what = Console.ReadLine();
                Console.Clear();
                if (what == "1")
                {
                    Console.WriteLine("You step inside Bad Omen Inn\n");
                    Thread.Sleep(1500);
                    while (alive)
                    {
                        Console.WriteLine("1. Ask for a bed");
                        Console.WriteLine("2. Buy Items");
                        Console.WriteLine("\n Press Any key to go back");
                        string inn = Console.ReadLine();
                        Console.Clear();
                        if (inn == "1")
                        {
                            while (alive)
                            {
                                Console.WriteLine("There's a bed available for 10 gold, would you like to take it?  y/n");
                                string ask = Console.ReadLine();
                                if (ask == "y")
                                {
                                    if (gold >= 10)
                                    {
                                        pla.Sleep();
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine("You do not have enough gold\n");
                                        break;
                                    }
                                }
                                else
                                    if (ask == "n")
                                    {
                                        break;
                                    }
                            }
                        }
                        else
                            if (inn == "2")
                            {
                                while (alive)
                                {
                                    Console.Write("Take a look at my wares");
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    Console.Write("         Current gold {0}\n", gold);
                                    Console.ForegroundColor = ConsoleColor.White;
                                    Console.WriteLine("1. Potions           10 gold each");
                                    Console.WriteLine("2. Strength Potion   35 gold each");
                                    Console.WriteLine("\nPress Any key to go back");
                                    string innbuy = Console.ReadLine();
                                    if (innbuy == "1")
                                    {
                                        Console.WriteLine("How many would you like?");
                                        int howm = int.Parse(Console.ReadLine());
                                        if (gold >= howm * 10)
                                        {
                                            Console.WriteLine("{0} Potion(s) purchased\n", howm);
                                            gold = gold - howm * 10;
                                            potions = potions + howm;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Not enough money");
                                        }
                                    }
                                    else
                                        if (innbuy == "2")
                                        {
                                            Console.WriteLine("How many would you like?");
                                            int howm = int.Parse(Console.ReadLine());
                                            if (gold >= howm * 35)
                                            {
                                                Console.WriteLine("{0} Strength Potion(s) purchased\n", howm);
                                                gold = gold - howm * 35;
                                                strengthpotions = strengthpotions + howm;
                                            }
                                            else
                                            {
                                                Console.WriteLine("Not enough money");
                                            }
                                        }
                                        else
                                            break;
                                }
                            }
                            else
                            {
                                break;
                            }
                    }
                }
                else
                    if (what == "2")
                    {
                        Console.WriteLine("You walk towards Town Square\n");
                        Thread.Sleep(1500);
                        while (alive)
                        {
                            Console.WriteLine("1. Weapon Shop");
                            Console.WriteLine("2. Armor Shop");
                            Console.WriteLine("3. Magic Shop");
                            Console.WriteLine("4. Kosh's House");
                            Console.WriteLine("\nPress Any key to go back");
                            string watsquare = Console.ReadLine();
                            Console.Clear();
                            if (watsquare == "1")
                            {
                                Console.WriteLine("You enter the Weapon Shop\n");
                                Thread.Sleep(1500);
                                Console.WriteLine("Blacksmith: Welcome.\n");
                                while (alive)
                                {
                                    Console.WriteLine("1. Buy Weapons.");
                                    Console.WriteLine("2. Sell Weapons.");
                                    Console.WriteLine("\nPress Any key to go back");
                                    string blacksmith = Console.ReadLine();
                                    Console.Clear();
                                    if (blacksmith == "1")
                                    {
                                        Console.Write("Blacksmith: Take a look at my merchandise            ");
                                        Console.ForegroundColor = ConsoleColor.Yellow;
                                        Console.Write("Current gold: {0}\n", gold);
                                        Console.ForegroundColor = ConsoleColor.White;
                                        Console.WriteLine("1. Iron Spear       attack: +1  strength: +5     35 gold\n");
                                        Console.WriteLine("2. Bronze Sword     attack: +0  strength: +7    40 gold");

                                        string black = Console.ReadLine();
                                        if (black == "1" & gold >= 35)
                                        {
                                            gold = gold - 35;
                                            numberofironspears = numberofironspears + 1;
                                            Console.WriteLine("Blacksmith: Would you like to equip it?  y/n");
                                            string equipask = Console.ReadLine();
                                            if (equipask == "y")
                                            {
                                                wep.EquipIronSpear();
                                            }
                                            Console.WriteLine("Blacksmith: Thank you for your business.\n");
                                        }
                                        else
                                            if (black == "1" & gold < 35)
                                            {
                                                Console.WriteLine("Blacksmith: You don't have enough money.");
                                                Thread.Sleep(1000);
                                                Console.Clear();
                                            }
                                            else
                                                if (black == "2" & gold >= 40)
                                                {
                                                    numberofbronzeswords = numberofbronzeswords + 1;
                                                    gold = gold - 40;
                                                    Console.WriteLine("Blacksmith: Would you like to equip it?  y/n");
                                                    string equipswordask = Console.ReadLine();
                                                    if (equipswordask == "y")
                                                    {
                                                        wep.EquipBronzeSword();
                                                    }
                                                    Console.WriteLine("Blacksmith: Thank you for your business.\n");

                                                }
                                                else
                                                    if (black == "2" & gold < 40)
                                                    {
                                                        Console.WriteLine("Blacksmith: You don't have enough money.");
                                                        Thread.Sleep(1000);
                                                        Console.Clear();
                                                    }
                                    }



                                    else
                                        if (blacksmith == "2")
                                        {
                                            Console.Write("Blacksmith: Let's take a look at what you have.          ");
                                            Console.ForegroundColor = ConsoleColor.Yellow;
                                            Console.Write("Current gold: {0}\n", gold);
                                            Console.ForegroundColor = ConsoleColor.White;
                                            Console.WriteLine("\nType the name of the Item you wish to sell, Or Press Any key to go back");
                                            Console.WriteLine("_________________________________________________________________________");
                                            if (numberofbronzedaggers > 0)
                                            {
                                                Console.WriteLine("Bronze Dagger =  10 Gold     x {0}", numberofbronzedaggers);
                                            }
                                            if (numberofbronzeswords > 0)
                                            {
                                                Console.WriteLine("Bronze Sword  =  20 Gold     x {0}", numberofbronzeswords);
                                            }
                                            if (numberofironspears > 0)
                                            {
                                                Console.WriteLine("Iron Spear    =  15 Gold     x {0}", numberofironspears);
                                            }
                                            string sellweaponone = Console.ReadLine();
                                            switch (sellweaponone.ToLower())
                                            {
                                                case "bronze dagger":
                                                    if (numberofbronzedaggers > 0)
                                                    {
                                                        Console.WriteLine("How many would you like to sell?");
                                                        int hm = int.Parse(Console.ReadLine());
                                                        if (hm > numberofbronzedaggers)
                                                        {
                                                            Console.WriteLine("Not enough bronze daggers");
                                                            break;
                                                        }
                                                        else
                                                        {
                                                            Console.WriteLine("Blacksmith: Thank you");
                                                            numberofbronzedaggers = numberofbronzedaggers - hm;
                                                            gold = hm * 10 + gold;
                                                            break;
                                                        }
                                                    }
                                                    break;
                                                case "bronze sword":
                                                    if (numberofbronzeswords > 0)
                                                    {
                                                        Console.WriteLine("How many would you like to sell?");
                                                        int hm = int.Parse(Console.ReadLine());
                                                        if (hm > numberofbronzeswords)
                                                        {
                                                            Console.WriteLine("Not enough bronze swords");
                                                            break;
                                                        }
                                                        else
                                                        {
                                                            Console.WriteLine("Blacksmith: Thank you");
                                                            numberofbronzeswords = numberofbronzeswords - hm;
                                                            gold = hm * 20 + gold;
                                                            break;
                                                        }
                                                    }
                                                    break;
                                                case "iron spear":
                                                    if (numberofironspears > 0)
                                                    {
                                                        Console.WriteLine("How many would you like to sell?");
                                                        int hm = int.Parse(Console.ReadLine());
                                                        if (hm > numberofironspears)
                                                        {
                                                            Console.WriteLine("Not enough spears");
                                                            break;
                                                        }
                                                        else
                                                        {
                                                            Console.WriteLine("Blacksmith: Thank you");
                                                            numberofironspears = numberofironspears - hm;
                                                            gold = hm * 15 + gold;
                                                            break;
                                                        }
                                                    }
                                                    break;
                                            }
                                            wep.CheckForWeapon();
                                        }
                                        else
                                        {
                                            break;
                                        }
                                }

                            }
                            else
                                if (watsquare == "2")
                                {
                                    Console.WriteLine("You enter the Armor Shop\n");
                                    Thread.Sleep(1500);
                                    Console.WriteLine("Armorer: Welcome.\n");
                                    while (alive)
                                    {
                                        Console.WriteLine("1. Buy Armor.");
                                        Console.WriteLine("2. Sell Armor.");
                                        Console.WriteLine("\nPress Any key to go back");
                                        string armorer = Console.ReadLine();
                                        Console.Clear();
                                        if (armorer == "1")
                                        {
                                            Console.Write("Armorer: Take a look at my merchandise.           ");
                                            Console.ForegroundColor = ConsoleColor.Yellow;
                                            Console.Write("Current gold: {0}\n", gold);
                                            Console.ForegroundColor = ConsoleColor.White;
                                            Console.WriteLine("1. Iron Helm          30 gold");
                                            Console.WriteLine("2. Iron Chest Armor   50 gold");
                                            Console.WriteLine("3. Iron Leggings      30 gold");
                                            Console.WriteLine("\nPress Any key to go back");
                                            string buyarmor = Console.ReadLine();
                                            if (buyarmor == "1" & gold >= 30)
                                            {
                                                Console.WriteLine("Armorer: Would you like to equip it?    y/n");
                                                string equipask1 = Console.ReadLine();
                                                if (equipask1 == "y")
                                                {
                                                    arm.EquipIronHelm();
                                                }
                                                gold = gold - 30;
                                                numberofironhelms = numberofironhelms + 1;
                                                Console.WriteLine("Armorer: Thank you for your business\n");
                                            }
                                            else
                                                if (buyarmor == "1" & gold < 30)
                                                {
                                                    Console.WriteLine("Armorer: You don't have enough money.");
                                                    Thread.Sleep(1000);
                                                    Console.Clear();
                                                }
                                                else
                                                    if (buyarmor == "2" & gold >= 50)
                                                    {
                                                        Console.WriteLine("Armorer: Would you like to equip it?    y/n");
                                                        string equipask2 = Console.ReadLine();
                                                        if (equipask2 == "y")
                                                        {
                                                            arm.EquipIronChest();
                                                        }
                                                        gold = gold - 50;
                                                        numberofironchest = numberofironchest + 1;
                                                        Console.WriteLine("Armorer: Thank you for your business\n");
                                                    }
                                                    else
                                                        if (buyarmor == "2" & gold < 50)
                                                        {
                                                            Console.WriteLine("Armorer: You don't have enough money.");
                                                            Thread.Sleep(1000);
                                                            Console.Clear();
                                                        }
                                                        else
                                                            if (buyarmor == "3" & gold >= 30)
                                                            {
                                                                Console.WriteLine("Armorer: Would you like to equip it?    y/n");
                                                                string equipask3 = Console.ReadLine();
                                                                if (equipask3 == "y")
                                                                {
                                                                    arm.EquipIronLeg();
                                                                }
                                                                gold = gold - 30;
                                                                numberofironlegs = numberofironlegs + 1;
                                                                Console.WriteLine("Armorer: Thank you for your business\n");
                                                            }
                                                            else
                                                                if (buyarmor == "3" & gold < 30)
                                                                {
                                                                    Console.WriteLine("Armorer: You don't have enough money.");
                                                                    Thread.Sleep(1000);
                                                                    Console.Clear();
                                                                }
                                        }
                                        else
                                            if (armorer == "2")
                                            {
                                                Console.WriteLine("Armorer: What would you like to sell?");
                                                Console.WriteLine("\nType the name of the Item you wish to sell, Or Press Any key to go back");
                                                Console.WriteLine("_________________________________________________________________________");

                                                if (numberofleatherhelms > 0)
                                                {
                                                    Console.WriteLine("Leather Helm      = 5 Gold    x {0}", numberofleatherhelms);
                                                }
                                                if (numberofleatherlegs > 0)
                                                {
                                                    Console.WriteLine("Leather Leggings  = 5 Gold    x {0}", numberofleatherlegs);
                                                }
                                                if (numberofleatherchest > 0)
                                                {
                                                    Console.WriteLine("Leather Chest     = 10 Gold   x {0}", numberofleatherchest);
                                                }
                                                if (numberofironhelms > 0)
                                                {
                                                    Console.WriteLine("Iron Helm         = 10 Gold   x {0}", numberofironhelms);
                                                }
                                                if (numberofironlegs > 0)
                                                {
                                                    Console.WriteLine("Iron Leggings     = 10 Gold   x {0}", numberofironlegs);
                                                }
                                                if (numberofironchest > 0)
                                                {
                                                    Console.WriteLine("Iron Chest        = 20 Gold   x {0}", numberofironchest);
                                                }
                                                string whatkindarmor = Console.ReadLine();
                                                switch (whatkindarmor.ToLower())
                                                {
                                                    case "leather helm":
                                                    case "leather helmet":
                                                    case "leather helms":
                                                    case "leather helmets":
                                                        if (numberofleatherhelms > 0)
                                                        {
                                                            Console.WriteLine("How many would you like to sell?");
                                                            int hm = int.Parse(Console.ReadLine());
                                                            if (hm > numberofleatherhelms)
                                                            {
                                                                Console.WriteLine("Not enough leather helmets");
                                                                break;
                                                            }
                                                            else
                                                            {
                                                                Console.WriteLine("Blacksmith: Thank you");
                                                                numberofleatherhelms = numberofleatherhelms - hm;
                                                                gold = hm * 5 + gold;
                                                                break;
                                                            }
                                                        }
                                                        break;
                                                    case "leather leggings":
                                                    case "leather legging":
                                                    case "leather leg":
                                                    case "leather legs":
                                                        if (numberofleatherlegs > 0)
                                                        {
                                                            Console.WriteLine("How many would you like to sell?");
                                                            int hm = int.Parse(Console.ReadLine());
                                                            if (hm > numberofleatherlegs)
                                                            {
                                                                Console.WriteLine("Not enough leather leggings");
                                                                break;
                                                            }
                                                            else
                                                            {
                                                                Console.WriteLine("Blacksmith: Thank you");
                                                                numberofleatherlegs = numberofleatherlegs - hm;
                                                                gold = hm * 5 + gold;
                                                                break;
                                                            }
                                                        }
                                                        break;
                                                    case "leather chest":
                                                    case "leather chests":
                                                        if (numberofleatherchest > 0)
                                                        {
                                                            Console.WriteLine("How many would you like to sell?");
                                                            int hm = int.Parse(Console.ReadLine());
                                                            if (hm > numberofleatherchest)
                                                            {
                                                                Console.WriteLine("Not enough leather Chests");
                                                                break;
                                                            }
                                                            else
                                                            {
                                                                Console.WriteLine("Blacksmith: Thank you");
                                                                numberofleatherchest = numberofleatherchest - hm;
                                                                gold = hm * 10 + gold;
                                                                break;
                                                            }
                                                        }
                                                        break;
                                                    case "iron helm":
                                                    case "iron helmet":
                                                    case "iron helms":
                                                    case "iron helmets":
                                                        if (numberofironhelms > 0)
                                                        {
                                                            Console.WriteLine("How many would you like to sell?");
                                                            int hm = int.Parse(Console.ReadLine());
                                                            if (hm > numberofironhelms)
                                                            {
                                                                Console.WriteLine("Not enough Iron helmets");
                                                                break;
                                                            }
                                                            else
                                                            {
                                                                Console.WriteLine("Blacksmith: Thank you");
                                                                numberofironhelms = numberofironhelms - hm;
                                                                gold = hm * 10 + gold;
                                                                break;
                                                            }
                                                        }
                                                        break;
                                                    case "iron leggings":
                                                    case "iron legging":
                                                    case "iron leg":
                                                    case "iron legs":
                                                        if (numberofironlegs > 0)
                                                        {
                                                            Console.WriteLine("How many would you like to sell?");
                                                            int hm = int.Parse(Console.ReadLine());
                                                            if (hm > numberofironlegs)
                                                            {
                                                                Console.WriteLine("Not enough Iron leggings");
                                                                break;
                                                            }
                                                            else
                                                            {
                                                                Console.WriteLine("Blacksmith: Thank you");
                                                                numberofironlegs = numberofironlegs - hm;
                                                                gold = hm * 10 + gold;
                                                                break;
                                                            }
                                                        }
                                                        break;
                                                    case "iron chest":
                                                    case "iron chests":
                                                        if (numberofironchest > 0)
                                                        {
                                                            Console.WriteLine("How many would you like to sell?");
                                                            int hm = int.Parse(Console.ReadLine());
                                                            if (hm > numberofironchest)
                                                            {
                                                                Console.WriteLine("Not enough Iron Chests");
                                                                break;
                                                            }
                                                            else
                                                            {
                                                                Console.WriteLine("Blacksmith: Thank you");
                                                                numberofironchest = numberofironchest - hm;
                                                                gold = hm * 20 + gold;
                                                                break;
                                                            }
                                                        }
                                                        break;
                                                }
                                            }
                                            else
                                            {
                                                break;
                                            }
                                    }
                                }
                                else
                                    if (watsquare == "3")
                                    {
                                        Console.WriteLine("You enter the Magic Shop\n");
                                        Thread.Sleep(1500);
                                    }
                                    else
                                        if (watsquare == "4")
                                        {
                                        }
                                        else
                                            break;
                        }
                    }
                    else
                        if (what == "3")
                        {
                            Console.WriteLine("As you walk towards the Castle you're in awe at its magnificence");
                            Thread.Sleep(1500);
                            while (alive)
                            {
                                Console.WriteLine("1. Enter the castle");
                                Console.WriteLine("\nPress Any key to go back");
                                string watcastle = Console.ReadLine();
                                if (watcastle == "1")
                                {
                                    if (guardisout == 0)
                                    {
                                        Console.WriteLine("Guard: Hold it right there! The King is not hosting any public gatherings at the moment, therefore i'll have to ask you to leave.");
                                        Console.WriteLine("1. How does 50 gold sound to you?");
                                        Console.WriteLine("2. I don't have time for this. Get out of my way or pay the consequences.");
                                        string actioncastle = Console.ReadLine();
                                        if (actioncastle == "1")
                                        {
                                            if (gold >= 50)
                                            {
                                                Console.WriteLine("Guard: Well we are underpaid.. You seem harmless enough, i'll let you in.");
                                                gold = gold - 50;
                                                guardisout = 1;
                                            }
                                            else
                                            {
                                                Console.WriteLine("Guard: You don't even have the gold. Get out of here.");
                                            }
                                        }
                                        else
                                            if (actioncastle == "2")
                                            {
                                                Console.WriteLine("Guard: You think you can hang with the likes of me? Very well then, prepare to battle!");
                                                Thread.Sleep(1500);
                                                fight = 3;
                                                bat.Battle();
                                            }
                                    }
                                }
                                else
                                {
                                    break;
                                }
                            }
                        }
                        else
                            if (what == "4")
                            {
                                pla.Screen();
                            }
                            else
                                if (what == "5")
                                {
                                    ma.SoutheastWarren();
                                }

            }
        }




    }
}
