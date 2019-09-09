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
    public partial class VtoryeBludaForm : Form
    {
        public delegate void EatAddHandler(object sender, EatEventArgs e);
        public event EatAddHandler EatAdded;
        public delegate void CountAddHandler(object sender, CountEventArgs e);
        public event CountAddHandler CountAdded;
        public double x;
        public double y;
        private ArrayList list = new ArrayList();
        public VtoryeBludaForm()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "")
            {
                comboBox1.SelectedIndex = 0;
                list.Add(new Eat(labelVtor.Text, label6.Text, 1.50, double.Parse(this.comboBox1.Text = "1")));
                x = 1.50 * 1.0;
                Form3 fr3 = new Form3();
                this.EatAdded += fr3.Show_list1;
                if (EatAdded != null) EatAdded(this, new EatEventArgs(list));
                this.CountAdded += fr3.Show_Count;
                if (CountAdded != null) CountAdded(this, new CountEventArgs(x));
                MessageBox.Show("Ваш заказ добавлен в список");

            }
            else
            {
                list.Add(new Eat(labelVtor.Text, label6.Text, 1.50, double.Parse(this.comboBox1.Text)));
                y = double.Parse((this.comboBox1.Text));
                x = 1.50 * y;
                Form3 fr3 = new Form3();
                this.EatAdded += fr3.Show_list1;
                if (EatAdded != null) EatAdded(this, new EatEventArgs(list));
                this.CountAdded += fr3.Show_Count;
                if (CountAdded != null) CountAdded(this, new CountEventArgs(x));
                MessageBox.Show("Ваш заказ добавлен в список");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (comboBox2.Text == "")
            {
                comboBox2.SelectedIndex = 0;
                list.Add(new Eat(labelVtor.Text, label12.Text, 2.90, double.Parse(this.comboBox2.Text = "1")));
                x = 2.90 * 1.0;
                Form3 fr3 = new Form3();
                this.EatAdded += fr3.Show_list1;
                if (EatAdded != null) EatAdded(this, new EatEventArgs(list));
                this.CountAdded += fr3.Show_Count;
                if (CountAdded != null) CountAdded(this, new CountEventArgs(x));
                MessageBox.Show("Ваш заказ добавлен в список");
            }
            else
            {
                list.Add(new Eat(labelVtor.Text, label12.Text, 2.90, double.Parse(this.comboBox2.Text)));
                y = double.Parse((this.comboBox2.Text));
                x = 2.90 * y;
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
            if (comboBox3.Text == "")
            {
                comboBox3.SelectedIndex = 0;
                list.Add(new Eat(labelVtor.Text, label18.Text, 3.00, double.Parse(this.comboBox3.Text = "1")));
                x = 3.00 * 1.0;
                Form3 fr3 = new Form3();
                this.EatAdded += fr3.Show_list1;
                if (EatAdded != null) EatAdded(this, new EatEventArgs(list));
                this.CountAdded += fr3.Show_Count;
                if (CountAdded != null) CountAdded(this, new CountEventArgs(x));
                MessageBox.Show("Ваш заказ добавлен в список");
            }
            else
            {
                list.Add(new Eat(labelVtor.Text, label18.Text, 3.00, double.Parse(this.comboBox3.Text)));
                y = double.Parse((this.comboBox3.Text));
                x = 3.00 * y;
                Form3 fr3 = new Form3();
                this.EatAdded += fr3.Show_list1;
                if (EatAdded != null) EatAdded(this, new EatEventArgs(list));
                this.CountAdded += fr3.Show_Count;
                if (CountAdded != null) CountAdded(this, new CountEventArgs(x));
                MessageBox.Show("Ваш заказ добавлен в список");
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (comboBox4.Text == "")
            {
                comboBox4.SelectedIndex = 0;
                list.Add(new Eat(labelVtor.Text, label23.Text, 2.25, double.Parse(this.comboBox4.Text = "1")));
                x = 2.25 * 1.0;
                Form3 fr3 = new Form3();
                this.EatAdded += fr3.Show_list1;
                if (EatAdded != null) EatAdded(this, new EatEventArgs(list));
                this.CountAdded += fr3.Show_Count;
                if (CountAdded != null) CountAdded(this, new CountEventArgs(x));
                MessageBox.Show("Ваш заказ добавлен в список");
            }
            else
            {
                list.Add(new Eat(labelVtor.Text, label23.Text, 2.25, double.Parse(this.comboBox4.Text)));
                y = double.Parse((this.comboBox4.Text));
                x = 2.25 * y;
                Form3 fr3 = new Form3();
                this.EatAdded += fr3.Show_list1;
                if (EatAdded != null) EatAdded(this, new EatEventArgs(list));
                this.CountAdded += fr3.Show_Count;
                if (CountAdded != null) CountAdded(this, new CountEventArgs(x));
                MessageBox.Show("Ваш заказ добавлен в список");
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (comboBox5.Text == "")
            {
                comboBox5.SelectedIndex = 0;
                list.Add(new Eat(labelVtor.Text, label29.Text, 2.25, double.Parse(this.comboBox5.Text = "1")));
                x = 2.25 * 1.0;
                Form3 fr3 = new Form3();
                this.EatAdded += fr3.Show_list1;
                if (EatAdded != null) EatAdded(this, new EatEventArgs(list));
                this.CountAdded += fr3.Show_Count;
                if (CountAdded != null) CountAdded(this, new CountEventArgs(x));
                MessageBox.Show("Ваш заказ добавлен в список");
            }
            else
            {
                list.Add(new Eat(labelVtor.Text, label29.Text, 14.30, double.Parse(this.comboBox5.Text)));
                y = double.Parse((this.comboBox5.Text));
                x = 14.30 * y;
                Form3 fr3 = new Form3();
                this.EatAdded += fr3.Show_list1;
                if (EatAdded != null) EatAdded(this, new EatEventArgs(list));
                this.CountAdded += fr3.Show_Count;
                if (CountAdded != null) CountAdded(this, new CountEventArgs(x));
                MessageBox.Show("Ваш заказ добавлен в список");
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (comboBox6.Text == "")
            {
                comboBox6.SelectedIndex = 0;
                list.Add(new Eat(labelVtor.Text, label35.Text, 2.25, double.Parse(this.comboBox6.Text = "1")));
                x = 2.25 * 1.0;
                Form3 fr3 = new Form3();
                this.EatAdded += fr3.Show_list1;
                if (EatAdded != null) EatAdded(this, new EatEventArgs(list));
                this.CountAdded += fr3.Show_Count;
                if (CountAdded != null) CountAdded(this, new CountEventArgs(x));
                MessageBox.Show("Ваш заказ добавлен в список");
            }
            else
            {
                list.Add(new Eat(labelVtor.Text, label35.Text, 14.30, double.Parse(this.comboBox6.Text)));
                y = double.Parse((this.comboBox6.Text));
                x = 14.30 * y;
                Form3 fr3 = new Form3();
                this.EatAdded += fr3.Show_list1;
                if (EatAdded != null) EatAdded(this, new EatEventArgs(list));
                this.CountAdded += fr3.Show_Count;
                if (CountAdded != null) CountAdded(this, new CountEventArgs(x));
                MessageBox.Show("Ваш заказ добавлен в список");
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
