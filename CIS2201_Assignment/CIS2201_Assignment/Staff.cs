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
            if (inputStaffID.Text == "")
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
            string cs = @"Data Source=(localdb)\mssqllocaldb;Initial Catalog=Hospital;Integrated Security=True;Pooling=False"; //my databse conenction

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
            string cs = @"Data Source=(localdb)\mssqllocaldb;Initial Catalog=Hospital;Integrated Security=True;Pooling=False"; //my database conenction

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

        private void label24_Click(object sender, EventArgs e)
        {

        }

        /*
        public void getStaffPay()
        {
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.connString))
            {
                connection.Open();
                String sql = "SELECT * FROM [Hospital].[staff] WHERE StaffID = @StaffID";
                using (SqlCommand comm = new SqlCommand(sql, connection))
                {

                    comm.Parameters.Add(new SqlParameter("@StaffID", SqlDbType.VarChar, 10));
                    comm.Parameters["@StaffID"].Value = payStaffId.Text;
                    SqlDataReader read;
                    read = comm.ExecuteReader();

                    while (read.Read())
                    {
                        
                        var hours = Convert.ToInt32(read["StaffHours"]);
                        var role = Convert.ToString(read["StaffRole"]);

                        switch(role)
                        {
                            case "Doctor":
                                firstScale f = new firstScale(hours, role);
                                hrsdgv.DataSource = hours;
                                payrolldgv.DataSource = f.GetStaffPayroll();
                                break;
                        }
                    }
                }
            }
        }
        */

        ///Calculate payroll attempt (tried to use interface and split each role in a pay Scale)
        /*
         * 
            Scale1:
            Doctor, specialist, Pharmacist

            Scale 2:
            Nurse, Therapist

            scale 3:
            Phsician, Interpreter, Social worker
        

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.connString))
            {
                connection.Open();
                String sql = "SELECT * FROM [Hospital].[staff] WHERE StaffID = @StaffID";
                using (SqlCommand comm = new SqlCommand(sql, connection))
                {

                    comm.Parameters.Add(new SqlParameter("@StaffID", SqlDbType.VarChar, 10));
                    comm.Parameters["@StaffID"].Value = payStaffId.Text;
                    SqlDataReader read;
                    read = comm.ExecuteReader();

                    try
                    {
                        while (read.NextResult())
                        {

                            var hours = Convert.ToInt32(read["StaffHours"]);
                            var role = read["StaffRole"].ToString();


                            if (role == "Doctor")
                            {
                                firstScale f = new firstScale(hours, role);
                                hrsdgv.DataSource = hours;
                                payrolldgv.DataSource = f.GetStaffPayroll();
                                break;
                            }
                            
                        }
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
        */

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

        private List<staffInformation> getStaffList()
        {

            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.connString))
            {
                connection.Open();
                String sql = "SELECT * FROM [Hospital].[staff] WHERE StaffID = @StaffID";
                using (SqlCommand comm = new SqlCommand(sql, connection))
                { 
                    comm.Parameters.Add(new SqlParameter("@StaffID", SqlDbType.VarChar, 10));
                    comm.Parameters["@StaffID"].Value = staffID.Text;
                    SqlDataReader read;
                    read = comm.ExecuteReader();

                    List<staffInformation> staffList = new List<staffInformation>();


                    while (read.Read())
                    {

                        staffInformation p = new staffInformation(read["StaffID"].ToString(), read["StaffName"].ToString(), read["StaffSurnameName"].ToString(), read["StaffGender"].ToString(), read["StaffDateOfBirth"].ToString(), read["StaffAge"].ToString(), read["StaffAddress"].ToString(), read["StaffEmail"].ToString(), read["StaffPhoneNumber"].ToString(), read["StaffBloodType"].ToString(), read["StaffInsurance"].ToString(), read["StaffRole"].ToString());
                        staffList.Add(p);
                    }
                    return staffList;
                }
            }
        }

        private List<staffD> getStaffDetailList()
        {
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.connString))
            {
                connection.Open();
                String sql = "SELECT * FROM [Hospital].[staffDetails] WHERE StaffID = @StaffID";
                using (SqlCommand comm = new SqlCommand(sql, connection))
                {
                    comm.Parameters.Add(new SqlParameter("@StaffID", SqlDbType.VarChar, 10));
                    comm.Parameters["@StaffID"].Value = staffDetailstxt.Text;
                    SqlDataReader read;
                    read = comm.ExecuteReader();

                    List<staffD> staffDetailList = new List<staffD>();


                    while (read.Read())
                    {

                        staffD p = new staffD(read["StaffID"].ToString(), read["StaffName"].ToString(), read["StaffSurname"].ToString(), read["StartOfContract"].ToString(), read["EndOfContract"].ToString(), read["TypeOfContract"].ToString(), read["NumberOfHours"].ToString(), read["Bonus"].ToString());
                        staffDetailList.Add(p);
                    }
                    return staffDetailList;
                }
            }
        }
        private void searchStaffID_Click(object sender, EventArgs e)
        {
            if (IsStaffIdValid())
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
            }
        }

        private void searchRole_Click_1(object sender, EventArgs e)
        {
            if (IsStaffIdDetailValid())
            {
                using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.connString))
                {
                    connection.Open();

                    try
                    {
                        detailsdgv.DataSource = getStaffDetailList();
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

        //=====================================================CALCULATE STAFF PAY================================================
        public class payroll
        {
            public virtual void calculatePay(int hours, int bonus, ref double pay, ref double tax, ref double payfinal)
            {
            }
        }

        //calculation on doctor pay rate
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
        private void getStaffBill()
        {            
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.connString))
            {
                //Using table Hospital.staff

                List<string> roleInformation = new List<string>();
                String roleStaff;
                //String selectedItem = (string)Filtercbx.SelectedItem;
                connection.Open();
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

                //Using table Hospital.staffDetails

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
    }
}
    

