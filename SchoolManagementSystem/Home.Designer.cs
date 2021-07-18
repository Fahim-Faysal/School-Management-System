namespace SchoolManagementSystem
{
    partial class Home
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.newAdmissionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newAdmissionToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.oldAdmissionToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.oldAdmissionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchStudentToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.individualDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.feedbackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutSchoolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newAdmissionToolStripMenuItem,
            this.oldAdmissionToolStripMenuItem,
            this.searchStudentToolStripMenuItem,
            this.deleteStudentToolStripMenuItem,
            this.feedbackToolStripMenuItem,
            this.aboutSchoolToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.menuStrip1.Size = new System.Drawing.Size(772, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // newAdmissionToolStripMenuItem
            // 
            this.newAdmissionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newAdmissionToolStripMenuItem1,
            this.oldAdmissionToolStripMenuItem1});
            this.newAdmissionToolStripMenuItem.Name = "newAdmissionToolStripMenuItem";
            this.newAdmissionToolStripMenuItem.Size = new System.Drawing.Size(92, 20);
            this.newAdmissionToolStripMenuItem.Text = "Admission";
            // 
            // newAdmissionToolStripMenuItem1
            // 
            this.newAdmissionToolStripMenuItem1.Name = "newAdmissionToolStripMenuItem1";
            this.newAdmissionToolStripMenuItem1.Size = new System.Drawing.Size(182, 22);
            this.newAdmissionToolStripMenuItem1.Text = "New Admission";
            this.newAdmissionToolStripMenuItem1.Click += new System.EventHandler(this.newAdmissionToolStripMenuItem1_Click);
            // 
            // oldAdmissionToolStripMenuItem1
            // 
            this.oldAdmissionToolStripMenuItem1.Name = "oldAdmissionToolStripMenuItem1";
            this.oldAdmissionToolStripMenuItem1.Size = new System.Drawing.Size(182, 22);
            this.oldAdmissionToolStripMenuItem1.Text = "Old Admission";
            this.oldAdmissionToolStripMenuItem1.Click += new System.EventHandler(this.oldAdmissionToolStripMenuItem1_Click);
            // 
            // oldAdmissionToolStripMenuItem
            // 
            this.oldAdmissionToolStripMenuItem.Name = "oldAdmissionToolStripMenuItem";
            this.oldAdmissionToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.oldAdmissionToolStripMenuItem.Text = "Fees";
            this.oldAdmissionToolStripMenuItem.Click += new System.EventHandler(this.oldAdmissionToolStripMenuItem_Click);
            // 
            // searchStudentToolStripMenuItem
            // 
            this.searchStudentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchStudentToolStripMenuItem1,
            this.individualDetailsToolStripMenuItem});
            this.searchStudentToolStripMenuItem.Name = "searchStudentToolStripMenuItem";
            this.searchStudentToolStripMenuItem.Size = new System.Drawing.Size(125, 20);
            this.searchStudentToolStripMenuItem.Text = "Student Details";
            // 
            // searchStudentToolStripMenuItem1
            // 
            this.searchStudentToolStripMenuItem1.Name = "searchStudentToolStripMenuItem1";
            this.searchStudentToolStripMenuItem1.Size = new System.Drawing.Size(196, 22);
            this.searchStudentToolStripMenuItem1.Text = "Search Student";
            this.searchStudentToolStripMenuItem1.Click += new System.EventHandler(this.searchStudentToolStripMenuItem1_Click);
            // 
            // individualDetailsToolStripMenuItem
            // 
            this.individualDetailsToolStripMenuItem.Name = "individualDetailsToolStripMenuItem";
            this.individualDetailsToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.individualDetailsToolStripMenuItem.Text = "Individual Details";
            this.individualDetailsToolStripMenuItem.Click += new System.EventHandler(this.individualDetailsToolStripMenuItem_Click);
            // 
            // deleteStudentToolStripMenuItem
            // 
            this.deleteStudentToolStripMenuItem.Name = "deleteStudentToolStripMenuItem";
            this.deleteStudentToolStripMenuItem.Size = new System.Drawing.Size(122, 20);
            this.deleteStudentToolStripMenuItem.Text = "Delete Student";
            this.deleteStudentToolStripMenuItem.Click += new System.EventHandler(this.deleteStudentToolStripMenuItem_Click);
            // 
            // feedbackToolStripMenuItem
            // 
            this.feedbackToolStripMenuItem.Name = "feedbackToolStripMenuItem";
            this.feedbackToolStripMenuItem.Size = new System.Drawing.Size(156, 20);
            this.feedbackToolStripMenuItem.Text = "School Informations";
            this.feedbackToolStripMenuItem.Click += new System.EventHandler(this.feedbackToolStripMenuItem_Click);
            // 
            // aboutSchoolToolStripMenuItem
            // 
            this.aboutSchoolToolStripMenuItem.Name = "aboutSchoolToolStripMenuItem";
            this.aboutSchoolToolStripMenuItem.Size = new System.Drawing.Size(100, 20);
            this.aboutSchoolToolStripMenuItem.Text = "Exit System";
            this.aboutSchoolToolStripMenuItem.Click += new System.EventHandler(this.aboutSchoolToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(12, 20);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(206, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(338, 55);
            this.label1.TabIndex = 1;
            this.label1.Text = "DASHBOARD";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 305);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Home";
            this.Text = "Home";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem newAdmissionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newAdmissionToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem oldAdmissionToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem oldAdmissionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchStudentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteStudentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem feedbackToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutSchoolToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchStudentToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem individualDetailsToolStripMenuItem;
        private System.Windows.Forms.Label label1;
    }
}