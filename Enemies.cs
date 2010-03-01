using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ConsoleApplication1
{
    class Enemies : Info
    {
        public void EnemyStatistic()
        {
            if (fight == 1)//rats status
            {
                enemyattack = 0;
                enemystrength = 4;
                enemyhp = 10;
                enemyname = "Rat";
                enemymaxhp = 10;

            }
            else
            if (fight == 50)//man in cave moor status
            {
                enemyattack = 3;
                enemystrength = 7;
                enemyhp = 25;
                enemyname = "Man";
                enemymaxhp = 25;
            }
            else
                if (fight == 51)//guard involved in assasination status
                {
                    enemyattack = 5;
                    enemystrength = 10;
                    enemyhp = 35;
                    enemyname = "Guard";
                    enemymaxhp = 35;
                }
                else
                    if (fight == 2)//bandits status
                    {
                        enemyattack = 3;
                        enemystrength = 9;
                        enemyhp = 25;
                        enemyname = "Bandit";
                        enemymaxhp = 25;
                    }
                    else
                        if (fight == 3)//guards statis
                        {
                            enemyattack = 3;
                            enemystrength = 7;
                            enemyhp = 25;
                            enemyname = "Guard";
                            enemymaxhp = 25;
                        }
        }

        public void EnemyHit()
        {
            Random hit = new Random();
            n = hit.Next(enemyattack, enemystrength);
            arm.Armorrating();
            n = n - armordefence;
            if (n < 0)
            {
                n = 0;
            }
        }
    }
}
