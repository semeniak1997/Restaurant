using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Kursovaya
{
   public class EatEventArgs: System.EventArgs
    {
        //Сообщение
        public ArrayList MyEat;

        public EatEventArgs(ArrayList _MyEat)
        {
            MyEat = _MyEat;
        }
    }
}
