using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace project
{
    public partial class forgetpass : Form
    {
        OleDbConnection con = new OleDbConnection();
        OleDbCommand com = new OleDbCommand();
        OleDbDataReader dr;
        Int32 count;
       
        public forgetpass()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void forgetpass_Load(object sender, EventArgs e)
        {
           /* pass.Hide();
            password.Hide();
            button1.Hide();
            */
        }

        private void ok_Click(object sender, EventArgs e)
        {
           /* if (secret.Text != "")
            {
                password.Show();
                pass.Show();
                button1.Show();
            }
            else
            {
                MessageBox.Show("please enter your secret word");
            }
            */
        }

        private void button1_Click(object sender, EventArgs e)
        {
           // this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
