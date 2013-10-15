using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace project
{
    public partial class HighSecurity_password : Form
    {
        public HighSecurity_password()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                if (textBox1.Text == "1")
                {
                    MessageBox.Show("database not connected");
                   // MessageBox.Show("Current balance updated successfully");
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("wrong secure password");
                }
            }
            else
            {
                MessageBox.Show("you have not entered secure password");

            }
        }
    }
}
