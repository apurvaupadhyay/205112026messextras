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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "205112026")
            {
                if (textBox2.Text == "apurva")
                {
                    account A1 = new account();
                    this.Hide();
                    A1.ShowDialog();
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Sorry.... you entered wrong userid or password");
                textBox1.Clear();
                textBox2.Clear();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Int32 flag = 0;
            string context = this.textbox5.Text;

            //  bool isnum = false;
            // bool issymbol = false;

            for (int i = 0; i < context.Length; i++)
            {   

                if (char.IsLetter(context[i]) || char.IsWhiteSpace(context[i]))
                {

                    //  isnum = true;

                    //  break;

                }
                else
                {
                    // this.textBox5.Text = " only alphabats";
                   // MessageBox.Show("Name should contain alphabats only");
                    flag = 1;



                }
            }
                string context1 = this.textBox6.Text;



            for (int i = 0; i < context1.Length; i++)
            {

                if (char.IsNumber(context1[i]))
                {


                }
                else
                {

                   // MessageBox.Show("Phone number should be numeric");
                    flag = 1;



                }
            }
                 string context2 = this.textBox7.Text;



                 for (int i = 0; i < context2.Length; i++)
                 {

                     if (char.IsNumber(context2[i]))
                     {


                     }
                     else
                     {

                       //  MessageBox.Show("Roll number should be numeric");
                         flag = 1;



                     }
                 }
                 string context3 = this.textBox10.Text;



            for (int i = 0; i < context3.Length; i++)
            {

                if (char.IsNumber(context3[i]))
                {


                }
                else
                {

                   // MessageBox.Show("balance should be numeric");
                    flag = 1;



                }


            }
            if (textBox3.Text != "" & textBox4.Text != "" & textbox5.Text != "" & textBox6.Text != "" & textBox7.Text != "" & textBox8.Text != "" & textBox9.Text != "" & textBox10.Text != "" & textBox12.Text != "" & Secretword.Text != "")
            {
               
            }
            else
            {
               // MessageBox.Show("please fillup all the details");
                flag = 1;
            }
            if (flag == 0)
            {   
                SECURITYALERT S2 = new SECURITYALERT();

                S2.ShowDialog();
            }
            else
            {
                MessageBox.Show("please fill all the details in correct format");
            }

                



        }

        private void textBox7_Validating(object sender, CancelEventArgs e)
        {

        }

        private void textBox7_TextChanged_1(object sender, EventArgs e)
        {
            string context = this.textBox7.Text;



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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            string context = this.textbox5.Text;

           

            for (int i = 0; i < context.Length; i++)
            {

                if (char.IsLetter(context[i]) || char.IsWhiteSpace(context[i]))
                {

                    

                }
                else
                {
                    // this.textBox5.Text = " only alphabats";
                    MessageBox.Show("only alphabats are allowed");



                }

                // if (isnum)
                // {

                //   this.textBox5.Text = "numbers not allowed";

                // }

            }
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            string context = this.textBox8.Text;

           

            for (int i = 0; i < context.Length; i++)
            {

                if (char.IsLetter(context[i]) || char.IsWhiteSpace(context[i])||char.IsPunctuation(context[i]))
                {

                }
                else
                {
                   
                    MessageBox.Show("only alphabats,whitespace,puntuation are allowed");



                }

                

            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            string context = this.textBox6.Text;



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

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            string context = this.textBox7.Text;



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

        private void textBox6_Validating(object sender, CancelEventArgs e)
        {
           
        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
          
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            string context = this.textBox10.Text;



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

        
       

        private void reset_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textbox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            textBox10.Text = "";
            textBox12.Text = "";

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (textBox1.Text != "")
            {
                forgetpass f1 = new forgetpass();
                f1.ShowDialog();
            }
            else
            {
                MessageBox.Show("please enter userid first");
            }
        }

        private void textBox7_Validated(object sender, EventArgs e)
        {
          
        }

        private void textBox6_Validated(object sender, EventArgs e)
        {
            
        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
