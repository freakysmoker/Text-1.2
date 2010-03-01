using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ConsoleApplication1
{
    class Map : Info
    {

        public void Locations()
        {
            if (location == 1 && fight == 0)
            {
                cit.Shang();
            }
            else
                if (location == 2 && fight == 0)
                {
                    SoutheastWarren();
                }
                else
                    if (location == 3 && fight == 0)
                    {
                        cav.CaveMoor();
                    }
                    else
                        if (location == 4 && fight == 0)
                        {
                            cit.Stonecity();
                        }
                        

            if (fight > 0)
            {
                bat.Battle();
            }
           

        }


        public void LocationNames()
        {
            if (discoveredCavemoor == 0)
            {
                cavemoorname = "Walk West";
            }
            else
                if (discoveredCavemoor == 1)
                {
                    cavemoorname = "Walk towards Cave Moor";
                }
            if (discoveredStoneCity == 0)
            {
                stonecityname = "Walk North";
            }
            else
                if (discoveredStoneCity == 1)
                {
                    stonecityname = "Walk towards Stone City";
                }


        }




        public void SoutheastWarren()
        {
            location = 2;
           
            
            while (alive)
            {
                LocationNames();
                Console.WriteLine("Location: South-East Warren\n");
                Console.WriteLine("1. {0}", cavemoorname);
                Console.WriteLine("2. {0}", stonecityname);
                Console.WriteLine("3. Walk to Shang Castle");
                Console.WriteLine("4. View status");
                string view = Console.ReadLine();
                if (view == "1")
                {
                        if (view == "1" & discoveredCavemoor == 0)
                        {
                            Console.Clear();
                            Console.WriteLine("As you walk West you discover an isolated cave, there's plenty of rat droppings near the entrance.\n");
                            Console.WriteLine("You discover Cave Moor.\n");
                            discoveredCavemoor = 1;
                            Thread.Sleep(3000);
                            cav.CaveMoor();
                        }
                        else
                            if (view == "1" & discoveredCavemoor == 1)
                            {
                                Console.WriteLine("You enter Cave Moor.");
                                Thread.Sleep(1500);
                                Console.Clear();
                                cav.CaveMoor();
                            }
                }
                else
                    if (view == "2")
                    {
                        if (discoveredStoneCity == 0)
                        {
                            Console.Clear();
                            Console.WriteLine("As you walk north you begin to notice several stone constructions.");
                            Console.WriteLine("You discover Stone City\n");
                            discoveredStoneCity = 1;
                            Thread.Sleep(3000);
                            cit.Stonecity();
                        }
                        else
                            if (discoveredStoneCity == 1)
                            {
                                Console.WriteLine("You enter Stone City.");
                                Thread.Sleep(1500);
                                Console.Clear();
                                cit.Stonecity();
                            }

                    }
                    else
                        if (view == "3")
                        {
                            Console.WriteLine("\n You return to Shang Castle.\n");
                            Thread.Sleep(1500);
                            cit.Shang();
                        }
                        else
                            if (view == "4")
                            {
                                pla.Screen();
                            }


            }

        }
    }
}
