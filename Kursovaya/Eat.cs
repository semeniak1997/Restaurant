using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursovaya
{
    class Eat
    {
        public string typeOfEat { get; set; }
        public string bludo { get; set; }
        public double prise { get; set; }
        public double kolichestvo { get; set; }

        public Eat(){}

        public Eat(string typeOfEat, string bludo, double prise, double kolichestvo)
        {
            this.typeOfEat = typeOfEat;
            this.bludo = bludo;
            this.prise = prise;
            this.kolichestvo = kolichestvo;
        }

        public override string ToString()
        {
            return String.Format("{0}: {1}, Цена:{2} бел.руб Количесвтво порций - {3} \n \n",typeOfEat, bludo, prise, kolichestvo);
        }
    }
}
