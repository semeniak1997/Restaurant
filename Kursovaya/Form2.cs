using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Collections;

namespace Kursovaya
{
    
    public partial class Form2 : Form
    {
        private readonly ErrorProvider errorProvider;
       public delegate void HumanAddHandler(object sender, HumanEventArgs e);
        public event HumanAddHandler HumanAdded;

        private ArrayList list = new ArrayList();

        public Form2()
        {
            InitializeComponent();
            errorProvider = new ErrorProvider(this); //ссылка на ошибки
            errorProvider.BlinkRate = 0;
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string namestring = textBoxName.Text.ToString();
            string surenamenamestring = textBoxSurename.Text.ToString();
            string GSMstring = textBoxGSM.Text.ToString();
            string pattern2 = @"[А-Я}{1}[а-я]|[A-Z]{1}[a-z]";
            string pattern1 = @"^\+375(29|33|44)[0-9]{7}$";
            string pattern = @"[А-Я}{1}[а-я]|[A-Z]{1}[a-z]";
            int count = 0;

            if (textBoxName.Text == "")
            {              
                errorProvider.SetError(textBoxName, "Поле пустое");                        
            } 
            else
            {
                count++;
            }
            if(textBoxSurename.Text == "")
            {
                errorProvider.SetError(textBoxSurename, "Поле пустое");
            }
            else
            {
                count++;
            }
            if(textBoxGSM.Text == "")
            {
                errorProvider.SetError(textBoxGSM, "Пустое поле");
            }
            else
            {
                count++;
            }
            if (listBoxHours.Text == "")
            {

                errorProvider.SetError(listBoxMinutes, "Укажите время");

            }
            else
            {
                count++;
            }

            if(listBoxMinutes.Text == "")
            {
                errorProvider.SetError(listBoxMinutes, "Укажите время");
            }
            else
            {
                count++;
            }
            if (!Regex.IsMatch(surenamenamestring, pattern))
            {
                errorProvider.SetError(textBoxSurename, "Некорректно введена фамилия, можно использовать только символы русского или английского алфавита и должно начинаться с большой буквы. Пример: Иванов или Ivanov");

            }
            else
            {
                count++;
            }
            if (!Regex.IsMatch(namestring, pattern2))
            {
                errorProvider.SetError(textBoxName, "Некорректно введено имя, можно использовать только символы русского или английского алфавита и должно начинаться с большой буквы. Пример: Никита или Nikita");
            }
            else
            {
                count++;
            }
            if(!Regex.IsMatch(GSMstring, pattern1))
            {
                errorProvider.SetError(textBoxGSM, "Некорректно введен номер телефона, Пример: +375291234567");
            }
            else
            {
                count++;
            }
            if (count == 8)
            {
                list.Add(new Human(textBoxName.Text, textBoxSurename.Text, textBoxGSM.Text, DateTime.Parse(this.dateTimePicker1.Text), listBoxHours.Text, listBoxMinutes.Text));
                Form3 fr3 = new Form3();
                this.HumanAdded += fr3.Show_list;
                if (HumanAdded != null) HumanAdded(this, new HumanEventArgs(list));
                MessageBox.Show("Вы прошли валидацию :)");                
                fr3.Show();
                Hide();
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
           
        }
    }
}

