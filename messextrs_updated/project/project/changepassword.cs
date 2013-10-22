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
    public partial class changepassword : Form
    {
        OleDbConnection con = new OleDbConnection();
        OleDbCommand com = new OleDbCommand();
        OleDbDataReader dr;
        Int32 count;
       
        public changepassword()
        {
            InitializeComponent();
        }

        private void changepassword_Load(object sender, EventArgs e)
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

        private void username_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if((username.Text != "") & (cpassword.Text != "") & (npassword.Text != "" ) &  (n2password.Text != "") & (hint.Text != ""))
            {
                com.Connection = con;
                        com.CommandText = "select password from login where rno='" + username.Text + "' ";
                        string pwd = Convert.ToString(com.ExecuteScalar());
                      //  MessageBox.Show(pwd);
                        
                if(pwd != "")
                {   
                    if(pwd == cpassword.Text)
                    {
                        if(npassword.Text== n2password.Text)
                        {   com.Connection = con;
                           com.CommandText = " update login set password='" + n2password.Text +  "' where rno= '" + username.Text + "' ";
                           com.ExecuteNonQuery();
                           com.CommandText = " update login set hint='" + hint.Text + "' where rno= '" + username.Text + "' ";
                           com.ExecuteNonQuery();
                           com.Dispose();
                           MessageBox.Show("PASSWORD AND HINT HAS BEEN CHANGED");
                           this.Close();
                        }
                        else
                        {
                            MessageBox.Show("REENTER PASSWORD DOES NOT MATCH WITH NEW PASSWORD");
                            npassword.Text = "";
                            n2password.Text = "";
                        }

                    }
                    else
                    {
                        MessageBox.Show("WRONG CURRENT PASSWORD");
                        cpassword.Text = "";
                    }

          
                }
                else
                {
                    MessageBox.Show("NO SUCH USER EXIST");
                    username.Text = "";
                }
            }
            else
            {
                MessageBox.Show("PLEASE FILL ALL THE ENTRIES");
            }
        }
    }
}
