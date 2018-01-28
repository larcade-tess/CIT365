using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_3_TessLarcade
{
    class Desk
    {
        int width = 34;
        int depth = 20;


        private void validateDepth()
        {
            if (depth < 48 && depth > 12)
            {
                Console.WriteLine(depth);
            }
            else
            {
                return;
            }


        }
    }
}
