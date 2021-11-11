using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT4._3
{
    class PS
    {
        public static float USCLN(float a, float b)
        {
            if (b == 0)
                return a;
            else
                return USCLN(b, a % b);
        }
    }
}
