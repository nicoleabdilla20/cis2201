
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
            this.allergiesopts = new System.Windows.Forms.ComboBox();
            this.addresstxt = new System.Windows.Forms.TextBox();
            this.telephonetxt = new System.Windows.Forms.TextBox();
            this.idtxt = new System.Windows.Forms.TextBox();
            this.surnametxt = new System.Windows.Forms.TextBox();
            this.nametxt = new System.Windows.Forms.TextBox();
            this.bloodopts = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dob = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Appointment = new System.Windows.Forms.TabPage();
            this.CalcBill = new System.Windows.Forms.TabPage();
            this.Search = new System.Windows.Forms.TabPage();
            this.visitdate = new System.Windows.Forms.DateTimePicker();
            this.doctortxt = new System.Windows.Forms.TextBox();
            this.summarytxt = new System.Windows.Forms.RichTextBox();
            this.historysummary = new System.Windows.Forms.RichTextBox();
            this.historydoctor = new System.Windows.Forms.TextBox();
            this.historydate = new System.Windows.Forms.DateTimePicker();
            this.submit = new System.Windows.Forms.Button();
            this.BlueBack.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hospitallogo)).BeginInit();
            this.PatientsTabControl.SuspendLayout();
            this.AddPat.SuspendLayout();
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
            this.BlueBack.Size = new System.Drawing.Size(1182, 47);
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
            this.PatientsTabControl.Controls.Add(this.Appointment);
            this.PatientsTabControl.Controls.Add(this.CalcBill);
            this.PatientsTabControl.Controls.Add(this.Search);
            this.PatientsTabControl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PatientsTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PatientsTabControl.Location = new System.Drawing.Point(0, 47);
            this.PatientsTabControl.Name = "PatientsTabControl";
            this.PatientsTabControl.Padding = new System.Drawing.Point(15, 5);
            this.PatientsTabControl.SelectedIndex = 0;
            this.PatientsTabControl.Size = new System.Drawing.Size(1182, 597);
            this.PatientsTabControl.TabIndex = 10;
            // 
            // Home
            // 
            this.Home.AccessibleRole = System.Windows.Forms.AccessibleRole.PageTab;
            this.Home.BackColor = System.Drawing.Color.White;
            this.Home.Cursor = System.Windows.Forms.Cursors.Default;
            this.Home.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Home.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Home.Location = new System.Drawing.Point(4, 33);
            this.Home.Name = "Home";
            this.Home.Padding = new System.Windows.Forms.Padding(3);
            this.Home.Size = new System.Drawing.Size(1174, 560);
            this.Home.TabIndex = 0;
            this.Home.Text = "Home";
            // 
            // AddPat
            // 
            this.AddPat.AccessibleRole = System.Windows.Forms.AccessibleRole.PageTab;
            this.AddPat.BackColor = System.Drawing.Color.White;
            this.AddPat.Controls.Add(this.submit);
            this.AddPat.Controls.Add(this.historysummary);
            this.AddPat.Controls.Add(this.historydoctor);
            this.AddPat.Controls.Add(this.historydate);
            this.AddPat.Controls.Add(this.summarytxt);
            this.AddPat.Controls.Add(this.doctortxt);
            this.AddPat.Controls.Add(this.visitdate);
            this.AddPat.Controls.Add(this.allergiesopts);
            this.AddPat.Controls.Add(this.addresstxt);
            this.AddPat.Controls.Add(this.telephonetxt);
            this.AddPat.Controls.Add(this.idtxt);
            this.AddPat.Controls.Add(this.surnametxt);
            this.AddPat.Controls.Add(this.nametxt);
            this.AddPat.Controls.Add(this.bloodopts);
            this.AddPat.Controls.Add(this.label16);
            this.AddPat.Controls.Add(this.label17);
            this.AddPat.Controls.Add(this.label18);
            this.AddPat.Controls.Add(this.label15);
            this.AddPat.Controls.Add(this.label14);
            this.AddPat.Controls.Add(this.label13);
            this.AddPat.Controls.Add(this.label12);
            this.AddPat.Controls.Add(this.label11);
            this.AddPat.Controls.Add(this.label10);
            this.AddPat.Controls.Add(this.label9);
            this.AddPat.Controls.Add(this.label8);
            this.AddPat.Controls.Add(this.label7);
            this.AddPat.Controls.Add(this.label6);
            this.AddPat.Controls.Add(this.label5);
            this.AddPat.Controls.Add(this.label4);
            this.AddPat.Controls.Add(this.dob);
            this.AddPat.Controls.Add(this.label3);
            this.AddPat.Controls.Add(this.label2);
            this.AddPat.Controls.Add(this.label1);
            this.AddPat.Cursor = System.Windows.Forms.Cursors.Default;
            this.AddPat.Font = new System.Drawing.Font("Microsoft Tai Le", 9F);
            this.AddPat.Location = new System.Drawing.Point(4, 33);
            this.AddPat.Name = "AddPat";
            this.AddPat.Padding = new System.Windows.Forms.Padding(3);
            this.AddPat.Size = new System.Drawing.Size(1174, 560);
            this.AddPat.TabIndex = 1;
            this.AddPat.Text = "Add Patient";
            // 
            // allergiesopts
            // 
            this.allergiesopts.FormattingEnabled = true;
            this.allergiesopts.Items.AddRange(new object[] {
            "Food",
            "Drug",
            "Insect",
            "Latex",
            "Mold",
            "Pet Pollen"});
            this.allergiesopts.Location = new System.Drawing.Point(121, 390);
            this.allergiesopts.Name = "allergiesopts";
            this.allergiesopts.Size = new System.Drawing.Size(121, 31);
            this.allergiesopts.TabIndex = 32;
            this.allergiesopts.Text = "Select";
            // 
            // addresstxt
            // 
            this.addresstxt.Location = new System.Drawing.Point(121, 273);
            this.addresstxt.Name = "addresstxt";
            this.addresstxt.Size = new System.Drawing.Size(334, 30);
            this.addresstxt.TabIndex = 31;
            // 
            // telephonetxt
            // 
            this.telephonetxt.Location = new System.Drawing.Point(124, 318);
            this.telephonetxt.Name = "telephonetxt";
            this.telephonetxt.Size = new System.Drawing.Size(121, 30);
            this.telephonetxt.TabIndex = 30;
            // 
            // idtxt
            // 
            this.idtxt.Location = new System.Drawing.Point(98, 193);
            this.idtxt.Name = "idtxt";
            this.idtxt.Size = new System.Drawing.Size(136, 30);
            this.idtxt.TabIndex = 29;
            // 
            // surnametxt
            // 
            this.surnametxt.Location = new System.Drawing.Point(330, 152);
            this.surnametxt.Name = "surnametxt";
            this.surnametxt.Size = new System.Drawing.Size(125, 30);
            this.surnametxt.TabIndex = 28;
            // 
            // nametxt
            // 
            this.nametxt.Location = new System.Drawing.Point(98, 152);
            this.nametxt.Name = "nametxt";
            this.nametxt.Size = new System.Drawing.Size(136, 30);
            this.nametxt.TabIndex = 27;
            // 
            // bloodopts
            // 
            this.bloodopts.FormattingEnabled = true;
            this.bloodopts.Items.AddRange(new object[] {
            "A",
            "B",
            "AB",
            "O"});
            this.bloodopts.Location = new System.Drawing.Point(141, 354);
            this.bloodopts.Name = "bloodopts";
            this.bloodopts.Size = new System.Drawing.Size(121, 31);
            this.bloodopts.TabIndex = 26;
            this.bloodopts.Text = "Select";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(587, 410);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(150, 23);
            this.label16.TabIndex = 25;
            this.label16.Text = "Summary of Visit:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(587, 362);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(69, 23);
            this.label17.TabIndex = 24;
            this.label17.Text = "Doctor:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(587, 316);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(51, 23);
            this.label18.TabIndex = 23;
            this.label18.Text = "Date:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(587, 165);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(150, 23);
            this.label15.TabIndex = 22;
            this.label15.Text = "Summary of Visit:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(587, 117);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(69, 23);
            this.label14.TabIndex = 21;
            this.label14.Text = "Doctor:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(587, 71);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(51, 23);
            this.label13.TabIndex = 20;
            this.label13.Text = "Date:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(31, 393);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(81, 23);
            this.label12.TabIndex = 19;
            this.label12.Text = "Allergies:";
            // 
            // label11
            // 
            this.label11.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label11.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label11.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label11.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label11.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label11.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label11.Location = new System.Drawing.Point(10, 71);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(445, 44);
            this.label11.TabIndex = 18;
            this.label11.Text = "General Details:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label10.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label10.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label10.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label10.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label10.Location = new System.Drawing.Point(586, 239);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(501, 44);
            this.label10.TabIndex = 17;
            this.label10.Text = "Other Visits:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label9.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label9.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label9.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label9.Location = new System.Drawing.Point(581, 12);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(506, 44);
            this.label9.TabIndex = 16;
            this.label9.Text = "Recent Visit:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(31, 357);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 23);
            this.label8.TabIndex = 15;
            this.label8.Text = "Blood Type:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(31, 318);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 23);
            this.label7.TabIndex = 14;
            this.label7.Text = "Telphone:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 277);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 23);
            this.label6.TabIndex = 13;
            this.label6.Text = "Address: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 23);
            this.label5.TabIndex = 12;
            this.label5.Text = "ID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 23);
            this.label4.TabIndex = 11;
            this.label4.Text = "Date Of Birth:";
            // 
            // dob
            // 
            this.dob.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dob.Location = new System.Drawing.Point(154, 232);
            this.dob.Name = "dob";
            this.dob.Size = new System.Drawing.Size(200, 30);
            this.dob.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(240, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 23);
            this.label3.TabIndex = 9;
            this.label3.Text = "Surname:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 23);
            this.label2.TabIndex = 8;
            this.label2.Text = "Name:";
            // 
            // label1
            // 
            this.label1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label1.BackColor = System.Drawing.SystemColors.Menu;
            this.label1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Lucida Fax", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(9, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(446, 44);
            this.label1.TabIndex = 7;
            this.label1.Text = "Add a Patient";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Appointment
            // 
            this.Appointment.Location = new System.Drawing.Point(4, 33);
            this.Appointment.Name = "Appointment";
            this.Appointment.Size = new System.Drawing.Size(1174, 560);
            this.Appointment.TabIndex = 4;
            this.Appointment.Text = "Appointment";
            this.Appointment.UseVisualStyleBackColor = true;
            // 
            // CalcBill
            // 
            this.CalcBill.AccessibleRole = System.Windows.Forms.AccessibleRole.PageTab;
            this.CalcBill.Font = new System.Drawing.Font("Microsoft Tai Le", 9F);
            this.CalcBill.Location = new System.Drawing.Point(4, 33);
            this.CalcBill.Name = "CalcBill";
            this.CalcBill.Padding = new System.Windows.Forms.Padding(3);
            this.CalcBill.Size = new System.Drawing.Size(1174, 560);
            this.CalcBill.TabIndex = 2;
            this.CalcBill.Text = "Calculate Bill";
            this.CalcBill.UseVisualStyleBackColor = true;
            // 
            // Search
            // 
            this.Search.AccessibleRole = System.Windows.Forms.AccessibleRole.PageTab;
            this.Search.Font = new System.Drawing.Font("Microsoft Tai Le", 9F);
            this.Search.Location = new System.Drawing.Point(4, 33);
            this.Search.Name = "Search";
            this.Search.Padding = new System.Windows.Forms.Padding(3);
            this.Search.Size = new System.Drawing.Size(1174, 560);
            this.Search.TabIndex = 3;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = true;
            // 
            // visitdate
            // 
            this.visitdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.visitdate.Location = new System.Drawing.Point(654, 71);
            this.visitdate.Name = "visitdate";
            this.visitdate.Size = new System.Drawing.Size(200, 30);
            this.visitdate.TabIndex = 33;
            // 
            // doctortxt
            // 
            this.doctortxt.Location = new System.Drawing.Point(662, 117);
            this.doctortxt.Name = "doctortxt";
            this.doctortxt.Size = new System.Drawing.Size(136, 30);
            this.doctortxt.TabIndex = 34;
            // 
            // summarytxt
            // 
            this.summarytxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.summarytxt.Location = new System.Drawing.Point(743, 162);
            this.summarytxt.Name = "summarytxt";
            this.summarytxt.Size = new System.Drawing.Size(344, 74);
            this.summarytxt.TabIndex = 35;
            this.summarytxt.Text = "";
            // 
            // historysummary
            // 
            this.historysummary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.historysummary.Location = new System.Drawing.Point(743, 408);
            this.historysummary.Name = "historysummary";
            this.historysummary.Size = new System.Drawing.Size(344, 74);
            this.historysummary.TabIndex = 38;
            this.historysummary.Text = "";
            // 
            // historydoctor
            // 
            this.historydoctor.Location = new System.Drawing.Point(662, 363);
            this.historydoctor.Name = "historydoctor";
            this.historydoctor.Size = new System.Drawing.Size(136, 30);
            this.historydoctor.TabIndex = 37;
            // 
            // historydate
            // 
            this.historydate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.historydate.Location = new System.Drawing.Point(654, 317);
            this.historydate.Name = "historydate";
            this.historydate.Size = new System.Drawing.Size(200, 30);
            this.historydate.TabIndex = 36;
            // 
            // submit
            // 
            this.submit.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.submit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.submit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.submit.Font = new System.Drawing.Font("Microsoft YaHei UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submit.Location = new System.Drawing.Point(3, 520);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(1168, 37);
            this.submit.TabIndex = 39;
            this.submit.Text = "SUBMIT";
            this.submit.UseVisualStyleBackColor = false;
            // 
            // Patients
            // 
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1182, 644);
            this.Controls.Add(this.PatientsTabControl);
            this.Controls.Add(this.BlueBack);
            this.Name = "Patients";
            this.BlueBack.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.hospitallogo)).EndInit();
            this.PatientsTabControl.ResumeLayout(false);
            this.AddPat.ResumeLayout(false);
            this.AddPat.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Panel BlueBack;
        private System.Windows.Forms.PictureBox hospitallogo;
        private System.Windows.Forms.TabControl PatientsTabControl;
        private System.Windows.Forms.TabPage Home;
        private System.Windows.Forms.TabPage CalcBill;
        private System.Windows.Forms.TabPage Search;
        private System.Windows.Forms.TabPage AddPat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dob;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox bloodopts;
        private System.Windows.Forms.TabPage Appointment;
        private System.Windows.Forms.TextBox surnametxt;
        private System.Windows.Forms.TextBox nametxt;
        private System.Windows.Forms.ComboBox allergiesopts;
        private System.Windows.Forms.TextBox addresstxt;
        private System.Windows.Forms.TextBox telephonetxt;
        private System.Windows.Forms.TextBox idtxt;
        private System.Windows.Forms.RichTextBox historysummary;
        private System.Windows.Forms.TextBox historydoctor;
        private System.Windows.Forms.DateTimePicker historydate;
        private System.Windows.Forms.RichTextBox summarytxt;
        private System.Windows.Forms.TextBox doctortxt;
        private System.Windows.Forms.DateTimePicker visitdate;
        private System.Windows.Forms.Button submit;
    }
}