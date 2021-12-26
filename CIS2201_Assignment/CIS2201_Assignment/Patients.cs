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

        private void submit_Click(object sender, EventArgs e)
        {
            if (IsPatientValid() && IsPatientIDValid() && isAddressValid())
            {
                // Create the connection.
                using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.connString))
                {
                    // Create a SqlCommand, and identify it as a stored procedure.
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
                            connection.Open();

                            sqlCommand.ExecuteNonQuery();
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

        private void visitsubmit_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.connString))
            {
                using (SqlCommand sqlCommand = new SqlCommand("Hospital.addPatientVisit", connection))
                {
                    sqlCommand.CommandType = CommandType.StoredProcedure;

                    sqlCommand.Parameters.Add(new SqlParameter("@PatientsID", SqlDbType.VarChar, 10));
                    sqlCommand.Parameters["@PatientsID"].Value = IDtxt.Text;

                    sqlCommand.Parameters.Add(new SqlParameter("@PatientsName", SqlDbType.NVarChar, 10));
                    sqlCommand.Parameters["@PatientsName"].Value = nametxt.Text;

                    sqlCommand.Parameters.Add(new SqlParameter("@PatientsSurname", SqlDbType.NVarChar, 10));
                    sqlCommand.Parameters["@PatientsSurnameName"].Value = surnametxt.Text;

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
                        connection.Open();

                        sqlCommand.ExecuteNonQuery();
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

        private List<patientInformation> getPatientsList()
        {
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.connString))
            {
                connection.Open();
                String sql = "SELECT * FROM [Hospital].[patients] WHERE PatientsID = @PatientsID";
                using (SqlCommand comm = new SqlCommand(sql, connection))
                {

                    comm.Parameters.Add(new SqlParameter("@PatientsID", SqlDbType.VarChar, 10));
                    comm.Parameters["@PatientsID"].Value = psearchID.Text;
                    SqlDataReader read;
                    read = comm.ExecuteReader();

                    List<patientInformation> patientsList = new List<patientInformation>();

                    while (read.Read())
                    {
                        patientInformation pa = new patientInformation(read["PatientsID"].ToString(), read["PatientsName"].ToString(), read["PatientsSurnameName"].ToString(), read["PatientsGender"].ToString(), read["PatientsDateOfBirth"].ToString(), read["PatientsAge"].ToString(), read["PatientsAddress"].ToString(), read["PatientsTelephone"].ToString(), read["PatientsBloodType"].ToString(), read["PatientsAllergies"].ToString(), read["PatientsInsurance"].ToString());
                        patientsList.Add(pa);
                    }
                    return patientsList;
                }
            }
        }


        

         private List<patientVisits> getPatientsVisitList()
         {
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.connString))
            {
                String selectedItem = (string)Filtercbx.SelectedItem;
                connection.Open();
                String sql = "SELECT * FROM [Hospital].[patientsVisits] WHERE PatientsID = @PatientsID";
                using (SqlCommand comm = new SqlCommand(sql, connection))
                {

                    comm.Parameters.Add(new SqlParameter("@PatientsID", SqlDbType.VarChar, 10));
                    comm.Parameters["@PatientsID"].Value = pvisitID.Text;
                    SqlDataReader read;
                    read = comm.ExecuteReader();

                    List<patientVisits> patientsList = new List<patientVisits>();


                    while (read.Read())
                    {

                        patientVisits p = new patientVisits(read["PatientsID"].ToString(), read["PatientsName"].ToString(), read["PatientsSurname"].ToString(), read["RecentVisitDate"].ToString(), read["RecentVisitDoctor"].ToString(), read["RecentVisitSummary"].ToString(), read["OtherVisitDate"].ToString(), read["OtherVisitDoctor"].ToString(), read["OtherVisitSummary"].ToString());
                        patientsList.Add(p);
                    }

                    if (selectedItem == "Date: Newest First")
                    {
                        var datenew =
                        from item in patientsList
                        let date = item.RecentVisitDate
                        let id = item.ID
                        orderby date descending
                        select item;

                        List<patientVisits> lst = datenew.ToList();
                        return lst;
                    }
                    else
                    {
                        var datenew =
                        from item in patientsList
                        let date = item.RecentVisitDate
                        let id = item.ID
                        orderby date ascending
                        select item;

                        List<patientVisits> lst = datenew.ToList();
                        return lst;
                    }
                }
            }
        } 


        /// <summary>
        /// source for searching a patient: "https://www.codesd.com/item/i-get-this-error-a-sqlparameter-with-parametername-firstname-is-not-contained-by-this-sqlparametercollection.html"
        /// </summary>
        private void searchPatient_Click(object sender, EventArgs e)
        {
            if (IsPatientInfoIDValid())
            {
                using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.connString))
                {
                    connection.Open();

                    try
                    {
                        patientdgv.DataSource = getPatientsList();
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

        private void visitsearch_Click(object sender, EventArgs e)
        {
            if (IsPatientvisitIDValid())
            {
                using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.connString))
                {
                    connection.Open();

                    try
                    {
                        visitdgv.DataSource = getPatientsVisitList();
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

        private void crtAppbtn_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.connString))
            {
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
                        connection.Open();

                        sqlCommand.ExecuteNonQuery();
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

        private List<patientAppointmet> getAppointment()
        {
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.connString))
            {
                String selectedItem = (string)AppFiltercbx.SelectedItem;
                connection.Open();
                String sql = "SELECT * FROM [Hospital].[Appointments] WHERE PatientsID = @PatientsID";
                using (SqlCommand comm = new SqlCommand(sql, connection))
                {

                    comm.Parameters.Add(new SqlParameter("@PatientsID", SqlDbType.VarChar, 10));
                    comm.Parameters["@PatientsID"].Value = AppsearchID.Text;
                    SqlDataReader read;
                    read = comm.ExecuteReader();

                    List<patientAppointmet> appointmentList = new List<patientAppointmet>();


                    while (read.Read())
                    {

                        patientAppointmet p = new patientAppointmet(read["AppointmentID"].ToString(), read["PatientsID"].ToString(), read["PatientsName"].ToString(), read["PatientsSurname"].ToString(), read["Doctor"].ToString(), read["CreationDate"].ToString(), read["ScheduledDate"].ToString());
                        appointmentList.Add(p);
                    }

                    if (selectedItem == "Sort by Date: Newest First")
                    {
                        var datenew =
                        from item in appointmentList
                        let date = item.ScheduledDate
                        orderby date descending
                        select item;

                        List<patientAppointmet> lst = datenew.ToList();
                        return lst;
                    }
                    else
                    {
                        var datenew =
                        from item in appointmentList
                        let date = item.ScheduledDate
                        orderby date ascending
                        select item;

                        List<patientAppointmet> lst = datenew.ToList();
                        return lst;
                    }
                }
            }
        }



        private void Appsearchbtn_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.connString))
            {
                connection.Open();

                try
                {
                    Appsearchdgv.DataSource = getAppointment();
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
    }

}


    



 
