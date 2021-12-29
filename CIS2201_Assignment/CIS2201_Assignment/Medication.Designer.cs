
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
            this.searchstaffbackbtn = new System.Windows.Forms.Button();
            this.AddMed = new System.Windows.Forms.TabPage();
            this.addMedbackbtn = new System.Windows.Forms.Button();
            this.buttonAddMed = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.bloodType = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
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
            this.addStaffbackbtn = new System.Windows.Forms.Button();
            this.detailsubmit = new System.Windows.Forms.Button();
            this.submit = new System.Windows.Forms.Button();
            this.Home = new System.Windows.Forms.TabPage();
            this.staffHomebackbtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.issuebtn = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.MedicationTabControl = new System.Windows.Forms.TabControl();
            this.maintenancetxt = new System.Windows.Forms.TextBox();
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
            this.Title.Location = new System.Drawing.Point(0, 0);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(791, 37);
            this.Title.TabIndex = 7;
            this.Title.Text = "Manage Medication";
            this.Title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // SearchMed
            // 
            this.SearchMed.AccessibleRole = System.Windows.Forms.AccessibleRole.PageTab;
            this.SearchMed.Controls.Add(this.panel2);
            this.SearchMed.Controls.Add(this.searchMedBackBtn);
            this.SearchMed.Controls.Add(this.searchstaffbackbtn);
            this.SearchMed.Font = new System.Drawing.Font("Microsoft Tai Le", 9F);
            this.SearchMed.Location = new System.Drawing.Point(4, 26);
            this.SearchMed.Margin = new System.Windows.Forms.Padding(2);
            this.SearchMed.Name = "SearchMed";
            this.SearchMed.Padding = new System.Windows.Forms.Padding(2);
            this.SearchMed.Size = new System.Drawing.Size(791, 394);
            this.SearchMed.TabIndex = 3;
            this.SearchMed.Text = "Search";
            this.SearchMed.UseVisualStyleBackColor = true;
            this.SearchMed.Click += new System.EventHandler(this.SearchMed_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.labelSeachMed);
            this.panel2.Controls.Add(this.medSearch);
            this.panel2.Controls.Add(this.searchTypeofMed);
            this.panel2.Controls.Add(this.meddgv);
            this.panel2.Controls.Add(this.label22);
            this.panel2.Location = new System.Drawing.Point(13, 16);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(767, 297);
            this.panel2.TabIndex = 72;
            // 
            // labelSeachMed
            // 
            this.labelSeachMed.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.labelSeachMed.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.labelSeachMed.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.labelSeachMed.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.labelSeachMed.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSeachMed.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelSeachMed.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelSeachMed.Location = new System.Drawing.Point(10, 10);
            this.labelSeachMed.Name = "labelSeachMed";
            this.labelSeachMed.Size = new System.Drawing.Size(228, 36);
            this.labelSeachMed.TabIndex = 19;
            this.labelSeachMed.Text = "Search Medication";
            this.labelSeachMed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // medSearch
            // 
            this.medSearch.Location = new System.Drawing.Point(309, 62);
            this.medSearch.Margin = new System.Windows.Forms.Padding(2);
            this.medSearch.Name = "medSearch";
            this.medSearch.Size = new System.Drawing.Size(76, 23);
            this.medSearch.TabIndex = 1;
            // 
            // searchTypeofMed
            // 
            this.searchTypeofMed.BackColor = System.Drawing.Color.DodgerBlue;
            this.searchTypeofMed.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.searchTypeofMed.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTypeofMed.Location = new System.Drawing.Point(401, 63);
            this.searchTypeofMed.Margin = new System.Windows.Forms.Padding(2);
            this.searchTypeofMed.Name = "searchTypeofMed";
            this.searchTypeofMed.Size = new System.Drawing.Size(62, 22);
            this.searchTypeofMed.TabIndex = 3;
            this.searchTypeofMed.Text = "Search";
            this.searchTypeofMed.UseVisualStyleBackColor = false;
            this.searchTypeofMed.Click += new System.EventHandler(this.searchTypeofMed_Click);
            // 
            // meddgv
            // 
            this.meddgv.AccessibleName = "medicationdgv";
            this.meddgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.meddgv.Location = new System.Drawing.Point(14, 100);
            this.meddgv.Margin = new System.Windows.Forms.Padding(2);
            this.meddgv.Name = "meddgv";
            this.meddgv.RowHeadersWidth = 51;
            this.meddgv.Size = new System.Drawing.Size(739, 168);
            this.meddgv.TabIndex = 2;
            this.meddgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.patientdgv_CellContentClick);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(10, 65);
            this.label22.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(295, 16);
            this.label22.TabIndex = 0;
            this.label22.Text = "Enter the name of medication that you want to search:";
            // 
            // searchMedBackBtn
            // 
            this.searchMedBackBtn.BackColor = System.Drawing.Color.DodgerBlue;
            this.searchMedBackBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.searchMedBackBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchMedBackBtn.Location = new System.Drawing.Point(6, 369);
            this.searchMedBackBtn.Margin = new System.Windows.Forms.Padding(2);
            this.searchMedBackBtn.Name = "searchMedBackBtn";
            this.searchMedBackBtn.Size = new System.Drawing.Size(56, 22);
            this.searchMedBackBtn.TabIndex = 71;
            this.searchMedBackBtn.Text = "Back";
            this.searchMedBackBtn.UseVisualStyleBackColor = false;
            this.searchMedBackBtn.Click += new System.EventHandler(this.searchMedBackBtn_Click);
            // 
            // searchstaffbackbtn
            // 
            this.searchstaffbackbtn.BackColor = System.Drawing.Color.DodgerBlue;
            this.searchstaffbackbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.searchstaffbackbtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchstaffbackbtn.Location = new System.Drawing.Point(6, 492);
            this.searchstaffbackbtn.Margin = new System.Windows.Forms.Padding(2);
            this.searchstaffbackbtn.Name = "searchstaffbackbtn";
            this.searchstaffbackbtn.Size = new System.Drawing.Size(56, 19);
            this.searchstaffbackbtn.TabIndex = 52;
            this.searchstaffbackbtn.Text = "Back";
            this.searchstaffbackbtn.UseVisualStyleBackColor = false;
            // 
            // AddMed
            // 
            this.AddMed.AccessibleRole = System.Windows.Forms.AccessibleRole.PageTab;
            this.AddMed.BackColor = System.Drawing.Color.White;
            this.AddMed.Controls.Add(this.addMedbackbtn);
            this.AddMed.Controls.Add(this.buttonAddMed);
            this.AddMed.Controls.Add(this.panel5);
            this.AddMed.Controls.Add(this.panel4);
            this.AddMed.Controls.Add(this.addStaffbackbtn);
            this.AddMed.Controls.Add(this.detailsubmit);
            this.AddMed.Controls.Add(this.submit);
            this.AddMed.Cursor = System.Windows.Forms.Cursors.Default;
            this.AddMed.Font = new System.Drawing.Font("Microsoft Tai Le", 9F);
            this.AddMed.Location = new System.Drawing.Point(4, 26);
            this.AddMed.Margin = new System.Windows.Forms.Padding(2);
            this.AddMed.Name = "AddMed";
            this.AddMed.Padding = new System.Windows.Forms.Padding(2);
            this.AddMed.Size = new System.Drawing.Size(791, 394);
            this.AddMed.TabIndex = 1;
            this.AddMed.Text = "Add Medication";
            // 
            // addMedbackbtn
            // 
            this.addMedbackbtn.BackColor = System.Drawing.Color.DodgerBlue;
            this.addMedbackbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addMedbackbtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addMedbackbtn.Location = new System.Drawing.Point(6, 372);
            this.addMedbackbtn.Margin = new System.Windows.Forms.Padding(2);
            this.addMedbackbtn.Name = "addMedbackbtn";
            this.addMedbackbtn.Size = new System.Drawing.Size(56, 19);
            this.addMedbackbtn.TabIndex = 70;
            this.addMedbackbtn.Text = "Back";
            this.addMedbackbtn.UseVisualStyleBackColor = false;
            this.addMedbackbtn.Click += new System.EventHandler(this.addMedbackbtn_Click);
            // 
            // buttonAddMed
            // 
            this.buttonAddMed.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonAddMed.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAddMed.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddMed.Location = new System.Drawing.Point(346, 327);
            this.buttonAddMed.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAddMed.Name = "buttonAddMed";
            this.buttonAddMed.Size = new System.Drawing.Size(112, 30);
            this.buttonAddMed.TabIndex = 69;
            this.buttonAddMed.Text = "Add Medication";
            this.buttonAddMed.UseVisualStyleBackColor = false;
            this.buttonAddMed.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.label10);
            this.panel5.Controls.Add(this.bloodType);
            this.panel5.Controls.Add(this.label8);
            this.panel5.Location = new System.Drawing.Point(188, 225);
            this.panel5.Margin = new System.Windows.Forms.Padding(2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(438, 91);
            this.panel5.TabIndex = 68;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(16, 7);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(422, 16);
            this.label10.TabIndex = 55;
            this.label10.Text = "If Blood Samples was chosen in Type of Medication, please choose blood type:";
            // 
            // bloodType
            // 
            this.bloodType.FormattingEnabled = true;
            this.bloodType.Items.AddRange(new object[] {
            "A",
            "B",
            "AB",
            "O"});
            this.bloodType.Location = new System.Drawing.Point(232, 44);
            this.bloodType.Margin = new System.Windows.Forms.Padding(2);
            this.bloodType.Name = "bloodType";
            this.bloodType.Size = new System.Drawing.Size(125, 24);
            this.bloodType.TabIndex = 26;
            this.bloodType.SelectedIndexChanged += new System.EventHandler(this.bloodType_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(91, 46);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 16);
            this.label8.TabIndex = 15;
            this.label8.Text = "Blood Type:";
            // 
            // panel4
            // 
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
            this.panel4.Location = new System.Drawing.Point(220, 6);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(372, 208);
            this.panel4.TabIndex = 67;
            // 
            // nameOfMed
            // 
            this.nameOfMed.Location = new System.Drawing.Point(200, 84);
            this.nameOfMed.Margin = new System.Windows.Forms.Padding(2);
            this.nameOfMed.Name = "nameOfMed";
            this.nameOfMed.Size = new System.Drawing.Size(125, 23);
            this.nameOfMed.TabIndex = 71;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 84);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 16);
            this.label2.TabIndex = 62;
            this.label2.Text = "Name of Medication:";
            // 
            // price
            // 
            this.price.Location = new System.Drawing.Point(200, 136);
            this.price.Margin = new System.Windows.Forms.Padding(2);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(125, 23);
            this.price.TabIndex = 51;
            // 
            // stock
            // 
            this.stock.Location = new System.Drawing.Point(200, 110);
            this.stock.Margin = new System.Windows.Forms.Padding(2);
            this.stock.Name = "stock";
            this.stock.Size = new System.Drawing.Size(125, 23);
            this.stock.TabIndex = 30;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(58, 168);
            this.label26.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(192, 16);
            this.label26.TabIndex = 50;
            this.label26.Text = "Maintenance Required (Yes or No):";
            // 
            // typeOfMed
            // 
            this.typeOfMed.FormattingEnabled = true;
            this.typeOfMed.Items.AddRange(new object[] {
            "Medicine",
            "Vaccine",
            "Blood Samples",
            "Instruments"});
            this.typeOfMed.Location = new System.Drawing.Point(200, 58);
            this.typeOfMed.Margin = new System.Windows.Forms.Padding(2);
            this.typeOfMed.Name = "typeOfMed";
            this.typeOfMed.Size = new System.Drawing.Size(125, 24);
            this.typeOfMed.TabIndex = 48;
            this.typeOfMed.SelectedIndexChanged += new System.EventHandler(this.typeOfMed_SelectedIndexChanged);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(58, 60);
            this.label21.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(114, 16);
            this.label21.TabIndex = 47;
            this.label21.Text = "Type of Medication:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(58, 128);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "Price:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(58, 106);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "Stock left: ";
            // 
            // label1
            // 
            this.label1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Lucida Fax", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(20, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(334, 36);
            this.label1.TabIndex = 7;
            this.label1.Text = "Add a new Medication ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // addStaffbackbtn
            // 
            this.addStaffbackbtn.BackColor = System.Drawing.Color.DodgerBlue;
            this.addStaffbackbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addStaffbackbtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addStaffbackbtn.Location = new System.Drawing.Point(4, 494);
            this.addStaffbackbtn.Margin = new System.Windows.Forms.Padding(2);
            this.addStaffbackbtn.Name = "addStaffbackbtn";
            this.addStaffbackbtn.Size = new System.Drawing.Size(56, 19);
            this.addStaffbackbtn.TabIndex = 66;
            this.addStaffbackbtn.Text = "Back";
            this.addStaffbackbtn.UseVisualStyleBackColor = false;
            // 
            // detailsubmit
            // 
            this.detailsubmit.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.detailsubmit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.detailsubmit.Font = new System.Drawing.Font("Microsoft YaHei UI", 11F, System.Drawing.FontStyle.Bold);
            this.detailsubmit.Location = new System.Drawing.Point(698, 416);
            this.detailsubmit.Margin = new System.Windows.Forms.Padding(2);
            this.detailsubmit.Name = "detailsubmit";
            this.detailsubmit.Size = new System.Drawing.Size(117, 32);
            this.detailsubmit.TabIndex = 49;
            this.detailsubmit.Text = "Add Details";
            this.detailsubmit.UseVisualStyleBackColor = false;
            // 
            // submit
            // 
            this.submit.AutoSize = true;
            this.submit.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.submit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.submit.Font = new System.Drawing.Font("Microsoft YaHei UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submit.Location = new System.Drawing.Point(168, 416);
            this.submit.Margin = new System.Windows.Forms.Padding(2);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(173, 32);
            this.submit.TabIndex = 39;
            this.submit.Text = "Add Staff member";
            this.submit.UseVisualStyleBackColor = false;
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
            this.Home.Location = new System.Drawing.Point(4, 26);
            this.Home.Margin = new System.Windows.Forms.Padding(2);
            this.Home.Name = "Home";
            this.Home.Padding = new System.Windows.Forms.Padding(2);
            this.Home.Size = new System.Drawing.Size(791, 394);
            this.Home.TabIndex = 0;
            this.Home.Text = "Home";
            // 
            // staffHomebackbtn
            // 
            this.staffHomebackbtn.BackColor = System.Drawing.Color.DodgerBlue;
            this.staffHomebackbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.staffHomebackbtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staffHomebackbtn.Location = new System.Drawing.Point(6, 492);
            this.staffHomebackbtn.Margin = new System.Windows.Forms.Padding(2);
            this.staffHomebackbtn.Name = "staffHomebackbtn";
            this.staffHomebackbtn.Size = new System.Drawing.Size(56, 19);
            this.staffHomebackbtn.TabIndex = 52;
            this.staffHomebackbtn.Text = "Back";
            this.staffHomebackbtn.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = global::CIS2201_Assignment.Properties.Resources._2008_i504_005__isometric_hospital_infographics;
            this.pictureBox1.Location = new System.Drawing.Point(2, 96);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(898, 299);
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
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(787, 94);
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
            this.richTextBox1.Location = new System.Drawing.Point(-57, 42);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(2);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ShowSelectionMargin = true;
            this.richTextBox1.Size = new System.Drawing.Size(626, 50);
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
            this.issuebtn.Location = new System.Drawing.Point(622, 52);
            this.issuebtn.Margin = new System.Windows.Forms.Padding(2);
            this.issuebtn.Name = "issuebtn";
            this.issuebtn.Size = new System.Drawing.Size(152, 32);
            this.issuebtn.TabIndex = 4;
            this.issuebtn.Text = "Report an Issue";
            this.issuebtn.UseVisualStyleBackColor = false;
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label14.Font = new System.Drawing.Font("Myanmar Text", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(-52, 0);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(884, 40);
            this.label14.TabIndex = 0;
            this.label14.Text = "Welcome to the Hospital Management System";
            this.label14.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // MedicationTabControl
            // 
            this.MedicationTabControl.Controls.Add(this.Home);
            this.MedicationTabControl.Controls.Add(this.AddMed);
            this.MedicationTabControl.Controls.Add(this.SearchMed);
            this.MedicationTabControl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MedicationTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MedicationTabControl.Location = new System.Drawing.Point(0, 0);
            this.MedicationTabControl.Margin = new System.Windows.Forms.Padding(2);
            this.MedicationTabControl.Name = "MedicationTabControl";
            this.MedicationTabControl.Padding = new System.Drawing.Point(15, 5);
            this.MedicationTabControl.SelectedIndex = 0;
            this.MedicationTabControl.Size = new System.Drawing.Size(799, 424);
            this.MedicationTabControl.TabIndex = 13;
            // 
            // maintenancetxt
            // 
            this.maintenancetxt.Location = new System.Drawing.Point(254, 165);
            this.maintenancetxt.Name = "maintenancetxt";
            this.maintenancetxt.Size = new System.Drawing.Size(71, 23);
            this.maintenancetxt.TabIndex = 72;
            // 
            // Medication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 424);
            this.Controls.Add(this.MedicationTabControl);
            this.Controls.Add(this.Title);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Medication";
            this.Text = "Medication";
            this.Load += new System.EventHandler(this.Medication_Load);
            this.SearchMed.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.meddgv)).EndInit();
            this.AddMed.ResumeLayout(false);
            this.AddMed.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.Home.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.MedicationTabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.TabPage SearchMed;
        private System.Windows.Forms.Button searchstaffbackbtn;
        private System.Windows.Forms.Label labelSeachMed;
        private System.Windows.Forms.TextBox medSearch;
        private System.Windows.Forms.Button searchTypeofMed;
        private System.Windows.Forms.DataGridView meddgv;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TabPage AddMed;
        private System.Windows.Forms.Button addStaffbackbtn;
        private System.Windows.Forms.TextBox price;
        private System.Windows.Forms.TextBox stock;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Button detailsubmit;
        private System.Windows.Forms.ComboBox typeOfMed;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.ComboBox bloodType;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage Home;
        private System.Windows.Forms.Button staffHomebackbtn;
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
    }
}