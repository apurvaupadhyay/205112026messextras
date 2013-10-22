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
    public partial class account : Form
    {
        public string apu;
        public string bal;
        Form1 frm1;
        
        HighSecurity_password h;
        OleDbConnection con = new OleDbConnection();
        OleDbCommand com = new OleDbCommand();
        OleDbDataReader dr;
        Int32 count;


        public account(Form1 f)
        {


            InitializeComponent();
            frm1 = f;


        }
        
        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // HighSecurity_password h2 = new HighSecurity_password();
            apu = frm1.a;
          //  bal = textBox9.Text;
            h = new HighSecurity_password(this);
            //  this.Hide();
            h.Show();
            //textBox9.Text = h8.bal1;
            //Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
           

                string rate, avail;
                List<int> indexList = new List<int>();
                double pr, bal, sum;
                string updatebal;
                if (radioButton1.Checked == true || radioButton2.Checked == true || radioButton3.Checked == true)
                {
                    if (checkedListBox1.CheckedItems.Count != 0)
                    {
                        int index = -1;
                        foreach (object checkedItem in checkedListBox1.CheckedItems)
                        {
                            index++;
                            rate = checkedItem.ToString().Split('\t')[3];
                            avail = checkedItem.ToString().Split('\t')[4];
                            //MessageBox.Show(avail);

                            com.Connection = con;
                            com.CommandText = "select cbal from account where rno='" + frm1.a + "' ";
                            string status = Convert.ToString(com.ExecuteScalar());

                            try
                            {
                                pr = Convert.ToDouble(rate);
                                bal = Convert.ToDouble(status);
                                sum = (bal - pr);
                                updatebal = Convert.ToString(sum);
                                if (bal >= pr)
                                {
                                    if (avail == "yes")
                                    {
                                        com.Connection = con;
                                        com.CommandText = " update account set cbal='" + updatebal + "' where rno= '" + frm1.a + "' ";
                                        //   MessageBox.Show("balance updated successfully");
                                        com.ExecuteNonQuery();
                                        com.Dispose();
                                        // this.Close();
                                        // MessageBox.Show("price of dish deducted from balance");
                                        //   textBox9.Text = updatebal; 
                                        MessageBox.Show("THANK YOU FOR USING MESS EXTRAS TAKE PRINTOUT AND GET THE DISH");
                                        // checkedListBox1.Items.Clear();
                                    }
                                    else
                                    {
                                        MessageBox.Show("Sorry !!! DISH NOT AVAILABLE TODAY");
                                        indexList.Add(index);
                                        //MessageBox.Show(index.ToString());
                                        //checkedListBox1.SetItemCheckState(index, unchecked);
                                    }

                                }
                                // MessageBox.Show("Thank you for using messextras system\nTake the printout and get your dish");
                                else
                                {
                                    MessageBox.Show("SORRY ! YOU DONT HAVE ENOUGH BALANCE");
                                    // checkedListBox1.Items.Clear();
                                }

                            }
                            catch (FormatException)
                            {
                                MessageBox.Show("Sorry !! Incorrect Format.");
                            }
                        }

                        if (indexList.Capacity != 0)
                        {
                            foreach (int i in indexList)
                            {
                                checkedListBox1.SetItemCheckState(i, CheckState.Unchecked);
                            }
                        }

                    }
                    else
                    {
                        MessageBox.Show("PLEASE SELECT A DISH FIRST");
                    }
                }

                else
                {
                    MessageBox.Show("PLEASE SELECT A SCHEDULE FIRST");
                }
            }

        

        private void button3_Click(object sender, EventArgs e)
        {
            // MessageBox.Show(+ s);

            sucesslogout s1 = new sucesslogout();
            this.Hide();
            s1.ShowDialog();
            this.Close();
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
            string apu = frm1.a;
            con.ConnectionString = "Provider=OraOLEDB.Oracle.1;Persist Security Info=False;User ID=mca1226;PASSWORD=User202;Data Source=nitt";
            try
            {
                con.Open();
                if (Convert.ToBoolean(con.State))
                {
                   // MessageBox.Show("Connection Success");
                    //  MessageBox.Show(frm1.a);
                    com.Connection = con;
                    // com.Connection = con;
                    com.CommandText = "select name from account where rno='" + frm1.a + "' ";
                    string status = Convert.ToString(com.ExecuteScalar());
                    // MessageBox.Show("Your Booking Status is : " + (status));
                    textBox1.Text = status;
                    com.CommandText = "select phone from account where rno='" + frm1.a + "'";
                    string status1 = Convert.ToString(com.ExecuteScalar());
                    textBox2.Text = status1;
                    com.CommandText = "select rno from account where rno='" + frm1.a + "'";
                    string status2 = Convert.ToString(com.ExecuteScalar());
                    textBox4.Text = status2;
                    com.CommandText = "select course from account where rno='" + frm1.a + "'";
                    string status3 = Convert.ToString(com.ExecuteScalar());
                    textBox3.Text = status3;
                    com.CommandText = "select dept from account where rno='" + frm1.a + "'";
                    string status4 = Convert.ToString(com.ExecuteScalar());
                    textBox5.Text = status4;
                    com.CommandText = "select hname from account where rno='" + frm1.a + "'";
                    string status5 = Convert.ToString(com.ExecuteScalar());
                    textBox7.Text = status5;
                    com.CommandText = "select hroom from account where rno='" + frm1.a + "'";
                    string status6 = Convert.ToString(com.ExecuteScalar());
                    textBox8.Text = status6;
                   /* com.CommandText = "select cbal from account where rno='" + frm1.a + "'";
                    string status7 = Convert.ToString(com.ExecuteScalar());
                    textBox9.Text = status7;
                    * */
                }
            }
            catch
            {
                MessageBox.Show("Connection Failed");
            }
            // MessageBox.Show(frm1.a);
            pictureBox2.Hide();
            pictureBox3.Hide();
            pictureBox4.Hide();
            //checkedListBox1.Hide();


        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                string count2 = "b";
                pictureBox3.Visible = false;
                pictureBox3.Hide();
                pictureBox4.Visible = false;
                pictureBox4.Hide();
                pictureBox2.Visible = true;
                pictureBox2.Show();

                com.CommandType = CommandType.Text;
                com.CommandText = "select * from dish where schedule='" + count2 + "'";//Place your query here
                com.Connection = con;
                OleDbDataAdapter da = new OleDbDataAdapter(com);
                DataSet ds = new DataSet();
                da.Fill(ds);
                string col;
                string id, name, price, avail;

                checkedListBox1.Items.Clear();

                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    id = dr.Field<string>(0);
                    name = dr.Field<string>(1);
                    price = dr.Field<string>(2);
                    avail = dr.Field<string>(4);
                    col = id + "\t" + name + "\t\t" + price + "\t" + avail;
                    checkedListBox1.Items.Add(col);
                } 
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
                string count3 = "l";
                com.CommandType = CommandType.Text;
                com.CommandText = "select * from dish where schedule='" + count3 + "'";//Place your query here
                com.Connection = con;
                OleDbDataAdapter da = new OleDbDataAdapter(com);
                DataSet ds = new DataSet();
                da.Fill(ds);
                string col;
                string id, name, price, avail;

                checkedListBox1.Items.Clear();
               
                
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    
                    id = dr.Field<string>(0);
                    name = dr.Field<string>(1);
                    price = dr.Field<string>(2);
                    avail = dr.Field<string>(4);
                    col = id + "\t" + name + "\t\t" + price + "\t" + avail;
                    checkedListBox1.Items.Add(col);
                    
                }

               
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
                string count4 = "d";
                com.CommandType = CommandType.Text;
                com.CommandText = "select * from dish where schedule='" + count4 + "'";//Place your query here
                com.Connection = con;
                OleDbDataAdapter da = new OleDbDataAdapter(com);
                DataSet ds = new DataSet();
                da.Fill(ds);
                string col;
                string id, name, price, avail;

                checkedListBox1.Items.Clear();

                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    id = dr.Field<string>(0);
                    name = dr.Field<string>(1);
                    price = dr.Field<string>(2);
                    avail = dr.Field<string>(4);
                    col = id + "\t" + name + "\t\t" + price + "\t" + avail;
                    checkedListBox1.Items.Add(col);
                }
                


            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {



        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            /* for (int i = 0; i < checkedListBox1.Items.Count; i++)
             {
                 if (checkedListBox1.GetItemChecked(i))
                 {
                     string str = checkedListBox1.GetItemText(i);
                     MessageBox.Show(str);

                    
                   
                 }
             }*/
         
        }

        private void button4_Click(object sender, EventArgs e)
        {
            com.Connection = con;
            com.CommandText = "select cbal from account where rno='" + frm1.a + "' ";
            string status = Convert.ToString(com.ExecuteScalar());
            MessageBox.Show(status);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            changepassword c1 = new changepassword();
            c1.ShowDialog();

        }
    }
}
