
namespace CIS2201_Assignment
{
    partial class Medication
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
            this.Title = new System.Windows.Forms.Label();
            this.SearchMed = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelSeachMed = new System.Windows.Forms.Label();
            this.medSearch = new System.Windows.Forms.TextBox();
            this.searchTypeofMed = new System.Windows.Forms.Button();
            this.meddgv = new System.Windows.Forms.DataGridView();
            this.label22 = new System.Windows.Forms.Label();
            this.searchMedBackBtn = new System.Windows.Forms.Button();
            this.AddMed = new System.Windows.Forms.TabPage();
            this.addMedbackbtn = new System.Windows.Forms.Button();
            this.buttonAddMed = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.bloodType = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.maintenancetxt = new System.Windows.Forms.TextBox();
            this.nameOfMed = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.price = new System.Windows.Forms.TextBox();
            this.stock = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.typeOfMed = new System.Windows.Forms.ComboBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Home = new System.Windows.Forms.TabPage();
            this.medHomebackbtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.issuebtn = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.MedicationTabControl = new System.Windows.Forms.TabControl();
            this.hospitallogo = new System.Windows.Forms.PictureBox();
            this.SearchMed.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.meddgv)).BeginInit();
            this.AddMed.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.Home.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.MedicationTabControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hospitallogo)).BeginInit();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.Title.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Title.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Title.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Title.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Title.Font = new System.Drawing.Font("Lucida Fax", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Title.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Title.Location = new System.Drawing.Point(-4, 0);
            this.Title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(1216, 46);
            this.Title.TabIndex = 7;
            this.Title.Text = "Manage Medication";
            this.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SearchMed
            // 
            this.SearchMed.AccessibleRole = System.Windows.Forms.AccessibleRole.PageTab;
            this.SearchMed.Controls.Add(this.panel2);
            this.SearchMed.Controls.Add(this.searchMedBackBtn);
            this.SearchMed.Font = new System.Drawing.Font("Microsoft Tai Le", 9F);
            this.SearchMed.Location = new System.Drawing.Point(4, 29);
            this.SearchMed.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SearchMed.Name = "SearchMed";
            this.SearchMed.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SearchMed.Size = new System.Drawing.Size(1202, 633);
            this.SearchMed.TabIndex = 3;
            this.SearchMed.Text = "Search";
            this.SearchMed.UseVisualStyleBackColor = true;
            this.SearchMed.Click += new System.EventHandler(this.SearchMed_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.labelSeachMed);
            this.panel2.Controls.Add(this.medSearch);
            this.panel2.Controls.Add(this.searchTypeofMed);
            this.panel2.Controls.Add(this.meddgv);
            this.panel2.Controls.Add(this.label22);
            this.panel2.Location = new System.Drawing.Point(78, 73);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1046, 386);
            this.panel2.TabIndex = 72;
            // 
            // labelSeachMed
            // 
            this.labelSeachMed.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.labelSeachMed.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelSeachMed.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.labelSeachMed.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.labelSeachMed.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.labelSeachMed.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSeachMed.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelSeachMed.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelSeachMed.Location = new System.Drawing.Point(13, 12);
            this.labelSeachMed.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSeachMed.Name = "labelSeachMed";
            this.labelSeachMed.Size = new System.Drawing.Size(304, 44);
            this.labelSeachMed.TabIndex = 19;
            this.labelSeachMed.Text = "Search Medication";
            this.labelSeachMed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // medSearch
            // 
            this.medSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.medSearch.Location = new System.Drawing.Point(396, 77);
            this.medSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.medSearch.Name = "medSearch";
            this.medSearch.Size = new System.Drawing.Size(100, 27);
            this.medSearch.TabIndex = 1;
            // 
            // searchTypeofMed
            // 
            this.searchTypeofMed.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.searchTypeofMed.BackColor = System.Drawing.Color.DodgerBlue;
            this.searchTypeofMed.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.searchTypeofMed.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTypeofMed.Location = new System.Drawing.Point(513, 77);
            this.searchTypeofMed.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchTypeofMed.Name = "searchTypeofMed";
            this.searchTypeofMed.Size = new System.Drawing.Size(83, 27);
            this.searchTypeofMed.TabIndex = 3;
            this.searchTypeofMed.Text = "Search";
            this.searchTypeofMed.UseVisualStyleBackColor = false;
            this.searchTypeofMed.Click += new System.EventHandler(this.searchTypeofMed_Click);
            // 
            // meddgv
            // 
            this.meddgv.AccessibleName = "medicationdgv";
            this.meddgv.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.meddgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.meddgv.Location = new System.Drawing.Point(31, 134);
            this.meddgv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.meddgv.Name = "meddgv";
            this.meddgv.RowHeadersWidth = 51;
            this.meddgv.Size = new System.Drawing.Size(985, 207);
            this.meddgv.TabIndex = 2;
            this.meddgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.patientdgv_CellContentClick);
            // 
            // label22
            // 
            this.label22.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(13, 80);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(367, 19);
            this.label22.TabIndex = 0;
            this.label22.Text = "Enter the name of medication that you want to search:";
            // 
            // searchMedBackBtn
            // 
            this.searchMedBackBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.searchMedBackBtn.BackColor = System.Drawing.Color.DodgerBlue;
            this.searchMedBackBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.searchMedBackBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchMedBackBtn.Location = new System.Drawing.Point(8, 598);
            this.searchMedBackBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchMedBackBtn.Name = "searchMedBackBtn";
            this.searchMedBackBtn.Size = new System.Drawing.Size(75, 27);
            this.searchMedBackBtn.TabIndex = 71;
            this.searchMedBackBtn.Text = "Back";
            this.searchMedBackBtn.UseVisualStyleBackColor = false;
            this.searchMedBackBtn.Click += new System.EventHandler(this.searchMedBackBtn_Click);
            // 
            // AddMed
            // 
            this.AddMed.AccessibleRole = System.Windows.Forms.AccessibleRole.PageTab;
            this.AddMed.BackColor = System.Drawing.Color.White;
            this.AddMed.Controls.Add(this.addMedbackbtn);
            this.AddMed.Controls.Add(this.buttonAddMed);
            this.AddMed.Controls.Add(this.panel5);
            this.AddMed.Controls.Add(this.panel4);
            this.AddMed.Cursor = System.Windows.Forms.Cursors.Default;
            this.AddMed.Font = new System.Drawing.Font("Microsoft Tai Le", 9F);
            this.AddMed.Location = new System.Drawing.Point(4, 29);
            this.AddMed.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddMed.Name = "AddMed";
            this.AddMed.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddMed.Size = new System.Drawing.Size(1202, 633);
            this.AddMed.TabIndex = 1;
            this.AddMed.Text = "Add Medication";
            // 
            // addMedbackbtn
            // 
            this.addMedbackbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.addMedbackbtn.BackColor = System.Drawing.Color.DodgerBlue;
            this.addMedbackbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addMedbackbtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addMedbackbtn.Location = new System.Drawing.Point(6, 597);
            this.addMedbackbtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addMedbackbtn.Name = "addMedbackbtn";
            this.addMedbackbtn.Size = new System.Drawing.Size(75, 28);
            this.addMedbackbtn.TabIndex = 70;
            this.addMedbackbtn.Text = "Back";
            this.addMedbackbtn.UseVisualStyleBackColor = false;
            this.addMedbackbtn.Click += new System.EventHandler(this.addMedbackbtn_Click);
            // 
            // buttonAddMed
            // 
            this.buttonAddMed.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonAddMed.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonAddMed.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAddMed.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddMed.Location = new System.Drawing.Point(513, 457);
            this.buttonAddMed.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAddMed.Name = "buttonAddMed";
            this.buttonAddMed.Size = new System.Drawing.Size(149, 37);
            this.buttonAddMed.TabIndex = 69;
            this.buttonAddMed.Text = "Add Medication";
            this.buttonAddMed.UseVisualStyleBackColor = false;
            this.buttonAddMed.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel5
            // 
            this.panel5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.label10);
            this.panel5.Controls.Add(this.bloodType);
            this.panel5.Controls.Add(this.label8);
            this.panel5.Location = new System.Drawing.Point(301, 332);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(583, 112);
            this.panel5.TabIndex = 68;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(21, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(531, 19);
            this.label10.TabIndex = 55;
            this.label10.Text = "If Blood Samples was chosen in Type of Medication, please choose blood type:";
            // 
            // bloodType
            // 
            this.bloodType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bloodType.FormattingEnabled = true;
            this.bloodType.Items.AddRange(new object[] {
            "A",
            "B",
            "AB",
            "O"});
            this.bloodType.Location = new System.Drawing.Point(309, 54);
            this.bloodType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bloodType.Name = "bloodType";
            this.bloodType.Size = new System.Drawing.Size(165, 27);
            this.bloodType.TabIndex = 26;
            this.bloodType.SelectedIndexChanged += new System.EventHandler(this.bloodType_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(121, 57);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 19);
            this.label8.TabIndex = 15;
            this.label8.Text = "Blood Type:";
            // 
            // panel4
            // 
            this.panel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.maintenancetxt);
            this.panel4.Controls.Add(this.nameOfMed);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.price);
            this.panel4.Controls.Add(this.stock);
            this.panel4.Controls.Add(this.label26);
            this.panel4.Controls.Add(this.typeOfMed);
            this.panel4.Controls.Add(this.label21);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Location = new System.Drawing.Point(345, 62);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(495, 256);
            this.panel4.TabIndex = 67;
            // 
            // maintenancetxt
            // 
            this.maintenancetxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.maintenancetxt.Location = new System.Drawing.Point(339, 203);
            this.maintenancetxt.Margin = new System.Windows.Forms.Padding(4);
            this.maintenancetxt.Name = "maintenancetxt";
            this.maintenancetxt.Size = new System.Drawing.Size(93, 27);
            this.maintenancetxt.TabIndex = 72;
            // 
            // nameOfMed
            // 
            this.nameOfMed.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nameOfMed.Location = new System.Drawing.Point(267, 103);
            this.nameOfMed.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nameOfMed.Name = "nameOfMed";
            this.nameOfMed.Size = new System.Drawing.Size(165, 27);
            this.nameOfMed.TabIndex = 71;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 19);
            this.label2.TabIndex = 62;
            this.label2.Text = "Name of Medication:";
            // 
            // price
            // 
            this.price.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.price.Location = new System.Drawing.Point(267, 167);
            this.price.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(165, 27);
            this.price.TabIndex = 51;
            // 
            // stock
            // 
            this.stock.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.stock.Location = new System.Drawing.Point(267, 135);
            this.stock.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.stock.Name = "stock";
            this.stock.Size = new System.Drawing.Size(165, 27);
            this.stock.TabIndex = 30;
            // 
            // label26
            // 
            this.label26.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(77, 207);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(239, 19);
            this.label26.TabIndex = 50;
            this.label26.Text = "Maintenance Required (Yes or No):";
            // 
            // typeOfMed
            // 
            this.typeOfMed.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.typeOfMed.FormattingEnabled = true;
            this.typeOfMed.Items.AddRange(new object[] {
            "Medicine",
            "Vaccine",
            "Blood Samples",
            "Instruments"});
            this.typeOfMed.Location = new System.Drawing.Point(267, 71);
            this.typeOfMed.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.typeOfMed.Name = "typeOfMed";
            this.typeOfMed.Size = new System.Drawing.Size(165, 27);
            this.typeOfMed.TabIndex = 48;
            this.typeOfMed.SelectedIndexChanged += new System.EventHandler(this.typeOfMed_SelectedIndexChanged);
            // 
            // label21
            // 
            this.label21.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(77, 74);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(141, 19);
            this.label21.TabIndex = 47;
            this.label21.Text = "Type of Medication:";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(77, 158);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 19);
            this.label7.TabIndex = 14;
            this.label7.Text = "Price:";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(77, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 19);
            this.label6.TabIndex = 13;
            this.label6.Text = "Stock left: ";
            // 
            // label1
            // 
            this.label1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Lucida Fax", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(27, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(445, 44);
            this.label1.TabIndex = 7;
            this.label1.Text = "Add a new Medication ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Home
            // 
            this.Home.AccessibleRole = System.Windows.Forms.AccessibleRole.PageTab;
            this.Home.BackColor = System.Drawing.Color.White;
            this.Home.Controls.Add(this.medHomebackbtn);
            this.Home.Controls.Add(this.pictureBox1);
            this.Home.Controls.Add(this.panel1);
            this.Home.Cursor = System.Windows.Forms.Cursors.Default;
            this.Home.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Home.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Home.Location = new System.Drawing.Point(4, 29);
            this.Home.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Home.Name = "Home";
            this.Home.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Home.Size = new System.Drawing.Size(1202, 633);
            this.Home.TabIndex = 0;
            this.Home.Text = "Home";
            // 
            // medHomebackbtn
            // 
            this.medHomebackbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.medHomebackbtn.BackColor = System.Drawing.Color.DodgerBlue;
            this.medHomebackbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.medHomebackbtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.medHomebackbtn.Location = new System.Drawing.Point(8, 603);
            this.medHomebackbtn.Name = "medHomebackbtn";
            this.medHomebackbtn.Size = new System.Drawing.Size(75, 27);
            this.medHomebackbtn.TabIndex = 53;
            this.medHomebackbtn.Text = "Back";
            this.medHomebackbtn.UseVisualStyleBackColor = false;
            this.medHomebackbtn.Click += new System.EventHandler(this.medHomebackbtn_Click);
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
            this.pictureBox1.Location = new System.Drawing.Point(3, 118);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1199, 519);
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
            this.panel1.Location = new System.Drawing.Point(3, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1196, 115);
            this.panel1.TabIndex = 1;
            // 
            // richTextBox1
            // 
            this.richTextBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.richTextBox1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.HideSelection = false;
            this.richTextBox1.Location = new System.Drawing.Point(-4, 52);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ShowSelectionMargin = true;
            this.richTextBox1.Size = new System.Drawing.Size(835, 62);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "Thank you for your service. If you ever encounter any issues with the system. Ple" +
    "ase inform us on the following number +356 77657333 or send us an issue!";
            // 
            // issuebtn
            // 
            this.issuebtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.issuebtn.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.issuebtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.issuebtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 11F, System.Drawing.FontStyle.Bold);
            this.issuebtn.Location = new System.Drawing.Point(948, 62);
            this.issuebtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.issuebtn.Name = "issuebtn";
            this.issuebtn.Size = new System.Drawing.Size(203, 39);
            this.issuebtn.TabIndex = 4;
            this.issuebtn.Text = "Report an Issue";
            this.issuebtn.UseVisualStyleBackColor = false;
            this.issuebtn.Click += new System.EventHandler(this.issuebtn_Click);
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label14.Font = new System.Drawing.Font("Myanmar Text", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(21, -3);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(1148, 49);
            this.label14.TabIndex = 0;
            this.label14.Text = "Welcome to the Hospital Management System";
            this.label14.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // MedicationTabControl
            // 
            this.MedicationTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MedicationTabControl.Controls.Add(this.Home);
            this.MedicationTabControl.Controls.Add(this.AddMed);
            this.MedicationTabControl.Controls.Add(this.SearchMed);
            this.MedicationTabControl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MedicationTabControl.Location = new System.Drawing.Point(2, 48);
            this.MedicationTabControl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MedicationTabControl.Name = "MedicationTabControl";
            this.MedicationTabControl.Padding = new System.Drawing.Point(15, 5);
            this.MedicationTabControl.SelectedIndex = 0;
            this.MedicationTabControl.Size = new System.Drawing.Size(1210, 666);
            this.MedicationTabControl.TabIndex = 13;
            // 
            // hospitallogo
            // 
            this.hospitallogo.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.hospitallogo.Image = global::CIS2201_Assignment.Properties.Resources.hospital;
            this.hospitallogo.Location = new System.Drawing.Point(6, -1);
            this.hospitallogo.Name = "hospitallogo";
            this.hospitallogo.Size = new System.Drawing.Size(45, 47);
            this.hospitallogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.hospitallogo.TabIndex = 14;
            this.hospitallogo.TabStop = false;
            // 
            // Medication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1212, 713);
            this.Controls.Add(this.hospitallogo);
            this.Controls.Add(this.MedicationTabControl);
            this.Controls.Add(this.Title);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Medication";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Medication";
            this.Load += new System.EventHandler(this.Medication_Load);
            this.SearchMed.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.meddgv)).EndInit();
            this.AddMed.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.Home.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.MedicationTabControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.hospitallogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.TabPage SearchMed;
        private System.Windows.Forms.Label labelSeachMed;
        private System.Windows.Forms.TextBox medSearch;
        private System.Windows.Forms.Button searchTypeofMed;
        private System.Windows.Forms.DataGridView meddgv;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TabPage AddMed;
        private System.Windows.Forms.TextBox price;
        private System.Windows.Forms.TextBox stock;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.ComboBox typeOfMed;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.ComboBox bloodType;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage Home;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button issuebtn;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TabControl MedicationTabControl;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button buttonAddMed;
        private System.Windows.Forms.Button addMedbackbtn;
        private System.Windows.Forms.Button searchMedBackBtn;
        private System.Windows.Forms.TextBox nameOfMed;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox maintenancetxt;
        private System.Windows.Forms.Button medHomebackbtn;
        private System.Windows.Forms.PictureBox hospitallogo;
    }
}