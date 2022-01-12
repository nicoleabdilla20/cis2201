
namespace CIS2201_Assignment
{
    partial class Navigation
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnPatients = new System.Windows.Forms.Button();
            this.btnStaff = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMedication_Click = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPatients
            // 
            this.btnPatients.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPatients.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnPatients.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPatients.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPatients.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPatients.Location = new System.Drawing.Point(89, 100);
            this.btnPatients.Margin = new System.Windows.Forms.Padding(4);
            this.btnPatients.Name = "btnPatients";
            this.btnPatients.Size = new System.Drawing.Size(187, 168);
            this.btnPatients.TabIndex = 1;
            this.btnPatients.Text = "Manage Patients";
            this.btnPatients.UseVisualStyleBackColor = false;
            this.btnPatients.Click += new System.EventHandler(this.btnPatients_Click);
            // 
            // btnStaff
            // 
            this.btnStaff.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnStaff.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnStaff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStaff.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16F);
            this.btnStaff.Location = new System.Drawing.Point(479, 100);
            this.btnStaff.Margin = new System.Windows.Forms.Padding(4);
            this.btnStaff.Name = "btnStaff";
            this.btnStaff.Size = new System.Drawing.Size(187, 168);
            this.btnStaff.TabIndex = 2;
            this.btnStaff.Text = "Manage Staff";
            this.btnStaff.UseVisualStyleBackColor = false;
            this.btnStaff.Click += new System.EventHandler(this.btnStaff_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExit.Location = new System.Drawing.Point(621, 396);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 37);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Logout";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label2
            // 
            this.label2.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.Font = new System.Drawing.Font("Lucida Fax", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(739, 34);
            this.label2.TabIndex = 6;
            this.label2.Text = "Hospital Management System";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(739, 39);
            this.panel1.TabIndex = 7;
            // 
            // btnMedication_Click
            // 
            this.btnMedication_Click.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnMedication_Click.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnMedication_Click.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMedication_Click.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMedication_Click.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16F);
            this.btnMedication_Click.Location = new System.Drawing.Point(284, 265);
            this.btnMedication_Click.Margin = new System.Windows.Forms.Padding(4);
            this.btnMedication_Click.Name = "btnMedication_Click";
            this.btnMedication_Click.Size = new System.Drawing.Size(187, 168);
            this.btnMedication_Click.TabIndex = 8;
            this.btnMedication_Click.Text = "Manage Medication";
            this.btnMedication_Click.UseVisualStyleBackColor = false;
            this.btnMedication_Click.Click += new System.EventHandler(this.button1_Click);
            // 
            // Navigation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(739, 474);
            this.Controls.Add(this.btnMedication_Click);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnStaff);
            this.Controls.Add(this.btnPatients);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Navigation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Management Form";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnPatients;
        private System.Windows.Forms.Button btnStaff;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnMedication_Click;
    }
}

