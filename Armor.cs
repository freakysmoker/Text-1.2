using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Armor : Info
    {
        public void Armorrating()
        {
            armordefence = helmarmor + chestarmor + legarmor;
        }

        public void ArmorNames()
        {
            if (hashelm == 0)
            {
                helmname = "none";
            }
            else
                if (hashelm == 1)
                {
                    helmname = "Leather Helmet";
                }
                else
                    if (hashelm == 2)
                    {
                        helmname = "Iron Helmet";
                    }
            if (haschest == 0)
            {
                chestname = "none";
            }
            else
                if (haschest == 1)
                {
                    chestname = "Leather Chest";
                }
                else
                    if (haschest == 2)
                    {
                        chestname = "Iron Chest";
                    }
            if (haslegs == 0)
            {
                legname = "none";
            }
            else
                if (haslegs == 1)
                {
                    legname = "Leather Leggings";
                }
                else
                    if (haslegs == 2)
                    {
                        legname = "Iron Leggings";
                    }
        }

        public void EquipLeatherHelm()
        {
            hashelm = 1;
            helmarmor = 1;
        }

        public void EquipLeatherChest()
        {
            haschest = 1;
            chestarmor = 1;
        }

        public void EquipLeatherLeg()
        {
            haslegs = 1;
            legarmor = 1;
        }

        public void EquipIronChest()
        {
            haschest = 2;
            chestarmor = 2;
        }

        public void EquipIronLeg()
        {
            haslegs = 2;
            legarmor = 2;
        }

        public void EquipIronHelm()
        {
            hashelm = 2;
            helmarmor = 2;
        }

        public void CheckForArmor()
        {
            if (hashelm == 1 & numberofleatherhelms == 0)
            {
                UnequipHelm();
            }
            if (haschest == 1 & numberofleatherchest == 0)
            {
                UnequipChest();
            }
            if (haslegs == 1 & numberofleatherlegs == 0)
            {
                UnequipLeg();
            }
            if (haschest == 2 & numberofironchest == 0)
            {
                UnequipChest();
            }
            if (haslegs == 2 & numberofironlegs == 0)
            {
                UnequipLeg();
            }
            if (hashelm == 2 & numberofironhelms == 0)
            {
                UnequipHelm();
            }
        }

        public void UnequipHelm()
        {
            hashelm = 0;
            helmarmor = 0;
        }

        public void UnequipChest()
        {
            haschest = 0;
            chestarmor = 0;
        }

        public void UnequipLeg()
        {
            haslegs = 0;
            legarmor = 0;
        }

    }
}
