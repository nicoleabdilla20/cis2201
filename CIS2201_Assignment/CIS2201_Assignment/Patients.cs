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
    public partial class Patients : Form
    {
        public Patients()
        {
            InitializeComponent();
        }

         private bool IsPatientsNameValid()
        {
            if (nametxt.Text == "")
            {
                MessageBox.Show("Please enter a name.");
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
        }
    }
 
