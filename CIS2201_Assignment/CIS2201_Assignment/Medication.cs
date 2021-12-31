using System;
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
    public partial class Medication : Form
    {
        public Medication()
        {
            InitializeComponent();
        }

        private void Medication_Load(object sender, EventArgs e)
        {

        }

        private void typeOfMed_SelectedIndexChanged(object sender, EventArgs e)
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

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void IDtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void gendertxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void agetxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private bool IsTypeValid() //not working
        {
            {
                if (typeOfMed.SelectedItem == "")
                {
                    MessageBox.Show("No Item is Selected");
                    return false;

                }
                else
                {
                    return true;

                }
            }
        }

        /* private bool IfTypeBloodSamples() //not working
        {
            //if blood samples was chosen in type of medication, make sure blood type is filled in
            if (typeOfMed.SelectedItem = "Blood Samples" )
            {
                if(bloodType.SelectedItem == "") { 
                
                MessageBox.Show("Please make sure that you have entered the blood type!");
                    }
                                return false;

            }
            else
            {
                                return true;

            }
        } */

        private bool IsStockValid()
        {
            if (stock.Text == "")
            {
                MessageBox.Show("Please make sure that you have entered the stock amount!");
                return false;
            }
            else
            {
                return true;
            }
        }

        private bool IsNameValid()
        {
            if (nameOfMed.Text == "")
            {
                MessageBox.Show("Please make sure that you have entered the name of the medication!");
                return false;
            }
            else
            {
                return true;
            }
        }

        private bool IsPriceValid()
        {
            if (price.Text == "")
            {
                MessageBox.Show("Please make sure that you have entered the price!");
                return false;
            }
            else
            {
                return true;
            }
        }
        private bool IsMaintenanceValid()
        {
            if (maintenancetxt.Text == "")
            {
                MessageBox.Show("Please make sure that you have entered if maintenance is required or not!");
                return false;
            }
            else {
                return true;
            }
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (IsStockValid() && IsNameValid() && IsPriceValid() && IsMaintenanceValid())
            {
                // Create the connection.
                using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.connString))
                {
                    // Create a SqlCommand, and identify it as a stored procedure.
                    using (SqlCommand sqlCommand = new SqlCommand("Hospital.addMedication", connection))
                    {
                        sqlCommand.CommandType = CommandType.StoredProcedure;

                        sqlCommand.Parameters.Add(new SqlParameter("@TypeOfMed", SqlDbType.NVarChar, 40));
                        sqlCommand.Parameters["@TypeOfMed"].Value = typeOfMed.Text;

                        sqlCommand.Parameters.Add(new SqlParameter("@NameOfMed", SqlDbType.NVarChar, 40));
                        sqlCommand.Parameters["@NameOfMed"].Value = nameOfMed.Text;

                        sqlCommand.Parameters.Add(new SqlParameter("@bloodType", SqlDbType.NVarChar, 40));
                        sqlCommand.Parameters["@bloodType"].Value = bloodType.Text;

                        sqlCommand.Parameters.Add(new SqlParameter("@stockAmount", SqlDbType.NVarChar, 40));
                        sqlCommand.Parameters["@stockAmount"].Value = stock.Text;

                        sqlCommand.Parameters.Add(new SqlParameter("@price", SqlDbType.NVarChar, 40));
                        sqlCommand.Parameters["@price"].Value = price.Text;

                        sqlCommand.Parameters.Add(new SqlParameter("@requireMaintenance", SqlDbType.VarChar, 40));
                        sqlCommand.Parameters["@requireMaintenance"].Value = maintenancetxt.Text;

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
            else 
             {
                string errorMessage = "Whoops......something went wrong!";
                MessageBox.Show(errorMessage);

             }
        }

        /*
        private void searchMedID_Click(object sender, EventArgs e)
        {
            if (IsTypeValid())
            {
                using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.connString))
                {
                    connection.Open();

                    try
                    {
                        //required list
                       // medicationdgv.DataSource = getMedicationList();
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

         private void issuebtn_Click(object sender, EventArgs e)
        {
            ReportIssue ReportIssue = new ReportIssue();
            ReportIssue.ShowDialog();
        }

        private void searchMedBackBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Navigation fm = new Navigation();
            fm.Show();
        }

        private void addMedbackbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Navigation fm = new Navigation();
            fm.Show();
        }

        private void checkbox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bloodType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void patientdgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void SearchMed_Click(object sender, EventArgs e)
        {

        }

        public bool IsSeachValid()
        {
            if(medSearch.Text == "")
            {
                MessageBox.Show("Please Enter a medication name to search!");
                return false;
            }
            else
            {
                return true;
            }
        }

        private List<medications> getMedList()
        {
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.connString))
            {
                connection.Open();
                String sql = "SELECT * FROM [Hospital].[Medication] WHERE NameOfMed = @NameOfMed";
                using (SqlCommand comm = new SqlCommand(sql, connection))
                {

                    comm.Parameters.Add(new SqlParameter("@NameOfMed", SqlDbType.VarChar, 10));
                    comm.Parameters["@NameOfMed"].Value = medSearch.Text;
                    SqlDataReader read;
                    read = comm.ExecuteReader();

                    List<medications> medList = new List<medications>();


                    while (read.Read())
                    {

                        medications p = new medications(read["TypeOfMed"].ToString(), read["NameOfMed"].ToString(), read["bloodType"].ToString(), read["stockAmount"].ToString(), read["price"].ToString(), read["requireMaintenance"].ToString());
                        medList.Add(p);
                    }
                    return medList;
                    
                }
            }
        }

        private void searchTypeofMed_Click(object sender, EventArgs e)
        {
                if (IsSeachValid())
                {
                    using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.connString))
                    {
                        connection.Open();

                        try
                        {
                            meddgv.DataSource = getMedList();
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

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void medHomebackbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Navigation fm = new Navigation();
            fm.Show();
        }
    }
}
