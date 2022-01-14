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
    public partial class Patients : Form
    {
        public Patients()
        {
            InitializeComponent();
        }

        //verification methods - checking whether all the fields were filled in or not
        private bool IsPatientValid()
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

        private bool IsPatientIDValid()
        {
            if (IDtxt.Text == "")
            {
                MessageBox.Show("Please make sure that you have entered the patient's ID!");
                return false;
            }
            else
            {
                return true;
            }
        }

        private bool IsPatientInfoIDValid()
        {
            if (psearchID.Text == "")
            {
                MessageBox.Show("Please make sure that you have entered the patient's ID!");
                return false;
            }
            else
            {
                return true;
            }
        }

        private bool IsPatientPlanIDValid()
        {
            if (textBoxID.Text == "")
            {
                MessageBox.Show("Please make sure that you have entered the patient's ID!");
                return false;
            }
            else
            {
                return true;
            }
        }

        private bool IsPatientvisitIDValid()
        {
            if (pvisitID.Text == "")
            {
                MessageBox.Show("Please make sure that you have entered the patient's ID!");
                return false;
            }
            else
            {
                return true;
            }
        }

        private void TelephoneValidation_Leave(object sender, EventArgs e)
        {
            if ((telephonetxt.Text.Length < 15) && (telephonetxt.Text.Length > 0))
            {
                MessageBox.Show("Phone number must be max 15 digits!");
                telephonetxt.Focus();
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

        //adding a new patient and storing it into the database
        private void submit_Click(object sender, EventArgs e)
        {
            //verification methods
            if (IsPatientValid() && IsPatientIDValid() && isAddressValid())
            {
                //creating the connection
                using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.connString))
                {
                    //creating a SqlCommand, and identifying it as a stored procedure
                    using (SqlCommand sqlCommand = new SqlCommand("Hospital.addPatient", connection))
                    {
                        sqlCommand.CommandType = CommandType.StoredProcedure;

                        sqlCommand.Parameters.Add(new SqlParameter("@PatientsName", SqlDbType.NVarChar, 40));
                        sqlCommand.Parameters["@PatientsName"].Value = nametxt.Text;

                        sqlCommand.Parameters.Add(new SqlParameter("@PatientsSurnameName", SqlDbType.NVarChar, 40));
                        sqlCommand.Parameters["@PatientsSurnameName"].Value = surnametxt.Text;

                        sqlCommand.Parameters.Add(new SqlParameter("@PatientsGender", SqlDbType.NVarChar, 40));
                        sqlCommand.Parameters["@PatientsGender"].Value = gendertxt.Text;

                        sqlCommand.Parameters.Add(new SqlParameter("@PatientsAge", SqlDbType.Int));
                        sqlCommand.Parameters["@PatientsAge"].Value = Int32.Parse(agetxt.Text);

                        sqlCommand.Parameters.Add(new SqlParameter("@PatientsDateOfBirth", SqlDbType.Date));
                        sqlCommand.Parameters["@PatientsDateOfBirth"].Value = dob.Value;

                        sqlCommand.Parameters.Add(new SqlParameter("@PatientsAddress", SqlDbType.VarChar, 100));
                        sqlCommand.Parameters["@PatientsAddress"].Value = addresstxt.Text;

                        sqlCommand.Parameters.Add(new SqlParameter("@PatientsTelephone", SqlDbType.Int));
                        sqlCommand.Parameters["@PatientsTelephone"].Value = Int32.Parse(telephonetxt.Text);

                        sqlCommand.Parameters.Add(new SqlParameter("@PatientsBloodType", SqlDbType.VarChar, 10));
                        sqlCommand.Parameters["@PatientsBloodType"].Value = bloodopts.Text;

                        sqlCommand.Parameters.Add(new SqlParameter("@PatientsAllergies", SqlDbType.VarChar, 10));
                        sqlCommand.Parameters["@PatientsAllergies"].Value = allergiesopts.Text;

                        sqlCommand.Parameters.Add(new SqlParameter("@PatientsInsurance", SqlDbType.Char, 1));
                        sqlCommand.Parameters["@PatientsInsurance"].Value = insurancetxt.Text;

                        sqlCommand.Parameters.Add(new SqlParameter("@PatientsID", SqlDbType.VarChar, 10));
                        sqlCommand.Parameters["@PatientsID"].Value = IDtxt.Text;

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

        //adding a new patient visit and storing it into the database
        private void visitsubmit_Click(object sender, EventArgs e)
        {
            //verification methods
            if (IsPatientValid() && IsPatientIDValid())
            {
                //creating the connection
                using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.connString))
                {
                    //creating a SqlCommand, and identifying it as a stored procedure
                    using (SqlCommand sqlCommand = new SqlCommand("Hospital.addPatientVisit", connection))
                    {
                        sqlCommand.CommandType = CommandType.StoredProcedure;

                        sqlCommand.Parameters.Add(new SqlParameter("@PatientsID", SqlDbType.VarChar, 10));
                        sqlCommand.Parameters["@PatientsID"].Value = IDtxt.Text;

                        sqlCommand.Parameters.Add(new SqlParameter("@PatientsName", SqlDbType.NVarChar, 10));
                        sqlCommand.Parameters["@PatientsName"].Value = nametxt.Text;

                        sqlCommand.Parameters.Add(new SqlParameter("@PatientsSurname", SqlDbType.NVarChar, 10));
                        sqlCommand.Parameters["@PatientsSurname"].Value = surnametxt.Text;

                        sqlCommand.Parameters.Add(new SqlParameter("@RecentVisitDate", SqlDbType.Date));
                        sqlCommand.Parameters["@RecentVisitDate"].Value = visitdate.Value;

                        sqlCommand.Parameters.Add(new SqlParameter("@RecentVisitDoctor", SqlDbType.VarChar, 40));
                        sqlCommand.Parameters["@RecentVisitDoctor"].Value = doctortxt.Text;

                        sqlCommand.Parameters.Add(new SqlParameter("@RecentVisitSummary", SqlDbType.VarChar, 100));
                        sqlCommand.Parameters["@RecentVisitSummary"].Value = summarytxt.Text;

                        sqlCommand.Parameters.Add(new SqlParameter("@OtherVisitDate", SqlDbType.Date));
                        sqlCommand.Parameters["@OtherVisitDate"].Value = historydate.Value;

                        sqlCommand.Parameters.Add(new SqlParameter("@OtherVisitDoctor", SqlDbType.VarChar, 40));
                        sqlCommand.Parameters["@OtherVisitDoctor"].Value = historydoctor.Text;

                        sqlCommand.Parameters.Add(new SqlParameter("@OtherVisitSummary", SqlDbType.VarChar, 100));
                        sqlCommand.Parameters["@OtherVisitSummary"].Value = historysummary.Text;
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

        //Method that returns a list made up the requested information from the database.
        private List<patientInformation> getPatientsList()
        {
            //Establishinhg the database connection.
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.connString))
            {
                //Opening connection that was established above.
                connection.Open();
                //SQL string query that will retrieve data from teh database.
                String sql = "SELECT * FROM [Hospital].[patients] WHERE PatientsID = @PatientsID";
                //Creating a new SQL command made up of the connection and the sql query that were both created above.
                using (SqlCommand comm = new SqlCommand(sql, connection))
                {
                    //Adding the ID entered from the user through the WinForm as a new sql parameter.
                    comm.Parameters.Add(new SqlParameter("@PatientsID", SqlDbType.VarChar, 10));
                    comm.Parameters["@PatientsID"].Value = psearchID.Text;
                    //Creating a new SQL data reader object.
                    SqlDataReader read;
                    read = comm.ExecuteReader();

                    //Creating a new list that will be returned.
                    List<patientInformation> patientsList = new List<patientInformation>();

                    while (read.Read())
                    {
                        //Creating a new object of the class 'patientInformation' and passing the data read from the database through the SqlDataReader object that was created above, as arguments to the class' constructor.
                        patientInformation pa = new patientInformation(read["PatientsID"].ToString(), read["PatientsName"].ToString(), read["PatientsSurnameName"].ToString(), read["PatientsGender"].ToString(), read["PatientsDateOfBirth"].ToString(), read["PatientsAge"].ToString(), read["PatientsAddress"].ToString(), read["PatientsTelephone"].ToString(), read["PatientsBloodType"].ToString(), read["PatientsAllergies"].ToString(), read["PatientsInsurance"].ToString());
                        //Adding the variables created in the class 'patientInformation' to the list.
                        patientsList.Add(pa);
                    }
                    //Returning the list.
                    return patientsList;
                }
            }
        }



        //Method that returns a list made up the requested information from the database.
         private List<patientVisits> getPatientsVisitList()
         {
            //Establishinhg the database connection.
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.connString))
            {
                //Creaying an object of the filterBox in order to be interacted with later on.
                String selectedItem = (string)Filtercbx.SelectedItem;
                //Opening the above created connection
                connection.Open();
                //SQL string query that will retrieve data from teh database.
                String sql = "SELECT * FROM [Hospital].[patientsVisits] WHERE PatientsID = @PatientsID";
                //Creating a new SQL command made up of the connection and the sql query that were both created above.
                using (SqlCommand comm = new SqlCommand(sql, connection))
                {
                    //Adding the ID entered from the user through the WinForm as a new sql parameter.
                    comm.Parameters.Add(new SqlParameter("@PatientsID", SqlDbType.VarChar, 10));
                    comm.Parameters["@PatientsID"].Value = pvisitID.Text;
                    //Creating a new SQL data reader object.
                    SqlDataReader read;
                    read = comm.ExecuteReader();

                    //Creating a new list that will be returned.
                    List<patientVisits> patientsList = new List<patientVisits>();

                    while (read.Read())
                    {
                        //Creating a new object of the class 'patientVisits' and passing the data read from the database through the SqlDataReader object that was created above, as arguments to the class' constructor.
                        patientVisits p = new patientVisits(read["PatientsID"].ToString(), read["PatientsName"].ToString(), read["PatientsSurname"].ToString(), read["RecentVisitDate"].ToString(), read["RecentVisitDoctor"].ToString(), read["RecentVisitSummary"].ToString(), read["OtherVisitDate"].ToString(), read["OtherVisitDoctor"].ToString(), read["OtherVisitSummary"].ToString());
                        //Adding the variables created in the class 'patientVisits' to the list.
                        patientsList.Add(p);
                    }

                    //Determining the choice of the filterBox by the user through the object that was created above.
                    if (selectedItem == "Date: Newest First")
                    {
                        //LINQ commands that re-arrange the data returned according to the choice of the user.
                        var datenew =
                        from item in patientsList
                        let date = item.RecentVisitDate
                        let id = item.ID
                        orderby date ascending
                        select item;

                        //Creating a new list 'lst' which is made up of the data from the above LINQ commands turned to a list.
                        List<patientVisits> lst = datenew.ToList();
                        //Returning the list.
                        return lst;
                    }
                    else
                    {
                        //LINQ commands that re-arrange the data returned according to the choice of the user.
                        var datenew =
                        from item in patientsList
                        let date = item.RecentVisitDate
                        let id = item.ID
                        orderby date descending
                        select item;

                        //Creating a new list 'lst' which is made up of the data from the above LINQ commands turned to a list.
                        List<patientVisits> lst = datenew.ToList();
                        //Returning the list.
                        return lst;
                    }
                }
            }
        } 

        //Method that will execute when the user hits the search patient button.
        private void searchPatient_Click(object sender, EventArgs e)
        {
            //Validation
            if (IsPatientInfoIDValid())
            {
                //Establishinhg the database connection.
                using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.connString))
                {
                    //Opening the above created connection
                    connection.Open();

                    //Using a try-catch to help point out any exception errors that might come up.
                    try
                    {
                        //Determining the 'getPatientsList()' method as the data grid view output.
                        patientdgv.DataSource = getPatientsList();
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
        }

        //Method that will execute when the user hits the search patient's visit button.
        private void visitsearch_Click(object sender, EventArgs e)
        {
            //Validation
            if (IsPatientvisitIDValid())
            {
                //Establishinhg the database connection.
                using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.connString))
                {
                    //Opening the above created connection
                    connection.Open();

                    //Using a try-catch to help point out any exception errors that might come up.
                    try
                    {
                        //Determining the 'getPatientsvisitlist()' method as the data grid view output.
                        visitdgv.DataSource = getPatientsVisitList();
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
        }

        //adding a new appointment and storing it into the database
        private void crtAppbtn_Click(object sender, EventArgs e)
        {
            //creating the connection
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.connString))
            {
                //creating a SqlCommand, and identifying it as a stored procedure
                using (SqlCommand sqlCommand = new SqlCommand("Hospital.addAppointment", connection))
                {
                    sqlCommand.CommandType = CommandType.StoredProcedure;

                    sqlCommand.Parameters.Add(new SqlParameter("@PatientsID", SqlDbType.VarChar, 40));
                    sqlCommand.Parameters["@PatientsID"].Value = ApppatID.Text;

                    sqlCommand.Parameters.Add(new SqlParameter("@PatientsName", SqlDbType.VarChar, 40));
                    sqlCommand.Parameters["@PatientsName"].Value = ApppatName.Text;

                    sqlCommand.Parameters.Add(new SqlParameter("@PatientsSurname", SqlDbType.VarChar, 40));
                    sqlCommand.Parameters["@PatientsSurname"].Value = ApppatSurname.Text;

                    sqlCommand.Parameters.Add(new SqlParameter("@Doctor", SqlDbType.VarChar, 40));
                    sqlCommand.Parameters["@Doctor"].Value = AppDoctor.Text;

                    sqlCommand.Parameters.Add(new SqlParameter("@CreationDate", SqlDbType.Date));
                    sqlCommand.Parameters["@CreationDate"].Value = Appcdate.Value;

                    sqlCommand.Parameters.Add(new SqlParameter("@ScheduledDate", SqlDbType.Date));
                    sqlCommand.Parameters["@ScheduledDate"].Value = Appsdate.Value;
                    try
                    {
                        //opening conneciton
                        connection.Open();

                        sqlCommand.ExecuteNonQuery();
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

        //retrieving an appointment that is stored in the database according to the patients ID 
        private List<patientAppointmet> getAppointment()
        {
            //creating the connection
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.connString))
            {
                //Creaying an object of the filterBox in order to be interacted with later on.
                String selectedItem = (string)AppFiltercbx.SelectedItem;
                //Opening the above created connection.
                connection.Open();
                //SQL string query that will retrieve data from teh database.
                String sql = "SELECT * FROM [Hospital].[Appointments] WHERE PatientsID = @PatientsID";
                //Creating a new SQL command made up of the connection and the sql query that were both created above.
                using (SqlCommand comm = new SqlCommand(sql, connection))
                {
                    //Adding the ID entered from the user through the WinForm as a new sql parameter.
                    comm.Parameters.Add(new SqlParameter("@PatientsID", SqlDbType.VarChar, 10));
                    comm.Parameters["@PatientsID"].Value = AppsearchID.Text;
                    //Creating a new SQL data reader object.
                    SqlDataReader read;
                    read = comm.ExecuteReader();

                    //Creating a new list that will be returned.
                    List<patientAppointmet> appointmentList = new List<patientAppointmet>();


                    while (read.Read())
                    {
                        //Creating a new object of the class 'patientAppointment' and passing the data read from the database through the SqlDataReader object that was created above, as arguments to the class' constructor.
                        patientAppointmet p = new patientAppointmet(read["AppointmentID"].ToString(), read["PatientsID"].ToString(), read["PatientsName"].ToString(), read["PatientsSurname"].ToString(), read["Doctor"].ToString(), read["CreationDate"].ToString(), read["ScheduledDate"].ToString());
                        //Adding the variables created in the class 'patientVisits' to the list.
                        appointmentList.Add(p);
                    }

                    //Determining the choice of the filterBox by the user through the object that was created above.
                    if (selectedItem == "Sort by Date: Newest First")
                    {
                        //LINQ commands that re-arrange the data returned according to the choice of the user.
                        var datenew =
                        from item in appointmentList
                        let date = item.ScheduledDate
                        orderby date ascending
                        select item;

                        //Creating a new list 'lst' which is made up of the data from the above LINQ commands turned to a list.
                        List<patientAppointmet> lst = datenew.ToList();
                        //Returning the list.
                        return lst;
                    }
                    else
                    {
                        //LINQ commands that re-arrange the data returned according to the choice of the user.
                        var datenew =
                        from item in appointmentList
                        let date = item.ScheduledDate
                        orderby date descending
                        select item;

                        //Creating a new list 'lst' which is made up of the data from the above LINQ commands turned to a list.
                        List<patientAppointmet> lst = datenew.ToList();
                        //Returning the list.
                        return lst;
                    }
                }
            }
        }


        //Method that will execute when the user hits the search patient's appointment button.
        private void Appsearchbtn_Click(object sender, EventArgs e)
        {
            
                //Establishinhg the database connection.
                using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.connString))
                {
                    //Opening the above created connection
                    connection.Open();

                    //Using a try-catch to help point out any exception errors that might come up.
                    try
                    {
                        //Determining the 'getAppointment()' method as the data grid view output.
                       Appsearchdgv.DataSource = getAppointment();
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

        private void label32_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label29_Click(object sender, EventArgs e)
        {

        }

        private void label30_Click(object sender, EventArgs e)
        {

        }

        private void ApppatName_TextChanged(object sender, EventArgs e)
        {

        }

        private void ApppatSurname_TextChanged(object sender, EventArgs e)
        {

        }

        private void label33_Click(object sender, EventArgs e)
        {

        }

        private void Appcdate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Appsdate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label35_Click(object sender, EventArgs e)
        {

        }

        private void Appointment_Click(object sender, EventArgs e)
        {

        }

        private void label31_Click(object sender, EventArgs e)
        {

        }

        private void AppDoctor_TextChanged(object sender, EventArgs e)
        {

        }

        private void label36_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

         private void issuebtn_Click(object sender, EventArgs e)
        {
            //opens Report Issue form
            ReportIssue ReportIssue = new ReportIssue();
            ReportIssue.ShowDialog();
        }

        private void patHomebackbtn_Click(object sender, EventArgs e)
        {
            //goes back to Navigation form
            this.Hide();
            Navigation fm = new Navigation();
            fm.Show();
        }

        private void addPatbackbtn_Click(object sender, EventArgs e)
        {
            //goes back to Navigation form
            this.Hide();
            Navigation fm = new Navigation();
            fm.Show();
        }

        private void Appbackbtn_Click(object sender, EventArgs e)
        {
            //goes back to Navigation form
            this.Hide();
            Navigation fm = new Navigation();
            fm.Show();
        }

        private void billBackbtn_Click(object sender, EventArgs e)
        {
            //goes back to Navigation form
            this.Hide();
            Navigation fm = new Navigation();
            fm.Show();
        }

        private void searchPatbackbtn_Click(object sender, EventArgs e)
        {
            //goes back to Navigation form
            this.Hide();
            Navigation fm = new Navigation();
            fm.Show();
        }

        private void textBoxID_TextChanged(object sender, EventArgs e)
        {

        }

        //=================================================================Calculate Patient Bill=================================================================
        int expenseTotal = 100;
        int finalAnswer;

        //retrieving the type of insurance the patient has in order to calculate the bill
        private string getPatientsInsurance()
        {
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.connString))
            {
                List<string> planInformation = new List<string>();
                String selectedItem = (string)Filtercbx.SelectedItem;
                connection.Open();
                String sql = "SELECT * FROM [Hospital].[patients] WHERE PatientsID = @PatientsID";
                using (SqlCommand comm = new SqlCommand(sql, connection))
                {

                    comm.Parameters.Add(new SqlParameter("@PatientsID", SqlDbType.VarChar, 10));
                    comm.Parameters["@PatientsID"].Value = textBoxID.Text;
                    SqlDataReader read;
                    read = comm.ExecuteReader();

                    while (read.Read())
                    {
                        String pl = read["PatientsInsurance"].ToString();
                        planInformation.Add(pl.ToString());

                    }
                    //ID not found error
                    String patientPlan = "test";
                    try
                    {
                        patientPlan = planInformation[0].ToString();
                        calculateBill(patientPlan);
                        //return patientPlan;
                    }
                    catch (ArgumentOutOfRangeException ex)
                    {
                        MessageBox.Show("ID not found!");
                        
                    }

                    return patientPlan;



                }
            }
        }
        
        //calculating the bill in accordance to the insurance plan chosen by the patient beforehand
        private void calculateBill(String plan)
        {
            try {
                int night = Convert.ToInt32(textBoxNights.Text);

                if (plan.Equals("X"))
                {
                    MessageBox.Show("Your insurance plan is X: you agreed to pay 100% of the bill out of pocket.");
                    expenseTotal = expenseTotal * night;
                    planX x = new planX();
                    finalAnswer = x.calculate(expenseTotal);
                    MessageBox.Show("Final Answer: " + finalAnswer);
                }
                else if (plan.Equals("Y"))
                {
                    MessageBox.Show("Your insurance plan is Y: you agreed to pay counterpart funding (50%) if the bill is more than 700. If it's less than 700, you agreed to pay 100% of the bill out of pocket.");
                    expenseTotal = expenseTotal * night;
                    planY y = new planY();
                    finalAnswer = y.calculate(expenseTotal);
                    MessageBox.Show("Final Answer: " + finalAnswer);
                }
                else
                {
                    MessageBox.Show("Your insurance plan is Z: you agreed to pay no counterpart for service uptake.");
                    expenseTotal = expenseTotal * night;
                    planZ z = new planZ();
                    finalAnswer = z.calculate(expenseTotal);
                    MessageBox.Show("Final Answer: " + finalAnswer);
                }

                textBoxExpenseTotal.Text = expenseTotal.ToString();
                textBoxPay.Text = finalAnswer.ToString();
                expenseTotal = 100;
            }
            catch (FormatException ex) {
                MessageBox.Show("Please enter number of nights!");
            }
        }

        //calculate bill button
        private void button1_Click(object sender, EventArgs e)
        {            
            if (IsPatientPlanIDValid())
            {
                using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.connString))
                {
                    connection.Open();

                    try
                    {
                        getPatientsInsurance();
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

        private void psearchID_TextChanged(object sender, EventArgs e)
        {

        }

        private void Patients_Load(object sender, EventArgs e)
        {

        }

        private void patientdgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label39_Click(object sender, EventArgs e)
        {

        }

        private void nametxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void surnametxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void gendertxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void agetxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void dob_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void IDtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void addresstxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void telephonetxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Search_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AddPat_Click(object sender, EventArgs e)
        {

        }

        private void visitdgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Title_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }
    }

}


    



 
