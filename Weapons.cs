using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Security.Cryptography;

namespace ConsoleApplication1
{
    class Weapons : Info
    {
      
       
        public void Force()
        {
            Weaponcalculation();
            
            Random hit = new Random();
            h = hit.Next(playermaxattack, playermaxstrength);

            Random crit = new Random(DateTime.Now.Millisecond);
            Thread.Sleep(5);
            int c = crit.Next(1, 101);
            
            if (playercritchance > c)
            {
                h = h * 2;
                Console.WriteLine("You've hit a critical blow!");
            }
        }
     
        public void WeaponNames()
        {
            if (hasweapon == 0)
            {
                weaponname = "none";
            }
            else
                if (hasweapon == 1)
                {
                    weaponname = "Bronze Dagger";
                }
                else
                    if (hasweapon == 2)
                    {
                        weaponname = "Bronze Sword";
                    }
                    else
                        if (hasweapon == 3)
                        {
                            weaponname = "Iron Spear";
                        }

        }

        public void Weaponcalculation()
        {
            playermaxattack = playerattack + weaponattack;
            playermaxstrength = playerstrength + weaponstrength + enhancedstr;
            finalcriticalchance = playerbasecritical + playercritchance;
        }

        public void UnequipWeapon()
        {
            hasweapon = 0;
            weaponstrength = 0;
            weaponattack = 0;
            playercritchance = 0;
        }

        public void CheckForWeapon()
        {
            if (hasweapon == 1 & numberofbronzedaggers == 0)
            {
                UnequipWeapon();
            }
            else
                if (hasweapon == 2 & numberofbronzeswords == 0)
                {
                    UnequipWeapon();
                }
                else
                    if (hasweapon == 3 & numberofironspears == 0)
                    {
                        UnequipWeapon();
                    }
        }

        public void EquipIronSpear()
        {
            hasweapon = 3;
            weaponstrength = 5;
            weaponattack = 1;
            playercritchance = 5;
        }

        public void EquipBronzeDagger()
        {
            hasweapon = 1;
            weaponstrength = 3;
            weaponattack = 1;
            playercritchance = 10;
            
        }

        public void EquipBronzeSword()
        {
            hasweapon = 2;
            weaponstrength = 5;
            weaponattack = 0;
            playercritchance = 0;
           
        }
    }
}
