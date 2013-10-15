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
    public partial class account : Form
    {
        public account()
        {
            InitializeComponent();
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            //textBox9.Text = "500";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //this.Hide();
            addbal  ab1 = new addbal();
            //this.Hide();
            ab1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                for (int i = 0; i < checkedListBox1.Items.Count; i++)
                {
                    if (checkedListBox1.GetItemChecked(i))
                    {
                        string str = (string)checkedListBox1.Items[i];
                        MessageBox.Show(str);
                    }

                }
            }
            if (radioButton2.Checked == true)
            {
                for (int i = 0; i < checkedListBox2.Items.Count; i++)
                {
                    if (checkedListBox2.GetItemChecked(i))
                    {
                        string str = (string)checkedListBox2.Items[i];
                        MessageBox.Show(str);
                    }

                }
            }
            if (radioButton3.Checked == true)
            {
                for (int i = 0; i < checkedListBox3.Items.Count; i++)
                {
                    if (checkedListBox2.GetItemChecked(i))
                    {
                        string str = (string)checkedListBox3.Items[i];
                        MessageBox.Show(str);
                    }

                }
            }
            
            if (radioButton1.Checked == true || radioButton2.Checked == true || radioButton3.Checked == true)
            {   
               
                MessageBox.Show("database not connected");
               // MessageBox.Show("Thank you for using messextras system\nTake the printout and get your dish");
            }
            else
            {
                MessageBox.Show("please choose a schedule");
            }

        
        }



        private void button3_Click(object sender, EventArgs e)
        {
            sucesslogout s1 = new sucesslogout();
            this.Hide();
            s1.ShowDialog();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

            if (radioButton1.Checked == true)
            {
                this.Show();
            }
            
        }

        private void account_Load(object sender, EventArgs e)
        {
            textBox1.Text = "Apurva upadhyay";
            textBox1.Show();
            textBox2.Text = "9043876649";
            textBox2.Show();
            textBox4.Text = "205112026";
            textBox4.Show();
            textBox3.Text = "mca";
            textBox3.Show();
            textBox5.Text = "ca";
            textBox5.Show();
            textBox7.Text = "opale";
            textBox7.Show();
            textBox8.Text = "53";
            textBox9.Text = "500";
            textBox9.Show();
            textBox8.Show();
            pictureBox2.Hide();
            pictureBox3.Hide();
            pictureBox4.Hide();
            checkedListBox1.Hide();
            checkedListBox2.Hide();
            checkedListBox3.Hide();
            


        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                pictureBox3.Visible = false;
                pictureBox3.Hide();
                pictureBox4.Visible = false;
                pictureBox4.Hide();
                pictureBox2.Visible = true;
                pictureBox2.Show();
                checkedListBox1.Visible = true;
                checkedListBox2.Visible = false;
                checkedListBox3.Visible = false;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                pictureBox2.Visible = false;
                pictureBox2.Hide();
                pictureBox4.Visible = false;
                pictureBox4.Hide();
                pictureBox3.Visible = true;
                pictureBox3.Show();
                checkedListBox2.Visible = true;
                checkedListBox1.Visible = false;
                checkedListBox3.Visible = false;
                
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked == true)
            {
                pictureBox2.Visible = false;
                pictureBox2.Hide();
                pictureBox3.Visible = false;
                pictureBox3.Hide();
                pictureBox4.Visible = true;
                pictureBox4.Show();
                checkedListBox3.Visible = true;
                checkedListBox1.Visible = false;
                checkedListBox2.Visible = false;

            }
   
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           // textBox1.Text = "Apurva upadhyay";
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //textBox2.Text = "9043876649";

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
           // textBox4.Text = "205112026";

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
          //  textBox3.Text = "mca";
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
          //  textBox5.Text = "ca";
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            //textBox7.Text = "opale";
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
          //  textBox8.Text = "53";
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        { 
           /* if (radioButton1.Checked == true)
            {
                checkedListBox1.Visible = true;
            }*/
        }

        private void checkedListBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*if (radioButton3.Checked == true)
            {
                checkedListBox3.Visible = true;
            }*/
        }

        private void checkedListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
           /* if (radioButton2.Checked == true)
            {
                checkedListBox2.Visible = true;
            }*/
        }
    }
}
