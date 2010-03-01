using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ConsoleApplication1
{
    class Caves : Info
    {
        public void CaveMoor()
        {
            location = 3;
            while (alive)
            {

                Console.WriteLine("Location: Cave Moor\n\n");
                Console.WriteLine("1. Explore ");
                Console.WriteLine("2. Hunt");
                Console.WriteLine("3. View Status");
                if (questsemicompleted5 == 1 & killedguard == 0)
                {
                    Console.WriteLine("4. Ambush Guard");
                }
                Console.WriteLine("\nPress Any key to go back");
                string action = Console.ReadLine();
                Console.Clear();
                if (action == "1")
                {
                    Random en = new Random(DateTime.Now.Millisecond);
                    Thread.Sleep(5);
                    int d = en.Next(1, 101);
                    if (d >= 70 & d <= 95)
                    {
                        fight = 1;
                    }
                    else
                        if (d > 95 & d <= 100)
                    {
                        fight = 2;
                    }
                    if (d >= 70)
                    {
                        Console.WriteLine("An enemy stops you in your tracks!");
                        Thread.Sleep(1500);
                        bat.Battle();
                    }
                    else

                        if (killedman == 0 & questgiven3 == 0)
                        {
                            Console.WriteLine("You see a chest, closely guarded by a seemingly powerful man.\n");
                        }
                    while (alive)
                    {
                        if (questfailed3 == 0)
                        {
                            Console.WriteLine("1. Talk to man");
                            Console.WriteLine("2. Attack man");
                        }
                        if (questfailed3 == 1 & openedchest == 0)
                        {
                            Console.WriteLine("3. Open Chest");
                        }
                        if (questfailed3 == 1 & openedchest == 1)
                        {
                            Console.WriteLine("There is nothing else in this cave");
                        }
                        Console.WriteLine("\nPress Any key to go back");
                        string action2 = Console.ReadLine();
                        Console.Clear();
                        if (action2 == "1" & killedman == 0)
                        {
                            if (questgiven3 == 1)
                            {
                                Console.WriteLine("Man: What are you waiting for? Go find him in Stone city.");
                                break;
                            }
                            Console.WriteLine("Man: What are you doing here? This is My chest. You'd better back off!\n");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("1. Maybe we can arrange something.");
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("2. YOU better back off before i kill you.");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("3. Sorry to have bothered you.");
                            string action3 = Console.ReadLine();
                            if (action3 == "1")
                            {
                                Console.WriteLine("Man: Well... my friend was supposed to come back a few hours ago, if you can find him and see what's taking him so long i might let you have the chest, it was supposed to be his anyways.\n");
                                Console.WriteLine("1. Sure, i'll find him.");
                                Console.WriteLine("2. Do your own dirty work.");
                                string action4 = Console.ReadLine();
                                if (action4 == "1")
                                {
                                    Console.WriteLine("Man: Great, you'll find him in Stone city up in the North. I'm not sure where he would be exactly though.\n");
                                    questgiven3 = 1;
                                    Console.WriteLine("--------------------------------------------------");
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    Console.WriteLine("       Quest received: Missing friend");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    Console.WriteLine("--------------------------------------------------");
                                    break;
                                }
                                else
                                    if (action4 == "2")
                                    {
                                        Console.WriteLine("Man: Fine, i'll keep waiting here then.");
                                        break;
                                    }
                            }
                            else
                                if (action3 == "2")
                                {
                                    Console.Clear();
                                    Console.WriteLine("Man: Heh.. YOU are going to kill ME? i'm surprised you even made it through a rat. But who am i to let down a challenge?\n");
                                    Thread.Sleep(1500);
                                    killedman = 1;
                                    bat.Battle();
                                }
                                else
                                {
                                    break;
                                }
                        }
                        else
                            if (action2 == "2" & killedman == 0)
                            {
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine("You silently sneak up on the man, but he notices you're there\n");
                                Console.ForegroundColor = ConsoleColor.White;
                                killedman = 1;
                                bat.Battle();
                            }
                            else
                                if (action2 == "3" & questfailed3 == 1)
                                {
                                    Console.WriteLine("You eagerly open the Chest and find 5 potions!\n");
                                    openedchest = 1;
                                    potions = potions + 5;
                                }
                        break;
                    } 
                }
                else
                    if (action == "2")
                    {
                        Random en = new Random(DateTime.Now.Millisecond);
                        Thread.Sleep(5);
                        int d = en.Next(1, 101);
                        if (d > 0 & d <= 90)
                        {
                            fight = 1;
                        }
                        else
                        {
                            fight = 2;
                        }
                        bat.Battle();
                    }
                    else
                        if (action == "3")
                        {
                            pla.Screen();
                        }
                        else
                            if (action == "4" & questsemicompleted5 == 1 & killedguard == 0)
                            {
                                bat.Battle();
                            }
                            else
                            {
                                ma.SoutheastWarren();
                            }

            }
        }
    }
}
