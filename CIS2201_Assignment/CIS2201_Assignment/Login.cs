using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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

         //Connection String
       // string cs = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\SQLQuery1.mdf;Integrated Security=True;";


        private void btnLogin_Click(object sender, EventArgs e)
        {
            
            String Test = "Test";
            if(passwordValidate(Test))
            {
                Form frm = new Navigation();
                frm.Show();
            }
        }
            /*
            if (txtUsername.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Please provide a valid UserName and Password.");
                return;
            }
            try
            {
                //Create SqlConnection
                SqlConnection con = new SqlConnection(cs);
                SqlCommand cmd = new SqlCommand("Select * from LoginTable where Username=@username and Password=@password", con);
                cmd.Parameters.AddWithValue("@username", txtUsername.Text);
                cmd.Parameters.AddWithValue("@password", txtPassword.Text);
                con.Open();
                SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapt.Fill(ds);
                con.Close();
                int count = ds.Tables[0].Rows.Count;
                //If count is equal to 1, than show frmMain form
                if (count == 1)
                {
                    MessageBox.Show("Login Successful!");
                    this.Hide();
                    Navigation fm = new Navigation();
                    fm.Show();
                }
                else
                {
                    MessageBox.Show("Login Failed!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }*/
        private bool passwordValidate(String pass)
        {
            if (txtUsername.Text == "")
            {
                MessageBox.Show("Please enter a Password!");
                return false;
            }
            else if (txtUsername.Text != pass)
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

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void lblUsername_Click(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblPassword_Click(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged_2(object sender, EventArgs e)
        {

        }
    }
}
      

