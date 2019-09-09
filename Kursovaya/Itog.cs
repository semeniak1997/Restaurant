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
    public partial class Itog : Form
    {
        public delegate void ButtonClickHandler(object sender, HumanEventArgs e);
        //public event ButtonClickHandler ButtonClicked;

        Dictionary<Eat, int> zakaz;
        string name;
        private List<Human> humanList;
        public Itog(/*Dictionary<Eat, int> zakazy, string name*/)
        {
            InitializeComponent();
            //zakaz = zakazy;
            //this.name = name;
            
        }
        //public void Show_List (object sender, HumanEventArgs e)
        //{
        //    foreach(Human human in e.people)
        //    {
        //        richTextBox2.Text += human.ToString();
        //    }
        //}
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

          
                }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {
            

            //richTextBox2.Text = humanList.ToString();

            //Form2 fr2 = this.Owner as Form2;
            //richTextBox2.Text += fr2.textBoxName.Text;
            //richTextBox2.Text += ((Carlsberg)this.Tag).label1.Text;


        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Form2 fr2 = new Form2();
            //fr2.HumanAdded += this.AddHuman_ButtonClicked;

        }
        //private void AddHuman_ButtonClicked(object sender, HumanEventArgs e)
        //{
        //    humanList.Add(e.Human);
            
        }
    }

