using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_4_TessLarcade
{
    class Desk
    {
        public int deskWidth { get; set; }
        public int deskDepth { get; set; }
        public int deskDrawers { get; set; }
        public DesktopMaterial Desktopmaterial { get; set; }

        public const int MINWIDTH = 24;
        public const int MAXWIDTH = 96;
        public const int MINDEPTH = 12;
        public const int MAXDEPTH = 48;

        public enum DesktopMaterial
        {
            Oak = 200,
            Laminate = 100,
            Pine = 50,
            Rosewood =300,
            Veneer = 150
        };
    }
}
