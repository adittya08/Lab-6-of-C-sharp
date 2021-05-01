namespace Online_Quiz_Management_System.Views
{
    partial class InputIdUserNameForTeacher
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxEnterUserName = new System.Windows.Forms.TextBox();
            this.textBoxEnterName = new System.Windows.Forms.TextBox();
            this.textBoxEnterPassword = new System.Windows.Forms.TextBox();
            this.buttonSignUp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(128, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Your Username:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(128, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter Your Name:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(128, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Enter Your Password :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // textBoxEnterUserName
            // 
            this.textBoxEnterUserName.Location = new System.Drawing.Point(293, 76);
            this.textBoxEnterUserName.Name = "textBoxEnterUserName";
            this.textBoxEnterUserName.Size = new System.Drawing.Size(164, 22);
            this.textBoxEnterUserName.TabIndex = 3;
            this.textBoxEnterUserName.TextChanged += new System.EventHandler(this.textBoxEnterUserName_TextChanged);
            // 
            // textBoxEnterName
            // 
            this.textBoxEnterName.Location = new System.Drawing.Point(293, 131);
            this.textBoxEnterName.Name = "textBoxEnterName";
            this.textBoxEnterName.Size = new System.Drawing.Size(164, 22);
            this.textBoxEnterName.TabIndex = 4;
            this.textBoxEnterName.TextChanged += new System.EventHandler(this.textBoxEnterName_TextChanged);
            // 
            // textBoxEnterPassword
            // 
            this.textBoxEnterPassword.Location = new System.Drawing.Point(293, 183);
            this.textBoxEnterPassword.Name = "textBoxEnterPassword";
            this.textBoxEnterPassword.Size = new System.Drawing.Size(164, 22);
            this.textBoxEnterPassword.TabIndex = 5;
            this.textBoxEnterPassword.TextChanged += new System.EventHandler(this.textBoxEnterPassword_TextChanged);
            // 
            // buttonSignUp
            // 
            this.buttonSignUp.Location = new System.Drawing.Point(381, 254);
            this.buttonSignUp.Name = "buttonSignUp";
            this.buttonSignUp.Size = new System.Drawing.Size(75, 23);
            this.buttonSignUp.TabIndex = 6;
            this.buttonSignUp.Text = "Sign Up";
            this.buttonSignUp.UseVisualStyleBackColor = true;
            this.buttonSignUp.Click += new System.EventHandler(this.buttonSignUp_Click);
            // 
            // InputIdUserNameForTeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonSignUp);
            this.Controls.Add(this.textBoxEnterPassword);
            this.Controls.Add(this.textBoxEnterName);
            this.Controls.Add(this.textBoxEnterUserName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "InputIdUserNameForTeacher";
            this.Text = "InputIdUserName";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxEnterUserName;
        private System.Windows.Forms.TextBox textBoxEnterName;
        private System.Windows.Forms.TextBox textBoxEnterPassword;
        private System.Windows.Forms.Button buttonSignUp;
    }
}