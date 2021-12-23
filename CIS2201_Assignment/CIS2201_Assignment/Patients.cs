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
        public class Patient
        {
            public string ID { get; set; }
            public string Name { get; set; }
            public string Surname { get; set; }
            public string Gender { get; set; }
            public string DateofBirth { get; set; }
            public string Age { get; set; }
            public string Address { get; set; }
            public string Telephone { get; set; }
            public string BloodType { get; set; }
            public string Allergies { get; set; }
            public string Insurance { get; set; }
            public Patient(string id, string name, string surname, string gender, string dateofbirth, string age, string address, string telephone, string bloddtype, string allergies, string insurance)
            {
                ID = id;
                Name = name;
                Surname = surname;
                Gender = gender;
                DateofBirth = dateofbirth;
                Age = age;
                Address = address;
                Telephone = telephone;
                BloodType = bloddtype;
                Allergies = allergies;
                Insurance = insurance;
            }
        }

        public class PatientVisit
        {
            public string ID { get; set; }
            public string RecentVisitDate { get; set; }
            public string RecentVisitDoctor { get; set; }
            public string RecentVisitSummary { get; set; }
            public string OtherVisitDate { get; set; }
            public string OtherVisitDoctor { get; set; }
            public string OtherVisitSummary { get; set; }
            public PatientVisit(string id, string recentvisitdate, string recentvisitdoctor, string recentvisitsummary, string othervisitdate, string othervisitdoctor, string othervisitsummary)
            {
                ID = id;
                RecentVisitDate = recentvisitdate;
                RecentVisitDoctor = recentvisitdoctor;
                RecentVisitSummary = recentvisitsummary;
                OtherVisitDate = othervisitdate;
                OtherVisitDoctor = othervisitdoctor;
                OtherVisitSummary = othervisitsummary;
            }
        }

        public class Appointments
        {
            public string AppID { get; set; }
            public string PatID { get; set; }
            public string Name { get; set; }
            public string Surname { get; set; }
            public string Doctor { get; set; }
            public string CreationDate { get; set; }
            public string ScheduledDate { get; set; }

            public Appointments(string appid, string id, string name, string surname, string doctor, string creationdate, string scheduleddate)
            {
       
                AppID = appid;
                PatID = id;
                Name = name;
                Surname = name;
                Doctor = doctor;
                CreationDate = creationdate;
                ScheduledDate = scheduleddate;
            }
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

        private List<Patient> getPatientsList()
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

                    List<Patient> patientsList = new List<Patient>();

                    while (read.Read())
                    {
                        Patient pa = new Patient(read["PatientsID"].ToString(), read["PatientsName"].ToString(), read["PatientsSurnameName"].ToString(), read["PatientsGender"].ToString(), read["PatientsDateOfBirth"].ToString(), read["PatientsAge"].ToString(), read["PatientsAddress"].ToString(), read["PatientsTelephone"].ToString(), read["PatientsBloodType"].ToString(), read["PatientsAllergies"].ToString(), read["PatientsInsurance"].ToString());
                        patientsList.Add(pa);
                    }
                    return patientsList;
                }
            }
        }


        

         private List<PatientVisit> getPatientsVisitList()
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

                    List<PatientVisit> patientsList = new List<PatientVisit>();


                    while (read.Read())
                    {
                        
                        PatientVisit p = new PatientVisit(read["PatientsID"].ToString(), read["RecentVisitDate"].ToString(), read["RecentVisitDoctor"].ToString(), read["RecentVisitSummary"].ToString(), read["OtherVisitDate"].ToString(), read["OtherVisitDoctor"].ToString(), read["OtherVisitSummary"].ToString());
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

                        List<PatientVisit> lst = datenew.ToList();
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

                        List<PatientVisit> lst = datenew.ToList();
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

        private List<Appointments> getAppointment()
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

                    List<Appointments> appointmentList = new List<Appointments>();


                    while (read.Read())
                    {

                        Appointments p = new Appointments(read["AppointmentID"].ToString(), read["PatientsID"].ToString(), read["PatientsName"].ToString(), read["PatientsSurname"].ToString(), read["Doctor"].ToString(), read["CreationDate"].ToString(), read["ScheduledDate"].ToString());
                        appointmentList.Add(p);
                    }

                    if (selectedItem == "Sort by Date: Newest First")
                    {
                        var datenew =
                        from item in appointmentList
                        let date = item.ScheduledDate
                        orderby date descending
                        select item;

                        List<Appointments> lst = datenew.ToList();
                        return lst;
                    }
                    else
                    {
                        var datenew =
                        from item in appointmentList
                        let date = item.ScheduledDate
                        orderby date ascending
                        select item;

                        List<Appointments> lst = datenew.ToList();
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
    }

}


    



 
