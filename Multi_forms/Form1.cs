﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Multi_forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            pf.form = this;
        }

        PayForm pf = new PayForm();
    
        private void button1_Click(object sender, EventArgs e)
        {
            pf.Show();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();

        }
    }
}
