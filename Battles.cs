using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ConsoleApplication1
{
    class Battles : Info
    {
        public void Battle()
        {
            if (killedman == 1)//will only go here once, related to Missing Friend.
            {
                fight = 50;
            }
            if (questsemicompleted5 == 1 & questcompleted5 == 0)//will only go here once, related to Assasination
            {
                fight = 51;
            }
            if (enemygreet == 1)
            {
                ene.EnemyStatistic();
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("\n{0} appears!\n", enemyname);
                Console.ForegroundColor = ConsoleColor.White;
                Thread.Sleep(1500);
                enemygreet = 0;
            }
            if (enemyhp == enemymaxhp)
            {
                ene.EnemyStatistic();
            }
            else
                if (enemyhp <= 0)
                {
                    ene.EnemyStatistic();
                }

            while (alive)
            {
                Console.WriteLine("___________________________________________________________");
                decimal one_percent = (decimal)(playermaxhp / 100.0);
                decimal value = (decimal)playerhp;
                Console.Write("{0}'s HP: ",name);
                if (value >= (one_percent * 61))
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("{0}\n", playerhp);
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else if (value >= (one_percent * 26) && value <= (one_percent * 60))
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("{0}\n",playerhp);
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else if (value <= (one_percent * 25))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("{0}\n", playerhp);
                    Console.ForegroundColor = ConsoleColor.White;
                }
                decimal two_percent = (decimal)(enemymaxhp / 100.0);
                decimal value1 = (decimal)enemyhp;
                Console.Write("{0}'s HP: ",enemyname);
                if (value1 >= (two_percent * 61))
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("{0}\n", enemyhp);
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else if (value1 >= (two_percent * 26) && value1 <= (two_percent * 60))
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("{0}\n", enemyhp);
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else if (value1 <= (two_percent * 25))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("{0}\n", enemyhp);
                    Console.ForegroundColor = ConsoleColor.White;
                }
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("");
                Console.WriteLine("1. Fight");
                Console.WriteLine("2. Status");
                Console.WriteLine("3. Run away");
                Console.WriteLine("___________________________________________________________");
                string what = Console.ReadLine();
                if (what == "1")
                {
                    pla.OnStrPotion();
                    wep.Force();
                    Console.WriteLine("you hit {0} Hp", h);
                    enemyhp = enemyhp - h;
                    Thread.Sleep(500);
                    if (enemyhp > 0)
                    {
                        ene.EnemyHit();
                        Console.WriteLine("{1} hits you {0} hp", n,enemyname);
                        playerhp = playerhp - n;
                        Thread.Sleep(500);
                        pla.Death();
                        Console.Clear();
                    }
                    else
                        if (enemyhp <= 0)
                        {
                            enemygreet = 1;

                            if (fight == 1)
                            {
                                dro.RatDrop();
                            }
                            if (fight == 2)
                            {
                                dro.BanditDrop();
                            }
                            if (fight == 3)
                            {
                                dro.GuardDrop();
                            }
                            if (fight == 50)
                            {
                                killedman = 2;
                                que.MissingFriend();
                            }
                            if (fight == 51)
                            {
                                killedguard = 1;
                                dro.QuestfiveDrop();
                                que.Assasinationcompleted();
                            }
                            fight = 0;
                            onstrpot = 0;
                            ma.Locations();
                        }
                }
                else
                    if (what == "2")
                    {
                        pla.Screen();
                    }
                    else
                        if (what == "3")
                        {
                            if (fight == 50 | fight == 51)
                            {
                                Console.WriteLine("You can't run from this battle!");
                                Thread.Sleep(1500);
                                continue;
                            }
                            onstrpot = 0;
                            enemygreet = 1;
                            fight = 0;
                            ma.Locations();
                        }
            }
        }
    }
}
