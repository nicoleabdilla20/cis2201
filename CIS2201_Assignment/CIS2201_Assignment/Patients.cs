using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CIS2201_Assignment
{
    public partial class Patients : Form
    {
        public Patients()
        {
            InitializeComponent();
        }

        private string patientsID;
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
            if(addresstxt.Text == "")
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
                    catch
                    {
                        MessageBox.Show("Patient record was not added, something went wrong!");
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

        /// <summary>
        /// source for searching a patient: "https://www.codesd.com/item/i-get-this-error-a-sqlparameter-with-parametername-firstname-is-not-contained-by-this-sqlparametercollection.html"
        /// </summary>
        private void searchPatient_Click(object sender, EventArgs e)
        {
            if(IsPatientInfoIDValid())
            {
                using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.connString))
                {

                    using (SqlDataAdapter adapter = new SqlDataAdapter("Hospital.searchPatient", connection))
                    {
                        adapter.SelectCommand.CommandType = CommandType.StoredProcedure;

                        SqlParameter p = new SqlParameter();
                        p.ParameterName = "@PatientsID";
                        p.Value = psearchID.Text;

                        adapter.SelectCommand.Parameters.Add(p);
                        
                        try
                        {

                            DataTable d = new DataTable();
                            adapter.Fill(d);
                            patientdgv.DataSource = d;
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

        private void searchVisit_Click(object sender, EventArgs e)
        {
            if (IsPatientvisitIDValid())
            {
                using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.connString))
                { 
                    using (SqlDataAdapter adapter = new SqlDataAdapter("Hospital.searchPatientVisit", connection))
                    {
                        adapter.SelectCommand.CommandType = CommandType.StoredProcedure;

                        SqlParameter p = new SqlParameter();
                        p.ParameterName = "@PatientsID";
                        p.Value = pvisitID.Text;

                        adapter.SelectCommand.Parameters.Add(p);

                        try
                        {

                            DataTable d = new DataTable();
                            adapter.Fill(d);
                            visitdgv.DataSource = d;
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
 
