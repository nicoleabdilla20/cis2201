using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper;

namespace CIS2201_Assignment
{
    public partial class ReportIssue : Form
    {
        public ReportIssue()
        {
            InitializeComponent();
        }

        private bool IsStaffIDWorkValid()
        {
            if (idtxt.Text == "")
            {
                MessageBox.Show("Please make sure that you have entered the Staff's ID!");
                return false;
            }
            else
            {
                return true;
            }
        }

        private void issuebtn_Click(object sender, EventArgs e)
        {
            string cs = @"Data Source=(localdb)\mssqllocaldb;Initial Catalog=Test;Integrated Security=True;Pooling=False"; //my database conenction

            if (IsStaffIDWorkValid())
            {
                using (SqlConnection connection = new SqlConnection(cs))
                {
                    // Create a SqlCommand, and identify it as a stored procedure.
                    using (SqlCommand sqlCommand = new SqlCommand("Hospital.addIssue", connection))
                    {
                        sqlCommand.CommandType = CommandType.StoredProcedure;


                        sqlCommand.Parameters.Add(new SqlParameter("@StaffID", SqlDbType.VarChar, 10));
                        sqlCommand.Parameters["@StaffID"].Value = idtxt.Text;

                        sqlCommand.Parameters.Add(new SqlParameter("@StaffDate", SqlDbType.Date));
                        sqlCommand.Parameters["@StaffDate"].Value = dateTimePicker1.Text;

                        sqlCommand.Parameters.Add(new SqlParameter("@Details", SqlDbType.VarChar, 500));
                        sqlCommand.Parameters["@Details"].Value = detailtxt.Text;

                        try
                        {
                            connection.Open();
                            sqlCommand.ExecuteNonQuery();
                            string message = "Successfully added";
                            MessageBox.Show(message);

                        }
                        catch (System.Data.SqlClient.SqlException sqlException)
                        {
                            System.Windows.Forms.MessageBox.Show(sqlException.Message);
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }

            }
        }

    }
    }
