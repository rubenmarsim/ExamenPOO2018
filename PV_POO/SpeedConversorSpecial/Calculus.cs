using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeedConversorSpecial
{
    public class Calculus : SpeedConversorStandard.Calculus
    {
        public override int SpeedConversion(int parsecs)
        {
            parsecs *= 15000;
            int result = 0;
            result = parsecs * 1500;
            return result;
        }

        public int SpeedConversion(int parsecs, string nave)
        {
            int res = 0;
            if (nave.Equals("XW"))
            {
                res = base.SpeedConversion(parsecs) * 3;
            }
            else if (nave.Equals("CS"))
            {
                res = base.SpeedConversion(parsecs) * 2;
            }
            else
            {
                res = base.SpeedConversion(parsecs);
            }
            
            return res;
        }
    }
}
