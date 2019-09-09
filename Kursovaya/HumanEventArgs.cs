using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Kursovaya
{
    public class HumanEventArgs : System.EventArgs

    {
        //Сообщение
        public ArrayList people;

        public HumanEventArgs(ArrayList _people)
        {
            people = _people;
        }
    }
    
}
