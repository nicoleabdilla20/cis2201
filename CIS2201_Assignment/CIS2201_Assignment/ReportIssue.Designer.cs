
namespace CIS2201_Assignment
{
    partial class ReportIssue
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
            this.label1 = new System.Windows.Forms.Label();
            this.idtxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.detailtxt = new System.Windows.Forms.RichTextBox();
            this.issuebtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.hospitallogo = new System.Windows.Forms.PictureBox();
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
            this.Title.Size = new System.Drawing.Size(570, 46);
            this.Title.TabIndex = 12;
            this.Title.Text = "Report an Issue";
            this.Title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(159, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Staff ID:";
            // 
            // idtxt
            // 
            this.idtxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.idtxt.Location = new System.Drawing.Point(303, 91);
            this.idtxt.Name = "idtxt";
            this.idtxt.Size = new System.Drawing.Size(138, 26);
            this.idtxt.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(159, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Detail of Issue:";
            // 
            // detailtxt
            // 
            this.detailtxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.detailtxt.BackColor = System.Drawing.SystemColors.Menu;
            this.detailtxt.Location = new System.Drawing.Point(163, 227);
            this.detailtxt.Name = "detailtxt";
            this.detailtxt.Size = new System.Drawing.Size(278, 96);
            this.detailtxt.TabIndex = 17;
            this.detailtxt.Text = "Write Here ...";
            // 
            // issuebtn
            // 
            this.issuebtn.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.issuebtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.issuebtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.issuebtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 11F, System.Drawing.FontStyle.Bold);
            this.issuebtn.Location = new System.Drawing.Point(0, 492);
            this.issuebtn.Name = "issuebtn";
            this.issuebtn.Size = new System.Drawing.Size(570, 40);
            this.issuebtn.TabIndex = 18;
            this.issuebtn.Text = "Submit Issue";
            this.issuebtn.UseVisualStyleBackColor = false;
            this.issuebtn.Click += new System.EventHandler(this.issuebtn_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(159, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 20);
            this.label3.TabIndex = 19;
            this.label3.Text = "Date:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dateTimePicker1.Location = new System.Drawing.Point(241, 150);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 26);
            this.dateTimePicker1.TabIndex = 20;
            // 
            // hospitallogo
            // 
            this.hospitallogo.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.hospitallogo.Image = global::CIS2201_Assignment.Properties.Resources.hospital;
            this.hospitallogo.Location = new System.Drawing.Point(0, -1);
            this.hospitallogo.Name = "hospitallogo";
            this.hospitallogo.Size = new System.Drawing.Size(45, 47);
            this.hospitallogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.hospitallogo.TabIndex = 21;
            this.hospitallogo.TabStop = false;
            // 
            // ReportIssue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(570, 532);
            this.Controls.Add(this.hospitallogo);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.issuebtn);
            this.Controls.Add(this.detailtxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.idtxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Title);
            this.Name = "ReportIssue";
            this.Text = "ReportIssue";
            ((System.ComponentModel.ISupportInitialize)(this.hospitallogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox idtxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox detailtxt;
        private System.Windows.Forms.Button issuebtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.PictureBox hospitallogo;
    }
}