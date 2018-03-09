using MegaDesk;
using System;

namespace CalcQuote
{
   public class DeskQuote
    {
        #region Object variables
        public DateTime QuoteDate { get; set; }
        private Desk Desk = new Desk();
        private int RushDays { get; set; }
        private int QuotePrice { get; set; }
        #endregion

        #region Constants 
        const int drawerPrice = 50;
        const int baseSize = 1000;
        const int surfaceAreaPrice = 1;
        const int rush1 = 3;
        const int rush2 = 5;
        const int rush3 = 7;
        const int rushMax = 2000;
        #endregion

        public int surfaceArea;
        int desktop;
        string desktopMaterial;
        public int DeskDrawers;


        public DeskQuote(int width, int depth, int drawers, string material, int rush)
        {
            surfaceArea = width * depth;
            desktopMaterial = material;
            RushDays = rush;
            DeskDrawers = drawers;

        }

        public int quoteTotal()
        {
            return 200 + surfaceAreaCost() + drawerCost() + materialCost() + RushCost();
        }

        private int materialCost()
        {
            if (desktopMaterial == "Oak")
            {
                return 200;
            }
            else if (desktopMaterial == "Laminate")
            {
                return 100;
            }
            else if (desktopMaterial == "Pine")
            {
                return 500;
            }
            else if (desktopMaterial == "Rosewood")
            {
                return 300;
            }
            else if (desktopMaterial == "Veneer")
            {
                return 150;
            }
            else
            {
                return 0;
            }
        }
            private int surfaceAreaCost()
        {
            if (surfaceArea > 1000)
            {
                return surfaceArea - 1000;
            }
            else
            {
                return 0;
            }

        }

        private int drawerCost()
        {
            return DeskDrawers * 50;
        }

        private int RushCost()
        {
            if (RushDays == 3)
            {
                if (surfaceArea > 1000)
                {
                    return 60;
                }
                else if (surfaceArea < 2000)
                {
                    return 70;
                }
                else
                {
                    return 80;
                }
            }
            else if (RushDays == 5)
            {
                if (surfaceArea < 1000)
                {
                    return 40;
                }
                else if (surfaceArea < 2000)
                {
                    return 50;
                }
                else
                {
                    return 60;
                }
            }
            else if (RushDays == 7)
            {
                if (surfaceArea < 1000)
                {
                    return 30;
                }
                else if (surfaceArea < 2000)
                {
                    return 35;
                }
                else
                {
                    return 40;
                }
            }
            else return 0;
        }
    }
}
