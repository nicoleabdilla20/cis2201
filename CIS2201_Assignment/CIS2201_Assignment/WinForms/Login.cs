﻿using System;
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

        //checking if both the username and password were entered before logging in
        private bool checkLogin()
        {
            if (txtUsername.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Please provide a valid Username and Password!");
                return false;
            }
            else
            {
                return true;
            }
        }

        //checking if the username and password are valid to log into the system
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (checkLogin())
            {
                //Connection String to connect to the database and acccess the usernames and passwords that are valid
                string sql = "Select * from [Hospital].[login] where Username=@Username and Password=@Password";
                //creating the connection
                using (SqlConnection con = new SqlConnection(Properties.Settings.Default.connString))
                {
                    using (SqlCommand cmd = new SqlCommand(sql, con))
                    {
                        //opening connection string
                        con.Open();
                        try
                        {
                            cmd.Parameters.AddWithValue("@username", txtUsername.Text);
                            cmd.Parameters.AddWithValue("@password", txtPassword.Text);
                            SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                            DataSet ds = new DataSet();
                            adapt.Fill(ds);
                            //closing connection string
                            con.Close();
                            int count = ds.Tables[0].Rows.Count;
                            //If count is equal to 1, than log in was successfull hence show navigation form
                            //else, show login failed error message
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


                    }
                }
            }
        }
           

        

        private void button1_Click(object sender, EventArgs e)
        {
            //closing the application
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

        private void logo_Click(object sender, EventArgs e)
        {

        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtPassword_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void btnLogin_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void Login_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}

