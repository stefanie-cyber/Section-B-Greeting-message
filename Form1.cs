using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Section_B_Greeting_message
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGreeting_Click(object sender, EventArgs e)
        {
            //txtname in string ,user enter 
            string name = txtName.Text;
              
            //desplay message
            MessageBox.Show("Hello " + name + "!");

        }
    }
}
