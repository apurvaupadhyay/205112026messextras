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
    public partial class sucesslogout : Form
    {
        public sucesslogout()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 l3 = new Form1();
                    this.Hide();
                    l3.ShowDialog();
                
        }
    }
}
