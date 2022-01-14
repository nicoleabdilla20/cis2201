﻿using System;
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

        //verification methods - checking whether all the fields were filled in or not
        private bool IsTypeValid() 
        {
            {
                if (this.typeOfMed.SelectedIndex == -1)
                {
                    MessageBox.Show("Please make sure that you have entered the type of medication!");
                    return false;

                }
                else
                {
                    return true;

                }
            }
        } 

        private bool IsNameValid()
        {
            if (typeOfMed.Items.Contains("Medicine") || typeOfMed.Items.Contains("Vaccine") || typeOfMed.Items.Contains("Instruments"))
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
            else if (typeOfMed.Items.Contains("Blood Samples"))
            {
                if(this.bloodType.SelectedIndex == -1) 
                { 
                    MessageBox.Show("Please make sure that you have entered the blood type!");
                }
                return false;
            }
            else
            {
               return true;
            }
        } 

 
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
            if (this.maintenanceCmboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please make sure that you have entered if maintenance is required or not!");
                return false;
            }
            else {
                return true;
            }
          
        }

        //adding a new medication equipment and storing it into the database
        private void button1_Click(object sender, EventArgs e)
        {
            //verification methods
            if (IsTypeValid() && IsNameValid() && IsStockValid() && IsPriceValid() && IsMaintenanceValid())
            {
                //creating the connection
                using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.connString))
                {
                    //creating a SqlCommand, and identifying it as a stored procedure
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
                        sqlCommand.Parameters["@requireMaintenance"].Value = maintenanceCmboBox.Text;

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

        private void searchMedBackBtn_Click(object sender, EventArgs e)
        {
            //goes back to Navigation form
            this.Hide();
            Navigation fm = new Navigation();
            fm.Show();
        }

        private void addMedbackbtn_Click(object sender, EventArgs e)
        {
            //goes back to Navigation form
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

        //verification method - makes sure field was not left empty
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

        //medication list
        private List<medications> getMedList()
        {
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.connString))
            {
                //Establishinhg the database connection.
                connection.Open();
                //SQL string query that will retrieve data from teh database.
                String sql = "SELECT * FROM [Hospital].[Medication] WHERE NameOfMed = @NameOfMed";
                //Creating a new SQL command made up of the connection and the sql query that were both created above.
                using (SqlCommand comm = new SqlCommand(sql, connection))
                {
                    //Adding the ID entered from the user through the WinForm as a new sql parameter.
                    comm.Parameters.Add(new SqlParameter("@NameOfMed", SqlDbType.VarChar, 10));
                    comm.Parameters["@NameOfMed"].Value = medSearch.Text;
                    //Creating a new SQL data reader object.
                    SqlDataReader read;
                    read = comm.ExecuteReader();

                    //Creating a new list that will be returned.
                    List<medications> medList = new List<medications>();


                    while (read.Read())
                    {
                        //Creating a new object of the class 'medications' and passing the data read from the database through the SqlDataReader object that was created above, as arguments to the class' constructor.
                        medications p = new medications(read["TypeOfMed"].ToString(), read["NameOfMed"].ToString(), read["bloodType"].ToString(), read["stockAmount"].ToString(), read["price"].ToString(), read["requireMaintenance"].ToString());
                        //Adding the variables created in the class 'medication' to the list.
                        medList.Add(p);
                    }
                    //Returning the list.
                    return medList;
                    
                }
            }
        }
        
        //searching a medication from the database by type of medication
        private void searchTypeofMed_Click(object sender, EventArgs e)
        {
            if (IsSeachValid())
            {
                //Establishinhg the database connection.
                using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.connString))
                {
                    //Opening the above created connection
                    connection.Open();

                    //Using a try-catch to help point out any exception errors that might come up.
                    try
                    {
                        //Determining the 'getMedList()' method as the data grid view output.
                        meddgv.DataSource = getMedList();
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

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void medHomebackbtn_Click(object sender, EventArgs e)
        {
            //goes back to Navigation form
            this.Hide();
            Navigation fm = new Navigation();
            fm.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void stock_TextChanged(object sender, EventArgs e)
        {

        }
    }
}