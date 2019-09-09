using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Kursovaya
{ 
    public class Human
    {      
        public string name { get; set; }
        public string surname { get; set; }
        public string GSM { get; set; }
        public DateTime date { get; set; }
        public string hours { get; set; }
        public string minutes { get; set; }

        public Human()
        { }

        public Human(string name, string surname, string GSM, DateTime date, string hours, string minutes)
        {
            this.name = name;
            this.surname = surname;
            this.GSM = GSM;
            this.date = date;
            this.hours = hours;
            this.minutes = minutes;
        }        
        public override string ToString()
        {
            return String.Format("Имя: {0} {1}\nТелефон: {2}\n Дата: {3}\n Время: {4}:{5} \n \n", name, surname, GSM, date, hours, minutes);
        }

    }
}
