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

namespace Kursovaya
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            MessageBox.Show(ConnectionAvailable("http://www.google.com").ToString());

            bool ConnectionAvailable(string strServer)
            {
                try
                {
                    HttpWebRequest reqFP = (HttpWebRequest)HttpWebRequest.Create(strServer);

                    HttpWebResponse rspFP = (HttpWebResponse)reqFP.GetResponse();
                    if (HttpStatusCode.OK == rspFP.StatusCode)
                    {
                        // HTTP = 200 - Интернет безусловно есть! 
                        rspFP.Close();
                        Form2 fr2 = new Form2();
                        fr2.Show();
                        Hide();
                        MessageBox.Show("Мы проверяли Ваше интернет-соединение");
                        return true;

                    }
                    else
                    {
                        // сервер вернул отрицательный ответ, возможно что инета нет
                        rspFP.Close();
                        MessageBox.Show("Отсутствует интренет-соединение!");
                        return false;

                    }
                }
                catch (WebException)
                {
                    MessageBox.Show("Отсутствует интренет-соединение!");
                    return false;
                }
            }


        }
    }
}

