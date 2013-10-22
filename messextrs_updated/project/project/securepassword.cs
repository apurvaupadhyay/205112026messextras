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
    public partial class securepassword : Form
    {
        Form1 frm2;
       
        OleDbConnection con = new OleDbConnection();
        OleDbCommand com = new OleDbCommand();
        OleDbDataReader dr;
        Int32 count;
       
        public securepassword(Form1 frm3)
        {   
            InitializeComponent();
            frm2 = frm3;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" & textBox2.Text != "")
            {
                if (textBox1.Text == "1")
                {
                    com.Connection = con;

                    com.CommandText = "insert into account(rno , name,phone, Course,dept, Hname , hroom ,cbal ) values ('" + frm2.rollno + "','" + frm2.name + "','" + frm2.phone + "','" + frm2.course + "','" + frm2.dept + "','" + frm2.hname + "','" + frm2.hroom + "','" + textBox2.Text + "')";
                    com.ExecuteNonQuery();
                    /*     com.Dispose();
                      */
                    com.CommandText = "insert into login(rno ,password,hint) values ('" + frm2.rollno + "','" + frm2.password + "','" + frm2.hint + "')";
                    // com.Connection = con;
                    com.ExecuteNonQuery();
                    com.Dispose();
                    sucessregister s1 = new sucessregister();
                    this.Hide();
                    s1.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show(" SORRY !!! WRONG SECURE PASSWORD");
                    textBox1.Text = "";
                }
            }
            else
            {
                MessageBox.Show("PLEASE FILL UP ALL DETAILS");

            }
        }

        private void securepassword_Load(object sender, EventArgs e)
        {
            con.ConnectionString = "Provider=OraOLEDB.Oracle.1;Persist Security Info=False;User ID=mca1226;PASSWORD=User202;Data Source=nitt";
            try
            {
                con.Open();
                if (Convert.ToBoolean(con.State))
                {
                   // MessageBox.Show("Connection Success");
                    com.Connection = con;


                }
            }
            catch
            {
                MessageBox.Show("CONNECTION FAILED");
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

                    MessageBox.Show("SORRY ! YOU CAN ENTER ONLY NUMBERS");
                    textBox2.Text = "";
                    



                }


            }
            
        }
    }
}
