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
            if (IsStaffValid() && IsStaffIDValid() && isAddressValid())
            {
             // Create the connection.
                using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.connString))
                {
                    // Create a SqlCommand, and identify it as a stored procedure.
                    using (SqlCommand sqlCommand = new SqlCommand("Hospital.addPatient", connection))
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

            if (IsStaffIDWorkValid() && IsStaffNoOfHrsValid())
            {
                 // Create the connection.
                using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.connString))
                {
                    // Create a SqlCommand, and identify it as a stored procedure.
                    using (SqlCommand sqlCommand = new SqlCommand("Hospital.addStaff", connection))
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
        
        //------------------------------SEARCH TAB PAGE --------------------------------

         private List<staffInformation> getStaffList()
        {
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.connString))
            {
                connection.Open();
                String sql = "SELECT * FROM [Hospital].[staff] WHERE StaffID = @StaffID";
                using (SqlCommand comm = new SqlCommand(sql, connection))
                {

                    comm.Parameters.Add(new SqlParameter("@StaffID", SqlDbType.VarChar, 10));
                    comm.Parameters["@StaffID"].Value = ssearchID.Text;
                    SqlDataReader read;
                    read = comm.ExecuteReader();

                    List<staffInformation> patientsList = new List<staffInformation>();

                    while (read.Read())
                    {
                        patientInformation pa = new patientInformation(read["StaffID"].ToString(), read["StaffName"].ToString(), read["StaffSurnameName"].ToString(), read["StaffGender"].ToString(), read["StaffDateOfBirth"].ToString(), read["StaffAge"].ToString(), read["StaffAddress"].ToString(), read["StaffEmail"].ToString(), read["StaffPhoneNumber"].ToString(), read["StaffBloodType"].ToString(),  read["PatientsInsurance"].ToString(), read["StaffRole"].ToString());
                        patientsList.Add(pa);
                    }
                    return patientsList;
                }
            }
        }


        

         private List<staffD> getStaffDetailsList()
         {
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.connString))
            {
                String selectedItem = (string)Filtercbx.SelectedItem;
                connection.Open();
                String sql = "SELECT * FROM [Hospital].[staffDetails] WHERE StaffID = @StaffID";
                using (SqlCommand comm = new SqlCommand(sql, connection))
                {

                    comm.Parameters.Add(new SqlParameter("@StaffID", SqlDbType.VarChar, 10));
                    comm.Parameters["@StaffID"].Value = pvisitID.Text;
                    SqlDataReader read;
                    read = comm.ExecuteReader();

                    List<staffD> staffList = new List<staffD>();


                    while (read.Read())
                    {

                        staffD p = new staffD(read["StaffID"].ToString(), read["StartOfContract"].ToString(), read["EndOfContract"].ToString(), read["TypeOfContract"].ToString(), read["NumberOfHours"].ToString(), read["Bonus"].ToString());
                        staffList.Add(p);
                    }

                    if (selectedItem == "Date: Newest First")
                    {
                        var datenew =
                        from item in staffList
                        let date = item.StartOfContract
                        let id = item.ID
                        orderby date descending
                        select item;

                        List<staffD> lst = datenew.ToList();
                        return lst;
                    }
                    else
                    {
                        var datenew =
                        from item in staffList
                        let date = item.StartOfContract
                        let id = item.ID
                        orderby date ascending
                        select item;

                        List<staffD> lst = datenew.ToList();
                        return lst;
                    }
                }
            }
        } 


        /// <summary>
        /// source for searching a staff: "https://www.codesd.com/item/i-get-this-error-a-sqlparameter-with-parametername-firstname-is-not-contained-by-this-sqlparametercollection.html"
        /// </summary>
        private void searchStaffID_Click(object sender, EventArgs e)
        {
            if (IsStaffIDValid())
            {
                using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.connString))
                {
                    connection.Open();

                    try
                    {
                        staffdgv.DataSource = getStaffList();
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
               
            } else
                {
                    MessageBox.Show("Error");
                }
        }

        private void searchRole_Click(object sender, EventArgs e)
        {
            if (IsStaffIDValid())
            {
                using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.connString))
                {
                    connection.Open();

                    try
                    {
                        detailsdgv.DataSource = getPatientsVisitList();
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
                
            }else
                {
                   MessageBox.Show("Error");

                }
        }

        
        //used in Home tab apge
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

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void label37_Click(object sender, EventArgs e)
        {

        }

        private void textBoxhours_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxwage_TextChanged(object sender, EventArgs e)
        {

        }

        private void label38_Click(object sender, EventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label40_Click(object sender, EventArgs e)
        {

        }

        //=================================================================Calculate Staff Pay=================================================================


        double wage;
        double tax = 0.18;
        double tot;

        //method to get Staff Hours
        private string getStaffHours()
        {
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.connString))
            {
                List<string> planInformation = new List<string>();
                String selectedItem = (string)hrperwk.SelectedItem;
                connection.Open();
                String sql = "SELECT * FROM [Hospital].[staffDetails] WHERE StaffID = @StaffID";
                using (SqlCommand comm = new SqlCommand(sql, connection))
                {

                    comm.Parameters.Add(new SqlParameter("@StaffID", SqlDbType.VarChar, 10));
                    comm.Parameters["@StaffID"].Value = inputid.Text;
                    SqlDataReader read;
                    read = comm.ExecuteReader();


                    while (read.Read())
                    {
                        String hour = read["NumberOfHours"].ToString();
                        planInformation.Add(hour.ToString());

                    }

                    String staffPlan = planInformation[0].ToString();
                    outputhr.Text = staffPlan.ToString();
                    MessageBox.Show("This is the number of work hours:" + staffPlan);

                    getStaffRole(staffPlan);
                    return staffPlan;

                }
            }
           
        }

        //method to get Staff Role
        private void getStaffRole(string id)
        {
           using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.connString))
            {
                List<string> planRole = new List<string>();
                String sql = "SELECT* FROM [Hospital].[staff]";
                connection.Open();
                using (SqlCommand comm = new SqlCommand(sql, connection))
                {
                    //need to get staff role by id -- basically search
                    string staffid =this.id; //stores id of staff
                   //need a method that retrieves staffrole according to ID
                   

                    //METHOD HERE

                    //then get staff role and use it to calculate bill
                    comm.Parameters.Add(new SqlParameter("@StaffRole", SqlDbType.NVarChar, 10));
                    comm.Parameters["@StafRole"].Value = roleopts.Text;
                    SqlDataReader read;
                    read = comm.ExecuteReader();

                    while (read.Read())
                    {
                        String pl = read["StaffRole"].ToString();
                        planRole.Add(pl.ToString());

                    }

                    String staffRole = planRole; //will store staff role
                    MessageBox.Show(staffRole);
                    calculateBill(staffRole);
                    return staffRole;
                }
           }
        }

        private void calculateBill(String r)
        {
            int hour = Convert.ToInt32(outputhr.Text); //stores number of hours of staff
            if (r.Equals("doctor"))
            {
                MessageBox.Show("Doctor! The hourly rate is 90 euros.");
                wage = 90 * hour; //90 is the hourly rate of the doctor
                tax = tax*wage;
                tot = wage-tax;
                //need to add bonus
                MessageBox.Show("Final Wage: " + tot);
            }
            else if (r.Equals("therapist"))
            {MessageBox.Show("therapist! The hourly rate is 50 euros.");
                wage = 50 * hour; 
                tax = tax*wage;
                tot = wage-tax;
                MessageBox.Show("Final Wage: " + tot);
            }
            else if(r.Equals("physician"))
            {
                MessageBox.Show("Physician! The hourly rate is 105 euros.");
                wage = 105 * hour; 
                tax = tax*wage;
                tot = wage-tax;
                MessageBox.Show("Final Wage: " + tot);
            }
            else if (r.Equals("specialist"))
            {
                MessageBox.Show("specialist! The hourly rate is 110 euros.");
                wage = 110 * hour;
                tax = tax * wage;
                tot = wage - tax;
                MessageBox.Show("Final Wage: " + tot);
            }
            else if (r.Equals("pharmacist"))
            {
                MessageBox.Show("pharmacist! The hourly rate is 20 euros.");
                wage = 20 * hour; 
                tax = tax * wage;
                tot = wage - tax;
                MessageBox.Show("Final Wage: " + tot);
            }
            else if (r.Equals("social worker"))
            {
                MessageBox.Show("social worker! The hourly rate is 15 euros.");
                wage = 15 * hour; 
                tax = tax * wage;
                tot = wage - tax;
                MessageBox.Show("Final Wage: " + tot);
            }
            else if (r.Equals("interpreter"))
            {
                MessageBox.Show("interpreter! The hourly rate is 100 euros.");
                wage = 100 * hour;
                tax = tax * wage;
                tot = wage - tax;
                MessageBox.Show("Final Wage: " + tot);
            }

            outputpay.Text = wage.ToString();
            outputtax.Text = tax.ToString();
            outputtotal.Text = tot.ToString();
        }

        private void calcbtn_Click(object sender, EventArgs e)
        {

                using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.connString))
                {
                    connection.Open();

                    try
                    {
                        getStaffHours();
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
