
namespace CIS2201_Assignment
{
    partial class Patients

    {
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PatientsMenu = new System.Windows.Forms.MenuStrip();
            this.PatientMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.CalcBillMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.HomeMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.SearchMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.PatientsMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.Font = new System.Drawing.Font("Lucida Fax", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1047, 46);
            this.label2.TabIndex = 6;
            this.label2.Text = "Manage Patients";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1178, 47);
            this.panel1.TabIndex = 7;
            // 
            // PatientsMenu
            // 
            this.PatientsMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.PatientsMenu.AutoSize = false;
            this.PatientsMenu.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.PatientsMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PatientsMenu.Dock = System.Windows.Forms.DockStyle.None;
            this.PatientsMenu.Font = new System.Drawing.Font("Sitka Text", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatientsMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.PatientsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.HomeMenu,
            this.PatientMenu,
            this.CalcBillMenu,
            this.SearchMenu,
            this.ExitMenu});
            this.PatientsMenu.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.PatientsMenu.Location = new System.Drawing.Point(0, 92);
            this.PatientsMenu.Name = "PatientsMenu";
            this.PatientsMenu.Size = new System.Drawing.Size(173, 487);
            this.PatientsMenu.TabIndex = 8;
            // 
            // PatientMenu
            // 
            this.PatientMenu.Name = "PatientMenu";
            this.PatientMenu.Size = new System.Drawing.Size(166, 33);
            this.PatientMenu.Text = "Add Patient";
            // 
            // CalcBillMenu
            // 
            this.CalcBillMenu.Name = "CalcBillMenu";
            this.CalcBillMenu.Size = new System.Drawing.Size(166, 33);
            this.CalcBillMenu.Text = "Calculate Bill";
            // 
            // ExitMenu
            // 
            this.ExitMenu.Name = "ExitMenu";
            this.ExitMenu.Size = new System.Drawing.Size(166, 33);
            this.ExitMenu.Text = "Exit";
            // 
            // HomeMenu
            // 
            this.HomeMenu.AutoSize = false;
            this.HomeMenu.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.HomeMenu.Name = "HomeMenu";
            this.HomeMenu.Size = new System.Drawing.Size(166, 33);
            this.HomeMenu.Text = "Home";
            this.HomeMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            // 
            // SearchMenu
            // 
            this.SearchMenu.Name = "SearchMenu";
            this.SearchMenu.Size = new System.Drawing.Size(166, 33);
            this.SearchMenu.Text = "Search";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 46);
            this.label1.TabIndex = 9;
            this.label1.Text = "Menu";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::CIS2201_Assignment.Properties.Resources.hospital;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 47);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // Patients
            // 
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1178, 578);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PatientsMenu);
            this.Name = "Patients";
            this.panel1.ResumeLayout(false);
            this.PatientsMenu.ResumeLayout(false);
            this.PatientsMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip PatientsMenu;
        private System.Windows.Forms.ToolStripMenuItem HomeMenu;
        private System.Windows.Forms.ToolStripMenuItem PatientMenu;
        private System.Windows.Forms.ToolStripMenuItem CalcBillMenu;
        private System.Windows.Forms.ToolStripMenuItem SearchMenu;
        private System.Windows.Forms.ToolStripMenuItem ExitMenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}