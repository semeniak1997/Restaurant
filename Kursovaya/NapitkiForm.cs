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
    public partial class NapitkiForm : Form
    {
        public delegate void EatAddHandler(object sender, EatEventArgs e);
        public event EatAddHandler EatAdded;
        public delegate void CountAddHandler(object sender, CountEventArgs e);
        public event CountAddHandler CountAdded;
        public double x;
        public double y;
        private ArrayList list = new ArrayList();

        public NapitkiForm()
        {
            InitializeComponent();
          
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "")
            {
                comboBox1.SelectedIndex = 0;
                list.Add(new Eat(labelBezAlco.Text, labelMoloko.Text, 1.30, double.Parse(this.comboBox1.Text = "1")));
                x = 1.30 * 1.0;
                Form3 fr3 = new Form3();
                this.EatAdded += fr3.Show_list1;
                if (EatAdded != null) EatAdded(this, new EatEventArgs(list));
                this.CountAdded += fr3.Show_Count;
                if (CountAdded != null) CountAdded(this, new CountEventArgs(x));
                MessageBox.Show("Ваш заказ добавлен в список");

            }
            else
            {
                list.Add(new Eat(labelBezAlco.Text, labelMoloko.Text, 1.30, double.Parse(this.comboBox1.Text)));
                y = double.Parse((this.comboBox1.Text));
                x = 1.30 * y;
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
            if (comboBox2.Text == "")
            {
                comboBox2.SelectedIndex = 0;
                list.Add(new Eat(labelBezAlco.Text, label9.Text, 1.10, double.Parse(this.comboBox2.Text = "1")));
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
                list.Add(new Eat(labelBezAlco.Text, label9.Text, 1.10, double.Parse(this.comboBox2.Text)));
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox3.Text == "")
            {
                comboBox3.SelectedIndex = 0;
                list.Add(new Eat(labelBezAlco.Text, label13.Text, 0.75, double.Parse(this.comboBox3.Text = "1")));
                x = 0.75 * 1.0;
                Form3 fr3 = new Form3();
                this.EatAdded += fr3.Show_list1;
                if (EatAdded != null) EatAdded(this, new EatEventArgs(list));
                this.CountAdded += fr3.Show_Count;
                if (CountAdded != null) CountAdded(this, new CountEventArgs(x));
                MessageBox.Show("Ваш заказ добавлен в список");
            }
            else
            {
                list.Add(new Eat(labelBezAlco.Text, label13.Text, 0.75, double.Parse(this.comboBox3.Text)));
                y = double.Parse((this.comboBox3.Text));
                x = 0.75 * y;
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
                list.Add(new Eat(labelBezAlco.Text, label17.Text, 1.80, double.Parse(this.comboBox4.Text = "1")));
                x = 1.80 * 1.0;
                Form3 fr3 = new Form3();
                this.EatAdded += fr3.Show_list1;
                if (EatAdded != null) EatAdded(this, new EatEventArgs(list));
                this.CountAdded += fr3.Show_Count;
                if (CountAdded != null) CountAdded(this, new CountEventArgs(x));
                MessageBox.Show("Ваш заказ добавлен в список");
            }
            else
            {
                list.Add(new Eat(labelBezAlco.Text, label17.Text, 1.80, double.Parse(this.comboBox4.Text)));
                y = double.Parse((this.comboBox4.Text));
                x = 1.80 * y;
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
            if (comboBox5.Text == "")
            {
                comboBox5.SelectedIndex = 0;
                list.Add(new Eat(labelBezAlco.Text, label21.Text, 0.40, double.Parse(this.comboBox5.Text = "1")));
                x = 0.40 * 1.0;
                Form3 fr3 = new Form3();
                this.EatAdded += fr3.Show_list1;
                if (EatAdded != null) EatAdded(this, new EatEventArgs(list));
                this.CountAdded += fr3.Show_Count;
                if (CountAdded != null) CountAdded(this, new CountEventArgs(x));
                MessageBox.Show("Ваш заказ добавлен в список");
            }
            else
            {
                list.Add(new Eat(labelBezAlco.Text, label21.Text, 0.40, double.Parse(this.comboBox5.Text)));
                y = double.Parse((this.comboBox5.Text));
                x = 0.40 * y;
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
                list.Add(new Eat(labelBezAlco.Text, label25.Text, 1.10, double.Parse(this.comboBox6.Text = "1")));
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
                list.Add(new Eat(labelBezAlco.Text, label25.Text, 1.10, double.Parse(this.comboBox6.Text)));
                y = double.Parse((this.comboBox6.Text));
                x = 1.10 * y;
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
            if (comboBox7.Text == "")
            {
                comboBox7.SelectedIndex = 0;
                list.Add(new Eat(labelAlco.Text, label29.Text, 22.00, double.Parse(this.comboBox7.Text = "1")));
                x = 22.00 * 1.0;
                Form3 fr3 = new Form3();
                this.EatAdded += fr3.Show_list1;
                if (EatAdded != null) EatAdded(this, new EatEventArgs(list));
                this.CountAdded += fr3.Show_Count;
                if (CountAdded != null) CountAdded(this, new CountEventArgs(x));
                MessageBox.Show("Ваш заказ добавлен в список");
            }
            else
            {
                list.Add(new Eat(labelAlco.Text, label29.Text, 22.00, double.Parse(this.comboBox7.Text)));
                y = double.Parse((this.comboBox7.Text));
                x = 22.00 * y;
                Form3 fr3 = new Form3();
                this.EatAdded += fr3.Show_list1;
                if (EatAdded != null) EatAdded(this, new EatEventArgs(list));
                this.CountAdded += fr3.Show_Count;
                if (CountAdded != null) CountAdded(this, new CountEventArgs(x));
                MessageBox.Show("Ваш заказ добавлен в список");
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (comboBox8.Text == "")
            {
                comboBox8.SelectedIndex = 0;
                list.Add(new Eat(labelAlco.Text, label33.Text, 18.00, double.Parse(this.comboBox8.Text = "1")));
                x = 18.00 * 1.0;
                Form3 fr3 = new Form3();
                this.EatAdded += fr3.Show_list1;
                if (EatAdded != null) EatAdded(this, new EatEventArgs(list));
                this.CountAdded += fr3.Show_Count;
                if (CountAdded != null) CountAdded(this, new CountEventArgs(x));
                MessageBox.Show("Ваш заказ добавлен в список");
            }
            else
            {
                list.Add(new Eat(labelAlco.Text, label33.Text, 18.00, double.Parse(this.comboBox8.Text)));
                y = double.Parse((this.comboBox8.Text));
                x = 18.00 * y;
                Form3 fr3 = new Form3();
                this.EatAdded += fr3.Show_list1;
                if (EatAdded != null) EatAdded(this, new EatEventArgs(list));
                this.CountAdded += fr3.Show_Count;
                if (CountAdded != null) CountAdded(this, new CountEventArgs(x));
                MessageBox.Show("Ваш заказ добавлен в список");
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (comboBox9.Text == "")
            {
                comboBox8.SelectedIndex = 0;
                list.Add(new Eat(labelAlco.Text, label37.Text, 38.00, double.Parse(this.comboBox9.Text = "1")));
                x = 38.00 * 1.0;
                Form3 fr3 = new Form3();
                this.EatAdded += fr3.Show_list1;
                if (EatAdded != null) EatAdded(this, new EatEventArgs(list));
                this.CountAdded += fr3.Show_Count;
                if (CountAdded != null) CountAdded(this, new CountEventArgs(x));
                MessageBox.Show("Ваш заказ добавлен в список");
            }
            else
            {
                list.Add(new Eat(labelAlco.Text, label37.Text, 38.00, double.Parse(this.comboBox9.Text)));
                y = double.Parse((this.comboBox9.Text));
                x = 38.00 * y;
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
            if (comboBox10.Text == "")
            {
                comboBox8.SelectedIndex = 0;
                list.Add(new Eat(labelAlco.Text, label41.Text, 30.00, double.Parse(this.comboBox10.Text = "1")));
                x = 30.00 * 1.0;
                Form3 fr3 = new Form3();
                this.EatAdded += fr3.Show_list1;
                if (EatAdded != null) EatAdded(this, new EatEventArgs(list));
                this.CountAdded += fr3.Show_Count;
                if (CountAdded != null) CountAdded(this, new CountEventArgs(x));
                MessageBox.Show("Ваш заказ добавлен в список");
            }
            else
            {
                list.Add(new Eat(labelAlco.Text, label41.Text, 30.00, double.Parse(this.comboBox10.Text)));
                y = double.Parse((this.comboBox10.Text));
                x = 30.00 * y;
                Form3 fr3 = new Form3();
                this.EatAdded += fr3.Show_list1;
                if (EatAdded != null) EatAdded(this, new EatEventArgs(list));
                this.CountAdded += fr3.Show_Count;
                if (CountAdded != null) CountAdded(this, new CountEventArgs(x));
                MessageBox.Show("Ваш заказ добавлен в список");
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (comboBox11.Text == "")
            {
                comboBox11.SelectedIndex = 0;
                list.Add(new Eat(labelAlco.Text, label45.Text, 2.70, double.Parse(this.comboBox11.Text = "1")));
                x = 2.70 * 1.0;
                Form3 fr3 = new Form3();
                this.EatAdded += fr3.Show_list1;
                if (EatAdded != null) EatAdded(this, new EatEventArgs(list));
                this.CountAdded += fr3.Show_Count;
                if (CountAdded != null) CountAdded(this, new CountEventArgs(x));
                MessageBox.Show("Ваш заказ добавлен в список");
            }
            else
            {
                list.Add(new Eat(labelAlco.Text, label45.Text, 2.70, double.Parse(this.comboBox11.Text)));
                y = double.Parse((this.comboBox11.Text));
                x = 2.70 * y;
                Form3 fr3 = new Form3();
                this.EatAdded += fr3.Show_list1;
                if (EatAdded != null) EatAdded(this, new EatEventArgs(list));
                this.CountAdded += fr3.Show_Count;
                if (CountAdded != null) CountAdded(this, new CountEventArgs(x));
                MessageBox.Show("Ваш заказ добавлен в список");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
