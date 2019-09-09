using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Kursovaya
{
    public partial class Deserty : Form
    {
        public delegate void EatAddHandler(object sender, EatEventArgs e);
        public event EatAddHandler EatAdded;
        public delegate void CountAddHandler(object sender, CountEventArgs e);
        public event CountAddHandler CountAdded;
        public double x;
        public double y;
        private ArrayList list = new ArrayList();
        public Deserty()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (comboBox1.Text == "")
            {
                comboBox1.SelectedIndex = 0;
                list.Add(new Eat(labelDesert.Text, label6.Text, 0.80, double.Parse(this.comboBox1.Text = "1")));
                x = 0.80 * 1.0;
                Form3 fr3 = new Form3();
                this.EatAdded += fr3.Show_list1;
                if (EatAdded != null) EatAdded(this, new EatEventArgs(list));
                this.CountAdded += fr3.Show_Count;
                if (CountAdded != null) CountAdded(this, new CountEventArgs(x));
                MessageBox.Show("Ваш заказ добавлен в список");

            }
            else
            {
                list.Add(new Eat(labelDesert.Text, label6.Text, 0.80, double.Parse(this.comboBox1.Text)));
                y = double.Parse((this.comboBox1.Text));
                x = 0.80 * y;
                Form3 fr3 = new Form3();
                this.EatAdded += fr3.Show_list1;
                if (EatAdded != null) EatAdded(this, new EatEventArgs(list));
                this.CountAdded += fr3.Show_Count;
                if (CountAdded != null) CountAdded(this, new CountEventArgs(x));
                MessageBox.Show("Ваш заказ добавлен в список");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (comboBox2.Text == "")
            {
                comboBox2.SelectedIndex = 0;
                list.Add(new Eat(labelDesert.Text, label12.Text, 1.10, double.Parse(this.comboBox2.Text = "1")));
                x = 1.10 * 1.0;
                Form3 fr3 = new Form3();
                this.EatAdded += fr3.Show_list1;
                if (EatAdded != null) EatAdded(this, new EatEventArgs(list));
                this.CountAdded += fr3.Show_Count;
                if (CountAdded != null) CountAdded(this, new CountEventArgs(x));
                MessageBox.Show("Ваш заказ добавлен в список");
            }
            else
            {
                list.Add(new Eat(labelDesert.Text, label12.Text, 1.10, double.Parse(this.comboBox2.Text)));
                y = double.Parse((this.comboBox2.Text));
                x = 1.10 * y;
                Form3 fr3 = new Form3();
                this.EatAdded += fr3.Show_list1;
                if (EatAdded != null) EatAdded(this, new EatEventArgs(list));
                this.CountAdded += fr3.Show_Count;
                if (CountAdded != null) CountAdded(this, new CountEventArgs(x));
                MessageBox.Show("Ваш заказ добавлен в список");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (comboBox3.Text == "")
            {
                comboBox3.SelectedIndex = 0;
                list.Add(new Eat(labelDesert.Text, label18.Text, 1.20, double.Parse(this.comboBox3.Text = "1")));
                x = 1.20 * 1.0;
                Form3 fr3 = new Form3();
                this.EatAdded += fr3.Show_list1;
                if (EatAdded != null) EatAdded(this, new EatEventArgs(list));
                this.CountAdded += fr3.Show_Count;
                if (CountAdded != null) CountAdded(this, new CountEventArgs(x));
                MessageBox.Show("Ваш заказ добавлен в список");
            }
            else
            {
                list.Add(new Eat(labelDesert.Text, label18.Text, 1.20, double.Parse(this.comboBox3.Text)));
                y = double.Parse((this.comboBox3.Text));
                x = 1.20 * y;
                Form3 fr3 = new Form3();
                this.EatAdded += fr3.Show_list1;
                if (EatAdded != null) EatAdded(this, new EatEventArgs(list));
                this.CountAdded += fr3.Show_Count;
                if (CountAdded != null) CountAdded(this, new CountEventArgs(x));
                MessageBox.Show("Ваш заказ добавлен в список");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (comboBox4.Text == "")
            {
                comboBox4.SelectedIndex = 0;
                list.Add(new Eat(labelDesert.Text, label24.Text, 1.05, double.Parse(this.comboBox4.Text = "1")));
                x = 1.05 * 1.0;
                Form3 fr3 = new Form3();
                this.EatAdded += fr3.Show_list1;
                if (EatAdded != null) EatAdded(this, new EatEventArgs(list));
                this.CountAdded += fr3.Show_Count;
                if (CountAdded != null) CountAdded(this, new CountEventArgs(x));
                MessageBox.Show("Ваш заказ добавлен в список");
            }
            else
            {
                list.Add(new Eat(labelDesert.Text, label24.Text, 1.05, double.Parse(this.comboBox4.Text)));
                y = double.Parse((this.comboBox4.Text));
                x = 1.05 * y;
                Form3 fr3 = new Form3();
                this.EatAdded += fr3.Show_list1;
                if (EatAdded != null) EatAdded(this, new EatEventArgs(list));
                this.CountAdded += fr3.Show_Count;
                if (CountAdded != null) CountAdded(this, new CountEventArgs(x));
                MessageBox.Show("Ваш заказ добавлен в список");
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (comboBox5.Text == "")
            {
                comboBox5.SelectedIndex = 0;
                list.Add(new Eat(labelDesert.Text, label30.Text, 1.70, double.Parse(this.comboBox5.Text = "1")));
                x = 1.70 * 1.0;
                Form3 fr3 = new Form3();
                this.EatAdded += fr3.Show_list1;
                if (EatAdded != null) EatAdded(this, new EatEventArgs(list));
                this.CountAdded += fr3.Show_Count;
                if (CountAdded != null) CountAdded(this, new CountEventArgs(x));
                MessageBox.Show("Ваш заказ добавлен в список");
            }
            else
            {
                list.Add(new Eat(labelDesert.Text, label30.Text, 1.70, double.Parse(this.comboBox5.Text)));
                y = double.Parse((this.comboBox5.Text));
                x = 1.70 * y;
                Form3 fr3 = new Form3();
                this.EatAdded += fr3.Show_list1;
                if (EatAdded != null) EatAdded(this, new EatEventArgs(list));
                this.CountAdded += fr3.Show_Count;
                if (CountAdded != null) CountAdded(this, new CountEventArgs(x));
                MessageBox.Show("Ваш заказ добавлен в список");
            }
        }
        private void button8_Click(object sender, EventArgs e)
        {
            if (comboBox6.Text == "")
            {
                comboBox6.SelectedIndex = 0;
                list.Add(new Eat(labelDesert.Text, label36.Text, 0.70, double.Parse(this.comboBox6.Text = "1")));
                x = 0.70 * 1.0;
                Form3 fr3 = new Form3();
                this.EatAdded += fr3.Show_list1;
                if (EatAdded != null) EatAdded(this, new EatEventArgs(list));
                this.CountAdded += fr3.Show_Count;
                if (CountAdded != null) CountAdded(this, new CountEventArgs(x));
                MessageBox.Show("Ваш заказ добавлен в список");
            }
            else
            {
                list.Add(new Eat(labelDesert.Text, label36.Text, 0.70, double.Parse(this.comboBox6.Text)));
                y = double.Parse((this.comboBox6.Text));
                x = 0.70 * y;
                Form3 fr3 = new Form3();
                this.EatAdded += fr3.Show_list1;
                if (EatAdded != null) EatAdded(this, new EatEventArgs(list));
                this.CountAdded += fr3.Show_Count;
                if (CountAdded != null) CountAdded(this, new CountEventArgs(x));
                MessageBox.Show("Ваш заказ добавлен в список");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
