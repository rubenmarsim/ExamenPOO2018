using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeedConversorStandard
{
    public class Calculus
    {
        virtual public int SpeedConversion(int parsecs)
        {
            int result = 0;
            result = parsecs * 1500;
            return result;
        }
    }
}
