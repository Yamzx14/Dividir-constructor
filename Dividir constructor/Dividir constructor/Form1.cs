﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dividir_constructor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Divicionclass Divi = new Divicionclass
                (int.Parse(textBox1.Text),
                int.Parse(textBox2.Text));

            textBox3.Text = Divi.Dividir().ToString();
        }
    }
}
