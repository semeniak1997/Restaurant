using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Windows.Forms;

namespace Kursovaya
{
    public partial class Borshch : Form
    {
        public delegate void HumanAddHandler(object sender, HumanEventArgs e);
        public event HumanAddHandler HumanAdded;
        private ArrayList list = new ArrayList();
        private readonly ErrorProvider errorProvider;

        public Borshch()
        {
            InitializeComponent();
            errorProvider = new ErrorProvider(this); //ссылка на ошибки
            errorProvider.BlinkRate = 0;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            PervoeBludoForm pervoebludo = new PervoeBludoForm();
            pervoebludo.Show();
            Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form3 fr3 = new Form3();
            fr3.Show();
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "")
            { comboBox1.SelectedIndex = 0;
                list.Add(new Human("Первые блюда", "Борщ", 1.25, double.Parse(this.comboBox1.Text = "1")));
                Form3 fr3 = new Form3();
                this.HumanAdded += fr3.Show_list;
                if (HumanAdded != null) HumanAdded(this, new HumanEventArgs(list));
                fr3.Show();
                Hide();
            }
            else
            {
                list.Add(new Human("Первые блюда", "Борщ", 1.25, double.Parse(this.comboBox1.Text)));
                Form3 fr3 = new Form3();
                this.HumanAdded += fr3.Show_list;
                if (HumanAdded != null) HumanAdded(this, new HumanEventArgs(list));
                fr3.Show();
                Hide();
            }
        }

        private void Ресторан_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
