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
    public partial class Alkogolnye : Form
    {
       
        public Alkogolnye()
        {
            InitializeComponent();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LuisRoderer luis = new LuisRoderer();
            luis.Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Kaberne kaberne = new Kaberne();
            kaberne.Show();
            Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            JimBeam jim = new JimBeam();
            jim.Show();
            Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Finland fin = new Finland();
            fin.Show();
            Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Carlsberg carlsberg = new Carlsberg();
            carlsberg.Show();
            Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CapitanMorgan capitan = new CapitanMorgan();
            capitan.Show();
            Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form3 fr3 = new Form3();
            fr3.Show();
            Hide();
        }
    }
}
