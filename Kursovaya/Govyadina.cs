﻿using System;
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
    public partial class Govyadina : Form
    {
        public Govyadina()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            VtoryeBludaForm vtorblud = new VtoryeBludaForm();
            vtorblud.Show();
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
