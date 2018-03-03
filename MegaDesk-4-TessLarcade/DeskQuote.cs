using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MegaDesk_4_TessLarcade.Desk;

namespace MegaDesk_4_TessLarcade
{
    class DeskQuote
    {
        #region Object variables
        private DateTime QuoteDate { get; set; }
        private Desk Desk = new Desk();
        private int RushDays { get; set; }
        private int QuotePrice { get; set; }
        public MainMenu Tag { get; internal set; }
        #endregion

        #region Constants 
        private const int basePrice = 200;
        private const int drawerPrice = 50;
        private const int baseSize = 1000;
        private const int surfaceAreaPrice = 1;
        private const int rush1 = 3;
        private const int rush2 = 5;
        private const int rush3 = 7;
        private const int rushMax = 2000;
        #endregion

        public int surfaceArea = 0;

        public DeskQuote(int width, int depth, int drawers, DesktopMaterial material, int rush)
        {
            Desk.deskWidth = width;
            Desk.deskDepth = depth;
            Desk.deskDrawers = drawers;
            Desk.Desktopmaterial = material;
            RushDays = rush;

            surfaceArea = Desk.deskWidth * Desk.deskDepth;
        }
        public int quoteTotal()
        {
            return basePrice + surfaceAreaCost() + drawerCost() + (int)Desk.Desktopmaterial+ RushCost();
        }

        private int surfaceAreaCost()
        {
            if (surfaceArea > 1000) {
                return surfaceArea - 1000; 
                    }
            else
            {
                return 0;
            }
                
        }

        private int drawerCost()
        {
            return Desk.deskDrawers * 50;
        }

        private int RushCost()
        {
            if (RushDays == 3)
            {
                if (surfaceArea < 1000)
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
