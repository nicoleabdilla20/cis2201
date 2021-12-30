
using System;
using System.Windows.Forms;

namespace CIS2201_Assignment
{
    partial class Staff

    {
        private void InitializeComponent()
        {
            this.Title = new System.Windows.Forms.Label();
            this.StaffTabControl = new System.Windows.Forms.TabControl();
            this.Home = new System.Windows.Forms.TabPage();
            this.staffHomebackbtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.issuebtn = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.AddStaff = new System.Windows.Forms.TabPage();
            this.panel7 = new System.Windows.Forms.Panel();
            this.checkbox = new System.Windows.Forms.TextBox();
            this.idwork = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.contracttype = new System.Windows.Forms.ComboBox();
            this.label27 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.eoc = new System.Windows.Forms.DateTimePicker();
            this.label16 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.soc = new System.Windows.Forms.DateTimePicker();
            this.hrperwk = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.emailtxt = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.insurancetxt = new System.Windows.Forms.ComboBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.IDtxt = new System.Windows.Forms.TextBox();
            this.agetxt = new System.Windows.Forms.TextBox();
            this.surnametxt = new System.Windows.Forms.TextBox();
            this.gendertxt = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.roleopts = new System.Windows.Forms.ComboBox();
            this.addresstxt = new System.Windows.Forms.TextBox();
            this.phonenotxt = new System.Windows.Forms.TextBox();
            this.nametxt = new System.Windows.Forms.TextBox();
            this.bloodopts = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dob = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.addStaffbackbtn = new System.Windows.Forms.Button();
            this.detailsubmit = new System.Windows.Forms.Button();
            this.submit = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CalcBill = new System.Windows.Forms.TabPage();
            this.panel8 = new System.Windows.Forms.Panel();
            this.outputtax = new System.Windows.Forms.TextBox();
            this.label40 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.calcbtn = new System.Windows.Forms.Button();
            this.outputtotal = new System.Windows.Forms.TextBox();
            this.outputhr = new System.Windows.Forms.TextBox();
            this.outputpay = new System.Windows.Forms.TextBox();
            this.inputid = new System.Windows.Forms.TextBox();
            this.label38 = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.payrollBackbtn = new System.Windows.Forms.Button();
            this.Search = new System.Windows.Forms.TabPage();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label25 = new System.Windows.Forms.Label();
            this.detailsdgv = new System.Windows.Forms.DataGridView();
            this.searchRole = new System.Windows.Forms.Button();
            this.staffDetailstxt = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label24 = new System.Windows.Forms.Label();
            this.searchStaffID = new System.Windows.Forms.Button();
            this.staffdgv = new System.Windows.Forms.DataGridView();
            this.staffID = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.searchstaffbackbtn = new System.Windows.Forms.Button();
            this.hospitallogo = new System.Windows.Forms.PictureBox();
            this.StaffTabControl.SuspendLayout();
            this.Home.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.AddStaff.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.CalcBill.SuspendLayout();
            this.panel8.SuspendLayout();
            this.Search.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.detailsdgv)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.staffdgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitallogo)).BeginInit();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.Title.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Title.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.Title.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Title.Font = new System.Drawing.Font("Lucida Fax", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Title.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Title.Location = new System.Drawing.Point(0, 0);
            this.Title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(1212, 46);
            this.Title.TabIndex = 7;
            this.Title.Text = "Manage Staff";
            this.Title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // StaffTabControl
            // 
            this.StaffTabControl.Controls.Add(this.Home);
            this.StaffTabControl.Controls.Add(this.AddStaff);
            this.StaffTabControl.Controls.Add(this.CalcBill);
            this.StaffTabControl.Controls.Add(this.Search);
            this.StaffTabControl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StaffTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StaffTabControl.Location = new System.Drawing.Point(0, 46);
            this.StaffTabControl.Name = "StaffTabControl";
            this.StaffTabControl.Padding = new System.Drawing.Point(15, 5);
            this.StaffTabControl.SelectedIndex = 0;
            this.StaffTabControl.Size = new System.Drawing.Size(1212, 667);
            this.StaffTabControl.TabIndex = 12;
            // 
            // Home
            // 
            this.Home.AccessibleRole = System.Windows.Forms.AccessibleRole.PageTab;
            this.Home.BackColor = System.Drawing.Color.White;
            this.Home.Controls.Add(this.staffHomebackbtn);
            this.Home.Controls.Add(this.pictureBox1);
            this.Home.Controls.Add(this.panel1);
            this.Home.Cursor = System.Windows.Forms.Cursors.Default;
            this.Home.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Home.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Home.Location = new System.Drawing.Point(4, 33);
            this.Home.Name = "Home";
            this.Home.Padding = new System.Windows.Forms.Padding(3);
            this.Home.Size = new System.Drawing.Size(1204, 630);
            this.Home.TabIndex = 0;
            this.Home.Text = "Home";
            // 
            // staffHomebackbtn
            // 
            this.staffHomebackbtn.BackColor = System.Drawing.Color.DodgerBlue;
            this.staffHomebackbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.staffHomebackbtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staffHomebackbtn.Location = new System.Drawing.Point(8, 600);
            this.staffHomebackbtn.Name = "staffHomebackbtn";
            this.staffHomebackbtn.Size = new System.Drawing.Size(75, 26);
            this.staffHomebackbtn.TabIndex = 52;
            this.staffHomebackbtn.Text = "Back";
            this.staffHomebackbtn.UseVisualStyleBackColor = false;
            this.staffHomebackbtn.Click += new System.EventHandler(this.staffHomebackbtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = global::CIS2201_Assignment.Properties.Resources._2008_i504_005__isometric_hospital_infographics;
            this.pictureBox1.Location = new System.Drawing.Point(3, 118);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1197, 509);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.WaitOnLoad = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.richTextBox1);
            this.panel1.Controls.Add(this.issuebtn);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1198, 115);
            this.panel1.TabIndex = 1;
            // 
            // richTextBox1
            // 
            this.richTextBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.richTextBox1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.HideSelection = false;
            this.richTextBox1.Location = new System.Drawing.Point(-1, 52);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ShowSelectionMargin = true;
            this.richTextBox1.Size = new System.Drawing.Size(834, 61);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "Thank you for your service. If you ever encounter any issues with the system. Ple" +
    "ase inform us on the following number +356 77657333 or send us an issue!";
            // 
            // issuebtn
            // 
            this.issuebtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.issuebtn.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.issuebtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.issuebtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 11F, System.Drawing.FontStyle.Bold);
            this.issuebtn.Location = new System.Drawing.Point(905, 64);
            this.issuebtn.Name = "issuebtn";
            this.issuebtn.Size = new System.Drawing.Size(202, 39);
            this.issuebtn.TabIndex = 4;
            this.issuebtn.Text = "Report an Issue";
            this.issuebtn.UseVisualStyleBackColor = false;
            this.issuebtn.Click += new System.EventHandler(this.issuebtn_Click);
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label14.Font = new System.Drawing.Font("Myanmar Text", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(6, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(1179, 49);
            this.label14.TabIndex = 0;
            this.label14.Text = "Welcome to the Hospital Management System";
            this.label14.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // AddStaff
            // 
            this.AddStaff.AccessibleRole = System.Windows.Forms.AccessibleRole.PageTab;
            this.AddStaff.BackColor = System.Drawing.Color.White;
            this.AddStaff.Controls.Add(this.panel7);
            this.AddStaff.Controls.Add(this.panel6);
            this.AddStaff.Controls.Add(this.addStaffbackbtn);
            this.AddStaff.Controls.Add(this.detailsubmit);
            this.AddStaff.Controls.Add(this.submit);
            this.AddStaff.Controls.Add(this.label11);
            this.AddStaff.Controls.Add(this.label9);
            this.AddStaff.Controls.Add(this.label1);
            this.AddStaff.Cursor = System.Windows.Forms.Cursors.Default;
            this.AddStaff.Font = new System.Drawing.Font("Microsoft Tai Le", 9F);
            this.AddStaff.Location = new System.Drawing.Point(4, 33);
            this.AddStaff.Name = "AddStaff";
            this.AddStaff.Padding = new System.Windows.Forms.Padding(3);
            this.AddStaff.Size = new System.Drawing.Size(1204, 630);
            this.AddStaff.TabIndex = 1;
            this.AddStaff.Text = "Add Staff";
            this.AddStaff.Click += new System.EventHandler(this.AddStaff_Click);
            // 
            // panel7
            // 
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.checkbox);
            this.panel7.Controls.Add(this.idwork);
            this.panel7.Controls.Add(this.label28);
            this.panel7.Controls.Add(this.contracttype);
            this.panel7.Controls.Add(this.label27);
            this.panel7.Controls.Add(this.label17);
            this.panel7.Controls.Add(this.eoc);
            this.panel7.Controls.Add(this.label16);
            this.panel7.Controls.Add(this.label10);
            this.panel7.Controls.Add(this.soc);
            this.panel7.Controls.Add(this.hrperwk);
            this.panel7.Controls.Add(this.label13);
            this.panel7.Location = new System.Drawing.Point(642, 70);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(505, 358);
            this.panel7.TabIndex = 68;
            // 
            // checkbox
            // 
            this.checkbox.Location = new System.Drawing.Point(84, 277);
            this.checkbox.Name = "checkbox";
            this.checkbox.Size = new System.Drawing.Size(136, 30);
            this.checkbox.TabIndex = 66;
            // 
            // idwork
            // 
            this.idwork.Location = new System.Drawing.Point(61, 16);
            this.idwork.Name = "idwork";
            this.idwork.Size = new System.Drawing.Size(136, 30);
            this.idwork.TabIndex = 65;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(15, 19);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(32, 23);
            this.label28.TabIndex = 64;
            this.label28.Text = "ID:";
            // 
            // contracttype
            // 
            this.contracttype.FormattingEnabled = true;
            this.contracttype.Items.AddRange(new object[] {
            "Definite",
            "Indefinite"});
            this.contracttype.Location = new System.Drawing.Point(288, 160);
            this.contracttype.Name = "contracttype";
            this.contracttype.Size = new System.Drawing.Size(194, 31);
            this.contracttype.TabIndex = 63;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(15, 163);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(146, 23);
            this.label27.TabIndex = 62;
            this.label27.Text = "Type of Contract:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(15, 280);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(63, 23);
            this.label17.TabIndex = 58;
            this.label17.Text = "Bonus:";
            // 
            // eoc
            // 
            this.eoc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.eoc.Location = new System.Drawing.Point(282, 102);
            this.eoc.Name = "eoc";
            this.eoc.Size = new System.Drawing.Size(200, 30);
            this.eoc.TabIndex = 57;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(15, 108);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(138, 23);
            this.label16.TabIndex = 56;
            this.label16.Text = "End of Contract:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(16, 65);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(145, 23);
            this.label10.TabIndex = 55;
            this.label10.Text = "Start of Contract:";
            // 
            // soc
            // 
            this.soc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.soc.Location = new System.Drawing.Point(282, 59);
            this.soc.Name = "soc";
            this.soc.Size = new System.Drawing.Size(200, 30);
            this.soc.TabIndex = 54;
            // 
            // hrperwk
            // 
            this.hrperwk.FormattingEnabled = true;
            this.hrperwk.Items.AddRange(new object[] {
            "20",
            "40",
            "50",
            "60"});
            this.hrperwk.Location = new System.Drawing.Point(288, 220);
            this.hrperwk.Name = "hrperwk";
            this.hrperwk.Size = new System.Drawing.Size(194, 31);
            this.hrperwk.TabIndex = 52;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(15, 223);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(233, 23);
            this.label13.TabIndex = 20;
            this.label13.Text = "Number of Hours Per Week:";
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.emailtxt);
            this.panel6.Controls.Add(this.label26);
            this.panel6.Controls.Add(this.insurancetxt);
            this.panel6.Controls.Add(this.label21);
            this.panel6.Controls.Add(this.label20);
            this.panel6.Controls.Add(this.IDtxt);
            this.panel6.Controls.Add(this.agetxt);
            this.panel6.Controls.Add(this.surnametxt);
            this.panel6.Controls.Add(this.gendertxt);
            this.panel6.Controls.Add(this.label19);
            this.panel6.Controls.Add(this.roleopts);
            this.panel6.Controls.Add(this.addresstxt);
            this.panel6.Controls.Add(this.phonenotxt);
            this.panel6.Controls.Add(this.nametxt);
            this.panel6.Controls.Add(this.bloodopts);
            this.panel6.Controls.Add(this.label12);
            this.panel6.Controls.Add(this.label8);
            this.panel6.Controls.Add(this.label7);
            this.panel6.Controls.Add(this.label6);
            this.panel6.Controls.Add(this.label5);
            this.panel6.Controls.Add(this.label4);
            this.panel6.Controls.Add(this.dob);
            this.panel6.Controls.Add(this.label3);
            this.panel6.Controls.Add(this.label2);
            this.panel6.Location = new System.Drawing.Point(56, 132);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(446, 361);
            this.panel6.TabIndex = 67;
            // 
            // emailtxt
            // 
            this.emailtxt.Location = new System.Drawing.Point(119, 209);
            this.emailtxt.Name = "emailtxt";
            this.emailtxt.Size = new System.Drawing.Size(121, 30);
            this.emailtxt.TabIndex = 51;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(12, 216);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(56, 23);
            this.label26.TabIndex = 50;
            this.label26.Text = "Email:";
            // 
            // insurancetxt
            // 
            this.insurancetxt.FormattingEnabled = true;
            this.insurancetxt.Items.AddRange(new object[] {
            "X",
            "Y",
            "Z"});
            this.insurancetxt.Location = new System.Drawing.Point(119, 319);
            this.insurancetxt.Name = "insurancetxt";
            this.insurancetxt.Size = new System.Drawing.Size(121, 31);
            this.insurancetxt.TabIndex = 48;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(12, 322);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(89, 23);
            this.label21.TabIndex = 47;
            this.label21.Text = "Insurance:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(299, 93);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(46, 23);
            this.label20.TabIndex = 46;
            this.label20.Text = "Age:";
            // 
            // IDtxt
            // 
            this.IDtxt.Location = new System.Drawing.Point(75, 51);
            this.IDtxt.Name = "IDtxt";
            this.IDtxt.Size = new System.Drawing.Size(136, 30);
            this.IDtxt.TabIndex = 45;
            // 
            // agetxt
            // 
            this.agetxt.Location = new System.Drawing.Point(345, 90);
            this.agetxt.Name = "agetxt";
            this.agetxt.Size = new System.Drawing.Size(86, 30);
            this.agetxt.TabIndex = 44;
            // 
            // surnametxt
            // 
            this.surnametxt.Location = new System.Drawing.Point(307, 11);
            this.surnametxt.Name = "surnametxt";
            this.surnametxt.Size = new System.Drawing.Size(125, 30);
            this.surnametxt.TabIndex = 42;
            // 
            // gendertxt
            // 
            this.gendertxt.Location = new System.Drawing.Point(307, 51);
            this.gendertxt.Name = "gendertxt";
            this.gendertxt.Size = new System.Drawing.Size(125, 30);
            this.gendertxt.TabIndex = 41;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(222, 58);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(71, 23);
            this.label19.TabIndex = 40;
            this.label19.Text = "Gender:";
            // 
            // roleopts
            // 
            this.roleopts.FormattingEnabled = true;
            this.roleopts.Items.AddRange(new object[] {
            "doctor",
            "nurse",
            "therapist",
            "physician",
            "specialist",
            "pharmacist",
            "social worker",
            "interpreter"});
            this.roleopts.Location = new System.Drawing.Point(119, 281);
            this.roleopts.Name = "roleopts";
            this.roleopts.Size = new System.Drawing.Size(121, 31);
            this.roleopts.TabIndex = 32;
            // 
            // addresstxt
            // 
            this.addresstxt.Location = new System.Drawing.Point(98, 129);
            this.addresstxt.Name = "addresstxt";
            this.addresstxt.Size = new System.Drawing.Size(334, 30);
            this.addresstxt.TabIndex = 31;
            // 
            // phonenotxt
            // 
            this.phonenotxt.Location = new System.Drawing.Point(119, 175);
            this.phonenotxt.Name = "phonenotxt";
            this.phonenotxt.Size = new System.Drawing.Size(121, 30);
            this.phonenotxt.TabIndex = 30;
            // 
            // nametxt
            // 
            this.nametxt.Location = new System.Drawing.Point(75, 8);
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
            this.bloodopts.Location = new System.Drawing.Point(119, 245);
            this.bloodopts.Name = "bloodopts";
            this.bloodopts.Size = new System.Drawing.Size(121, 31);
            this.bloodopts.TabIndex = 26;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 280);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(49, 23);
            this.label12.TabIndex = 19;
            this.label12.Text = "Role:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 247);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 23);
            this.label8.TabIndex = 15;
            this.label8.Text = "Blood Type:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 179);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 23);
            this.label7.TabIndex = 14;
            this.label7.Text = "Telphone:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 23);
            this.label6.TabIndex = 13;
            this.label6.Text = "Address: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 23);
            this.label5.TabIndex = 12;
            this.label5.Text = "ID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 23);
            this.label4.TabIndex = 11;
            this.label4.Text = "Date Of Birth:";
            // 
            // dob
            // 
            this.dob.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dob.Location = new System.Drawing.Point(131, 93);
            this.dob.Name = "dob";
            this.dob.Size = new System.Drawing.Size(144, 30);
            this.dob.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(217, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 23);
            this.label3.TabIndex = 9;
            this.label3.Text = "Surname:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 23);
            this.label2.TabIndex = 8;
            this.label2.Text = "Name:";
            // 
            // addStaffbackbtn
            // 
            this.addStaffbackbtn.BackColor = System.Drawing.Color.DodgerBlue;
            this.addStaffbackbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addStaffbackbtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addStaffbackbtn.Location = new System.Drawing.Point(8, 600);
            this.addStaffbackbtn.Name = "addStaffbackbtn";
            this.addStaffbackbtn.Size = new System.Drawing.Size(75, 26);
            this.addStaffbackbtn.TabIndex = 66;
            this.addStaffbackbtn.Text = "Back";
            this.addStaffbackbtn.UseVisualStyleBackColor = false;
            this.addStaffbackbtn.Click += new System.EventHandler(this.addStaffbackbtn_Click);
            // 
            // detailsubmit
            // 
            this.detailsubmit.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.detailsubmit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.detailsubmit.Font = new System.Drawing.Font("Microsoft YaHei UI", 11F, System.Drawing.FontStyle.Bold);
            this.detailsubmit.Location = new System.Drawing.Point(991, 441);
            this.detailsubmit.Name = "detailsubmit";
            this.detailsubmit.Size = new System.Drawing.Size(156, 40);
            this.detailsubmit.TabIndex = 49;
            this.detailsubmit.Text = "Add Details";
            this.detailsubmit.UseVisualStyleBackColor = false;
            this.detailsubmit.Click += new System.EventHandler(this.detailsubmit_Click);
            // 
            // submit
            // 
            this.submit.AutoSize = true;
            this.submit.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.submit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.submit.Font = new System.Drawing.Font("Microsoft YaHei UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submit.Location = new System.Drawing.Point(271, 509);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(231, 40);
            this.submit.TabIndex = 39;
            this.submit.Text = "Add Staff member";
            this.submit.UseVisualStyleBackColor = false;
            this.submit.Click += new System.EventHandler(this.submit_Click);
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
            this.label11.Location = new System.Drawing.Point(56, 85);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(446, 44);
            this.label11.TabIndex = 18;
            this.label11.Text = "General Details:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.label9.Location = new System.Drawing.Point(642, 23);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(505, 44);
            this.label9.TabIndex = 16;
            this.label9.Text = "Work Details";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.label1.Location = new System.Drawing.Point(56, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(446, 44);
            this.label1.TabIndex = 7;
            this.label1.Text = "Add a new Staff member";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // CalcBill
            // 
            this.CalcBill.AccessibleRole = System.Windows.Forms.AccessibleRole.PageTab;
            this.CalcBill.BackColor = System.Drawing.Color.White;
            this.CalcBill.Controls.Add(this.panel8);
            this.CalcBill.Controls.Add(this.payrollBackbtn);
            this.CalcBill.Font = new System.Drawing.Font("Microsoft Tai Le", 9F);
            this.CalcBill.Location = new System.Drawing.Point(4, 33);
            this.CalcBill.Name = "CalcBill";
            this.CalcBill.Padding = new System.Windows.Forms.Padding(3);
            this.CalcBill.Size = new System.Drawing.Size(1204, 630);
            this.CalcBill.TabIndex = 2;
            this.CalcBill.Text = "Calculate Payroll";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.White;
            this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel8.Controls.Add(this.outputtax);
            this.panel8.Controls.Add(this.label40);
            this.panel8.Controls.Add(this.label41);
            this.panel8.Controls.Add(this.label39);
            this.panel8.Controls.Add(this.calcbtn);
            this.panel8.Controls.Add(this.outputtotal);
            this.panel8.Controls.Add(this.outputhr);
            this.panel8.Controls.Add(this.outputpay);
            this.panel8.Controls.Add(this.inputid);
            this.panel8.Controls.Add(this.label38);
            this.panel8.Controls.Add(this.label43);
            this.panel8.Controls.Add(this.label37);
            this.panel8.Controls.Add(this.label42);
            this.panel8.Location = new System.Drawing.Point(407, 60);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(436, 364);
            this.panel8.TabIndex = 67;
            // 
            // outputtax
            // 
            this.outputtax.Location = new System.Drawing.Point(282, 267);
            this.outputtax.Name = "outputtax";
            this.outputtax.Size = new System.Drawing.Size(125, 30);
            this.outputtax.TabIndex = 67;
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(26, 270);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(40, 23);
            this.label40.TabIndex = 66;
            this.label40.Text = "Tax:";
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(26, 72);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(273, 23);
            this.label41.TabIndex = 65;
            this.label41.Text = "Please enter the following details:";
            // 
            // label39
            // 
            this.label39.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label39.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label39.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label39.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label39.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label39.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label39.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label39.Location = new System.Drawing.Point(26, 10);
            this.label39.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(381, 44);
            this.label39.TabIndex = 64;
            this.label39.Text = "Calculate Staff member\'s Payroll";
            this.label39.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // calcbtn
            // 
            this.calcbtn.BackColor = System.Drawing.Color.DodgerBlue;
            this.calcbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.calcbtn.Location = new System.Drawing.Point(30, 138);
            this.calcbtn.Name = "calcbtn";
            this.calcbtn.Size = new System.Drawing.Size(108, 32);
            this.calcbtn.TabIndex = 63;
            this.calcbtn.Text = "Calculate";
            this.calcbtn.UseVisualStyleBackColor = false;
            // 
            // outputtotal
            // 
            this.outputtotal.Location = new System.Drawing.Point(282, 310);
            this.outputtotal.Name = "outputtotal";
            this.outputtotal.Size = new System.Drawing.Size(125, 30);
            this.outputtotal.TabIndex = 60;
            // 
            // outputhr
            // 
            this.outputhr.Location = new System.Drawing.Point(282, 184);
            this.outputhr.Name = "outputhr";
            this.outputhr.Size = new System.Drawing.Size(125, 30);
            this.outputhr.TabIndex = 59;
            // 
            // outputpay
            // 
            this.outputpay.Location = new System.Drawing.Point(282, 223);
            this.outputpay.Name = "outputpay";
            this.outputpay.Size = new System.Drawing.Size(125, 30);
            this.outputpay.TabIndex = 59;
            // 
            // inputid
            // 
            this.inputid.Location = new System.Drawing.Point(282, 109);
            this.inputid.Name = "inputid";
            this.inputid.Size = new System.Drawing.Size(125, 30);
            this.inputid.TabIndex = 58;
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(26, 313);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(210, 23);
            this.label38.TabIndex = 55;
            this.label38.Text = "Staff member\'s total pay:";
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Location = new System.Drawing.Point(26, 187);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(151, 23);
            this.label43.TabIndex = 54;
            this.label43.Text = "Number of hours:";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(26, 226);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(85, 23);
            this.label37.TabIndex = 54;
            this.label37.Text = "Staff pay:";
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Location = new System.Drawing.Point(26, 112);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(74, 23);
            this.label42.TabIndex = 53;
            this.label42.Text = "ID Card:";
            // 
            // payrollBackbtn
            // 
            this.payrollBackbtn.BackColor = System.Drawing.Color.DodgerBlue;
            this.payrollBackbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.payrollBackbtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payrollBackbtn.Location = new System.Drawing.Point(8, 598);
            this.payrollBackbtn.Name = "payrollBackbtn";
            this.payrollBackbtn.Size = new System.Drawing.Size(75, 28);
            this.payrollBackbtn.TabIndex = 52;
            this.payrollBackbtn.Text = "Back";
            this.payrollBackbtn.UseVisualStyleBackColor = false;
            this.payrollBackbtn.Click += new System.EventHandler(this.payrollBackbtn_Click);
            // 
            // Search
            // 
            this.Search.AccessibleRole = System.Windows.Forms.AccessibleRole.PageTab;
            this.Search.BackColor = System.Drawing.Color.White;
            this.Search.Controls.Add(this.panel5);
            this.Search.Controls.Add(this.panel4);
            this.Search.Controls.Add(this.searchstaffbackbtn);
            this.Search.Font = new System.Drawing.Font("Microsoft Tai Le", 9F);
            this.Search.Location = new System.Drawing.Point(4, 33);
            this.Search.Name = "Search";
            this.Search.Padding = new System.Windows.Forms.Padding(3);
            this.Search.Size = new System.Drawing.Size(1204, 630);
            this.Search.TabIndex = 3;
            this.Search.Text = "Search";
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.label25);
            this.panel5.Controls.Add(this.detailsdgv);
            this.panel5.Controls.Add(this.searchRole);
            this.panel5.Controls.Add(this.staffDetailstxt);
            this.panel5.Controls.Add(this.label23);
            this.panel5.Location = new System.Drawing.Point(25, 298);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1160, 288);
            this.panel5.TabIndex = 54;
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
            this.label25.Location = new System.Drawing.Point(21, 16);
            this.label25.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(356, 51);
            this.label25.TabIndex = 20;
            this.label25.Text = "Search staff members details";
            this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // detailsdgv
            // 
            this.detailsdgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.detailsdgv.Location = new System.Drawing.Point(25, 127);
            this.detailsdgv.Name = "detailsdgv";
            this.detailsdgv.RowHeadersWidth = 51;
            this.detailsdgv.Size = new System.Drawing.Size(1105, 131);
            this.detailsdgv.TabIndex = 7;
            // 
            // searchRole
            // 
            this.searchRole.BackColor = System.Drawing.Color.DodgerBlue;
            this.searchRole.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.searchRole.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchRole.Location = new System.Drawing.Point(494, 84);
            this.searchRole.Name = "searchRole";
            this.searchRole.Size = new System.Drawing.Size(75, 23);
            this.searchRole.TabIndex = 6;
            this.searchRole.Text = "Search";
            this.searchRole.UseVisualStyleBackColor = false;
            this.searchRole.Click += new System.EventHandler(this.searchRole_Click_1);
            // 
            // staffDetailstxt
            // 
            this.staffDetailstxt.Location = new System.Drawing.Point(388, 84);
            this.staffDetailstxt.Name = "staffDetailstxt";
            this.staffDetailstxt.Size = new System.Drawing.Size(100, 30);
            this.staffDetailstxt.TabIndex = 5;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(21, 87);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(535, 23);
            this.label23.TabIndex = 4;
            this.label23.Text = "Enter the Id of teh staff member whom details you want to search:";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.label24);
            this.panel4.Controls.Add(this.searchStaffID);
            this.panel4.Controls.Add(this.staffdgv);
            this.panel4.Controls.Add(this.staffID);
            this.panel4.Controls.Add(this.label22);
            this.panel4.Location = new System.Drawing.Point(25, 20);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1153, 259);
            this.panel4.TabIndex = 53;
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
            this.label24.Location = new System.Drawing.Point(21, 17);
            this.label24.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(304, 44);
            this.label24.TabIndex = 19;
            this.label24.Text = "Search a staff member";
            this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label24.Click += new System.EventHandler(this.label24_Click);
            // 
            // searchStaffID
            // 
            this.searchStaffID.BackColor = System.Drawing.Color.DodgerBlue;
            this.searchStaffID.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.searchStaffID.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchStaffID.Location = new System.Drawing.Point(440, 75);
            this.searchStaffID.Name = "searchStaffID";
            this.searchStaffID.Size = new System.Drawing.Size(72, 22);
            this.searchStaffID.TabIndex = 3;
            this.searchStaffID.Text = "Search";
            this.searchStaffID.UseVisualStyleBackColor = false;
            this.searchStaffID.Click += new System.EventHandler(this.searchStaffID_Click);
            // 
            // staffdgv
            // 
            this.staffdgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.staffdgv.Location = new System.Drawing.Point(25, 118);
            this.staffdgv.Name = "staffdgv";
            this.staffdgv.RowHeadersWidth = 51;
            this.staffdgv.Size = new System.Drawing.Size(1105, 119);
            this.staffdgv.TabIndex = 2;
            // 
            // staffID
            // 
            this.staffID.Location = new System.Drawing.Point(334, 75);
            this.staffID.Name = "staffID";
            this.staffID.Size = new System.Drawing.Size(100, 30);
            this.staffID.TabIndex = 1;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(21, 78);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(462, 23);
            this.label22.TabIndex = 0;
            this.label22.Text = "Enter the ID of the staff member that you want to search:";
            // 
            // searchstaffbackbtn
            // 
            this.searchstaffbackbtn.BackColor = System.Drawing.Color.DodgerBlue;
            this.searchstaffbackbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.searchstaffbackbtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchstaffbackbtn.Location = new System.Drawing.Point(8, 599);
            this.searchstaffbackbtn.Name = "searchstaffbackbtn";
            this.searchstaffbackbtn.Size = new System.Drawing.Size(75, 27);
            this.searchstaffbackbtn.TabIndex = 52;
            this.searchstaffbackbtn.Text = "Back";
            this.searchstaffbackbtn.UseVisualStyleBackColor = false;
            this.searchstaffbackbtn.Click += new System.EventHandler(this.searchstaffbackbtn_Click);
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
            // 
            // Staff
            // 
            this.ClientSize = new System.Drawing.Size(1212, 713);
            this.Controls.Add(this.StaffTabControl);
            this.Controls.Add(this.hospitallogo);
            this.Controls.Add(this.Title);
            this.Name = "Staff";
            this.StaffTabControl.ResumeLayout(false);
            this.Home.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.AddStaff.ResumeLayout(false);
            this.AddStaff.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.CalcBill.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.Search.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.detailsdgv)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.staffdgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitallogo)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.PictureBox hospitallogo;
        private System.Windows.Forms.TabControl StaffTabControl;
        private System.Windows.Forms.TabPage Home;
        private System.Windows.Forms.TabPage AddStaff;
        private System.Windows.Forms.Button detailsubmit;
        private System.Windows.Forms.ComboBox insurancetxt;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox IDtxt;
        private System.Windows.Forms.TextBox agetxt;
        private System.Windows.Forms.TextBox surnametxt;
        private System.Windows.Forms.TextBox gendertxt;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.ComboBox roleopts;
        private System.Windows.Forms.TextBox addresstxt;
        private System.Windows.Forms.TextBox phonenotxt;
        private System.Windows.Forms.TextBox nametxt;
        private System.Windows.Forms.ComboBox bloodopts;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
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
        private System.Windows.Forms.TabPage CalcBill;
        private System.Windows.Forms.TabPage Search;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.DataGridView detailsdgv;
        private System.Windows.Forms.Button searchRole;
        private System.Windows.Forms.TextBox staffDetailstxt;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Button searchStaffID;
        private System.Windows.Forms.DataGridView staffdgv;
        private System.Windows.Forms.TextBox staffID;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox emailtxt;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker soc;
        private System.Windows.Forms.ComboBox hrperwk;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.DateTimePicker eoc;
        private System.Windows.Forms.ComboBox contracttype;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox idwork;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button issuebtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button staffHomebackbtn;
        private System.Windows.Forms.Button addStaffbackbtn;
        private System.Windows.Forms.Button payrollBackbtn;
        private System.Windows.Forms.Button searchstaffbackbtn;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Button calcbtn;
        private System.Windows.Forms.TextBox outputtotal;
        private System.Windows.Forms.TextBox outputpay;
        private System.Windows.Forms.TextBox inputid;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.TextBox outputtax;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.TextBox outputhr;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.TextBox checkbox;
        private PaintEventHandler panel8_Paint;
        private EventHandler textBox1_TextChanged;
        private EventHandler label40_Click;
        private EventHandler calcbtn_Click;
        private EventHandler label38_Click;
        private EventHandler label37_Click;
        private EventHandler searchRole_Click;
    }
}