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
    public partial class addbal : Form
    {
        public addbal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {   if(textBox1.Text !="")
            {
                HighSecurity_password h2 = new HighSecurity_password();
                this.Hide();
                h2.ShowDialog();
            }
            else
            {
                MessageBox.Show("please enter amount to be added");
            }


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string context = this.textBox1.Text;



            for (int i = 0; i < context.Length; i++)
            {

                if (char.IsNumber(context[i]))
                {


                }
                else
                {

                    MessageBox.Show("only numbers are allowed");



                }
            }
        }
    }
}
