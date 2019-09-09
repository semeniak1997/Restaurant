using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace Kursovaya
{
    public partial class Form3 : Form
    {
        private double z = 0;
        private string s = "Итог: ";
        public Form3()
        {             
            InitializeComponent();          
        }
       
        public void Show_list(object sender, HumanEventArgs e)
        {
            foreach(Human human in e.people)
            {
                richTextBox1.Text += human.ToString();
            }           
        }

        public void Show_list1(object sender, EatEventArgs e)
        {
            foreach (Eat eat in e.MyEat)
            {
                richTextBox1.Text += eat.ToString();
            }

        }
       public void Show_Count(object sender, CountEventArgs e)
        {
           z += e.result;           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PervoeBludoForm pervoe = new PervoeBludoForm();          
            pervoe.EatAdded += this.Show_list1;
            pervoe.CountAdded += this.Show_Count;
            pervoe.Show();            
        }
        private void button2_Click(object sender, EventArgs e)
        {
            VtoryeBludaForm vtorblud = new VtoryeBludaForm();
            vtorblud.EatAdded += this.Show_list1;
            vtorblud.CountAdded += this.Show_Count;
            vtorblud.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Souce souce = new Souce();
            souce.EatAdded += this.Show_list1;
            souce.CountAdded += this.Show_Count;
            souce.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SalatyForm salat = new SalatyForm();
            salat.EatAdded += this.Show_list1;
            salat.CountAdded += this.Show_Count;
            salat.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Deserty deserty = new Deserty();
            deserty.EatAdded += this.Show_list1;
            deserty.CountAdded += this.Show_Count;
            deserty.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            NapitkiForm napitki = new NapitkiForm();
            napitki.EatAdded += this.Show_list1;
            napitki.CountAdded += this.Show_Count;
            napitki.Show();
        }
        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = z.ToString();
            button8.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button1.Enabled = false;
            textBox1.Enabled = false;
            button7.Enabled = true;
        }       
        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox1.Text == "0")
            {
                MessageBox.Show("Вы ничего не заказали!");
            }
            else
            {
                MailAddress from = new MailAddress("systemrestCustomer@gmail.com", "System_Customer");
                MailAddress to = new MailAddress("System_rest_nik@mail.ru");
                MailMessage m = new MailMessage(from, to);
                m.Subject = "Новый заказ!!!";
                m.Body = richTextBox1.Text.ToString() + s + textBox1.Text.ToString();
                SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
                smtp.Credentials = new NetworkCredential("systemrestCustomer@gmail.com", "mefebi29");
                smtp.EnableSsl = true;
                smtp.Send(m);
                MessageBox.Show("Ваш заказ отправлен");
                Final final = new Final();
                final.Show();
                Hide();
            }
        }

       
    }
}
