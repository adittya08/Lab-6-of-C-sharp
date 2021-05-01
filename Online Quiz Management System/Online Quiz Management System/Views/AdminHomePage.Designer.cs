namespace Online_Quiz_Management_System.Views
{
    partial class AdminHomePage
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
            this.buttonAddTeacherAccount = new System.Windows.Forms.Button();
            this.buttonUpdateTeacherAccount = new System.Windows.Forms.Button();
            this.buttonAddStudentAccount = new System.Windows.Forms.Button();
            this.buttonUpdateStudentAccount = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonAddTeacherAccount
            // 
            this.buttonAddTeacherAccount.Location = new System.Drawing.Point(177, 72);
            this.buttonAddTeacherAccount.Name = "buttonAddTeacherAccount";
            this.buttonAddTeacherAccount.Size = new System.Drawing.Size(137, 56);
            this.buttonAddTeacherAccount.TabIndex = 1;
            this.buttonAddTeacherAccount.Text = "Add Teacher Account";
            this.buttonAddTeacherAccount.UseVisualStyleBackColor = true;
            this.buttonAddTeacherAccount.Click += new System.EventHandler(this.buttonAddTeacherAccount_Click);
            // 
            // buttonUpdateTeacherAccount
            // 
            this.buttonUpdateTeacherAccount.Location = new System.Drawing.Point(177, 218);
            this.buttonUpdateTeacherAccount.Name = "buttonUpdateTeacherAccount";
            this.buttonUpdateTeacherAccount.Size = new System.Drawing.Size(137, 51);
            this.buttonUpdateTeacherAccount.TabIndex = 2;
            this.buttonUpdateTeacherAccount.Text = "Search  Teacher Account";
            this.buttonUpdateTeacherAccount.UseVisualStyleBackColor = true;
            this.buttonUpdateTeacherAccount.Click += new System.EventHandler(this.buttonUpdateTeacherAccount_Click);
            // 
            // buttonAddStudentAccount
            // 
            this.buttonAddStudentAccount.Location = new System.Drawing.Point(488, 72);
            this.buttonAddStudentAccount.Name = "buttonAddStudentAccount";
            this.buttonAddStudentAccount.Size = new System.Drawing.Size(142, 56);
            this.buttonAddStudentAccount.TabIndex = 5;
            this.buttonAddStudentAccount.Text = "Add Student Account";
            this.buttonAddStudentAccount.UseVisualStyleBackColor = true;
            this.buttonAddStudentAccount.Click += new System.EventHandler(this.buttonAddStudentAccount_Click);
            // 
            // buttonUpdateStudentAccount
            // 
            this.buttonUpdateStudentAccount.Location = new System.Drawing.Point(488, 218);
            this.buttonUpdateStudentAccount.Name = "buttonUpdateStudentAccount";
            this.buttonUpdateStudentAccount.Size = new System.Drawing.Size(142, 63);
            this.buttonUpdateStudentAccount.TabIndex = 6;
            this.buttonUpdateStudentAccount.Text = "Search Student Account";
            this.buttonUpdateStudentAccount.UseVisualStyleBackColor = true;
            this.buttonUpdateStudentAccount.Click += new System.EventHandler(this.buttonUpdateStudentAccount_Click);
            // 
            // AdminHomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonUpdateStudentAccount);
            this.Controls.Add(this.buttonAddStudentAccount);
            this.Controls.Add(this.buttonUpdateTeacherAccount);
            this.Controls.Add(this.buttonAddTeacherAccount);
            this.Name = "AdminHomePage";
            this.Text = "AdminHomePage";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonAddTeacherAccount;
        private System.Windows.Forms.Button buttonUpdateTeacherAccount;
        private System.Windows.Forms.Button buttonAddStudentAccount;
        private System.Windows.Forms.Button buttonUpdateStudentAccount;
    }
}