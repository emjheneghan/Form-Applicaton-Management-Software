namespace FormAssignment
{
    partial class AddContact
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddContact));
            this.grpAddStudent = new System.Windows.Forms.GroupBox();
            this.txtSID = new System.Windows.Forms.TextBox();
            this.lblStudentID = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.rdoUndergrad = new System.Windows.Forms.RadioButton();
            this.rdoPostgrad = new System.Windows.Forms.RadioButton();
            this.txtSPhone = new System.Windows.Forms.TextBox();
            this.txtSEmail = new System.Windows.Forms.TextBox();
            this.txtSName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.gpbAddTeacher = new System.Windows.Forms.GroupBox();
            this.cboSubjects = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTSalary = new System.Windows.Forms.TextBox();
            this.lblSalary = new System.Windows.Forms.Label();
            this.txtTPhone = new System.Windows.Forms.TextBox();
            this.txtTName = new System.Windows.Forms.TextBox();
            this.txtTEmail = new System.Windows.Forms.TextBox();
            this.lblTName = new System.Windows.Forms.Label();
            this.lblTPhone = new System.Windows.Forms.Label();
            this.lblTEmail = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.btnAddTeacher = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.btnLogout = new System.Windows.Forms.Button();
            this.grpAddStudent.SuspendLayout();
            this.gpbAddTeacher.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // grpAddStudent
            // 
            this.grpAddStudent.Controls.Add(this.txtSID);
            this.grpAddStudent.Controls.Add(this.lblStudentID);
            this.grpAddStudent.Controls.Add(this.lblStatus);
            this.grpAddStudent.Controls.Add(this.rdoUndergrad);
            this.grpAddStudent.Controls.Add(this.rdoPostgrad);
            this.grpAddStudent.Controls.Add(this.txtSPhone);
            this.grpAddStudent.Controls.Add(this.txtSEmail);
            this.grpAddStudent.Controls.Add(this.txtSName);
            this.grpAddStudent.Controls.Add(this.label2);
            this.grpAddStudent.Controls.Add(this.label1);
            this.grpAddStudent.Controls.Add(this.lblName);
            this.grpAddStudent.ForeColor = System.Drawing.SystemColors.Control;
            this.grpAddStudent.Location = new System.Drawing.Point(106, 79);
            this.grpAddStudent.Name = "grpAddStudent";
            this.grpAddStudent.Size = new System.Drawing.Size(342, 227);
            this.grpAddStudent.TabIndex = 0;
            this.grpAddStudent.TabStop = false;
            this.grpAddStudent.Text = "Add Student";
            // 
            // txtSID
            // 
            this.txtSID.Location = new System.Drawing.Point(88, 191);
            this.txtSID.Name = "txtSID";
            this.txtSID.Size = new System.Drawing.Size(228, 20);
            this.txtSID.TabIndex = 8;
            // 
            // lblStudentID
            // 
            this.lblStudentID.AutoSize = true;
            this.lblStudentID.Location = new System.Drawing.Point(15, 191);
            this.lblStudentID.Name = "lblStudentID";
            this.lblStudentID.Size = new System.Drawing.Size(64, 13);
            this.lblStudentID.TabIndex = 9;
            this.lblStudentID.Text = "Student ID :";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(15, 128);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(43, 13);
            this.lblStatus.TabIndex = 8;
            this.lblStatus.Text = "Status :";
            // 
            // rdoUndergrad
            // 
            this.rdoUndergrad.AutoSize = true;
            this.rdoUndergrad.Location = new System.Drawing.Point(88, 154);
            this.rdoUndergrad.Name = "rdoUndergrad";
            this.rdoUndergrad.Size = new System.Drawing.Size(75, 17);
            this.rdoUndergrad.TabIndex = 7;
            this.rdoUndergrad.TabStop = true;
            this.rdoUndergrad.Text = "Undergrad";
            this.rdoUndergrad.UseVisualStyleBackColor = true;
            // 
            // rdoPostgrad
            // 
            this.rdoPostgrad.AutoSize = true;
            this.rdoPostgrad.Location = new System.Drawing.Point(88, 128);
            this.rdoPostgrad.Name = "rdoPostgrad";
            this.rdoPostgrad.Size = new System.Drawing.Size(67, 17);
            this.rdoPostgrad.TabIndex = 6;
            this.rdoPostgrad.TabStop = true;
            this.rdoPostgrad.Text = "Postgrad";
            this.rdoPostgrad.UseVisualStyleBackColor = true;
            // 
            // txtSPhone
            // 
            this.txtSPhone.Location = new System.Drawing.Point(88, 58);
            this.txtSPhone.Name = "txtSPhone";
            this.txtSPhone.Size = new System.Drawing.Size(228, 20);
            this.txtSPhone.TabIndex = 4;
            // 
            // txtSEmail
            // 
            this.txtSEmail.Location = new System.Drawing.Point(88, 91);
            this.txtSEmail.Name = "txtSEmail";
            this.txtSEmail.Size = new System.Drawing.Size(228, 20);
            this.txtSEmail.TabIndex = 5;
            // 
            // txtSName
            // 
            this.txtSName.Location = new System.Drawing.Point(88, 25);
            this.txtSName.Name = "txtSName";
            this.txtSName.Size = new System.Drawing.Size(228, 20);
            this.txtSName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Email :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Phone :";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(15, 25);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(41, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name :";
            // 
            // gpbAddTeacher
            // 
            this.gpbAddTeacher.Controls.Add(this.cboSubjects);
            this.gpbAddTeacher.Controls.Add(this.label3);
            this.gpbAddTeacher.Controls.Add(this.txtTSalary);
            this.gpbAddTeacher.Controls.Add(this.lblSalary);
            this.gpbAddTeacher.Controls.Add(this.txtTPhone);
            this.gpbAddTeacher.Controls.Add(this.txtTName);
            this.gpbAddTeacher.Controls.Add(this.txtTEmail);
            this.gpbAddTeacher.Controls.Add(this.lblTName);
            this.gpbAddTeacher.Controls.Add(this.lblTPhone);
            this.gpbAddTeacher.Controls.Add(this.lblTEmail);
            this.gpbAddTeacher.ForeColor = System.Drawing.SystemColors.Control;
            this.gpbAddTeacher.Location = new System.Drawing.Point(472, 79);
            this.gpbAddTeacher.Name = "gpbAddTeacher";
            this.gpbAddTeacher.Size = new System.Drawing.Size(352, 227);
            this.gpbAddTeacher.TabIndex = 1;
            this.gpbAddTeacher.TabStop = false;
            this.gpbAddTeacher.Text = "Add Teacher";
            // 
            // cboSubjects
            // 
            this.cboSubjects.FormattingEnabled = true;
            this.cboSubjects.Location = new System.Drawing.Point(84, 183);
            this.cboSubjects.Name = "cboSubjects";
            this.cboSubjects.Size = new System.Drawing.Size(249, 21);
            this.cboSubjects.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Subjects Taught :";
            // 
            // txtTSalary
            // 
            this.txtTSalary.Location = new System.Drawing.Point(84, 125);
            this.txtTSalary.Name = "txtTSalary";
            this.txtTSalary.Size = new System.Drawing.Size(249, 20);
            this.txtTSalary.TabIndex = 12;
            // 
            // lblSalary
            // 
            this.lblSalary.AutoSize = true;
            this.lblSalary.Location = new System.Drawing.Point(11, 125);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(42, 13);
            this.lblSalary.TabIndex = 17;
            this.lblSalary.Text = "Salary :";
            // 
            // txtTPhone
            // 
            this.txtTPhone.Location = new System.Drawing.Point(84, 58);
            this.txtTPhone.Name = "txtTPhone";
            this.txtTPhone.Size = new System.Drawing.Size(249, 20);
            this.txtTPhone.TabIndex = 10;
            // 
            // txtTName
            // 
            this.txtTName.Location = new System.Drawing.Point(84, 25);
            this.txtTName.Name = "txtTName";
            this.txtTName.Size = new System.Drawing.Size(249, 20);
            this.txtTName.TabIndex = 9;
            // 
            // txtTEmail
            // 
            this.txtTEmail.Location = new System.Drawing.Point(84, 91);
            this.txtTEmail.Name = "txtTEmail";
            this.txtTEmail.Size = new System.Drawing.Size(249, 20);
            this.txtTEmail.TabIndex = 11;
            // 
            // lblTName
            // 
            this.lblTName.AutoSize = true;
            this.lblTName.Location = new System.Drawing.Point(11, 25);
            this.lblTName.Name = "lblTName";
            this.lblTName.Size = new System.Drawing.Size(41, 13);
            this.lblTName.TabIndex = 11;
            this.lblTName.Text = "Name :";
            // 
            // lblTPhone
            // 
            this.lblTPhone.AutoSize = true;
            this.lblTPhone.Location = new System.Drawing.Point(11, 58);
            this.lblTPhone.Name = "lblTPhone";
            this.lblTPhone.Size = new System.Drawing.Size(44, 13);
            this.lblTPhone.TabIndex = 12;
            this.lblTPhone.Text = "Phone :";
            // 
            // lblTEmail
            // 
            this.lblTEmail.AutoSize = true;
            this.lblTEmail.Location = new System.Drawing.Point(11, 91);
            this.lblTEmail.Name = "lblTEmail";
            this.lblTEmail.Size = new System.Drawing.Size(38, 13);
            this.lblTEmail.TabIndex = 13;
            this.lblTEmail.Text = "Email :";
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.ForeColor = System.Drawing.SystemColors.Control;
            this.lblInfo.Location = new System.Drawing.Point(60, 15);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(105, 13);
            this.lblInfo.TabIndex = 2;
            this.lblInfo.Text = "Menu > Add Contact";
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(174)))), ((int)(((byte)(232)))));
            this.btnAddStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddStudent.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAddStudent.Location = new System.Drawing.Point(326, 312);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(113, 34);
            this.btnAddStudent.TabIndex = 3;
            this.btnAddStudent.Text = "Add Student";
            this.btnAddStudent.UseVisualStyleBackColor = false;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // btnAddTeacher
            // 
            this.btnAddTeacher.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(174)))), ((int)(((byte)(232)))));
            this.btnAddTeacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTeacher.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAddTeacher.Location = new System.Drawing.Point(711, 312);
            this.btnAddTeacher.Name = "btnAddTeacher";
            this.btnAddTeacher.Size = new System.Drawing.Size(113, 34);
            this.btnAddTeacher.TabIndex = 4;
            this.btnAddTeacher.Text = "Add Teacher";
            this.btnAddTeacher.UseVisualStyleBackColor = false;
            this.btnAddTeacher.Click += new System.EventHandler(this.btnAddTeacher_Click);
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(174)))), ((int)(((byte)(232)))));
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.SystemColors.Control;
            this.btnBack.Location = new System.Drawing.Point(841, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(66, 34);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnDisplay
            // 
            this.btnDisplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(174)))), ((int)(((byte)(232)))));
            this.btnDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisplay.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDisplay.Location = new System.Drawing.Point(30, 404);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(155, 34);
            this.btnDisplay.TabIndex = 6;
            this.btnDisplay.Text = "Go to Display Contacts";
            this.btnDisplay.UseVisualStyleBackColor = false;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // pbLogo
            // 
            this.pbLogo.Image = global::FormAssignment.Properties.Resources.DBS2;
            this.pbLogo.Location = new System.Drawing.Point(0, 0);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(54, 50);
            this.pbLogo.TabIndex = 1;
            this.pbLogo.TabStop = false;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(174)))), ((int)(((byte)(232)))));
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.SystemColors.Control;
            this.btnLogout.Location = new System.Drawing.Point(822, 413);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(85, 37);
            this.btnLogout.TabIndex = 8;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // AddContact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(88)))), ((int)(((byte)(149)))));
            this.ClientSize = new System.Drawing.Size(919, 462);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnDisplay);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnAddTeacher);
            this.Controls.Add(this.btnAddStudent);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.gpbAddTeacher);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.grpAddStudent);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddContact";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddContact";
            this.grpAddStudent.ResumeLayout(false);
            this.grpAddStudent.PerformLayout();
            this.gpbAddTeacher.ResumeLayout(false);
            this.gpbAddTeacher.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpAddStudent;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.GroupBox gpbAddTeacher;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.TextBox txtSID;
        private System.Windows.Forms.Label lblStudentID;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.RadioButton rdoUndergrad;
        private System.Windows.Forms.RadioButton rdoPostgrad;
        private System.Windows.Forms.TextBox txtSPhone;
        private System.Windows.Forms.TextBox txtSEmail;
        private System.Windows.Forms.TextBox txtSName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTSalary;
        private System.Windows.Forms.Label lblSalary;
        private System.Windows.Forms.TextBox txtTPhone;
        private System.Windows.Forms.TextBox txtTName;
        private System.Windows.Forms.TextBox txtTEmail;
        private System.Windows.Forms.Label lblTName;
        private System.Windows.Forms.Label lblTPhone;
        private System.Windows.Forms.Label lblTEmail;
        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.Button btnAddTeacher;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.ComboBox cboSubjects;
    }
}