using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ConsoleApplication1
{
    class Quests : Info
    {

        public void QuestsName()
        {
            if (questgiven1 == 0)
            {
                quest1name = "Not Started\n\n\n";
            }
            else
                if (questgiven1 == 1 & questcompleted1 == 0)
                {
                    quest1name = "Incomplete\n\n\n";
                }
                else
                    if (questgiven1 == 1 & questcompleted1 == 1)
                    {
                        quest1name = "Completed\n\n\n";
                    }
            if (questgiven2 == 0)
            {
                quest2name = "Not Started\n\n\n";
            }
            else
                if (questgiven2 == 1 & questcompleted2 == 0)
                {
                    quest2name = "Incomplete\n\n\n";
                }
                else
                    if (questgiven2 == 1 & questcompleted2 == 1)
                    {
                        quest2name = "Completed\n\n\n";
                    }
            if (questfailed3 == 1)
            {
                quest3name = "Failed\n\n\n";
            }
            else
                if (questgiven3 == 0)
                {
                    quest3name = "Not Started\n\n\n";
                }
                else
                    if (questgiven3 == 1 & questcompleted3 == 0)
                    {
                        quest3name = "Incomplete\n\n\n";
                    }
                    else
                        if (questgiven3 == 1 & questcompleted3 == 1)
                        {
                            quest3name = "Completed\n\n\n";
                        }
            if (questfailed4 == 1)
            {
                quest4name = "Failed\n\n\n";
            }
            else
                if (questgiven4 == 0)
                {
                    quest4name = "Not Started\n\n\n";
                }
                else
                    if (questgiven4 == 1 & questcompleted4 == 0)
                    {
                        quest4name = "Incomplete\n\n\n";
                    }
                    else
                        if (questgiven4 == 1 & questcompleted4 == 1)
                        {
                            quest4name = "Completed\n\n\n";
                        }
            if (questgiven5 == 0)
            {
                quest5name = "Not Started\n\n\n";
            }
            else
                if (questgiven5 == 1 & questcompleted5 == 0)
                {
                    quest5name = "Incomplete\n\n\n";
                }
                else
                    if (questgiven5 == 1 & questcompleted5 == 1)
                    {
                        quest5name = "Completed\n\n\n";
                    }
            if (questfailed6 == 1)
            {
                quest6name = "Failed\n\n\n";
            }
            else
                if (questgiven6 == 0)
                {
                    quest6name = "Not Started\n\n\n";
                }
                else
                    if (questgiven6 == 1 & questcompleted6 == 0)
                    {
                        quest6name = "Incomplete\n\n\n";
                    }
                    else
                        if (questgiven6 == 1 & questcompleted6 == 1)
                        {
                            quest6name = "Completed\n\n\n";
                        }











        }


        public void Hexquest()
        {
            if (questgiven1 == 0 & talkedwhex == 0)//go here if no quest have been given and first time talking to hex
            {
                Console.WriteLine("Gatekeeper: Hello, i've never seen you before, my name is Hex, what brings you  here?");
                Console.WriteLine("1. I'm not sure actually, i just randomly appeared here");
                Console.WriteLine("2. I'm here on a business trip");
                talkedwhex = 1;
                string convo = Console.ReadLine();
                Console.Clear();
                if (convo == "1")
                {
                    Console.WriteLine("Hex: Really? i think you're also a little crazy, well no matter, you look like aguy who can get things done, care for a simple errand? i'll make it worth your while.");//ask giving quest
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("1. Sure, what do you need?");//accept quest
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("2. Maybe another time");//decline quest
                    string quest1 = Console.ReadLine();
                    Console.Clear();
                    if (quest1 == "1")//accepted quest
                    {
                        Console.WriteLine("Hex: Good, i need you to talk to the Merchant at the Pawnshop, he owes me some  gold but is always dodging me, since you're new i don't think he'll assume you're working for me. Talk to him and ask him about the gold.\n");
                        questgiven1 = 1;

                        Console.WriteLine("--------------------------------------------------");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("       Quest received: Hex's Problem");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("--------------------------------------------------");
                    }
                    else
                        if (quest1 == "2")//declined quest
                        {
                            Console.WriteLine("Hex: Oh that's too bad, well talk to me when you have time.");
                        }
                }
                else
                    if (convo == "2")//second conversation answer
                    {
                        Console.WriteLine("Hex: Business trip huh? from where?\n");
                        Console.WriteLine("1. I don't remember");
                        Console.WriteLine("2. None of your business");
                        string convo1 = Console.ReadLine();
                        Console.Clear();
                        if (convo1 == "1")
                        {
                            Console.WriteLine("Hex: Forgetful are we? it's okay, but listen i have a very simple errand to do but i don't have the time since i'm here all the time, care to help me out? i'll make it worth your while");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("1. Sure i'll do it");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("2. I'm too busy");
                            string questone = Console.ReadLine();
                            Console.Clear();
                            if (questone == "1")//quest accepted
                            {
                                Console.WriteLine("Hex: Good, i need you to talk to the Merchant at the Pawnshop, he owes me some gold but is always dodging me, since you're new i don't think he'll assume you're working for me. Talk to him and ask him about the gold.\n");
                                questgiven1 = 1;

                                Console.WriteLine("--------------------------------------------------");
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine("       Quest received: Hex's Problem");
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("--------------------------------------------------");

                            }
                            else
                                if (questone == "2")//quest declined
                                {
                                    Console.WriteLine("Hex: That's too bad, well talk to me whenever you have time.");
                                }
                        }
                        else
                            if (convo1 == "2")
                            {
                                Console.WriteLine("Hex: Wow, where did that come from?");
                            }
                    }
            }
            else
                if (questgiven1 == 1 | talkedwhex == 1)//go here if player has talked with hex before
                {
                    Console.WriteLine("Hex: Hello, what brings you by?");
                    Console.WriteLine("1. Quest");
                    string convoone = Console.ReadLine();
                    Console.Clear();
                    if (convoone == "1")
                    {
                        if (questgiven1 == 0)//go here if quest was previously declined
                        {
                            Console.WriteLine("Hex: Sure i have a little errand that needs doing, think you're up for it?");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("1. Sure am");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("2. Forget it");
                            string ask = Console.ReadLine();
                            Console.Clear();
                            if (ask == "1")//accept quest
                            {
                                Console.WriteLine("Hex: Good, i need you to talk to the Merchant at the Pawnshop, he owes me some gold but is always dodging me, since you're new i don't think he'll assume you're working for me. Talk to him and ask him about the gold.\n");
                                questgiven1 = 1;
                                Console.WriteLine("--------------------------------------------------");
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine("       Quest received: Hex's Problem");
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("--------------------------------------------------");
                            }
                            else
                                if (ask == "2")//decline quest
                                {
                                    Console.WriteLine("Hex: Will do.");
                                }
                        }
                        else
                            if (questgiven1 == 1 & questcompleted1 == 0)//go here if quest has been accepted
                            {
                                Console.WriteLine("Hex: So how's that errand going?");
                                if (talkedtomerchant1 == 1 & questsemicompleted1 == 0)//go here if player threatened the merchant
                                {
                                    Console.WriteLine("1. I've talked to him");
                                    Console.ReadLine();
                                    Console.WriteLine("Hex: Well? what happened?\n");
                                    Console.WriteLine("1. I threatened him but he didn't buy it.\n");
                                    string askone = Console.ReadLine();
                                    Console.WriteLine("Hex: Hmm, I think i can help you with that. I found this years ago while guarding these gates, a fellow quickly ran away from the castle and while i chased him he dropped a stolen poison Dagger, i want you to have it. I'm sure he'll take you seriously now.\n");
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("                 Received Quest Item:  Poisoned Dagger\n");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    sword = 1;
                                }
                                else
                                    if (questsemicompleted1 == 1)
                                    {
                                        Console.WriteLine("1. I've talked to him");
                                        Console.ReadLine();
                                        Console.WriteLine("Hex: Well? what happened?\n");
                                        if (talkedtomerchant2 == 0 & killedmerchant == 0)
                                        {
                                            Console.ForegroundColor = ConsoleColor.Green;
                                            Console.WriteLine("1. After a little incentive he decided to pay you back");//player gives gold back
                                            Console.ForegroundColor = ConsoleColor.White;
                                        }
                                        if (talkedtomerchant2 == 0 & killedmerchant == 0)
                                        {
                                            Console.ForegroundColor = ConsoleColor.Red;
                                            Console.WriteLine("2. I tried hard to make him pay you back, but i couldn't do it.");//player does not give gold back
                                            Console.ForegroundColor = ConsoleColor.White;
                                        }
                                        if (talkedtomerchant2 == 1)
                                        {
                                            Console.ForegroundColor = ConsoleColor.Red;
                                            Console.WriteLine("1. I tried hard to make him pay you back, but i couldn't do it.");//player makes deal with merchant
                                            Console.ForegroundColor = ConsoleColor.White;
                                        }
                                        if (killedmerchant == 1)
                                        {
                                            Console.ForegroundColor = ConsoleColor.Red;
                                            Console.WriteLine("1. He had an accident before i could get there, guards were around his shop and wouldn't let me in.");//player kills merchant and doesnt give gold back to hex
                                            Console.ForegroundColor = ConsoleColor.White;
                                        }
                                        if (killedmerchant == 1)
                                        {
                                            Console.ForegroundColor = ConsoleColor.Green;
                                            Console.WriteLine("2. Here's your gold, i assure you he'll never bother you again.");//player kills merchant and gives gold
                                            Console.ForegroundColor = ConsoleColor.White;
                                        }

                                        string asktwo = Console.ReadLine();
                                        if (asktwo == "1" & talkedtomerchant2 == 0 & killedmerchant == 0)
                                        {
                                            Console.WriteLine("Hex: Oh thank you so much {0}, I can't believe you went through all this trouble to help an old man like me, i'm not supposed to do this but i'll let you out of the castle completely free from now on. You're truly a white knight.", name);
                                            questcompleted1 = 1;
                                            Console.ForegroundColor = ConsoleColor.Green;
                                            Console.WriteLine("--------------------------Quest completed--------------------------");
                                            Console.WriteLine("You've received 50 gold");
                                            Console.WriteLine("You've received 50 Experience points");
                                            Console.WriteLine("--------------------------------------------------------------------");
                                            Console.ForegroundColor = ConsoleColor.White;
                                            karma = karma + 1;
                                            gold = gold - 50;
                                            playerxp = playerxp + 50;
                                            receivedgold = 0;
                                            Console.WriteLine("\nPress Any key to go back.");
                                            Console.ReadLine();
                                            Console.Clear();
                                            pla.Leveling();
                                        }
                                        else
                                            if (asktwo == "2" & talkedtomerchant2 == 0 & killedmerchant == 0)
                                            {
                                                Console.WriteLine("Hex: Oh... i'm dissapointed i thought you were the one to do it, well at least you tried.\n");
                                                questcompleted1 = 1;
                                                Console.ForegroundColor = ConsoleColor.Green;
                                                Console.WriteLine("---------------------------Quest completed--------------------------");
                                                Console.ForegroundColor = ConsoleColor.Green;
                                                Console.WriteLine("You've received 20 Experience points");
                                                Console.WriteLine("--------------------------------------------------------------------");
                                                Console.ForegroundColor = ConsoleColor.White;
                                                karma = karma - 1;
                                                playerxp = playerxp + 20;
                                                receivedgold = 0;
                                                Console.WriteLine("\nPress Any key to go back.");
                                                Console.ReadLine();
                                                Console.Clear();
                                                pla.Leveling();
                                            }
                                            else
                                                if (asktwo == "1" & talkedtomerchant2 == 1)
                                                {
                                                    Console.WriteLine("Hex: Oh... i'm dissapointed i thought you were the one to do it, well at least you tried.\n");
                                                    questcompleted1 = 1;
                                                    madedeal = 1;
                                                    Console.ForegroundColor = ConsoleColor.Green;
                                                    Console.WriteLine("---------------------------Quest completed--------------------------");
                                                    Console.ForegroundColor = ConsoleColor.Green;
                                                    Console.WriteLine("You've received 20 Experience points");
                                                    Console.WriteLine("--------------------------------------------------------------------");
                                                    Console.ForegroundColor = ConsoleColor.White;
                                                    karma = karma - 1;
                                                    playerxp = playerxp + 20;
                                                    receivedgold = 0;
                                                    Console.WriteLine("\nPress Any key to go back.");
                                                    Console.ReadLine();
                                                    Console.Clear();
                                                    pla.Leveling();
                                                }
                                                else
                                                    if (asktwo == "1" & killedmerchant == 1)
                                                    {
                                                        Console.WriteLine("Hex: Well he had it coming to him, thanks for trying to help me, but i really needed that gold.");
                                                        questcompleted1 = 1;
                                                        Console.ForegroundColor = ConsoleColor.Green;
                                                        Console.WriteLine("---------------------------Quest completed-------------------------");
                                                        Console.ForegroundColor = ConsoleColor.Green;
                                                        Console.WriteLine("You've received 25 Experience points");
                                                        Console.WriteLine("--------------------------------------------------------------------");
                                                        Console.ForegroundColor = ConsoleColor.White;
                                                        karma = karma - 1;
                                                        playerxp = playerxp + 25;
                                                        receivedgold = 0;
                                                        Console.WriteLine("\nPress Any key to go back.");
                                                        Console.ReadLine();
                                                        Console.Clear();
                                                        pla.Leveling();
                                                    }
                                                    else
                                                        if (asktwo == "2" & killedmerchant == 1)
                                                        {
                                                            Console.WriteLine("Hex: Well that is very good news indeed, thank you so much for the gold. In return i'll let you out of the castle for free anytime you want, you've been very helpful.");
                                                            Console.ForegroundColor = ConsoleColor.Green;
                                                            Console.WriteLine("--------------------------Quest completed---------------------------");
                                                            Console.WriteLine("You've received 50 gold");
                                                            Console.WriteLine("You've received 50 Experience points");
                                                            Console.WriteLine("--------------------------------------------------------------------");
                                                            Console.ForegroundColor = ConsoleColor.White;
                                                            questcompleted1 = 1;
                                                            karma = karma + 1;
                                                            gold = gold - 50;
                                                            playerxp = playerxp + 50;
                                                            receivedgold = 0;
                                                            Console.WriteLine("\nPress Any key to go back.");
                                                            Console.ReadLine();
                                                            Console.Clear();
                                                            pla.Leveling();
                                                        }
                                    }
                                    else
                                        if (questsemicompleted1 == 0)
                                        {
                                            Console.WriteLine("1. I'm still working on it");//player hasn't finished the quest
                                            Console.ReadLine();
                                            Console.WriteLine("Hex: Well what are you waiting for, talk to the Merchant at the Pawnshop.\n");
                                        }
                            }

                    }
                }

        }


        public void Materials()
        {
            if (rattails >= 5)
            {
                questsemicompleted2 = 1;
            }

            if (questgiven2 == 0)
            {
                Console.WriteLine("Armorer: Well lad, i am in need of materials, if you're able to bring me 5 rat  tails i'll be able to make you a Leather Chest free of charge.");
                Console.WriteLine("\nWhat would you like to do?");
                Console.WriteLine("1. Take the Quest");
                Console.WriteLine("2. Decline.");
                string armorerquest1ask = Console.ReadLine();
                if (armorerquest1ask == "1")
                {
                    Console.WriteLine("Armorer: Great! you'll find rat tails in cave Moor, which is located West of here. Once you have five, bring them to me.\n");
                    questgiven2 = 1;
                    Console.WriteLine("--------------------------------------------------");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("       Quest received: Materials");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("--------------------------------------------------");
                    Thread.Sleep(1000);

                }
                else
                    if (armorerquest1ask == "2")
                    {
                        Console.WriteLine("Armorer: I understand, well talk to me when you have time.\n");
                    }
            }
            else
                if (questgiven2 == 1)
                {
                    Console.WriteLine("Armorer: So how's the hunting going?");
                    if (questsemicompleted2 == 0)
                    {
                        Console.WriteLine("1. I'm still working on it.");
                    }
                    else
                        if (questsemicompleted2 == 1)
                        {
                            Console.WriteLine("1. I've brought the rat tails.");
                        }
                    string howquest = Console.ReadLine();

                    if (howquest == "1" & questsemicompleted2 == 0)
                    {
                        Console.WriteLine("Armorer: In case you've forgotten, you can find rat tails in Cave Moor, which is just outside the castle gates to the West. Bring me five and i'll make you some armor free of charge.");
                    }
                    else
                        if (howquest == "1" & questsemicompleted2 == 1)
                        {
                            Console.WriteLine("Armorer: Fantastic! Thanks a lot sir, i'll now give you this Leather Chest free of charge, thanks again.");
                            Console.WriteLine("_________________________________________________");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("    Quest Completed: Materials");
                            Console.WriteLine("You've received 25 Experience and 30 gold");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("_________________________________________________");
                            numberofleatherchest = numberofleatherchest + 1;
                            gold = gold + 30;
                            playerxp = playerxp + 25;
                            karma = karma + 1;
                            questcompleted2 = 1;
                            rattails = rattails - 5;
                            pla.Leveling();
                        }
                }
        }


        public void MissingFriend()
        {
            Console.WriteLine("Man: Ugh.... Please.. spare my life, i'll let you take the chest, i don't care anymore. Please..\n");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("1. It'll be more fun to just kill you.");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("2. I'll let you live, just make sure to never cross me again");
            Console.ForegroundColor = ConsoleColor.White;
            string tokillman = Console.ReadLine();
            if (tokillman == "1")
            {
                Console.WriteLine("Man: No! Please, No!");
                Thread.Sleep(1000);
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("*As he screams for mercy you swiftly thrust your sword into his chest, rupturing his heart and killing him instantly*\n");
                Thread.Sleep(3000);
                Console.ForegroundColor = ConsoleColor.White;
                dro.QuesttwoDrop();
                questgiven3 = 1;
                questfailed3 = 1;
                karma = karma - 2;
            }
            else
                if (tokillman == "2")
                {
                    Console.WriteLine("Man: Oh, thank you, here, you can have whatever's in the chest, i'm glad i've crossed paths with a white knite just as yourself.");
                    karma = karma + 1;
                    questgiven3 = 1;
                    questfailed3 = 1;
                }
        }


        public void HelpingHand()
        {
            if (karma < 0 | questgiven6 == 1 | questfailed4 == 1)
            {
                Console.WriteLine("Guard: People have spoken of the things you've done. I have nothing to gain from speaking to a man such as yourself");
            }
            else
                if (questcompleted4 == 1)
                {
                    Console.WriteLine("Guard: Thank you so much for your help, civilian.\n");
                }
            if (karma >= 0)
            {
                if (questsemicompleted4 == 1 & questcompleted4 == 0)
                {
                    Console.WriteLine("Guard: So, What did you find out?\n");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("1. He digs up graves in various cities in order to get any valuables");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.ReadLine();
                    Console.WriteLine("\nGuard: My god, He's about to be taught how we deal with criminals in Shang.\nThank you very much for all your help.");
                    Console.WriteLine("_________________________________________________________");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("         Quest Completed: Helping Hand");
                    Console.WriteLine("     Received 50 Experience and 50 Gold");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("_________________________________________________________");
                    Thread.Sleep(2000);
                    questcompleted4 = 1;
                    gold = gold + 50;
                    karma = karma + 2;
                    playerxp = playerxp + 50;
                    pla.Leveling();
                }
                if (questgiven4 == 0)
                {
                    Console.WriteLine("Guard: Welcome to the Inn, friend.I am a Law abiding guard and I expect civilians to be as well.\nThat man in the corner seems a little suspicious though, sadly he hasn't done anything wrong so i can't do anything about him.\n");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("1. Is there anything i can do to help?");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("2. You should stop telling your life story to a person you just met");
                    string quest4ask = Console.ReadLine();
                    Console.Clear();
                    if (quest4ask == "1")
                    {
                        Console.WriteLine("Guard: There is, i've never seen you before so i assume you're new here. I need you to talk to him, but don't mention I sent you. If he tells you anything suspicious make sure to report it to me and I'll make sure he pays");
                        Console.WriteLine("--------------------------------------------------");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("       Quest received: Helping Hand");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("--------------------------------------------------");
                        questgiven4 = 1;
                    }
                    else
                        if (quest4ask == "2")
                        {
                            Console.WriteLine("\nGuard: You're pushing your luck, peasant.\n");
                        }
                }

            }
            if (questgiven5 == 1)
            {
                Console.WriteLine("Guard: What is it?\n");
                Console.WriteLine("1. That Man has a stash in cave moor");
                Console.ReadLine();
                Console.WriteLine("Guard: Interesting, If it's true there will be hell to pay! Follow me, I'm sure he doesn't work alone and i might need you to help me out.\n");
                questsemicompleted5 = 1;
            }
        }


        public void Assasinationcompleted()
        {
            if (killedguard == 1)
            {

                Console.WriteLine("Man: So you did it, I can't say that I'm surprised. You've proven to be a very cold hearted individual, which is exactly what my crew and I need.");
                Console.Write("If you want to know more, talk to Kosh in Stone City.\nThe password is ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("C++ sucks");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(", don't forget it!\n");
                Console.WriteLine("_________________________________________________");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("    Quest Completed: Assasination");
                Console.WriteLine("You've received 50 Experience and 50 gold");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("_________________________________________________");
                gold = gold + 50;
                playerxp = playerxp + 50;
                Console.WriteLine("--------------------------------------------------");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("       Quest received: From Rags to Riches");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine("Press Any Key to Continue");
                Console.ReadLine();
                questgiven4 = 1;
                questfailed4 = 1;
                questcompleted5 = 1;
                questgiven6 = 1;
                karma = karma - 2;
                pla.Leveling();

            }
        }


        public void Assasination()
        {
            if (karma > 0 & questgiven4 == 0)
            {
                Console.WriteLine("Man: Heh.. Sorry but i don't speak to the likes of you.");
            }
            else
                if (karma <= 0 & questgiven4 == 0)
                {
                    Console.WriteLine("Man: Say... word has gotten around Shang, you're certainly the guy who looks out for himself. I have an offer for you if you're interested\n");
                    Console.WriteLine("1. What did you have in mind");
                    Console.WriteLine("2. I'm not interested");
                    string takequest = Console.ReadLine();
                    Console.Clear();
                    if (takequest == "1")
                    {
                        Console.Write("Man: If you want to know more, talk to Kosh in Stone City. The password is ");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("C++ sucks");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write(", don't forget it!\n");
                        questfailed4 = 1;
                    }
                    else
                        if (takequest == "2")
                        {
                            Console.WriteLine("Man: Fine, it's your loss");
                        }


                }
            if (questgiven4 == 1)
            {
                while (alive)
                {
                    Console.WriteLine("Man: What do you want? I'm a little busy at the moment.\n");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("1. I understand you're a guy who can get things done");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("2. Listen, that guard is onto you, he's asked me to spy on you");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("3. Sorry to bother you");
                    string what = Console.ReadLine();
                    Console.Clear();
                    if (what == "1")
                    {
                        Console.WriteLine("Man: Yeah that's right. I can get you any armor or weapon of your choice at a fair price, for me of course.\n");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("1. Sounds mysterious, how do get them?");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("2. Really? How can I buy some of your merchandise?       (fail Helping Hand)");
                        Console.ForegroundColor = ConsoleColor.White;
                        string good = Console.ReadLine();
                        Console.Clear();
                        if (good == "1")
                        {
                            Console.WriteLine("Man: It's simple, I travel town by town digging up graves in their cemeteries and taking whatever's valuable.\nCan you believe some people get buried with extremelly rare armor on? It's a waste if you ask me");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("1. I could never do that, too risky.");
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("2. I would like to do that. Give me any tips and i won't tell the guard");
                            Console.ForegroundColor = ConsoleColor.White;
                            string good1 = Console.ReadLine();
                            Console.Clear();
                            if (good1 == "1")
                            {
                                Console.WriteLine("Man: Yes, It's a risky business, but it pays well\n");
                                questsemicompleted4 = 1;
                                break;
                            }
                            else
                                if (good1 == "2")
                                {
                                    Console.WriteLine("Man: First you'll have to do a little something for me.\n Think you're up for it?");
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("\n1. I'm always up for anything");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    Console.WriteLine("2. You're too scary for me");
                                    string askstuffa = Console.ReadLine();
                                    Console.Clear();
                                    if (askstuffa == "1")
                                    {
                                        Console.WriteLine("Man: Is that so? Well here's the plan.\n\nTell him I keep a stash hidden in Cave Moor, have him follow you there and when the time comes... Kill him. ");
                                        Console.WriteLine("I know you'll do a good job");
                                        Console.WriteLine("--------------------------------------------------");
                                        Console.ForegroundColor = ConsoleColor.Yellow;
                                        Console.WriteLine("       Quest received: Assasination");
                                        Console.ForegroundColor = ConsoleColor.White;
                                        Console.WriteLine("--------------------------------------------------");
                                        questgiven5 = 1;
                                        break;
                                    }
                                    else
                                        if (askstuffa == "2")
                                        {
                                            Console.WriteLine("Man: I can't blame you, you look pretty wimpy");
                                            break;
                                        }
                                }
                        }
                        else
                            if (good == "2")
                            {
                                Console.WriteLine("Man: First you'll have to do a little something for me.\n Think you're up for it?");
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("\n1. I'm always up for anything");
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("2. You're too scary for me");
                                string askstuff = Console.ReadLine();
                                Console.Clear();
                                if (askstuff == "1")
                                {
                                    Console.WriteLine("Man: Is that so? Well here's the plan.\n\nTell him I keep a stash hidden in Cave Moor, have him follow you there and when the time comes... Kill him. ");
                                    Console.WriteLine("I know you'll do a good job");
                                    Console.WriteLine("--------------------------------------------------");
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    Console.WriteLine("       Quest received: Assasination");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    Console.WriteLine("--------------------------------------------------");
                                    questgiven5 = 1;
                                    break;
                                }
                                else
                                    if (askstuff == "2")
                                    {
                                        Console.WriteLine("Man: I can't blame you, you look pretty wimpy");
                                        break;
                                    }
                            }

                    }
                    else
                        if (what == "2")
                        {
                            Console.WriteLine("Man: Is that so? You did the right thing by telling me, these guards have been very bothersome to myself and my crew, but i have an idea to change all that.\n\nTell him I keep a stash hidden in Cave Moor, have him follow you there and when the time comes... Kill him. ");
                            Console.WriteLine("I know you'll do a good job");
                            Console.WriteLine("--------------------------------------------------");
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("       Quest received: Assasination");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("--------------------------------------------------");
                            questgiven5 = 1;
                            break;


                        }
                        else
                            if (what == "3")
                            {
                                break;
                            }
                }
            }







        }



    }
}
