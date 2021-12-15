
namespace CIS2201_Assignment
{
    partial class Patients

    {
        private void InitializeComponent()
        {
            this.Title = new System.Windows.Forms.Label();
            this.BlueBack = new System.Windows.Forms.Panel();
            this.hospitallogo = new System.Windows.Forms.PictureBox();
            this.PatientsTabControl = new System.Windows.Forms.TabControl();
            this.Home = new System.Windows.Forms.TabPage();
            this.AddPat = new System.Windows.Forms.TabPage();
            this.CalcBill = new System.Windows.Forms.TabPage();
            this.Search = new System.Windows.Forms.TabPage();
            this.BlueBack.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hospitallogo)).BeginInit();
            this.PatientsTabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.Title.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Title.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Title.Font = new System.Drawing.Font("Lucida Fax", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Title.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Title.Location = new System.Drawing.Point(0, 0);
            this.Title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(1047, 46);
            this.Title.TabIndex = 6;
            this.Title.Text = "Manage Patients";
            this.Title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // BlueBack
            // 
            this.BlueBack.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BlueBack.Controls.Add(this.hospitallogo);
            this.BlueBack.Controls.Add(this.Title);
            this.BlueBack.Dock = System.Windows.Forms.DockStyle.Top;
            this.BlueBack.Location = new System.Drawing.Point(0, 0);
            this.BlueBack.Name = "BlueBack";
            this.BlueBack.Size = new System.Drawing.Size(1178, 47);
            this.BlueBack.TabIndex = 7;
            // 
            // hospitallogo
            // 
            this.hospitallogo.Dock = System.Windows.Forms.DockStyle.Left;
            this.hospitallogo.Image = global::CIS2201_Assignment.Properties.Resources.hospital;
            this.hospitallogo.Location = new System.Drawing.Point(0, 0);
            this.hospitallogo.Name = "hospitallogo";
            this.hospitallogo.Size = new System.Drawing.Size(45, 47);
            this.hospitallogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.hospitallogo.TabIndex = 10;
            this.hospitallogo.TabStop = false;
            // 
            // PatientsTabControl
            // 
            this.PatientsTabControl.Controls.Add(this.Home);
            this.PatientsTabControl.Controls.Add(this.AddPat);
            this.PatientsTabControl.Controls.Add(this.CalcBill);
            this.PatientsTabControl.Controls.Add(this.Search);
            this.PatientsTabControl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PatientsTabControl.Location = new System.Drawing.Point(0, 47);
            this.PatientsTabControl.Name = "PatientsTabControl";
            this.PatientsTabControl.SelectedIndex = 0;
            this.PatientsTabControl.Size = new System.Drawing.Size(1178, 531);
            this.PatientsTabControl.TabIndex = 10;
            // 
            // Home
            // 
            this.Home.BackColor = System.Drawing.Color.White;
            this.Home.Cursor = System.Windows.Forms.Cursors.Default;
            this.Home.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Home.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Home.Location = new System.Drawing.Point(4, 29);
            this.Home.Name = "Home";
            this.Home.Padding = new System.Windows.Forms.Padding(3);
            this.Home.Size = new System.Drawing.Size(1170, 498);
            this.Home.TabIndex = 0;
            this.Home.Text = "Home";
            // 
            // AddPat
            // 
            this.AddPat.Font = new System.Drawing.Font("Microsoft Tai Le", 9F);
            this.AddPat.Location = new System.Drawing.Point(4, 29);
            this.AddPat.Name = "AddPat";
            this.AddPat.Padding = new System.Windows.Forms.Padding(3);
            this.AddPat.Size = new System.Drawing.Size(1170, 498);
            this.AddPat.TabIndex = 1;
            this.AddPat.Text = "Add Patient";
            this.AddPat.UseVisualStyleBackColor = true;
            // 
            // CalcBill
            // 
            this.CalcBill.Font = new System.Drawing.Font("Microsoft Tai Le", 9F);
            this.CalcBill.Location = new System.Drawing.Point(4, 29);
            this.CalcBill.Name = "CalcBill";
            this.CalcBill.Padding = new System.Windows.Forms.Padding(3);
            this.CalcBill.Size = new System.Drawing.Size(1170, 498);
            this.CalcBill.TabIndex = 2;
            this.CalcBill.Text = "Calculate Bill";
            this.CalcBill.UseVisualStyleBackColor = true;
            // 
            // Search
            // 
            this.Search.Font = new System.Drawing.Font("Microsoft Tai Le", 9F);
            this.Search.Location = new System.Drawing.Point(4, 29);
            this.Search.Name = "Search";
            this.Search.Padding = new System.Windows.Forms.Padding(3);
            this.Search.Size = new System.Drawing.Size(1170, 498);
            this.Search.TabIndex = 3;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = true;
            // 
            // Patients
            // 
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1178, 578);
            this.Controls.Add(this.PatientsTabControl);
            this.Controls.Add(this.BlueBack);
            this.Name = "Patients";
            this.BlueBack.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.hospitallogo)).EndInit();
            this.PatientsTabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Panel BlueBack;
        private System.Windows.Forms.PictureBox hospitallogo;
        private System.Windows.Forms.TabControl PatientsTabControl;
        private System.Windows.Forms.TabPage Home;
        private System.Windows.Forms.TabPage AddPat;
        private System.Windows.Forms.TabPage CalcBill;
        private System.Windows.Forms.TabPage Search;
    }
}