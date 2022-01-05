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

        //verification methods - checking whether all the fields were filled in or not
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


        //adding a new staff member and storing it into the database
        private void submit_Click(object sender, EventArgs e)
        {
            //connection string
            string cs = @"Data Source=(localdb)\mssqllocaldb;Initial Catalog=Hospital;Integrated Security=True;Pooling=False"; //my databse conenction

            //verification methods
            if (IsStaffValid() && IsStaffIDValid() && isAddressValid())
            {
                //creating the connection
                using (SqlConnection connection = new SqlConnection(cs))
                {
                   //creating a SqlCommand, and identifying it as a stored procedure
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
                            //opening conneciton
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
                            //closing connection
                            connection.Close();
                        }
                    }
                }

            }
            
             else 
                     {
                        string errorMessage = "Whoops......something went wrong!";
                        MessageBox.Show(errorMessage);

                     }
        }

        //more verification methods
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

        //adding a new staff member's details and storing it into the database
        private void detailsubmit_Click(object sender, EventArgs e)
        {
            //connection string
            string cs = @"Data Source=(localdb)\mssqllocaldb;Initial Catalog=Hospital;Integrated Security=True;Pooling=False"; //my database conenction

            if (IsStaffIDWorkValid() && IsStaffNoOfHrsValid())
            {
                using (SqlConnection connection = new SqlConnection(cs))
                {
                    //creating a SqlCommand, and identifying it as a stored procedure
                    using (SqlCommand sqlCommand = new SqlCommand("Hospital.addStaffDetails", connection))
                    {
                        sqlCommand.CommandType = CommandType.StoredProcedure;

                        sqlCommand.Parameters.Add(new SqlParameter("@StaffID", SqlDbType.VarChar, 10));
                        sqlCommand.Parameters["@StaffID"].Value = idwork.Text;

                        sqlCommand.Parameters.Add(new SqlParameter("@StaffName", SqlDbType.VarChar, 10));
                        sqlCommand.Parameters["@StaffName"].Value = nametxt.Text;

                        sqlCommand.Parameters.Add(new SqlParameter("@StaffSurname", SqlDbType.VarChar, 10));
                        sqlCommand.Parameters["@StaffSurname"].Value = surnametxt.Text;

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
                            //opening connection
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
                            //closing connection
                            connection.Close();
                        }
                    }
                }

            }
            
             else 
                     {
                        string errorMessage = "Whoops......something went wrong!";
                        MessageBox.Show(errorMessage);

                     }
        }

        private void issuebtn_Click(object sender, EventArgs e)
        {
            //opens Report Issue form
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
            //goes back to Navigation form
            this.Hide();
            Navigation fm = new Navigation();
            fm.Show();
        }

        private void payrollBackbtn_Click(object sender, EventArgs e)
        {
            //goes back to Navigation form
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
            //goes back to Navigation form
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

        //verification methods
        public bool IsStaffIdValid()
        {
            if (staffID.Text == "")
            {
                MessageBox.Show("PLease enter an Id to search");
                return false;
            }
            else
            {
                return true;
            }
        }
        public bool IsStaffIdDetailValid()
        {
            if (staffDetailstxt.Text == "")
            {
                MessageBox.Show("PLease enter an Id to search");
                return false;
            }
            else
            {
                return true;
            }
        }

        //searching a staff member with staff ID from database
        private List<staffInformation> getStaffList()
        {
            //Establishinhg the database connection.
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.connString))
            {
                //Opening connection that was established above.
                connection.Open();
                //SQL string query that will retrieve data from teh database.
                String sql = "SELECT * FROM [Hospital].[staff] WHERE StaffID = @StaffID";
                //Creating a new SQL command made up of the connection and the sql query that were both created above.
                using (SqlCommand comm = new SqlCommand(sql, connection))
                {
                    //Adding the ID entered from the user through the WinForm as a new sql parameter.
                    comm.Parameters.Add(new SqlParameter("@StaffID", SqlDbType.VarChar, 10));
                    comm.Parameters["@StaffID"].Value = staffID.Text;
                    //Creating a new SQL data reader object.
                    SqlDataReader read;
                    read = comm.ExecuteReader();

                    //Creating a new list that will be returned.
                    List<staffInformation> staffList = new List<staffInformation>();


                    while (read.Read())
                    {
                        //Creating a new object of the class 'staffInformation' and passing the data read from the database through the SqlDataReader object that was created above, as arguments to the class' constructor.
                        staffInformation p = new staffInformation(read["StaffID"].ToString(), read["StaffName"].ToString(), read["StaffSurnameName"].ToString(), read["StaffGender"].ToString(), read["StaffDateOfBirth"].ToString(), read["StaffAge"].ToString(), read["StaffAddress"].ToString(), read["StaffEmail"].ToString(), read["StaffPhoneNumber"].ToString(), read["StaffBloodType"].ToString(), read["StaffInsurance"].ToString(), read["StaffRole"].ToString());
                        //Adding the variables created in the class 'patientInformation' to the list.
                        staffList.Add(p);
                    }
                    //Returning the list.
                    return staffList;
                }
            }
        }

         //searching a staff member's detaiols with staff ID from database
        private List<staffD> getStaffDetailList()
        {
            //Establishinhg the database connection.
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.connString))
            {
                //Opening connection that was established above.
                connection.Open();
                //SQL string query that will retrieve data from teh database.
                String sql = "SELECT * FROM [Hospital].[staffDetails] WHERE StaffID = @StaffID";
                //Creating a new SQL command made up of the connection and the sql query that were both created above.
                using (SqlCommand comm = new SqlCommand(sql, connection))
                {
                    //Adding the ID entered from the user through the WinForm as a new sql parameter.
                    comm.Parameters.Add(new SqlParameter("@StaffID", SqlDbType.VarChar, 10));
                    comm.Parameters["@StaffID"].Value = staffDetailstxt.Text;
                    //Creating a new SQL data reader object.
                    SqlDataReader read;
                    read = comm.ExecuteReader();

                    //Creating a new list that will be returned.
                    List<staffD> staffDetailList = new List<staffD>();


                    while (read.Read())
                    {
                        //Creating a new object of the class 'staffD' and passing the data read from the database through the SqlDataReader object that was created above, as arguments to the class' constructor.
                        staffD p = new staffD(read["StaffID"].ToString(), read["StaffName"].ToString(), read["StaffSurname"].ToString(), read["StartOfContract"].ToString(), read["EndOfContract"].ToString(), read["TypeOfContract"].ToString(), read["NumberOfHours"].ToString(), read["Bonus"].ToString());
                        //Adding the variables created in the class 'patientInformation' to the list.
                        staffDetailList.Add(p);
                    }
                    //Returning the list.
                    return staffDetailList;
                }
            }
        }

        //getting staff member list
        private void searchStaffID_Click(object sender, EventArgs e)
        {
            //Validation
            if (IsStaffIdValid())
            {
                //Establishinhg the database connection.
                using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.connString))
                {
                    //Opening the above created connection
                    connection.Open();

                    //Using a try-catch to help point out any exception errors that might come up.
                    try
                    {
                        //Determining the 'getStaffList()' method as the data grid view output.
                        staffdgv.DataSource = getStaffList();
                    }
                    catch (System.Data.SqlClient.SqlException sqlException)
                    {
                        //Catch the exception if necessaary. 
                        System.Windows.Forms.MessageBox.Show(sqlException.Message);
                    }
                    finally
                    {
                        //Since the execution is finsihed, the connection can be closed.
                        connection.Close();
                    }

                }
            }
            else 
            {
                //Message that will be displayed if validation method is false.
                string errorMessage = "Whoops......something went wrong!";
                MessageBox.Show(errorMessage);

            }
        }

        //getting staff member's details list
        private void searchRole_Click_1(object sender, EventArgs e)
        {
            //Validation
            if (IsStaffIdDetailValid())
            {
                //Establishinhg the database connection.
                using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.connString))
                {
                    //Opening the above created connection
                    connection.Open();

                    //Using a try-catch to help point out any exception errors that might come up.
                    try
                    {
                        //Determining the 'getStaffDetaillist()' method as the data grid view output.
                        detailsdgv.DataSource = getStaffDetailList();
                    }
                    catch (System.Data.SqlClient.SqlException sqlException)
                    {
                        //Catch the exception if necessaary. 
                        System.Windows.Forms.MessageBox.Show(sqlException.Message);
                    }
                    finally
                    {
                        //Since the execution is finsihed, the connection can be closed.
                        connection.Close();
                    }

                }
            }
            else 
            {
                //Message that will be displayed if validation method is false.
                string errorMessage = "Whoops......something went wrong!";
                MessageBox.Show(errorMessage);
            }
        }

        //=====================================================CALCULATE STAFF PAY================================================
        public class payroll
        {
            public virtual void calculatePay(int hours, int bonus, ref double pay, ref double tax, ref double payfinal)
            {
            }
        }

        //doctor pay rate calculation 
        public class payDoctor : payroll
        {
           
            public override void calculatePay(int hours, int bonus, ref double pay, ref double tax, ref double payfinal)
            {
                int rate = 30;
                pay = (rate * hours)+bonus;
                tax = 0.25 * pay;
                payfinal = 0.75 * pay;
            }
        }

        //therapist pay rate calculation 
        public class payTherapist : payroll
        {

            public override void calculatePay(int hours, int bonus, ref double pay, ref double tax, ref double payfinal)
            {
                int rate = 25;
                pay = (rate * hours) + bonus;
                tax = 0.25 * pay;
                payfinal = 0.75 * pay;
            }
        }

        //nurse pay rate calculation 
        public class payNurse : payroll
        {

            public override void calculatePay(int hours, int bonus, ref double pay, ref double tax, ref double payfinal)
            {
                int rate = 15;
                pay = (rate * hours) + bonus;
                tax = 0.25 * pay;
                payfinal = 0.75 * pay;
            }
        }

        //physician pay rate calculation 
        public class payPhysicians : payroll
        {

            public override void calculatePay(int hours, int bonus, ref double pay, ref double tax, ref double payfinal)
            {
                int rate = 20;
                pay = (rate * hours) + bonus;
                tax = 0.25 * pay;
                payfinal = 0.75 * pay;
            }
        }

        //retrieving staff member's role and ID to calculate his/her pay roll
        private void getStaffBill()
        {            
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.connString))
            {
                //Using table Hospital.staff

                List<string> roleInformation = new List<string>();
                String roleStaff;
                connection.Open();
                //using Hospital.staff table
                String sql = "SELECT * FROM [Hospital].[staff] WHERE StaffID = @StaffID";
                using (SqlCommand comm = new SqlCommand(sql, connection))
                {

                    comm.Parameters.Add(new SqlParameter("@StaffID", SqlDbType.VarChar, 10));
                    comm.Parameters["@StaffID"].Value = inputStaffID.Text;
                    SqlDataReader read;
                    read = comm.ExecuteReader();

                    while (read.Read())
                    {
                        String role = read["StaffRole"].ToString();
                        roleInformation.Add(role.ToString());

                    }
                    read.Close();

                    roleStaff = roleInformation[0].ToString();
                }

                //using Hospital.staffDetails table
                List<string> hoursStaff = new List<string>();
                List<string> bonusStaff = new List<string>();

                int hoursInt;
                int bonusInt;

                String sql2 = "SELECT * FROM [Hospital].[staffDetails] WHERE StaffID = @StaffID";
                using (SqlCommand comm = new SqlCommand(sql2, connection))
                {

                    comm.Parameters.Add(new SqlParameter("@StaffID", SqlDbType.VarChar, 10));
                    comm.Parameters["@StaffID"].Value = inputStaffID.Text;
                    SqlDataReader reader;
                    reader = comm.ExecuteReader();

                    while (reader.Read())
                    {
                        String fetchHours = reader["NumberOfHours"].ToString();
                        String fetchBonus = reader["Bonus"].ToString();
                        hoursStaff.Add(fetchHours.ToString());
                        bonusStaff.Add(fetchBonus.ToString());

                    }
                    String hours = hoursStaff[0].ToString();
                    String bonus = bonusStaff[0].ToString();
                    
                    hoursInt = Convert.ToInt32(hoursStaff[0]);
                    bonusInt = Convert.ToInt32(bonusStaff[0]);

                }
                calculatePay(roleStaff, hoursInt, bonusInt);

            }
        }

        private void calculatePay(String role, int hours, int bonus)
        {
            double tax=1;
            double pay=1;
            double payfinal=1;

            if (role.Equals("Doctor"))
            {
                MessageBox.Show("Doctor Salary");
                payroll payroll = new payDoctor();
                payroll.calculatePay(hours, bonus, ref pay, ref tax, ref payfinal);

                staffHrs.Text = hours.ToString();
                staffPay.Text = pay.ToString();
                staffTax.Text = tax.ToString();
                staffTotalPay.Text = payfinal.ToString();
            }

            if (role.Equals("Physicians"))
            {
                MessageBox.Show("Physicians Salary");
                payroll payroll = new payPhysicians();
                payroll.calculatePay(hours, bonus, ref pay, ref tax, ref payfinal);

                staffHrs.Text = hours.ToString();
                staffPay.Text = pay.ToString();
                staffTax.Text = tax.ToString();
                staffTotalPay.Text = payfinal.ToString();
            }

            if (role.Equals("Therapist"))
            {
                MessageBox.Show("Therapist Salary");
                payroll payroll = new payTherapist();
                payroll.calculatePay(hours, bonus, ref pay, ref tax, ref payfinal);

                staffHrs.Text = hours.ToString();
                staffPay.Text = pay.ToString();
                staffTax.Text = tax.ToString();
                staffTotalPay.Text = payfinal.ToString();
            }

            if (role.Equals("Nurse"))
            {
                MessageBox.Show("Nurse Salary");
                payroll payroll = new payNurse();
                payroll.calculatePay(hours, bonus, ref pay, ref tax, ref payfinal);

                staffHrs.Text = hours.ToString();
                staffPay.Text = pay.ToString();
                staffTax.Text = tax.ToString();
                staffTotalPay.Text = payfinal.ToString();
            }
        }

        //button to clculate payroll and display the amount
        private void calcStaffPay_Click(object sender, EventArgs e)
        {
            if (IsStaffIDValid())
            {
                using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.connString))
                {
                    connection.Open();

                    try
                    {
                        getStaffBill();
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

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void staffID_TextChanged(object sender, EventArgs e)
        {

        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void staffDetailstxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void StaffTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void detailsdgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void staffdgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void Title_Click(object sender, EventArgs e)
        {

        }

        private void Staff_Load(object sender, EventArgs e)
        {

        }
    }
}
    

