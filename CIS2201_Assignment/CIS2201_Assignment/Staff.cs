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
    public partial class Staff : Form
    {
        public Staff()
        {
            InitializeComponent();
        }

        // Methods to validate add staff input fields
        private bool IsStaffValid()
        {
            if (nametxt.Text == "" || surnametxt.Text == "")
            {
                MessageBox.Show("Please make sure that you have entered both name and surname!");
                return false;
            }
            else
            {
                return true;
            }
        }

        private bool IsStaffIDValid()
        {
            if (IDtxt.Text == "")
            {
                MessageBox.Show("Please make sure that you have entered the Staff's ID!");
                return false;
            }
            else
            {
                return true;
            }
        }

        private void TelephoneValidation_Leave(object sender, EventArgs e)
        {
            if ((phonenotxt.Text.Length < 15) && (phonenotxt.Text.Length > 0))
            {
                MessageBox.Show("Phone number must be max 15 digits!");
                phonenotxt.Focus();
            }
        }
        private bool isAddressValid()
        {
            if (addresstxt.Text == "")
            {
                MessageBox.Show("Please make sure that you have entered an Address!");
                return false;
            }
            else
            {
                return true;
            }
        }


        //attach your connection here or use : using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.connString)) according to how you set DB
        private void submit_Click(object sender, EventArgs e)
        {
                    string cs = @"Data Source=(localdb)\mssqllocaldb;Initial Catalog=Test;Integrated Security=True;Pooling=False"; //my databse conenction

            if (IsStaffValid() && IsStaffIDValid() && isAddressValid())
            {
                // Create the connection.
                using (SqlConnection connection = new SqlConnection(cs))
                {
                    // Create a SqlCommand, and identify it as a stored procedure.
                    using (SqlCommand sqlCommand = new SqlCommand("Hospital.addStaff", connection))
                    {
                        sqlCommand.CommandType = CommandType.StoredProcedure;

                        sqlCommand.Parameters.Add(new SqlParameter("@StaffID", SqlDbType.VarChar, 10));
                        sqlCommand.Parameters["@StaffID"].Value = IDtxt.Text;

                        sqlCommand.Parameters.Add(new SqlParameter("@StaffName", SqlDbType.NVarChar, 40));
                        sqlCommand.Parameters["@StaffName"].Value = nametxt.Text;

                        sqlCommand.Parameters.Add(new SqlParameter("@StaffSurnameName", SqlDbType.NVarChar, 40));
                        sqlCommand.Parameters["@StaffSurnameName"].Value = surnametxt.Text;

                        sqlCommand.Parameters.Add(new SqlParameter("@StaffGender", SqlDbType.NVarChar, 40));
                        sqlCommand.Parameters["@StaffGender"].Value = gendertxt.Text;

                        sqlCommand.Parameters.Add(new SqlParameter("@StaffAge", SqlDbType.Int));
                        sqlCommand.Parameters["@StaffAge"].Value = Int32.Parse(agetxt.Text);

                        sqlCommand.Parameters.Add(new SqlParameter("@StaffDateOfBirth", SqlDbType.Date));
                        sqlCommand.Parameters["@StaffDateOfBirth"].Value = dob.Value;

                        sqlCommand.Parameters.Add(new SqlParameter("@StaffAddress", SqlDbType.VarChar, 100));
                        sqlCommand.Parameters["@StaffAddress"].Value = addresstxt.Text;

                        sqlCommand.Parameters.Add(new SqlParameter("@StaffEmail", SqlDbType.VarChar, 100));
                        sqlCommand.Parameters["@StaffEmail"].Value = emailtxt.Text;

                        sqlCommand.Parameters.Add(new SqlParameter("@StaffPhoneNumber", SqlDbType.Int));
                        sqlCommand.Parameters["@StaffPhoneNumber"].Value = Int32.Parse(phonenotxt.Text);

                        sqlCommand.Parameters.Add(new SqlParameter("@StaffBloodType", SqlDbType.VarChar, 10));
                        sqlCommand.Parameters["@StaffBloodType"].Value = bloodopts.Text;

                        sqlCommand.Parameters.Add(new SqlParameter("@StaffInsurance", SqlDbType.Char, 1));
                        sqlCommand.Parameters["@StaffInsurance"].Value = insurancetxt.Text;

                        sqlCommand.Parameters.Add(new SqlParameter("@StaffRole", SqlDbType.VarChar, 10));
                        sqlCommand.Parameters["@StaffRole"].Value = roleopts.Text;

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

       private bool IsStaffIDWorkValid()
        {
            if (idwork.Text == "")
            {
                MessageBox.Show("Please make sure that you have entered the Staff's ID!");
                return false;
            }
            else
            {
                return true;
            }
        }

        private bool IsStaffNoOfHrsValid()
        {
            if (hrperwk.Text == "")
            {
                MessageBox.Show("Please make sure that you have entered the Staff's number of hours!");
                return false;
            }
            else
            {
                return true;
            }
        }

        //button to save all data into database
        private void detailsubmit_Click(object sender, EventArgs e)
        {
            string cs = @"Data Source=(localdb)\mssqllocaldb;Initial Catalog=Test;Integrated Security=True;Pooling=False"; //my database conenction

            if (IsStaffIDWorkValid() && IsStaffNoOfHrsValid())
            {
                using (SqlConnection connection = new SqlConnection(cs))
                {
                    // Create a SqlCommand, and identify it as a stored procedure.
                    using (SqlCommand sqlCommand = new SqlCommand("Hospital.addStaffDetails", connection))
                    {
                        sqlCommand.CommandType = CommandType.StoredProcedure;


                        sqlCommand.Parameters.Add(new SqlParameter("@StaffID", SqlDbType.VarChar, 10));
                        sqlCommand.Parameters["@StaffID"].Value = idwork.Text;

                        sqlCommand.Parameters.Add(new SqlParameter("@StartOfContract", SqlDbType.Date));
                        sqlCommand.Parameters["@StartOfContract"].Value = soc.Text;

                        sqlCommand.Parameters.Add(new SqlParameter("@EndOfContract", SqlDbType.Date));
                        sqlCommand.Parameters["@EndOfContract"].Value = eoc.Value;

                        sqlCommand.Parameters.Add(new SqlParameter("@TypeOfContract", SqlDbType.VarChar, 40));
                        sqlCommand.Parameters["@TypeOfContract"].Value = contracttype.Text;

                        sqlCommand.Parameters.Add(new SqlParameter("@NumberOfHours", SqlDbType.Int));
                        sqlCommand.Parameters["@NumberOfHours"].Value = hrperwk.Text;

                        sqlCommand.Parameters.Add(new SqlParameter("@Bonus", SqlDbType.VarChar, 100));
                        sqlCommand.Parameters["@Bonus"].Value = checkbox.Text;
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
        
        private void issuebtn_Click(object sender, EventArgs e)
        {
            ReportIssue ReportIssue = new ReportIssue();
            ReportIssue.ShowDialog();
        }

        private void Appsearchbtn_Click(object sender, EventArgs e)
        {

        }

        private void crtAppbtn_Click(object sender, EventArgs e)
        {

        }

        private void ApppatID_TextChanged(object sender, EventArgs e)
        {

        }

        private void searchstaffbackbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Navigation fm = new Navigation();
            fm.Show();
        }

        private void payrollBackbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Navigation fm = new Navigation();
            fm.Show();
        }

        private void addStaffbackbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Navigation fm = new Navigation();
            fm.Show();
        }

        private void staffHomebackbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Navigation fm = new Navigation();
            fm.Show();
        }

        private void AddStaff_Click(object sender, EventArgs e)
        {

        }
    }
}
