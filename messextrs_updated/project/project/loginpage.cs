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

{   //public string a;
    public partial class Form1 : Form
    {
        public string a;
        public string rollno;
        public string name;
        public string phone;
        public string course;
        public string dept;
        public string hname;
        public string hroom;
        public string cbal;
        public string password;
        public string hint;
        account ac;
        securepassword s1;
        OleDbConnection con = new OleDbConnection();
        OleDbCommand com = new OleDbCommand();
        OleDbDataReader dr;
        Int32 count;
       
        
        
        
        public Form1()
        {
            
            InitializeComponent();
          //  ac = new account(this);
           
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
            if (textBox1.Text != "" & textBox2.Text != "")
            {
                com.Connection = con;
                com.CommandText = "select password from login where rno='" + textBox1.Text + "' ";

                string pwd = Convert.ToString(com.ExecuteScalar());

                bool result = pwd.Equals(textBox2.Text, StringComparison.Ordinal);

                if (result)
                {

                    a = textBox1.Text;
                    ac = new account(this);
                    this.Hide();
                    ac.ShowDialog();
                    this.Close();
                }
                else
                {
                    textBox1.Text = "";
                    textBox2.Text = "";
                    MessageBox.Show("SORRY !!! WRONG USERNAME OR PASSWORD");
                }
            }
            else
            {
                MessageBox.Show("PLEASE FILL USERNAME AND PASSWORD");
            }
         
        }

        private void button2_Click(object sender, EventArgs e)
        {   


            if (textBox3.Text != "" & textBox4.Text != "" & textbox5.Text != "" & textBox6.Text != "" & textBox7.Text != "" & textBox8.Text != "" & textBox9.Text != ""  & textBox12.Text != "" & Secretword.Text != ""  )
            {
                int flag = 1;
                Int64 rollnumber = Convert.ToInt64(textBox7.Text);
                Int64 phonenumber = Convert.ToInt64(textBox6.Text);
                if (rollnumber >= 10000000)
                {
                    if (rollnumber <= 999999999)
                    {
                    }
                    else
                    {
                        flag = 0;
                        MessageBox.Show("ROLLNUMBER SHOULD BE OF 9 DIGITS");
                        textBox7.Text = "";

                    }
                }
                else
                {
                    flag = 0;
                    MessageBox.Show("ROLLNUMBER SHOULD BE OF 9 DIGITS");
                    textBox7.Text = "";


                }
                if (phonenumber >= 1000000000)
                {
                    if (phonenumber <= 9999999999)
                    {
                    }
                    else
                    {
                        flag = 0;
                        MessageBox.Show("PHONENUMBERS SHOULD BE OF 10 DIGITS");
                        textBox6.Text = "";
                    }
                }
                else
                {
                    flag = 0;
                    MessageBox.Show("PHONENUMBER SHOULD BE OF !) DIGITS");
                    textBox6.Text = "";
                }

                if (flag == 1)
                {
                    
                        //a2 = textBox7.Text;
                        com.Connection = con;
                        com.CommandText = "select password from login where rno='" + textBox7.Text + "' ";

                        string pwd = Convert.ToString(com.ExecuteScalar());

                        bool result;
                        if (pwd == string.Empty)
                        {
                            result = true;
                        }
                        else
                        {
                            result = false;
                        }
                        if (result == true)
                        {
                            rollno = textBox7.Text;
                            name = textbox5.Text;
                            phone = textBox6.Text;
                            course = textBox8.Text;
                            dept = textBox9.Text;
                            hname = textBox3.Text;
                            hroom = textBox4.Text;
                            password = textBox12.Text;
                            hint = Secretword.Text;



                            s1 = new securepassword(this);
                            this.Hide();
                            s1.ShowDialog();
                            this.Close();

                          /*  com.Connection = con;

                            com.CommandText = "insert into account(rno , name,phone, Course,dept, Hname , hroom ,cbal ) values ('" + textBox7.Text + "','" + textbox5.Text + "','" + textBox6.Text + "','" + textBox8.Text + "','" + textBox9.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox10.Text + "')";
                            com.ExecuteNonQuery();
                            /*     com.Dispose();
                              */
                          /* com.CommandText = "insert into login(rno ,password,hint) values ('" + textBox7.Text + "','" + textBox12.Text + "','" + Secretword.Text + "')";
                            // com.Connection = con;
                            com.ExecuteNonQuery();
                            com.Dispose();
                            sucessregister s1 = new sucessregister();
                            this.Hide();
                            s1.ShowDialog();
                            this.Close();
                            */
                            
                        }

                        else
                        {
                            MessageBox.Show("user already registered");

                            textBox1.Text = "";
                            textBox2.Text = "";
                            textBox3.Text = "";
                            textBox4.Text = "";
                            textbox5.Text = "";
                            textBox6.Text = "";
                            textBox7.Text = "";
                            textBox8.Text = "";
                            textBox9.Text = "";
                            
                            textBox12.Text = "";
                            Secretword.Text = "";
                        }
                    
                   

                }
            }
            else
            {
                MessageBox.Show("PLEASE FILL ALL THE DETAILS");
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

                    MessageBox.Show("SORRY !!!ONLY NUMBERS ARE ALLOWED");
                    textBox7.Text = "";



                }
           

            }
            

            
        }

        private void Form1_Load(object sender, EventArgs e)
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
                    
                    MessageBox.Show("SORRY !!! ONLY ALPHABATS ARE ALLOWED");
                    textbox5.Text = "";



                }

                

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
                    textBox8.Text = "";



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
                    textBox6.Text = "";



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
                    textBox7.Text = "";



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
            textBox12.Text = "";
            Secretword.Text = "";

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (textBox1.Text != "")
            {
                com.Connection = con;
                com.CommandText = "select hint from login where rno='" + textBox1.Text + "' ";

                string pwd = Convert.ToString(com.ExecuteScalar());

              //  bool result = pwd.Equals(textBox2.Text, StringComparison.Ordinal);
                MessageBox.Show("HINT FOR YOUR PASSWORD IS " +pwd);

                
               
              /*  forgetpass f1 = new forgetpass();
                f1.ShowDialog();
               * */
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
       

        private void button3_Click(object sender, EventArgs e)
        {
          
        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

    }
}
