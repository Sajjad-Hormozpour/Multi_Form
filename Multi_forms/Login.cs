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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        string username = "admin";
        string password = "admin";
        Form1 form1 = new Form1();

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == username)
            {
                if (textBox2.Text == password)
                    form1.Show();
            }

        }


        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("are you sure you want to exit ?", " EXIT", MessageBoxButtons.YesNo);
            if (dr == DialogResult.No)
                e.Cancel = true;
            if (dr == DialogResult.Yes) 
                this.Dispose();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "admin" && textBox2.Text == "admin")
            {
                form1.Show();
                this.Hide();
            }
        }
    }
}
