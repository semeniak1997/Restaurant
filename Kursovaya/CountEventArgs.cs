using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursovaya
{
   public class CountEventArgs: System.EventArgs
    {
        public double result;
        public CountEventArgs(double _result)
        {
            result = _result;
        }
    }
}
