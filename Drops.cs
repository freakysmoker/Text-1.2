using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ConsoleApplication1
{
    class Drops : Info
    {
        public void RatDrop()
        {
            Random dropgold = new Random(DateTime.Now.Millisecond);
            Thread.Sleep(5);
            int dg = dropgold.Next(1, 6);

            Random droptail = new Random(DateTime.Now.Millisecond);
            Thread.Sleep(5);
            int dt = droptail.Next(1, 101);

            Random dropexp = new Random(DateTime.Now.Millisecond);
            Thread.Sleep(5);
            int dx = dropexp.Next(1, 11);

            Console.WriteLine("You've received {0} Experience and {1} Gold\n", dx, dg);
            gold = gold + dg;
            playerxp = playerxp + dx;
            if (dt > 50)
            {
                Console.WriteLine("You've obtained a rat tail!\n");
                rattails = rattails + 1;
            }
            pla.Leveling();
        }

        public void QuesttwoDrop()
        {
            Random dropgold = new Random(DateTime.Now.Millisecond);
            Thread.Sleep(5);
            int dg = dropgold.Next(10, 26);

            Random dropexp = new Random(DateTime.Now.Millisecond);
            Thread.Sleep(5);
            int dx = dropexp.Next(20, 36);

            Random dropitem = new Random(DateTime.Now.Millisecond);
            Thread.Sleep(5);
            int di = dropitem.Next(1, 101);

            Console.WriteLine("You've received {0} Experience and {1} Gold\n", dx, dg);
            gold = gold + dg;
            playerxp = playerxp + dx;

            if (di <= 10)
            {
                Console.WriteLine("You've obtained Leather Leggings!\n");
                numberofleatherlegs = numberofleatherlegs + 1;
            }
            else
                if (di >= 90)
                {
                    Console.WriteLine("You've obtained a Leather Chest!\n");
                    numberofleatherchest = numberofleatherchest + 1;
                }
                else
                    if (di >= 45 && di <= 55)
                    {
                        Console.WriteLine("You've obtained a Leather Helm!\n");
                        numberofleatherhelms = numberofleatherhelms + 1;
                    }
            pla.Leveling();

        }

        public void QuestfiveDrop()
        {
            Random dropgold = new Random(DateTime.Now.Millisecond);
            Thread.Sleep(5);
            int dg = dropgold.Next(16, 36);

            Random dropexp = new Random(DateTime.Now.Millisecond);
            Thread.Sleep(5);
            int dx = dropexp.Next(31, 46);

            Random dropitem = new Random(DateTime.Now.Millisecond);
            Thread.Sleep(5);
            int di = dropitem.Next(1, 101);

            Console.WriteLine("You've received {0} Experience and {1} Gold\n", dx, dg);
            gold = gold + dg;
            playerxp = playerxp + dx;

            if (di <= 10)
            {
                Console.WriteLine("You've obtained Leather Leggings!\n");
                numberofleatherlegs = numberofleatherlegs + 1;
            }
            else
                if (di >= 90)
                {
                    Console.WriteLine("You've obtained a Leather Chest!\n");
                    numberofleatherchest = numberofleatherchest + 1;
                }
                else
                    if (di >= 45 && di <= 55)
                    {
                        Console.WriteLine("You've obtained a Leather Helm!\n");
                        numberofleatherhelms = numberofleatherhelms + 1;
                    }
            pla.Leveling();
        }

        public void BanditDrop()
        {
            Random dropgold = new Random(DateTime.Now.Millisecond);
            Thread.Sleep(5);
            int dg = dropgold.Next(10, 26);

            Random dropexp = new Random(DateTime.Now.Millisecond);
            Thread.Sleep(5);
            int dx = dropexp.Next(20, 36);

            Random dropitem = new Random(DateTime.Now.Millisecond);
            Thread.Sleep(5);
            int di = dropitem.Next(1, 101);

            Console.WriteLine("You've received {0} Experience and {1} Gold\n", dx, dg);
            gold = gold + dg;
            playerxp = playerxp + dx;

            if (di <= 10)
            {
                Console.WriteLine("You've obtained Leather Leggings!\n");
                numberofleatherlegs = numberofleatherlegs + 1;
            }
            else
                if (di >= 90)
                {
                    Console.WriteLine("You've obtained a Leather Chest!\n");
                    numberofleatherchest = numberofleatherchest + 1;
                }
                else
                    if (di >= 45 && di <= 55)
                    {
                        Console.WriteLine("You've obtained a Leather Helm!\n");
                        numberofleatherhelms = numberofleatherhelms + 1;
                    }
            pla.Leveling();

        }

        public void GuardDrop()
        {
            Random dropgold = new Random(DateTime.Now.Millisecond);
            Thread.Sleep(5);
            int dg = dropgold.Next(10, 26);

            Random dropexp = new Random(DateTime.Now.Millisecond);
            Thread.Sleep(5);
            int dx = dropexp.Next(20, 36);

            Random dropitem = new Random(DateTime.Now.Millisecond);
            Thread.Sleep(5);
            int di = dropitem.Next(1, 101);

            Console.WriteLine("You've received {0} Experience and {1} Gold\n", dx, dg);
            gold = gold + dg;
            playerxp = playerxp + dx;

            if (di <= 5)
            {
                Console.WriteLine("You've obtained an Iron Chest!\n");
                numberofironchest = numberofironchest + 1;
            }
            else
                if (di >= 95)
                {
                    Console.WriteLine("You've obtained an Iron Spear!\n");
                    numberofironspears = numberofironspears + 1;
                }
            pla.Leveling();
        }



    }
}
