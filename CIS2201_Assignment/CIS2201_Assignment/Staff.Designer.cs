﻿
namespace CIS2201_Assignment
{
    partial class Staff

    {
        private void InitializeComponent()
        {
            this.Title = new System.Windows.Forms.Label();
            this.hospitallogo = new System.Windows.Forms.PictureBox();
            this.StaffTabControl = new System.Windows.Forms.TabControl();
            this.Home = new System.Windows.Forms.TabPage();
            this.AddPat = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.visitsubmit = new System.Windows.Forms.Button();
            this.insurancetxt = new System.Windows.Forms.ComboBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.IDtxt = new System.Windows.Forms.TextBox();
            this.agetxt = new System.Windows.Forms.TextBox();
            this.surnametxt = new System.Windows.Forms.TextBox();
            this.gendertxt = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.submit = new System.Windows.Forms.Button();
            this.historysummary = new System.Windows.Forms.RichTextBox();
            this.historydoctor = new System.Windows.Forms.TextBox();
            this.historydate = new System.Windows.Forms.DateTimePicker();
            this.summarytxt = new System.Windows.Forms.RichTextBox();
            this.doctortxt = new System.Windows.Forms.TextBox();
            this.visitdate = new System.Windows.Forms.DateTimePicker();
            this.allergiesopts = new System.Windows.Forms.ComboBox();
            this.addresstxt = new System.Windows.Forms.TextBox();
            this.telephonetxt = new System.Windows.Forms.TextBox();
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
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.staffRoledgv = new System.Windows.Forms.DataGridView();
            this.searchRole = new System.Windows.Forms.Button();
            this.staffRole = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.searchStaffID = new System.Windows.Forms.Button();
            this.staffIDdgv = new System.Windows.Forms.DataGridView();
            this.staffID = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.filtercbx = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.hospitallogo)).BeginInit();
            this.StaffTabControl.SuspendLayout();
            this.AddPat.SuspendLayout();
            this.Search.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.staffRoledgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffIDdgv)).BeginInit();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.Title.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Title.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Title.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Title.Font = new System.Drawing.Font("Lucida Fax", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Title.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Title.Location = new System.Drawing.Point(-2, -1);
            this.Title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(1184, 46);
            this.Title.TabIndex = 7;
            this.Title.Text = "Manage Staff";
            this.Title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Title.Click += new System.EventHandler(this.Title_Click);
            // 
            // hospitallogo
            // 
            this.hospitallogo.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.hospitallogo.Image = global::CIS2201_Assignment.Properties.Resources.hospital;
            this.hospitallogo.Location = new System.Drawing.Point(4, -2);
            this.hospitallogo.Name = "hospitallogo";
            this.hospitallogo.Size = new System.Drawing.Size(45, 47);
            this.hospitallogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.hospitallogo.TabIndex = 11;
            this.hospitallogo.TabStop = false;
            this.hospitallogo.Click += new System.EventHandler(this.hospitallogo_Click);
            // 
            // StaffTabControl
            // 
            this.StaffTabControl.Controls.Add(this.Home);
            this.StaffTabControl.Controls.Add(this.AddPat);
            this.StaffTabControl.Controls.Add(this.Appointment);
            this.StaffTabControl.Controls.Add(this.CalcBill);
            this.StaffTabControl.Controls.Add(this.Search);
            this.StaffTabControl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StaffTabControl.Location = new System.Drawing.Point(-8, 48);
            this.StaffTabControl.Name = "StaffTabControl";
            this.StaffTabControl.Padding = new System.Drawing.Point(15, 5);
            this.StaffTabControl.SelectedIndex = 0;
            this.StaffTabControl.Size = new System.Drawing.Size(1199, 604);
            this.StaffTabControl.TabIndex = 12;
            // 
            // Home
            // 
            this.Home.AccessibleRole = System.Windows.Forms.AccessibleRole.PageTab;
            this.Home.BackColor = System.Drawing.Color.White;
            this.Home.Cursor = System.Windows.Forms.Cursors.Default;
            this.Home.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Home.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Home.Location = new System.Drawing.Point(4, 26);
            this.Home.Name = "Home";
            this.Home.Padding = new System.Windows.Forms.Padding(3);
            this.Home.Size = new System.Drawing.Size(1191, 574);
            this.Home.TabIndex = 0;
            this.Home.Text = "Home";
            // 
            // AddPat
            // 
            this.AddPat.AccessibleRole = System.Windows.Forms.AccessibleRole.PageTab;
            this.AddPat.BackColor = System.Drawing.Color.White;
            this.AddPat.Controls.Add(this.textBox1);
            this.AddPat.Controls.Add(this.label26);
            this.AddPat.Controls.Add(this.visitsubmit);
            this.AddPat.Controls.Add(this.insurancetxt);
            this.AddPat.Controls.Add(this.label21);
            this.AddPat.Controls.Add(this.label20);
            this.AddPat.Controls.Add(this.IDtxt);
            this.AddPat.Controls.Add(this.agetxt);
            this.AddPat.Controls.Add(this.surnametxt);
            this.AddPat.Controls.Add(this.gendertxt);
            this.AddPat.Controls.Add(this.label19);
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
            this.AddPat.Location = new System.Drawing.Point(4, 26);
            this.AddPat.Name = "AddPat";
            this.AddPat.Padding = new System.Windows.Forms.Padding(3);
            this.AddPat.Size = new System.Drawing.Size(1191, 574);
            this.AddPat.TabIndex = 1;
            this.AddPat.Text = "Add Staff";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(121, 352);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 23);
            this.textBox1.TabIndex = 51;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(35, 360);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(40, 16);
            this.label26.TabIndex = 50;
            this.label26.Text = "Email:";
            // 
            // visitsubmit
            // 
            this.visitsubmit.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.visitsubmit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.visitsubmit.Font = new System.Drawing.Font("Microsoft YaHei UI", 11F, System.Drawing.FontStyle.Bold);
            this.visitsubmit.Location = new System.Drawing.Point(931, 512);
            this.visitsubmit.Name = "visitsubmit";
            this.visitsubmit.Size = new System.Drawing.Size(156, 40);
            this.visitsubmit.TabIndex = 49;
            this.visitsubmit.Text = "Add Visits";
            this.visitsubmit.UseVisualStyleBackColor = false;
            this.visitsubmit.Click += new System.EventHandler(this.visitsubmit_Click);
            // 
            // insurancetxt
            // 
            this.insurancetxt.FormattingEnabled = true;
            this.insurancetxt.Items.AddRange(new object[] {
            "X",
            "Y",
            "Z"});
            this.insurancetxt.Location = new System.Drawing.Point(399, 327);
            this.insurancetxt.Name = "insurancetxt";
            this.insurancetxt.Size = new System.Drawing.Size(56, 24);
            this.insurancetxt.TabIndex = 48;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(330, 327);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(62, 16);
            this.label21.TabIndex = 47;
            this.label21.Text = "Insurance:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(330, 237);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(32, 16);
            this.label20.TabIndex = 46;
            this.label20.Text = "Age:";
            // 
            // IDtxt
            // 
            this.IDtxt.Location = new System.Drawing.Point(98, 195);
            this.IDtxt.Name = "IDtxt";
            this.IDtxt.Size = new System.Drawing.Size(136, 23);
            this.IDtxt.TabIndex = 45;
            // 
            // agetxt
            // 
            this.agetxt.Location = new System.Drawing.Point(368, 234);
            this.agetxt.Name = "agetxt";
            this.agetxt.Size = new System.Drawing.Size(86, 23);
            this.agetxt.TabIndex = 44;
            // 
            // surnametxt
            // 
            this.surnametxt.Location = new System.Drawing.Point(330, 155);
            this.surnametxt.Name = "surnametxt";
            this.surnametxt.Size = new System.Drawing.Size(125, 23);
            this.surnametxt.TabIndex = 42;
            // 
            // gendertxt
            // 
            this.gendertxt.Location = new System.Drawing.Point(330, 195);
            this.gendertxt.Name = "gendertxt";
            this.gendertxt.Size = new System.Drawing.Size(125, 23);
            this.gendertxt.TabIndex = 41;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(266, 200);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(49, 16);
            this.label19.TabIndex = 40;
            this.label19.Text = "Gender:";
            // 
            // submit
            // 
            this.submit.AutoSize = true;
            this.submit.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.submit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.submit.Font = new System.Drawing.Font("Microsoft YaHei UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submit.Location = new System.Drawing.Point(299, 512);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(201, 40);
            this.submit.TabIndex = 39;
            this.submit.Text = "Add Staff member";
            this.submit.UseVisualStyleBackColor = false;
            this.submit.Click += new System.EventHandler(this.submit_Click);
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
            this.historydoctor.Size = new System.Drawing.Size(136, 23);
            this.historydoctor.TabIndex = 37;
            // 
            // historydate
            // 
            this.historydate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.historydate.Location = new System.Drawing.Point(654, 317);
            this.historydate.Name = "historydate";
            this.historydate.Size = new System.Drawing.Size(200, 23);
            this.historydate.TabIndex = 36;
            // 
            // summarytxt
            // 
            this.summarytxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.summarytxt.Location = new System.Drawing.Point(743, 153);
            this.summarytxt.Name = "summarytxt";
            this.summarytxt.Size = new System.Drawing.Size(344, 74);
            this.summarytxt.TabIndex = 35;
            this.summarytxt.Text = "";
            // 
            // doctortxt
            // 
            this.doctortxt.Location = new System.Drawing.Point(662, 117);
            this.doctortxt.Name = "doctortxt";
            this.doctortxt.Size = new System.Drawing.Size(136, 23);
            this.doctortxt.TabIndex = 34;
            // 
            // visitdate
            // 
            this.visitdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.visitdate.Location = new System.Drawing.Point(654, 71);
            this.visitdate.Name = "visitdate";
            this.visitdate.Size = new System.Drawing.Size(200, 23);
            this.visitdate.TabIndex = 33;
            // 
            // allergiesopts
            // 
            this.allergiesopts.FormattingEnabled = true;
            this.allergiesopts.Items.AddRange(new object[] {
            "doctor",
            "nurse",
            "therapist",
            "physician",
            "specialist",
            "pharmacist",
            "social worker",
            "interpreter"});
            this.allergiesopts.Location = new System.Drawing.Point(121, 424);
            this.allergiesopts.Name = "allergiesopts";
            this.allergiesopts.Size = new System.Drawing.Size(121, 24);
            this.allergiesopts.TabIndex = 32;
            this.allergiesopts.Text = "Select";
            // 
            // addresstxt
            // 
            this.addresstxt.Location = new System.Drawing.Point(121, 273);
            this.addresstxt.Name = "addresstxt";
            this.addresstxt.Size = new System.Drawing.Size(334, 23);
            this.addresstxt.TabIndex = 31;
            // 
            // telephonetxt
            // 
            this.telephonetxt.Location = new System.Drawing.Point(121, 318);
            this.telephonetxt.Name = "telephonetxt";
            this.telephonetxt.Size = new System.Drawing.Size(121, 23);
            this.telephonetxt.TabIndex = 30;
            // 
            // nametxt
            // 
            this.nametxt.Location = new System.Drawing.Point(98, 152);
            this.nametxt.Name = "nametxt";
            this.nametxt.Size = new System.Drawing.Size(136, 23);
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
            this.bloodopts.Location = new System.Drawing.Point(121, 388);
            this.bloodopts.Name = "bloodopts";
            this.bloodopts.Size = new System.Drawing.Size(121, 24);
            this.bloodopts.TabIndex = 26;
            this.bloodopts.Text = "Select";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(587, 410);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(101, 16);
            this.label16.TabIndex = 25;
            this.label16.Text = "Summary of Visit:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(587, 362);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(48, 16);
            this.label17.TabIndex = 24;
            this.label17.Text = "Patient:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(587, 316);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(35, 16);
            this.label18.TabIndex = 23;
            this.label18.Text = "Date:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(587, 165);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(101, 16);
            this.label15.TabIndex = 22;
            this.label15.Text = "Summary of Visit:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(587, 117);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(48, 16);
            this.label14.TabIndex = 21;
            this.label14.Text = "Patient:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(587, 71);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(35, 16);
            this.label13.TabIndex = 20;
            this.label13.Text = "Date:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(35, 424);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(34, 16);
            this.label12.TabIndex = 19;
            this.label12.Text = "Role:";
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
            this.label8.Location = new System.Drawing.Point(35, 391);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 16);
            this.label8.TabIndex = 15;
            this.label8.Text = "Blood Type:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(31, 323);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "Telphone:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 277);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "Address: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "ID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Date Of Birth:";
            // 
            // dob
            // 
            this.dob.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dob.Location = new System.Drawing.Point(116, 234);
            this.dob.Name = "dob";
            this.dob.Size = new System.Drawing.Size(200, 23);
            this.dob.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(266, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Surname:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 16);
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
            this.label1.Text = "Add a new Staff member";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Appointment
            // 
            this.Appointment.Location = new System.Drawing.Point(4, 26);
            this.Appointment.Name = "Appointment";
            this.Appointment.Size = new System.Drawing.Size(1191, 574);
            this.Appointment.TabIndex = 4;
            this.Appointment.Text = "Appointment";
            this.Appointment.UseVisualStyleBackColor = true;
            // 
            // CalcBill
            // 
            this.CalcBill.AccessibleRole = System.Windows.Forms.AccessibleRole.PageTab;
            this.CalcBill.Font = new System.Drawing.Font("Microsoft Tai Le", 9F);
            this.CalcBill.Location = new System.Drawing.Point(4, 26);
            this.CalcBill.Name = "CalcBill";
            this.CalcBill.Padding = new System.Windows.Forms.Padding(3);
            this.CalcBill.Size = new System.Drawing.Size(1191, 574);
            this.CalcBill.TabIndex = 2;
            this.CalcBill.Text = "Calculate Payroll";
            this.CalcBill.UseVisualStyleBackColor = true;
            // 
            // Search
            // 
            this.Search.AccessibleRole = System.Windows.Forms.AccessibleRole.PageTab;
            this.Search.Controls.Add(this.filtercbx);
            this.Search.Controls.Add(this.label25);
            this.Search.Controls.Add(this.label24);
            this.Search.Controls.Add(this.staffRoledgv);
            this.Search.Controls.Add(this.searchRole);
            this.Search.Controls.Add(this.staffRole);
            this.Search.Controls.Add(this.label23);
            this.Search.Controls.Add(this.searchStaffID);
            this.Search.Controls.Add(this.staffIDdgv);
            this.Search.Controls.Add(this.staffID);
            this.Search.Controls.Add(this.label22);
            this.Search.Font = new System.Drawing.Font("Microsoft Tai Le", 9F);
            this.Search.Location = new System.Drawing.Point(4, 26);
            this.Search.Name = "Search";
            this.Search.Padding = new System.Windows.Forms.Padding(3);
            this.Search.Size = new System.Drawing.Size(1191, 574);
            this.Search.TabIndex = 3;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = true;
            // 
            // label25
            // 
            this.label25.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label25.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label25.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label25.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label25.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label25.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label25.Location = new System.Drawing.Point(22, 304);
            this.label25.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(356, 51);
            this.label25.TabIndex = 20;
            this.label25.Text = "Search staff members by role";
            this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label24
            // 
            this.label24.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label24.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label24.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label24.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label24.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label24.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label24.Location = new System.Drawing.Point(22, 22);
            this.label24.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(304, 44);
            this.label24.TabIndex = 19;
            this.label24.Text = "Search a staff member";
            this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // staffRoledgv
            // 
            this.staffRoledgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.staffRoledgv.Location = new System.Drawing.Point(25, 417);
            this.staffRoledgv.Name = "staffRoledgv";
            this.staffRoledgv.RowHeadersWidth = 51;
            this.staffRoledgv.Size = new System.Drawing.Size(1122, 131);
            this.staffRoledgv.TabIndex = 7;
            // 
            // searchRole
            // 
            this.searchRole.BackColor = System.Drawing.Color.DodgerBlue;
            this.searchRole.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.searchRole.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchRole.Location = new System.Drawing.Point(499, 366);
            this.searchRole.Name = "searchRole";
            this.searchRole.Size = new System.Drawing.Size(75, 27);
            this.searchRole.TabIndex = 6;
            this.searchRole.Text = "Search";
            this.searchRole.UseVisualStyleBackColor = false;
            this.searchRole.Click += new System.EventHandler(this.searchRole_Click);
            // 
            // staffRole
            // 
            this.staffRole.Location = new System.Drawing.Point(393, 369);
            this.staffRole.Name = "staffRole";
            this.staffRole.Size = new System.Drawing.Size(100, 23);
            this.staffRole.TabIndex = 5;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(22, 372);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(292, 16);
            this.label23.TabIndex = 4;
            this.label23.Text = "Enter the role of the staff member you want to search:";
            // 
            // searchStaffID
            // 
            this.searchStaffID.BackColor = System.Drawing.Color.DodgerBlue;
            this.searchStaffID.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.searchStaffID.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchStaffID.Location = new System.Drawing.Point(499, 84);
            this.searchStaffID.Name = "searchStaffID";
            this.searchStaffID.Size = new System.Drawing.Size(72, 27);
            this.searchStaffID.TabIndex = 3;
            this.searchStaffID.Text = "Search";
            this.searchStaffID.UseVisualStyleBackColor = false;
            this.searchStaffID.Click += new System.EventHandler(this.searchStaffID_Click);
            // 
            // staffIDdgv
            // 
            this.staffIDdgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.staffIDdgv.Location = new System.Drawing.Point(25, 133);
            this.staffIDdgv.Name = "staffIDdgv";
            this.staffIDdgv.RowHeadersWidth = 51;
            this.staffIDdgv.Size = new System.Drawing.Size(1122, 119);
            this.staffIDdgv.TabIndex = 2;
            // 
            // staffID
            // 
            this.staffID.Location = new System.Drawing.Point(393, 86);
            this.staffID.Name = "staffID";
            this.staffID.Size = new System.Drawing.Size(100, 23);
            this.staffID.TabIndex = 1;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(22, 90);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(307, 16);
            this.label22.TabIndex = 0;
            this.label22.Text = "Enter the ID of the staff member that you want to search:";
            // 
            // filtercbx
            // 
            this.filtercbx.FormattingEnabled = true;
            this.filtercbx.Items.AddRange(new object[] {
            "Hours Worked: Least First",
            "Hours Worked: Most First"});
            this.filtercbx.Location = new System.Drawing.Point(1026, 369);
            this.filtercbx.Name = "filtercbx";
            this.filtercbx.Size = new System.Drawing.Size(121, 24);
            this.filtercbx.TabIndex = 21;
            this.filtercbx.Text = "Sort by";
            // 
            // Staff
            // 
            this.ClientSize = new System.Drawing.Size(1182, 644);
            this.Controls.Add(this.StaffTabControl);
            this.Controls.Add(this.hospitallogo);
            this.Controls.Add(this.Title);
            this.Name = "Staff";
            this.Load += new System.EventHandler(this.Staff_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hospitallogo)).EndInit();
            this.StaffTabControl.ResumeLayout(false);
            this.AddPat.ResumeLayout(false);
            this.AddPat.PerformLayout();
            this.Search.ResumeLayout(false);
            this.Search.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.staffRoledgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffIDdgv)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.PictureBox hospitallogo;
        private System.Windows.Forms.TabControl StaffTabControl;
        private System.Windows.Forms.TabPage Home;
        private System.Windows.Forms.TabPage AddPat;
        private System.Windows.Forms.Button visitsubmit;
        private System.Windows.Forms.ComboBox insurancetxt;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox IDtxt;
        private System.Windows.Forms.TextBox agetxt;
        private System.Windows.Forms.TextBox surnametxt;
        private System.Windows.Forms.TextBox gendertxt;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.RichTextBox historysummary;
        private System.Windows.Forms.TextBox historydoctor;
        private System.Windows.Forms.DateTimePicker historydate;
        private System.Windows.Forms.RichTextBox summarytxt;
        private System.Windows.Forms.TextBox doctortxt;
        private System.Windows.Forms.DateTimePicker visitdate;
        private System.Windows.Forms.ComboBox allergiesopts;
        private System.Windows.Forms.TextBox addresstxt;
        private System.Windows.Forms.TextBox telephonetxt;
        private System.Windows.Forms.TextBox nametxt;
        private System.Windows.Forms.ComboBox bloodopts;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage Appointment;
        private System.Windows.Forms.TabPage CalcBill;
        private System.Windows.Forms.TabPage Search;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.DataGridView staffRoledgv;
        private System.Windows.Forms.Button searchRole;
        private System.Windows.Forms.TextBox staffRole;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Button searchStaffID;
        private System.Windows.Forms.DataGridView staffIDdgv;
        private System.Windows.Forms.TextBox staffID;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.ComboBox filtercbx;
    }
}