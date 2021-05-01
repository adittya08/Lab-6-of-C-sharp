namespace Online_Quiz_Management_System.Views
{
    partial class TeacherHomepage
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
            this.buttonSetQuiz = new System.Windows.Forms.Button();
            this.buttonSearchQuiz = new System.Windows.Forms.Button();
            this.textBoxSetQuiz = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonSetQuiz
            // 
            this.buttonSetQuiz.Location = new System.Drawing.Point(502, 105);
            this.buttonSetQuiz.Name = "buttonSetQuiz";
            this.buttonSetQuiz.Size = new System.Drawing.Size(134, 33);
            this.buttonSetQuiz.TabIndex = 0;
            this.buttonSetQuiz.Text = "Set Quiz";
            this.buttonSetQuiz.UseVisualStyleBackColor = true;
            this.buttonSetQuiz.Click += new System.EventHandler(this.buttonSetQuiz_Click);
            // 
            // buttonSearchQuiz
            // 
            this.buttonSearchQuiz.Location = new System.Drawing.Point(330, 230);
            this.buttonSearchQuiz.Name = "buttonSearchQuiz";
            this.buttonSearchQuiz.Size = new System.Drawing.Size(134, 33);
            this.buttonSearchQuiz.TabIndex = 1;
            this.buttonSearchQuiz.Text = "Search Quiz";
            this.buttonSearchQuiz.UseVisualStyleBackColor = true;
            this.buttonSearchQuiz.Click += new System.EventHandler(this.buttonSearchQuiz_Click);
            // 
            // textBoxSetQuiz
            // 
            this.textBoxSetQuiz.Location = new System.Drawing.Point(330, 110);
            this.textBoxSetQuiz.Name = "textBoxSetQuiz";
            this.textBoxSetQuiz.Size = new System.Drawing.Size(153, 22);
            this.textBoxSetQuiz.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(188, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Enter Quiz Name:";
            // 
            // TeacherHomepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxSetQuiz);
            this.Controls.Add(this.buttonSearchQuiz);
            this.Controls.Add(this.buttonSetQuiz);
            this.Name = "TeacherHomepage";
            this.Text = "TeacherHomepage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSetQuiz;
        private System.Windows.Forms.Button buttonSearchQuiz;
        private System.Windows.Forms.TextBox textBoxSetQuiz;
        private System.Windows.Forms.Label label1;
    }
}