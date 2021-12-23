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

        public class staffInformation
        {
            public string ID { get; set; }
            public string Name { get; set; }
            public string Surname { get; set; }
            public string Gender { get; set; }
            public string Email { get; set; }
            public string PhoneNumber { get; set; }
            public string Role { get; set; }
            public string Hours { get; set; }

            public staffInformation(string id, string name, string surname, string gender, string email, string phonenumber, string role, string hours)
            {
                ID = id;
                Name = name;
                Surname = surname;
                Gender = gender;
                Email = email;
                PhoneNumber = phonenumber;
                Role = role;
                Hours = hours;
            }
        }


        private void visitsubmit_Click(object sender, EventArgs e)
        {

        }

        private void Title_Click(object sender, EventArgs e)
        {

        }

        private void Staff_Load(object sender, EventArgs e)
        {

        }

        private void hospitallogo_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void submit_Click(object sender, EventArgs e)
        {

        }

        private List<staffInformation> SearchID()
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

                        staffInformation p = new staffInformation(read["StaffID"].ToString(), read["StaffName"].ToString(), read["StaffSurnameName"].ToString(), read["StaffGender"].ToString(), read["StaffEmail"].ToString(), read["StaffPhoneNumber"].ToString(), read["StaffRole"].ToString(), read["StaffHours"].ToString());
                        staffList.Add(p);
                    }
                    return staffList;
                }
            }
        }

        private List<staffInformation> SearchRole()
        {
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.connString))
            {
                String selectedItem = (string)filtercbx.SelectedItem;
                connection.Open();
                String sql = "SELECT * FROM [Hospital].[staff] WHERE StaffRole = @StaffRole";
                using (SqlCommand comm = new SqlCommand(sql, connection))
                {

                    comm.Parameters.Add(new SqlParameter("@StaffRole", SqlDbType.VarChar, 10));
                    comm.Parameters["@StaffRole"].Value = staffRole.Text;
                    SqlDataReader read;
                    read = comm.ExecuteReader();

                    List<staffInformation> staffList = new List<staffInformation>();


                    while (read.Read())
                    {

                        staffInformation p = new staffInformation(read["StaffID"].ToString(), read["StaffName"].ToString(), read["StaffSurnameName"].ToString(), read["StaffGender"].ToString(), read["StaffEmail"].ToString(), read["StaffPhoneNumber"].ToString(), read["StaffRole"].ToString(), read["StaffHours"].ToString());
                        staffList.Add(p);
                    }
                    if (selectedItem == "Hours Worked: Least First")
                    {
                        var hours =
                        from item in staffList
                        let date = item.Hours
                        let id = item.ID
                        orderby date descending
                        select item;

                        List<staffInformation> lst = hours.ToList();
                        return lst;
                    }
                    else
                    {
                        var hours =
                        from item in staffList
                        let date = item.Hours
                        let id = item.ID
                        orderby date ascending
                        select item;

                        List<staffInformation> lst = hours.ToList();
                        return lst;
                    }
                }
            }
        }

        private void searchStaffID_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.connString))
            {
                connection.Open();

                try
                {
                    staffIDdgv.DataSource = SearchID();
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

        private void searchRole_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.connString))
            {
                connection.Open();

                try
                {
                    staffRoledgv.DataSource = SearchRole();
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
