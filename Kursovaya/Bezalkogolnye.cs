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
    public partial class Bezalkogolnye : Form
    {
        
        public Bezalkogolnye()
        {
            InitializeComponent();
          
        }

        private void Bezalkogolnye_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Moloko moloko = new Moloko();
            moloko.Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Coca coca = new Coca();
            coca.Show();
            Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AppleJ apple = new AppleJ();
            apple.Show();
            Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Kvas kvas = new Kvas();
            kvas.Show();
            Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Tee tee = new Tee();
            tee.Show();
            Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Coffe coffe = new Coffe();
            coffe.Show();
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
