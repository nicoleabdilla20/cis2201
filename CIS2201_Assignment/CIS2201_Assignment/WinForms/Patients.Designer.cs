﻿
using System;
using System.Windows.Forms;

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
            this.patHomebackbtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.issuebtn = new System.Windows.Forms.Button();
            this.label36 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.AddPat = new System.Windows.Forms.TabPage();
            this.panel9 = new System.Windows.Forms.Panel();
            this.historysummary = new System.Windows.Forms.RichTextBox();
            this.historydoctor = new System.Windows.Forms.TextBox();
            this.historydate = new System.Windows.Forms.DateTimePicker();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.summarytxt = new System.Windows.Forms.RichTextBox();
            this.doctortxt = new System.Windows.Forms.TextBox();
            this.visitdate = new System.Windows.Forms.DateTimePicker();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.insurancetxt = new System.Windows.Forms.ComboBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.IDtxt = new System.Windows.Forms.TextBox();
            this.agetxt = new System.Windows.Forms.TextBox();
            this.surnametxt = new System.Windows.Forms.TextBox();
            this.gendertxt = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.allergiesopts = new System.Windows.Forms.ComboBox();
            this.addresstxt = new System.Windows.Forms.TextBox();
            this.telephonetxt = new System.Windows.Forms.TextBox();
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
            this.addPatbackbtn = new System.Windows.Forms.Button();
            this.visitsubmit = new System.Windows.Forms.Button();
            this.submit = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Appointment = new System.Windows.Forms.TabPage();
            this.Appbackbtn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.AppFiltercbx = new System.Windows.Forms.ComboBox();
            this.Appsearchdgv = new System.Windows.Forms.DataGridView();
            this.Appsearchbtn = new System.Windows.Forms.Button();
            this.AppsearchID = new System.Windows.Forms.TextBox();
            this.label34 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.crtAppbtn = new System.Windows.Forms.Button();
            this.label35 = new System.Windows.Forms.Label();
            this.Appsdate = new System.Windows.Forms.DateTimePicker();
            this.Appcdate = new System.Windows.Forms.DateTimePicker();
            this.label33 = new System.Windows.Forms.Label();
            this.AppDoctor = new System.Windows.Forms.TextBox();
            this.label31 = new System.Windows.Forms.Label();
            this.ApppatSurname = new System.Windows.Forms.TextBox();
            this.ApppatName = new System.Windows.Forms.TextBox();
            this.ApppatID = new System.Windows.Forms.TextBox();
            this.label30 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.CalcBill = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label41 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxPay = new System.Windows.Forms.TextBox();
            this.textBoxExpenseTotal = new System.Windows.Forms.TextBox();
            this.textBoxNights = new System.Windows.Forms.TextBox();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.label40 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.billBackbtn = new System.Windows.Forms.Button();
            this.Search = new System.Windows.Forms.TabPage();
            this.panel6 = new System.Windows.Forms.Panel();
            this.Filtercbx = new System.Windows.Forms.ComboBox();
            this.visitsearch = new System.Windows.Forms.Button();
            this.label25 = new System.Windows.Forms.Label();
            this.visitdgv = new System.Windows.Forms.DataGridView();
            this.pvisitID = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label24 = new System.Windows.Forms.Label();
            this.searchPatient = new System.Windows.Forms.Button();
            this.patientdgv = new System.Windows.Forms.DataGridView();
            this.psearchID = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.searchPatbackbtn = new System.Windows.Forms.Button();
            this.searchVisit = new System.Windows.Forms.Button();
            this.BlueBack.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hospitallogo)).BeginInit();
            this.PatientsTabControl.SuspendLayout();
            this.Home.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.AddPat.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.Appointment.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Appsearchdgv)).BeginInit();
            this.panel2.SuspendLayout();
            this.CalcBill.SuspendLayout();
            this.panel4.SuspendLayout();
            this.Search.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.visitdgv)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patientdgv)).BeginInit();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.Title.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Title.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Title.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Title.Font = new System.Drawing.Font("Lucida Fax", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Title.Location = new System.Drawing.Point(0, 0);
            this.Title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(1212, 46);
            this.Title.TabIndex = 6;
            this.Title.Text = "Manage Patients";
            this.Title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Title.Click += new System.EventHandler(this.Title_Click);
            // 
            // BlueBack
            // 
            this.BlueBack.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BlueBack.Controls.Add(this.hospitallogo);
            this.BlueBack.Controls.Add(this.Title);
            this.BlueBack.Dock = System.Windows.Forms.DockStyle.Top;
            this.BlueBack.Location = new System.Drawing.Point(0, 0);
            this.BlueBack.Name = "BlueBack";
            this.BlueBack.Size = new System.Drawing.Size(1212, 42);
            this.BlueBack.TabIndex = 7;
            // 
            // hospitallogo
            // 
            this.hospitallogo.Dock = System.Windows.Forms.DockStyle.Left;
            this.hospitallogo.Image = global::CIS2201_Assignment.Properties.Resources.hospital;
            this.hospitallogo.Location = new System.Drawing.Point(0, 0);
            this.hospitallogo.Name = "hospitallogo";
            this.hospitallogo.Size = new System.Drawing.Size(45, 42);
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
            this.PatientsTabControl.Location = new System.Drawing.Point(0, 42);
            this.PatientsTabControl.Name = "PatientsTabControl";
            this.PatientsTabControl.Padding = new System.Drawing.Point(15, 5);
            this.PatientsTabControl.SelectedIndex = 0;
            this.PatientsTabControl.Size = new System.Drawing.Size(1212, 671);
            this.PatientsTabControl.TabIndex = 10;
            // 
            // Home
            // 
            this.Home.AccessibleRole = System.Windows.Forms.AccessibleRole.PageTab;
            this.Home.BackColor = System.Drawing.Color.White;
            this.Home.Controls.Add(this.patHomebackbtn);
            this.Home.Controls.Add(this.pictureBox1);
            this.Home.Controls.Add(this.panel1);
            this.Home.Controls.Add(this.richTextBox1);
            this.Home.Cursor = System.Windows.Forms.Cursors.Default;
            this.Home.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Home.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Home.Location = new System.Drawing.Point(4, 26);
            this.Home.Name = "Home";
            this.Home.Padding = new System.Windows.Forms.Padding(3);
            this.Home.Size = new System.Drawing.Size(1204, 641);
            this.Home.TabIndex = 0;
            this.Home.Text = "Home";
            // 
            // patHomebackbtn
            // 
            this.patHomebackbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.patHomebackbtn.BackColor = System.Drawing.Color.DodgerBlue;
            this.patHomebackbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.patHomebackbtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patHomebackbtn.Location = new System.Drawing.Point(6, 606);
            this.patHomebackbtn.Name = "patHomebackbtn";
            this.patHomebackbtn.Size = new System.Drawing.Size(75, 27);
            this.patHomebackbtn.TabIndex = 52;
            this.patHomebackbtn.Text = "Back";
            this.patHomebackbtn.UseVisualStyleBackColor = false;
            this.patHomebackbtn.Click += new System.EventHandler(this.patHomebackbtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = global::CIS2201_Assignment.Properties.Resources._2008_i504_005__isometric_hospital_infographics;
            this.pictureBox1.Location = new System.Drawing.Point(0, 113);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1208, 528);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.WaitOnLoad = true;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.richTextBox2);
            this.panel1.Controls.Add(this.issuebtn);
            this.panel1.Controls.Add(this.label36);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1198, 115);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // richTextBox2
            // 
            this.richTextBox2.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.richTextBox2.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.richTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox2.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox2.HideSelection = false;
            this.richTextBox2.Location = new System.Drawing.Point(-2, 48);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.ShowSelectionMargin = true;
            this.richTextBox2.Size = new System.Drawing.Size(810, 62);
            this.richTextBox2.TabIndex = 1;
            this.richTextBox2.Text = "Thank you for your service. If you ever encounter any issues with the system. Ple" +
    "ase inform us on the following number +356 7765733 or send us an issue!";
            // 
            // issuebtn
            // 
            this.issuebtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.issuebtn.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.issuebtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.issuebtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 11F, System.Drawing.FontStyle.Bold);
            this.issuebtn.Location = new System.Drawing.Point(908, 64);
            this.issuebtn.Name = "issuebtn";
            this.issuebtn.Size = new System.Drawing.Size(202, 39);
            this.issuebtn.TabIndex = 4;
            this.issuebtn.Text = "Report an Issue";
            this.issuebtn.UseVisualStyleBackColor = false;
            this.issuebtn.Click += new System.EventHandler(this.issuebtn_Click);
            // 
            // label36
            // 
            this.label36.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label36.Font = new System.Drawing.Font("Myanmar Text", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label36.Location = new System.Drawing.Point(6, 0);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(1179, 61);
            this.label36.TabIndex = 0;
            this.label36.Text = "Welcome to the Hospital Management System";
            this.label36.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label36.Click += new System.EventHandler(this.label36_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.richTextBox1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.HideSelection = false;
            this.richTextBox1.Location = new System.Drawing.Point(13, 68);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ShowSelectionMargin = true;
            this.richTextBox1.Size = new System.Drawing.Size(834, 127);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "Thank you for your service. If you ever encounter any issues with the system. Ple" +
    "ase inform us on the following number +356 77657333 or send us an issue!";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // AddPat
            // 
            this.AddPat.AccessibleRole = System.Windows.Forms.AccessibleRole.PageTab;
            this.AddPat.BackColor = System.Drawing.Color.White;
            this.AddPat.Controls.Add(this.panel9);
            this.AddPat.Controls.Add(this.panel8);
            this.AddPat.Controls.Add(this.panel7);
            this.AddPat.Controls.Add(this.addPatbackbtn);
            this.AddPat.Controls.Add(this.visitsubmit);
            this.AddPat.Controls.Add(this.submit);
            this.AddPat.Controls.Add(this.label11);
            this.AddPat.Controls.Add(this.label10);
            this.AddPat.Controls.Add(this.label9);
            this.AddPat.Controls.Add(this.label1);
            this.AddPat.Cursor = System.Windows.Forms.Cursors.Default;
            this.AddPat.Font = new System.Drawing.Font("Microsoft Tai Le", 9F);
            this.AddPat.Location = new System.Drawing.Point(4, 26);
            this.AddPat.Name = "AddPat";
            this.AddPat.Padding = new System.Windows.Forms.Padding(3);
            this.AddPat.Size = new System.Drawing.Size(1204, 641);
            this.AddPat.TabIndex = 1;
            this.AddPat.Text = "Add Patient";
            this.AddPat.Click += new System.EventHandler(this.AddPat_Click);
            // 
            // panel9
            // 
            this.panel9.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel9.Controls.Add(this.historysummary);
            this.panel9.Controls.Add(this.historydoctor);
            this.panel9.Controls.Add(this.historydate);
            this.panel9.Controls.Add(this.label16);
            this.panel9.Controls.Add(this.label17);
            this.panel9.Controls.Add(this.label18);
            this.panel9.Location = new System.Drawing.Point(632, 314);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(524, 182);
            this.panel9.TabIndex = 53;
            // 
            // historysummary
            // 
            this.historysummary.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.historysummary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.historysummary.Location = new System.Drawing.Point(164, 96);
            this.historysummary.Name = "historysummary";
            this.historysummary.Size = new System.Drawing.Size(344, 74);
            this.historysummary.TabIndex = 38;
            this.historysummary.Text = "";
            // 
            // historydoctor
            // 
            this.historydoctor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.historydoctor.Location = new System.Drawing.Point(75, 46);
            this.historydoctor.Name = "historydoctor";
            this.historydoctor.Size = new System.Drawing.Size(200, 23);
            this.historydoctor.TabIndex = 37;
            // 
            // historydate
            // 
            this.historydate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.historydate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.historydate.Location = new System.Drawing.Point(75, 11);
            this.historydate.Name = "historydate";
            this.historydate.Size = new System.Drawing.Size(200, 23);
            this.historydate.TabIndex = 36;
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(9, 98);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(101, 16);
            this.label16.TabIndex = 25;
            this.label16.Text = "Summary of Visit:";
            // 
            // label17
            // 
            this.label17.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(9, 49);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(47, 16);
            this.label17.TabIndex = 24;
            this.label17.Text = "Doctor:";
            // 
            // label18
            // 
            this.label18.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(9, 17);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(35, 16);
            this.label18.TabIndex = 23;
            this.label18.Text = "Date:";
            // 
            // panel8
            // 
            this.panel8.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel8.Controls.Add(this.summarytxt);
            this.panel8.Controls.Add(this.doctortxt);
            this.panel8.Controls.Add(this.visitdate);
            this.panel8.Controls.Add(this.label15);
            this.panel8.Controls.Add(this.label14);
            this.panel8.Controls.Add(this.label13);
            this.panel8.Location = new System.Drawing.Point(632, 75);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(524, 177);
            this.panel8.TabIndex = 52;
            // 
            // summarytxt
            // 
            this.summarytxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.summarytxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.summarytxt.Location = new System.Drawing.Point(164, 89);
            this.summarytxt.Name = "summarytxt";
            this.summarytxt.Size = new System.Drawing.Size(344, 74);
            this.summarytxt.TabIndex = 35;
            this.summarytxt.Text = "";
            // 
            // doctortxt
            // 
            this.doctortxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.doctortxt.Location = new System.Drawing.Point(75, 45);
            this.doctortxt.Name = "doctortxt";
            this.doctortxt.Size = new System.Drawing.Size(200, 23);
            this.doctortxt.TabIndex = 34;
            // 
            // visitdate
            // 
            this.visitdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.visitdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.visitdate.Location = new System.Drawing.Point(75, 10);
            this.visitdate.Name = "visitdate";
            this.visitdate.Size = new System.Drawing.Size(200, 23);
            this.visitdate.TabIndex = 33;
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(9, 91);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(101, 16);
            this.label15.TabIndex = 22;
            this.label15.Text = "Summary of Visit:";
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(9, 48);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(47, 16);
            this.label14.TabIndex = 21;
            this.label14.Text = "Doctor:";
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(9, 16);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(35, 16);
            this.label13.TabIndex = 20;
            this.label13.Text = "Date:";
            // 
            // panel7
            // 
            this.panel7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.insurancetxt);
            this.panel7.Controls.Add(this.label21);
            this.panel7.Controls.Add(this.label20);
            this.panel7.Controls.Add(this.IDtxt);
            this.panel7.Controls.Add(this.agetxt);
            this.panel7.Controls.Add(this.surnametxt);
            this.panel7.Controls.Add(this.gendertxt);
            this.panel7.Controls.Add(this.label19);
            this.panel7.Controls.Add(this.allergiesopts);
            this.panel7.Controls.Add(this.addresstxt);
            this.panel7.Controls.Add(this.telephonetxt);
            this.panel7.Controls.Add(this.nametxt);
            this.panel7.Controls.Add(this.bloodopts);
            this.panel7.Controls.Add(this.label12);
            this.panel7.Controls.Add(this.label8);
            this.panel7.Controls.Add(this.label7);
            this.panel7.Controls.Add(this.label6);
            this.panel7.Controls.Add(this.label5);
            this.panel7.Controls.Add(this.label4);
            this.panel7.Controls.Add(this.dob);
            this.panel7.Controls.Add(this.label3);
            this.panel7.Controls.Add(this.label2);
            this.panel7.Location = new System.Drawing.Point(51, 139);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(459, 364);
            this.panel7.TabIndex = 51;
            // 
            // insurancetxt
            // 
            this.insurancetxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.insurancetxt.FormattingEnabled = true;
            this.insurancetxt.Items.AddRange(new object[] {
            "X - pay 100% of the bill out of pocket",
            "Y - pay counterpart funding (50%) if the bill is more than 700",
            "Z - pay no counterpart for service uptake"});
            this.insurancetxt.Location = new System.Drawing.Point(103, 318);
            this.insurancetxt.Name = "insurancetxt";
            this.insurancetxt.Size = new System.Drawing.Size(121, 24);
            this.insurancetxt.TabIndex = 48;
            // 
            // label21
            // 
            this.label21.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(18, 321);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(62, 16);
            this.label21.TabIndex = 47;
            this.label21.Text = "Insurance:";
            // 
            // label20
            // 
            this.label20.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(305, 97);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(32, 16);
            this.label20.TabIndex = 46;
            this.label20.Text = "Age:";
            this.label20.Click += new System.EventHandler(this.label20_Click);
            // 
            // IDtxt
            // 
            this.IDtxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.IDtxt.Location = new System.Drawing.Point(80, 55);
            this.IDtxt.Name = "IDtxt";
            this.IDtxt.Size = new System.Drawing.Size(136, 23);
            this.IDtxt.TabIndex = 45;
            this.IDtxt.TextChanged += new System.EventHandler(this.IDtxt_TextChanged);
            // 
            // agetxt
            // 
            this.agetxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.agetxt.Location = new System.Drawing.Point(350, 94);
            this.agetxt.Name = "agetxt";
            this.agetxt.Size = new System.Drawing.Size(86, 23);
            this.agetxt.TabIndex = 44;
            this.agetxt.TextChanged += new System.EventHandler(this.agetxt_TextChanged);
            // 
            // surnametxt
            // 
            this.surnametxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.surnametxt.Location = new System.Drawing.Point(312, 15);
            this.surnametxt.Name = "surnametxt";
            this.surnametxt.Size = new System.Drawing.Size(125, 23);
            this.surnametxt.TabIndex = 42;
            this.surnametxt.TextChanged += new System.EventHandler(this.surnametxt_TextChanged);
            // 
            // gendertxt
            // 
            this.gendertxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.gendertxt.Location = new System.Drawing.Point(312, 55);
            this.gendertxt.Name = "gendertxt";
            this.gendertxt.Size = new System.Drawing.Size(125, 23);
            this.gendertxt.TabIndex = 41;
            this.gendertxt.TextChanged += new System.EventHandler(this.gendertxt_TextChanged);
            // 
            // label19
            // 
            this.label19.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(238, 58);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(49, 16);
            this.label19.TabIndex = 40;
            this.label19.Text = "Gender:";
            this.label19.Click += new System.EventHandler(this.label19_Click);
            // 
            // allergiesopts
            // 
            this.allergiesopts.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.allergiesopts.FormattingEnabled = true;
            this.allergiesopts.Items.AddRange(new object[] {
            "Food",
            "Drug",
            "Insect",
            "Latex",
            "Mold",
            "Pet Pollen"});
            this.allergiesopts.Location = new System.Drawing.Point(103, 273);
            this.allergiesopts.Name = "allergiesopts";
            this.allergiesopts.Size = new System.Drawing.Size(121, 24);
            this.allergiesopts.TabIndex = 32;
            // 
            // addresstxt
            // 
            this.addresstxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.addresstxt.Location = new System.Drawing.Point(102, 137);
            this.addresstxt.Name = "addresstxt";
            this.addresstxt.Size = new System.Drawing.Size(334, 23);
            this.addresstxt.TabIndex = 31;
            this.addresstxt.TextChanged += new System.EventHandler(this.addresstxt_TextChanged);
            // 
            // telephonetxt
            // 
            this.telephonetxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.telephonetxt.Location = new System.Drawing.Point(103, 178);
            this.telephonetxt.Name = "telephonetxt";
            this.telephonetxt.Size = new System.Drawing.Size(121, 23);
            this.telephonetxt.TabIndex = 30;
            this.telephonetxt.TextChanged += new System.EventHandler(this.telephonetxt_TextChanged);
            // 
            // nametxt
            // 
            this.nametxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.nametxt.Location = new System.Drawing.Point(80, 12);
            this.nametxt.Name = "nametxt";
            this.nametxt.Size = new System.Drawing.Size(136, 23);
            this.nametxt.TabIndex = 27;
            this.nametxt.TextChanged += new System.EventHandler(this.nametxt_TextChanged);
            // 
            // bloodopts
            // 
            this.bloodopts.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.bloodopts.FormattingEnabled = true;
            this.bloodopts.Items.AddRange(new object[] {
            "A",
            "B",
            "AB",
            "O"});
            this.bloodopts.Location = new System.Drawing.Point(103, 224);
            this.bloodopts.Name = "bloodopts";
            this.bloodopts.Size = new System.Drawing.Size(121, 24);
            this.bloodopts.TabIndex = 26;
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(13, 276);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 16);
            this.label12.TabIndex = 19;
            this.label12.Text = "Allergies:";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 227);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 16);
            this.label8.TabIndex = 15;
            this.label8.Text = "Blood Type:";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 181);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "Telphone:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "Address: ";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "ID:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Date Of Birth:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // dob
            // 
            this.dob.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dob.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dob.Location = new System.Drawing.Point(116, 94);
            this.dob.Name = "dob";
            this.dob.Size = new System.Drawing.Size(182, 23);
            this.dob.TabIndex = 10;
            this.dob.ValueChanged += new System.EventHandler(this.dob_ValueChanged);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(238, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Surname:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Name:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // addPatbackbtn
            // 
            this.addPatbackbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.addPatbackbtn.BackColor = System.Drawing.Color.DodgerBlue;
            this.addPatbackbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addPatbackbtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPatbackbtn.Location = new System.Drawing.Point(8, 606);
            this.addPatbackbtn.Name = "addPatbackbtn";
            this.addPatbackbtn.Size = new System.Drawing.Size(75, 27);
            this.addPatbackbtn.TabIndex = 50;
            this.addPatbackbtn.Text = "Back";
            this.addPatbackbtn.UseVisualStyleBackColor = false;
            this.addPatbackbtn.Click += new System.EventHandler(this.addPatbackbtn_Click);
            // 
            // visitsubmit
            // 
            this.visitsubmit.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.visitsubmit.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.visitsubmit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.visitsubmit.Font = new System.Drawing.Font("Microsoft YaHei UI", 11F, System.Drawing.FontStyle.Bold);
            this.visitsubmit.Location = new System.Drawing.Point(1000, 502);
            this.visitsubmit.Name = "visitsubmit";
            this.visitsubmit.Size = new System.Drawing.Size(156, 40);
            this.visitsubmit.TabIndex = 49;
            this.visitsubmit.Text = "Add Visits";
            this.visitsubmit.UseVisualStyleBackColor = false;
            this.visitsubmit.Click += new System.EventHandler(this.visitsubmit_Click);
            // 
            // submit
            // 
            this.submit.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.submit.AutoSize = true;
            this.submit.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.submit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.submit.Font = new System.Drawing.Font("Microsoft YaHei UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submit.Location = new System.Drawing.Point(354, 509);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(156, 40);
            this.submit.TabIndex = 39;
            this.submit.Text = "Add Patient";
            this.submit.UseVisualStyleBackColor = false;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // label11
            // 
            this.label11.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label11.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label11.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label11.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label11.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label11.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label11.Location = new System.Drawing.Point(51, 92);
            this.label11.Margin = new System.Windows.Forms.Padding(0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(459, 44);
            this.label11.TabIndex = 18;
            this.label11.Text = "General Details:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label10.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label10.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label10.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label10.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label10.Location = new System.Drawing.Point(632, 267);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(524, 44);
            this.label10.TabIndex = 17;
            this.label10.Text = "Other Visits:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label9.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label9.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label9.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label9.Location = new System.Drawing.Point(632, 28);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(524, 44);
            this.label9.TabIndex = 16;
            this.label9.Text = "Recent Visit:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.BackColor = System.Drawing.SystemColors.Menu;
            this.label1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Lucida Fax", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(51, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(459, 44);
            this.label1.TabIndex = 7;
            this.label1.Text = "Add a Patient";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Appointment
            // 
            this.Appointment.BackColor = System.Drawing.Color.White;
            this.Appointment.Controls.Add(this.Appbackbtn);
            this.Appointment.Controls.Add(this.panel3);
            this.Appointment.Controls.Add(this.panel2);
            this.Appointment.Location = new System.Drawing.Point(4, 26);
            this.Appointment.Name = "Appointment";
            this.Appointment.Size = new System.Drawing.Size(1204, 641);
            this.Appointment.TabIndex = 4;
            this.Appointment.Text = "Appointment";
            this.Appointment.Click += new System.EventHandler(this.Appointment_Click);
            // 
            // Appbackbtn
            // 
            this.Appbackbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Appbackbtn.BackColor = System.Drawing.Color.DodgerBlue;
            this.Appbackbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Appbackbtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Appbackbtn.Location = new System.Drawing.Point(8, 604);
            this.Appbackbtn.Name = "Appbackbtn";
            this.Appbackbtn.Size = new System.Drawing.Size(75, 29);
            this.Appbackbtn.TabIndex = 51;
            this.Appbackbtn.Text = "Back";
            this.Appbackbtn.UseVisualStyleBackColor = false;
            this.Appbackbtn.Click += new System.EventHandler(this.Appbackbtn_Click);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.AppFiltercbx);
            this.panel3.Controls.Add(this.Appsearchdgv);
            this.panel3.Controls.Add(this.Appsearchbtn);
            this.panel3.Controls.Add(this.AppsearchID);
            this.panel3.Controls.Add(this.label34);
            this.panel3.Controls.Add(this.label27);
            this.panel3.Location = new System.Drawing.Point(35, 275);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1135, 297);
            this.panel3.TabIndex = 41;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // AppFiltercbx
            // 
            this.AppFiltercbx.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AppFiltercbx.FormattingEnabled = true;
            this.AppFiltercbx.Items.AddRange(new object[] {
            "Sort by Date: Newest First",
            "Sort by Date: Oldest First "});
            this.AppFiltercbx.Location = new System.Drawing.Point(958, 87);
            this.AppFiltercbx.Name = "AppFiltercbx";
            this.AppFiltercbx.Size = new System.Drawing.Size(153, 21);
            this.AppFiltercbx.TabIndex = 39;
            this.AppFiltercbx.Text = "Sort by Date: Newest First";
            // 
            // Appsearchdgv
            // 
            this.Appsearchdgv.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Appsearchdgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Appsearchdgv.Location = new System.Drawing.Point(18, 129);
            this.Appsearchdgv.Name = "Appsearchdgv";
            this.Appsearchdgv.RowHeadersWidth = 51;
            this.Appsearchdgv.Size = new System.Drawing.Size(1093, 150);
            this.Appsearchdgv.TabIndex = 38;
            // 
            // Appsearchbtn
            // 
            this.Appsearchbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Appsearchbtn.BackColor = System.Drawing.Color.DodgerBlue;
            this.Appsearchbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Appsearchbtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Appsearchbtn.Location = new System.Drawing.Point(539, 85);
            this.Appsearchbtn.Name = "Appsearchbtn";
            this.Appsearchbtn.Size = new System.Drawing.Size(75, 26);
            this.Appsearchbtn.TabIndex = 37;
            this.Appsearchbtn.Text = "Search";
            this.Appsearchbtn.UseVisualStyleBackColor = false;
            this.Appsearchbtn.Click += new System.EventHandler(this.Appsearchbtn_Click);
            // 
            // AppsearchID
            // 
            this.AppsearchID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AppsearchID.Location = new System.Drawing.Point(424, 88);
            this.AppsearchID.Name = "AppsearchID";
            this.AppsearchID.Size = new System.Drawing.Size(100, 20);
            this.AppsearchID.TabIndex = 36;
            // 
            // label34
            // 
            this.label34.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(15, 91);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(303, 13);
            this.label34.TabIndex = 35;
            this.label34.Text = "Enter the patient\'s ID whom\'s appointment you want so search:";
            // 
            // label27
            // 
            this.label27.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label27.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label27.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label27.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label27.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label27.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label27.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label27.Location = new System.Drawing.Point(14, 13);
            this.label27.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(304, 44);
            this.label27.TabIndex = 21;
            this.label27.Text = "Search appointment";
            this.label27.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.crtAppbtn);
            this.panel2.Controls.Add(this.label35);
            this.panel2.Controls.Add(this.Appsdate);
            this.panel2.Controls.Add(this.Appcdate);
            this.panel2.Controls.Add(this.label33);
            this.panel2.Controls.Add(this.AppDoctor);
            this.panel2.Controls.Add(this.label31);
            this.panel2.Controls.Add(this.ApppatSurname);
            this.panel2.Controls.Add(this.ApppatName);
            this.panel2.Controls.Add(this.ApppatID);
            this.panel2.Controls.Add(this.label30);
            this.panel2.Controls.Add(this.label29);
            this.panel2.Controls.Add(this.label28);
            this.panel2.Controls.Add(this.label26);
            this.panel2.Location = new System.Drawing.Point(35, 25);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(726, 236);
            this.panel2.TabIndex = 40;
            // 
            // crtAppbtn
            // 
            this.crtAppbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.crtAppbtn.BackColor = System.Drawing.Color.DodgerBlue;
            this.crtAppbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.crtAppbtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crtAppbtn.Location = new System.Drawing.Point(413, 193);
            this.crtAppbtn.Name = "crtAppbtn";
            this.crtAppbtn.Size = new System.Drawing.Size(75, 26);
            this.crtAppbtn.TabIndex = 34;
            this.crtAppbtn.Text = "Create";
            this.crtAppbtn.UseVisualStyleBackColor = false;
            this.crtAppbtn.Click += new System.EventHandler(this.crtAppbtn_Click);
            // 
            // label35
            // 
            this.label35.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(308, 121);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(85, 13);
            this.label35.TabIndex = 33;
            this.label35.Text = "Scheduled date:";
            this.label35.Click += new System.EventHandler(this.label35_Click);
            // 
            // Appsdate
            // 
            this.Appsdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Appsdate.Location = new System.Drawing.Point(499, 116);
            this.Appsdate.Name = "Appsdate";
            this.Appsdate.Size = new System.Drawing.Size(200, 20);
            this.Appsdate.TabIndex = 12;
            this.Appsdate.ValueChanged += new System.EventHandler(this.Appsdate_ValueChanged);
            // 
            // Appcdate
            // 
            this.Appcdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Appcdate.Location = new System.Drawing.Point(499, 82);
            this.Appcdate.Name = "Appcdate";
            this.Appcdate.Size = new System.Drawing.Size(200, 20);
            this.Appcdate.TabIndex = 31;
            this.Appcdate.ValueChanged += new System.EventHandler(this.Appcdate_ValueChanged);
            // 
            // label33
            // 
            this.label33.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(308, 87);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(136, 13);
            this.label33.TabIndex = 30;
            this.label33.Text = "Appointment creation Date:";
            this.label33.Click += new System.EventHandler(this.label33_Click);
            // 
            // AppDoctor
            // 
            this.AppDoctor.Location = new System.Drawing.Point(138, 196);
            this.AppDoctor.Name = "AppDoctor";
            this.AppDoctor.Size = new System.Drawing.Size(118, 20);
            this.AppDoctor.TabIndex = 29;
            this.AppDoctor.TextChanged += new System.EventHandler(this.AppDoctor_TextChanged);
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(15, 201);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(42, 13);
            this.label31.TabIndex = 28;
            this.label31.Text = "Doctor:";
            this.label31.Click += new System.EventHandler(this.label31_Click);
            // 
            // ApppatSurname
            // 
            this.ApppatSurname.Location = new System.Drawing.Point(138, 158);
            this.ApppatSurname.Name = "ApppatSurname";
            this.ApppatSurname.Size = new System.Drawing.Size(118, 20);
            this.ApppatSurname.TabIndex = 27;
            this.ApppatSurname.TextChanged += new System.EventHandler(this.ApppatSurname_TextChanged);
            // 
            // ApppatName
            // 
            this.ApppatName.Location = new System.Drawing.Point(138, 121);
            this.ApppatName.Name = "ApppatName";
            this.ApppatName.Size = new System.Drawing.Size(118, 20);
            this.ApppatName.TabIndex = 26;
            this.ApppatName.TextChanged += new System.EventHandler(this.ApppatName_TextChanged);
            // 
            // ApppatID
            // 
            this.ApppatID.Location = new System.Drawing.Point(138, 84);
            this.ApppatID.Name = "ApppatID";
            this.ApppatID.Size = new System.Drawing.Size(118, 20);
            this.ApppatID.TabIndex = 25;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(15, 161);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(88, 13);
            this.label30.TabIndex = 24;
            this.label30.Text = "Patient Surname:";
            this.label30.Click += new System.EventHandler(this.label30_Click);
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(15, 121);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(75, 13);
            this.label29.TabIndex = 23;
            this.label29.Text = "Patient name: ";
            this.label29.Click += new System.EventHandler(this.label29_Click);
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(15, 82);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(57, 13);
            this.label28.TabIndex = 22;
            this.label28.Text = "Patient ID:";
            // 
            // label26
            // 
            this.label26.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label26.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label26.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label26.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label26.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label26.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label26.Location = new System.Drawing.Point(14, 15);
            this.label26.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(304, 44);
            this.label26.TabIndex = 20;
            this.label26.Text = "Create appointment";
            this.label26.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CalcBill
            // 
            this.CalcBill.AccessibleRole = System.Windows.Forms.AccessibleRole.PageTab;
            this.CalcBill.BackColor = System.Drawing.Color.White;
            this.CalcBill.Controls.Add(this.panel4);
            this.CalcBill.Controls.Add(this.billBackbtn);
            this.CalcBill.Font = new System.Drawing.Font("Microsoft Tai Le", 9F);
            this.CalcBill.Location = new System.Drawing.Point(4, 26);
            this.CalcBill.Name = "CalcBill";
            this.CalcBill.Padding = new System.Windows.Forms.Padding(3);
            this.CalcBill.Size = new System.Drawing.Size(1204, 641);
            this.CalcBill.TabIndex = 2;
            this.CalcBill.Text = "Calculate Bill";
            // 
            // panel4
            // 
            this.panel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.label41);
            this.panel4.Controls.Add(this.label39);
            this.panel4.Controls.Add(this.button1);
            this.panel4.Controls.Add(this.textBoxPay);
            this.panel4.Controls.Add(this.textBoxExpenseTotal);
            this.panel4.Controls.Add(this.textBoxNights);
            this.panel4.Controls.Add(this.textBoxID);
            this.panel4.Controls.Add(this.label40);
            this.panel4.Controls.Add(this.label38);
            this.panel4.Controls.Add(this.label37);
            this.panel4.Controls.Add(this.label32);
            this.panel4.Location = new System.Drawing.Point(434, 44);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(358, 424);
            this.panel4.TabIndex = 66;
            // 
            // label41
            // 
            this.label41.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(26, 72);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(184, 16);
            this.label41.TabIndex = 65;
            this.label41.Text = "Please enter the following details:";
            // 
            // label39
            // 
            this.label39.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label39.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label39.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label39.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label39.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label39.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label39.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label39.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label39.Location = new System.Drawing.Point(26, 10);
            this.label39.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(304, 44);
            this.label39.TabIndex = 64;
            this.label39.Text = "Calculate Patient\'s Bill";
            this.label39.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label39.Click += new System.EventHandler(this.label39_Click);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackColor = System.Drawing.Color.DodgerBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(129, 236);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 32);
            this.button1.TabIndex = 63;
            this.button1.Text = "Calculate ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxPay
            // 
            this.textBoxPay.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxPay.Location = new System.Drawing.Point(205, 374);
            this.textBoxPay.Name = "textBoxPay";
            this.textBoxPay.Size = new System.Drawing.Size(125, 23);
            this.textBoxPay.TabIndex = 62;
            // 
            // textBoxExpenseTotal
            // 
            this.textBoxExpenseTotal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxExpenseTotal.Location = new System.Drawing.Point(205, 310);
            this.textBoxExpenseTotal.Name = "textBoxExpenseTotal";
            this.textBoxExpenseTotal.Size = new System.Drawing.Size(125, 23);
            this.textBoxExpenseTotal.TabIndex = 60;
            // 
            // textBoxNights
            // 
            this.textBoxNights.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxNights.Location = new System.Drawing.Point(205, 171);
            this.textBoxNights.Name = "textBoxNights";
            this.textBoxNights.Size = new System.Drawing.Size(125, 23);
            this.textBoxNights.TabIndex = 59;
            // 
            // textBoxID
            // 
            this.textBoxID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxID.Location = new System.Drawing.Point(205, 109);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(125, 23);
            this.textBoxID.TabIndex = 58;
            this.textBoxID.TextChanged += new System.EventHandler(this.textBoxID_TextChanged);
            // 
            // label40
            // 
            this.label40.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(26, 377);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(75, 16);
            this.label40.TabIndex = 57;
            this.label40.Text = "Patient\'s Bill:";
            // 
            // label38
            // 
            this.label38.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(26, 313);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(131, 16);
            this.label38.TabIndex = 55;
            this.label38.Text = "Patient\'s Total Expense:";
            // 
            // label37
            // 
            this.label37.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(26, 174);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(105, 16);
            this.label37.TabIndex = 54;
            this.label37.Text = "Number of nights:";
            // 
            // label32
            // 
            this.label32.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(26, 112);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(50, 16);
            this.label32.TabIndex = 53;
            this.label32.Text = "ID Card:";
            // 
            // billBackbtn
            // 
            this.billBackbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.billBackbtn.BackColor = System.Drawing.Color.DodgerBlue;
            this.billBackbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.billBackbtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.billBackbtn.Location = new System.Drawing.Point(8, 603);
            this.billBackbtn.Name = "billBackbtn";
            this.billBackbtn.Size = new System.Drawing.Size(75, 30);
            this.billBackbtn.TabIndex = 52;
            this.billBackbtn.Text = "Back";
            this.billBackbtn.UseVisualStyleBackColor = false;
            this.billBackbtn.Click += new System.EventHandler(this.billBackbtn_Click);
            // 
            // Search
            // 
            this.Search.AccessibleRole = System.Windows.Forms.AccessibleRole.PageTab;
            this.Search.BackColor = System.Drawing.Color.White;
            this.Search.Controls.Add(this.panel6);
            this.Search.Controls.Add(this.panel5);
            this.Search.Controls.Add(this.searchPatbackbtn);
            this.Search.Font = new System.Drawing.Font("Microsoft Tai Le", 9F);
            this.Search.Location = new System.Drawing.Point(4, 26);
            this.Search.Name = "Search";
            this.Search.Padding = new System.Windows.Forms.Padding(3);
            this.Search.Size = new System.Drawing.Size(1204, 641);
            this.Search.TabIndex = 3;
            this.Search.Text = "Search";
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // panel6
            // 
            this.panel6.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.Filtercbx);
            this.panel6.Controls.Add(this.visitsearch);
            this.panel6.Controls.Add(this.label25);
            this.panel6.Controls.Add(this.visitdgv);
            this.panel6.Controls.Add(this.pvisitID);
            this.panel6.Controls.Add(this.label23);
            this.panel6.Location = new System.Drawing.Point(21, 314);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1155, 277);
            this.panel6.TabIndex = 54;
            // 
            // Filtercbx
            // 
            this.Filtercbx.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Filtercbx.FormattingEnabled = true;
            this.Filtercbx.Items.AddRange(new object[] {
            "Date: Newest First",
            "Date: Oldest First"});
            this.Filtercbx.Location = new System.Drawing.Point(1005, 82);
            this.Filtercbx.Name = "Filtercbx";
            this.Filtercbx.Size = new System.Drawing.Size(121, 24);
            this.Filtercbx.TabIndex = 22;
            this.Filtercbx.Text = "Sort by";
            // 
            // visitsearch
            // 
            this.visitsearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.visitsearch.BackColor = System.Drawing.Color.DodgerBlue;
            this.visitsearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.visitsearch.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.visitsearch.Location = new System.Drawing.Point(532, 78);
            this.visitsearch.Name = "visitsearch";
            this.visitsearch.Size = new System.Drawing.Size(75, 26);
            this.visitsearch.TabIndex = 21;
            this.visitsearch.Text = " Search";
            this.visitsearch.UseVisualStyleBackColor = false;
            this.visitsearch.Click += new System.EventHandler(this.visitsearch_Click);
            // 
            // label25
            // 
            this.label25.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label25.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label25.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label25.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label25.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label25.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label25.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label25.Location = new System.Drawing.Point(11, 19);
            this.label25.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(304, 44);
            this.label25.TabIndex = 20;
            this.label25.Text = "Search a patient\'s visit";
            this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // visitdgv
            // 
            this.visitdgv.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.visitdgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.visitdgv.Location = new System.Drawing.Point(16, 127);
            this.visitdgv.Name = "visitdgv";
            this.visitdgv.RowHeadersWidth = 51;
            this.visitdgv.Size = new System.Drawing.Size(1122, 131);
            this.visitdgv.TabIndex = 7;
            this.visitdgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.visitdgv_CellContentClick);
            // 
            // pvisitID
            // 
            this.pvisitID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pvisitID.Location = new System.Drawing.Point(411, 77);
            this.pvisitID.Name = "pvisitID";
            this.pvisitID.Size = new System.Drawing.Size(100, 23);
            this.pvisitID.TabIndex = 5;
            // 
            // label23
            // 
            this.label23.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(11, 82);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(315, 16);
            this.label23.TabIndex = 4;
            this.label23.Text = "Enter the ID of the patient whose visits you want to search:";
            // 
            // panel5
            // 
            this.panel5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.label24);
            this.panel5.Controls.Add(this.searchPatient);
            this.panel5.Controls.Add(this.patientdgv);
            this.panel5.Controls.Add(this.psearchID);
            this.panel5.Controls.Add(this.label22);
            this.panel5.Location = new System.Drawing.Point(21, 23);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1155, 277);
            this.panel5.TabIndex = 53;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
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
            this.label24.Location = new System.Drawing.Point(12, 17);
            this.label24.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(304, 44);
            this.label24.TabIndex = 19;
            this.label24.Text = "Search a patient";
            this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // searchPatient
            // 
            this.searchPatient.BackColor = System.Drawing.Color.DodgerBlue;
            this.searchPatient.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.searchPatient.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchPatient.Location = new System.Drawing.Point(480, 75);
            this.searchPatient.Name = "searchPatient";
            this.searchPatient.Size = new System.Drawing.Size(75, 27);
            this.searchPatient.TabIndex = 3;
            this.searchPatient.Text = "Search";
            this.searchPatient.UseVisualStyleBackColor = false;
            this.searchPatient.Click += new System.EventHandler(this.searchPatient_Click);
            // 
            // patientdgv
            // 
            this.patientdgv.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.patientdgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.patientdgv.Location = new System.Drawing.Point(16, 130);
            this.patientdgv.Name = "patientdgv";
            this.patientdgv.RowHeadersWidth = 51;
            this.patientdgv.Size = new System.Drawing.Size(1122, 119);
            this.patientdgv.TabIndex = 2;
            this.patientdgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.patientdgv_CellContentClick);
            // 
            // psearchID
            // 
            this.psearchID.Location = new System.Drawing.Point(360, 75);
            this.psearchID.Name = "psearchID";
            this.psearchID.Size = new System.Drawing.Size(100, 23);
            this.psearchID.TabIndex = 1;
            this.psearchID.TextChanged += new System.EventHandler(this.psearchID_TextChanged);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(12, 78);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(273, 16);
            this.label22.TabIndex = 0;
            this.label22.Text = "Enter the ID of the patient that you want to search:";
            // 
            // searchPatbackbtn
            // 
            this.searchPatbackbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.searchPatbackbtn.BackColor = System.Drawing.Color.DodgerBlue;
            this.searchPatbackbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.searchPatbackbtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchPatbackbtn.Location = new System.Drawing.Point(6, 607);
            this.searchPatbackbtn.Name = "searchPatbackbtn";
            this.searchPatbackbtn.Size = new System.Drawing.Size(76, 29);
            this.searchPatbackbtn.TabIndex = 52;
            this.searchPatbackbtn.Text = "Back";
            this.searchPatbackbtn.UseVisualStyleBackColor = false;
            this.searchPatbackbtn.Click += new System.EventHandler(this.searchPatbackbtn_Click);
            // 
            // searchVisit
            // 
            this.searchVisit.Location = new System.Drawing.Point(0, 0);
            this.searchVisit.Name = "searchVisit";
            this.searchVisit.Size = new System.Drawing.Size(75, 23);
            this.searchVisit.TabIndex = 0;
            // 
            // Patients
            // 
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1212, 713);
            this.Controls.Add(this.PatientsTabControl);
            this.Controls.Add(this.BlueBack);
            this.Name = "Patients";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Patients_Load);
            this.BlueBack.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.hospitallogo)).EndInit();
            this.PatientsTabControl.ResumeLayout(false);
            this.Home.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.AddPat.ResumeLayout(false);
            this.AddPat.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.Appointment.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Appsearchdgv)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.CalcBill.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.Search.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.visitdgv)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patientdgv)).EndInit();
            this.ResumeLayout(false);

        }

        /*
        private void Patients_Load(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void pvsitfilter_combobox(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void idtxt_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
        */

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
        private System.Windows.Forms.TextBox nametxt;
        private System.Windows.Forms.ComboBox allergiesopts;
        private System.Windows.Forms.TextBox addresstxt;
        private System.Windows.Forms.TextBox telephonetxt;
        private System.Windows.Forms.RichTextBox historysummary;
        private System.Windows.Forms.TextBox historydoctor;
        private System.Windows.Forms.DateTimePicker historydate;
        private System.Windows.Forms.RichTextBox summarytxt;
        private System.Windows.Forms.TextBox doctortxt;
        private System.Windows.Forms.DateTimePicker visitdate;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox gendertxt;
        private System.Windows.Forms.TextBox surnametxt;
        private System.Windows.Forms.TextBox agetxt;
        private System.Windows.Forms.TextBox IDtxt;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.ComboBox insurancetxt;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button visitsubmit;
        private System.Windows.Forms.DataGridView visitdgv;
        private Button searchVisit;
        private System.Windows.Forms.TextBox pvisitID;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Button searchPatient;
        private System.Windows.Forms.DataGridView patientdgv;
        private System.Windows.Forms.TextBox psearchID;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.ComboBox patientFiltercbx;
        private System.Windows.Forms.Button pvisitbtn;
        private System.Windows.Forms.ComboBox visitFiltercbx;
        private Button visitsearch;
        private ComboBox Filtercbx;
        private Label label28;
        private Label label27;
        private Label label26;
        private Label label29;
        private Label label30;
        private TextBox ApppatSurname;
        private TextBox ApppatName;
        private TextBox ApppatID;
        private DataGridView Appsearchdgv;
        private Button Appsearchbtn;
        private TextBox AppsearchID;
        private Label label34;
        private Button crtAppbtn;
        private Label label35;
        private DateTimePicker Appsdate;
        private DateTimePicker Appcdate;
        private Label label33;
        private TextBox AppDoctor;
        private Label label31;
        private ComboBox AppFiltercbx;
        private RichTextBox richTextBox1;
        private Panel panel1;
        private RichTextBox richTextBox2;
        private Button issuebtn;
        private Label label36;
        private PictureBox pictureBox1;
        private Panel panel3;
        private Panel panel2;
        private Button patHomebackbtn;
        private Button addPatbackbtn;
        private Button Appbackbtn;
        private Button billBackbtn;
        private Button searchPatbackbtn;
        private Button button1;
        private TextBox textBoxPay;
        private TextBox textBoxExpenseTotal;
        private TextBox textBoxNights;
        private TextBox textBoxID;
        private Label label40;
        private Label label38;
        private Label label37;
        private Label label32;
        private Label label39;
        private Label label41;
        private Panel panel4;
        private Panel panel9;
        private Panel panel8;
        private Panel panel7;
        private Panel panel6;
        private Panel panel5;
    }
}