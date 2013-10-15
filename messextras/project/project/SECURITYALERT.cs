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
    public partial class SECURITYALERT : Form
    {
        public SECURITYALERT()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "1")
            {
                MessageBox.Show("database not connected");
             /*  sucessregister s1 = new sucessregister();
                    this.Hide();
                    s1.ShowDialog();*/
                
            }
            else
            {
                MessageBox.Show("Wrong secure password");
            }
        }
    }
}
