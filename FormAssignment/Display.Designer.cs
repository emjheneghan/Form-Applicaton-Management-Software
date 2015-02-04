namespace FormAssignment
{
    partial class Display
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Display));
            this.btnBack = new System.Windows.Forms.Button();
            this.lblInfo = new System.Windows.Forms.Label();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnDAll = new System.Windows.Forms.Button();
            this.btnDTeachers = new System.Windows.Forms.Button();
            this.btnDStudents = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.dgdDisplayAll = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgdDisplayAll)).BeginInit();
            this.SuspendLayout();
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
            this.btnBack.TabIndex = 9;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.ForeColor = System.Drawing.SystemColors.Control;
            this.lblInfo.Location = new System.Drawing.Point(60, 15);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(80, 13);
            this.lblInfo.TabIndex = 8;
            this.lblInfo.Text = "Menu > Display";
            // 
            // pbLogo
            // 
            this.pbLogo.Image = global::FormAssignment.Properties.Resources.DBS2;
            this.pbLogo.Location = new System.Drawing.Point(0, 0);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(54, 50);
            this.pbLogo.TabIndex = 7;
            this.pbLogo.TabStop = false;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(174)))), ((int)(((byte)(232)))));
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.SystemColors.Control;
            this.btnLogout.Location = new System.Drawing.Point(823, 413);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(85, 37);
            this.btnLogout.TabIndex = 10;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnDAll
            // 
            this.btnDAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(174)))), ((int)(((byte)(232)))));
            this.btnDAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDAll.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDAll.Location = new System.Drawing.Point(779, 110);
            this.btnDAll.Name = "btnDAll";
            this.btnDAll.Size = new System.Drawing.Size(115, 56);
            this.btnDAll.TabIndex = 17;
            this.btnDAll.Text = "Display All Contacts";
            this.btnDAll.UseVisualStyleBackColor = false;
            this.btnDAll.Click += new System.EventHandler(this.btnDAll_Click);
            // 
            // btnDTeachers
            // 
            this.btnDTeachers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(174)))), ((int)(((byte)(232)))));
            this.btnDTeachers.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDTeachers.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDTeachers.Location = new System.Drawing.Point(407, 110);
            this.btnDTeachers.Name = "btnDTeachers";
            this.btnDTeachers.Size = new System.Drawing.Size(115, 56);
            this.btnDTeachers.TabIndex = 16;
            this.btnDTeachers.Text = "Display Teachers";
            this.btnDTeachers.UseVisualStyleBackColor = false;
            this.btnDTeachers.Click += new System.EventHandler(this.btnDTeachers_Click);
            // 
            // btnDStudents
            // 
            this.btnDStudents.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(174)))), ((int)(((byte)(232)))));
            this.btnDStudents.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDStudents.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDStudents.Location = new System.Drawing.Point(35, 110);
            this.btnDStudents.Name = "btnDStudents";
            this.btnDStudents.Size = new System.Drawing.Size(115, 56);
            this.btnDStudents.TabIndex = 15;
            this.btnDStudents.Text = "Display Students";
            this.btnDStudents.UseVisualStyleBackColor = false;
            this.btnDStudents.Click += new System.EventHandler(this.btnDStudents_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(174)))), ((int)(((byte)(232)))));
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.SystemColors.Control;
            this.btnClear.Location = new System.Drawing.Point(35, 365);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(85, 37);
            this.btnClear.TabIndex = 18;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // dgdDisplayAll
            // 
            this.dgdDisplayAll.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgdDisplayAll.Location = new System.Drawing.Point(35, 188);
            this.dgdDisplayAll.Name = "dgdDisplayAll";
            this.dgdDisplayAll.Size = new System.Drawing.Size(860, 155);
            this.dgdDisplayAll.TabIndex = 19;
            // 
            // Display
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(88)))), ((int)(((byte)(149)))));
            this.ClientSize = new System.Drawing.Size(919, 462);
            this.Controls.Add(this.dgdDisplayAll);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDAll);
            this.Controls.Add(this.btnDTeachers);
            this.Controls.Add(this.btnDStudents);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.pbLogo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Display";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DBS Database Management System - Display";
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgdDisplayAll)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnDAll;
        private System.Windows.Forms.Button btnDTeachers;
        private System.Windows.Forms.Button btnDStudents;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.DataGridView dgdDisplayAll;
    }
}