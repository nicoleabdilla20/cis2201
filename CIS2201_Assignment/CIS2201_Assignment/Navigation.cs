using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CIS2201_Assignment
{
    public partial class Navigation : Form
    {
        public Navigation()
        {
            InitializeComponent();
        }

        private void btnPatients_Click(object sender, EventArgs e)
        { 
            this.Hide();
            Form frm = new Patients();
            frm.Show();
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            this.Hide();  
            Form frm = new Staff();
            frm.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login frm = new Login();
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form frm = new Medication();
            frm.Show();
        }
    }
}
