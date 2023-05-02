using System;
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
    public partial class PayForm : Form
    {
        SearchForm sf = new SearchForm();
        public Form1 form;
        public PayForm()
        {
            InitializeComponent();
            sf.pf = this;
        }

        private void PayForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            sf.textBox1.Text = "";
            sf.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox2.Text + "مبلغ :" + textBox1.Text);
            string t = textBox1.Text;
            string y = textBox2.Text;
            form.Box.Items.Add("Code daneshjooyi :" + t + " Mablagh: " + y);
            this.Hide();
            textBox1.Text = "";
            textBox2.Text = "";
            
        }
    }
}
