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
    public partial class HighSecurity_password : Form
    {   
        account acc;
        account a;
        public string bal1;
        OleDbConnection con = new OleDbConnection();
        OleDbCommand com = new OleDbCommand();
        OleDbDataReader dr;
        Int32 count;
       
        public HighSecurity_password(account acc2)
        {
            InitializeComponent();
            acc = acc2;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" & textBox2.Text != "")
            {
                if (textBox1.Text == "1")
                {
                    com.Connection = con;
                    com.CommandText = "select cbal from account where rno='" + acc.apu + "' ";
                    string status = Convert.ToString(com.ExecuteScalar());
                    Int32 status1 = Convert.ToInt32(status);
                    Int32 status2 = Convert.ToInt32(textBox2.Text);
                    Int32 status3 = (status1 + status2);
                    string status4 = Convert.ToString(status3);
                    com.CommandText = " update account set cbal='" + status4 + "' where rno= '" + acc.apu + "' ";
                    MessageBox.Show("balance updated successfully");
                    com.ExecuteNonQuery();
                    com.Dispose();
                    this.Close();

                }
                else
                {
                    MessageBox.Show("wrong secure password");
                    textBox1.Text = "";

                }
            }

            else
            {
                MessageBox.Show("enter all entries");

            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string context = this.textBox2.Text;



            for (int i = 0; i < context.Length; i++)
            {

                if (char.IsNumber(context[i]))
                {


                }
                else
                {

                    MessageBox.Show("only numbers are allowed");
                    textBox2.Text = "";
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void HighSecurity_password_Load(object sender, EventArgs e)
        {

          
            con.ConnectionString = "Provider=OraOLEDB.Oracle.1;Persist Security Info=False;User ID=mca1226;PASSWORD=User202;Data Source=nitt";
            try
            {
                con.Open();
                if (Convert.ToBoolean(con.State))
                {
                   
                    com.Connection = con;
                }
            }
            catch
            {
                MessageBox.Show("Connection Failed");
            }
        }
    }
}
