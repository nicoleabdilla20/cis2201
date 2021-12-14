using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CIS2201_Assignment
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            String Test = "Test";
            if(passwordValidate(Test))
            {
                Form frm = new Navigation();
                frm.Show();
            }
            
        }
        private bool passwordValidate(String pass)
        {
            if (txtPassword.Text == "")
            {
                MessageBox.Show("Please enter a Password!");
                return false;
            }
            else if (txtPassword.Text != pass)
            {
                MessageBox.Show("Incorrect Password");
                return false;
            }
            else
            {
                return true;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
      

