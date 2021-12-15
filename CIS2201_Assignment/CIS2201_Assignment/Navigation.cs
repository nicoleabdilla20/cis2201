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
              Form frm = new Patients();
                frm.Show();
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
              Form frm = new Staff();
              frm.Show();
        }

        //anchor update
        private void btnExit_Click(object sender, EventArgs e)
        {
             this.Close();
        }
    }
}
