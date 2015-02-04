namespace FormAssignment
{
    partial class Search
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Search));
            this.lblInfo = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSStudents = new System.Windows.Forms.Button();
            this.btnSTeachers = new System.Windows.Forms.Button();
            this.btnSAll = new System.Windows.Forms.Button();
            this.dgdDisplaySearch = new System.Windows.Forms.DataGridView();
            this.btnClearLists = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgdDisplaySearch)).BeginInit();
            this.SuspendLayout();
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.ForeColor = System.Drawing.SystemColors.Control;
            this.lblInfo.Location = new System.Drawing.Point(60, 15);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(80, 13);
            this.lblInfo.TabIndex = 3;
            this.lblInfo.Text = "Menu > Search";
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(174)))), ((int)(((byte)(232)))));
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.SystemColors.Control;
            this.btnBack.Location = new System.Drawing.Point(850, 5);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(66, 34);
            this.btnBack.TabIndex = 6;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // pbLogo
            // 
            this.pbLogo.Image = global::FormAssignment.Properties.Resources.DBS2;
            this.pbLogo.Location = new System.Drawing.Point(0, 0);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(54, 50);
            this.pbLogo.TabIndex = 2;
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
            this.btnLogout.TabIndex = 7;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.ForeColor = System.Drawing.SystemColors.Control;
            this.lblName.Location = new System.Drawing.Point(41, 101);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(118, 13);
            this.lblName.TabIndex = 9;
            this.lblName.Text = "Enter Name to Search :";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(192, 101);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(115, 20);
            this.txtSearch.TabIndex = 10;
            // 
            // btnSStudents
            // 
            this.btnSStudents.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(174)))), ((int)(((byte)(232)))));
            this.btnSStudents.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSStudents.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSStudents.Location = new System.Drawing.Point(25, 142);
            this.btnSStudents.Name = "btnSStudents";
            this.btnSStudents.Size = new System.Drawing.Size(132, 41);
            this.btnSStudents.TabIndex = 11;
            this.btnSStudents.Text = "Search Students";
            this.btnSStudents.UseVisualStyleBackColor = false;
            this.btnSStudents.Click += new System.EventHandler(this.btnSStudents_Click);
            // 
            // btnSTeachers
            // 
            this.btnSTeachers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(174)))), ((int)(((byte)(232)))));
            this.btnSTeachers.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSTeachers.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSTeachers.Location = new System.Drawing.Point(389, 142);
            this.btnSTeachers.Name = "btnSTeachers";
            this.btnSTeachers.Size = new System.Drawing.Size(132, 41);
            this.btnSTeachers.TabIndex = 12;
            this.btnSTeachers.Text = "Search Teachers";
            this.btnSTeachers.UseVisualStyleBackColor = false;
            this.btnSTeachers.Click += new System.EventHandler(this.btnSTeachers_Click);
            // 
            // btnSAll
            // 
            this.btnSAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(174)))), ((int)(((byte)(232)))));
            this.btnSAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSAll.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSAll.Location = new System.Drawing.Point(753, 142);
            this.btnSAll.Name = "btnSAll";
            this.btnSAll.Size = new System.Drawing.Size(132, 41);
            this.btnSAll.TabIndex = 13;
            this.btnSAll.Text = "Search All";
            this.btnSAll.UseVisualStyleBackColor = false;
            this.btnSAll.Click += new System.EventHandler(this.btnSAll_Click);
            // 
            // dgdDisplaySearch
            // 
            this.dgdDisplaySearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgdDisplaySearch.Location = new System.Drawing.Point(25, 199);
            this.dgdDisplaySearch.Name = "dgdDisplaySearch";
            this.dgdDisplaySearch.Size = new System.Drawing.Size(860, 155);
            this.dgdDisplaySearch.TabIndex = 20;
            // 
            // btnClearLists
            // 
            this.btnClearLists.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(174)))), ((int)(((byte)(232)))));
            this.btnClearLists.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearLists.ForeColor = System.Drawing.SystemColors.Control;
            this.btnClearLists.Location = new System.Drawing.Point(540, 376);
            this.btnClearLists.Name = "btnClearLists";
            this.btnClearLists.Size = new System.Drawing.Size(158, 37);
            this.btnClearLists.TabIndex = 21;
            this.btnClearLists.Text = "Clear Search";
            this.btnClearLists.UseVisualStyleBackColor = false;
            this.btnClearLists.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(88)))), ((int)(((byte)(149)))));
            this.ClientSize = new System.Drawing.Size(919, 462);
            this.Controls.Add(this.btnClearLists);
            this.Controls.Add(this.dgdDisplaySearch);
            this.Controls.Add(this.btnSAll);
            this.Controls.Add(this.btnSTeachers);
            this.Controls.Add(this.btnSStudents);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.pbLogo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Search";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DBS Database Management System - Search";
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgdDisplaySearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSStudents;
        private System.Windows.Forms.Button btnSTeachers;
        private System.Windows.Forms.Button btnSAll;
        private System.Windows.Forms.DataGridView dgdDisplaySearch;
        private System.Windows.Forms.Button btnClearLists;
    }
}