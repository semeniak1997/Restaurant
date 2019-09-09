using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kursovaya
{
    public partial class Carlsberg : Form
    {
        Dictionary<Eat, int> zakaz;
        string username;
        public Carlsberg(/*Dictionary<Eat, int> zakazy, string name*/)
        {
            InitializeComponent();
            //zakaz = zakazy; username = name;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Alkogolnye alko = new Alkogolnye();
            alko.Show();
            Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form3 fr3 = new Form3(/*zakaz, username*/);
            fr3.Show();
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //zakaz.Add(eat, int.Parse(this.comboBox1.Text));
            //zakaz.Keys
            Itog itog = new Itog();
            itog.Tag = this;
        }

        private void Ресторан_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
