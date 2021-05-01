namespace Online_Quiz_Management_System.Views
{
    partial class SetQuestion
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
            this.textBoxQuestion = new System.Windows.Forms.TextBox();
            this.textBoxOption1 = new System.Windows.Forms.TextBox();
            this.textBoxOption2 = new System.Windows.Forms.TextBox();
            this.textBoxOption3 = new System.Windows.Forms.TextBox();
            this.textBoxOption4 = new System.Windows.Forms.TextBox();
            this.textBoxAnswer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonNext = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxQuestion
            // 
            this.textBoxQuestion.Location = new System.Drawing.Point(109, 81);
            this.textBoxQuestion.Name = "textBoxQuestion";
            this.textBoxQuestion.Size = new System.Drawing.Size(607, 22);
            this.textBoxQuestion.TabIndex = 0;
            // 
            // textBoxOption1
            // 
            this.textBoxOption1.Location = new System.Drawing.Point(109, 147);
            this.textBoxOption1.Name = "textBoxOption1";
            this.textBoxOption1.Size = new System.Drawing.Size(134, 22);
            this.textBoxOption1.TabIndex = 1;
            // 
            // textBoxOption2
            // 
            this.textBoxOption2.Location = new System.Drawing.Point(109, 203);
            this.textBoxOption2.Name = "textBoxOption2";
            this.textBoxOption2.Size = new System.Drawing.Size(134, 22);
            this.textBoxOption2.TabIndex = 2;
            // 
            // textBoxOption3
            // 
            this.textBoxOption3.Location = new System.Drawing.Point(109, 258);
            this.textBoxOption3.Name = "textBoxOption3";
            this.textBoxOption3.Size = new System.Drawing.Size(134, 22);
            this.textBoxOption3.TabIndex = 3;
            // 
            // textBoxOption4
            // 
            this.textBoxOption4.Location = new System.Drawing.Point(109, 312);
            this.textBoxOption4.Name = "textBoxOption4";
            this.textBoxOption4.Size = new System.Drawing.Size(134, 22);
            this.textBoxOption4.TabIndex = 4;
            // 
            // textBoxAnswer
            // 
            this.textBoxAnswer.Location = new System.Drawing.Point(473, 233);
            this.textBoxAnswer.Name = "textBoxAnswer";
            this.textBoxAnswer.Size = new System.Drawing.Size(134, 22);
            this.textBoxAnswer.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Enter Question";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-1, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Enter Option 1:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Enter Option 2:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(0, 258);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Enter Option 3:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(0, 315);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Enter Option 4:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(321, 236);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Enter Correct Answer:";
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(627, 339);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(75, 23);
            this.buttonNext.TabIndex = 12;
            this.buttonNext.Text = "Next";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // SetQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxAnswer);
            this.Controls.Add(this.textBoxOption4);
            this.Controls.Add(this.textBoxOption3);
            this.Controls.Add(this.textBoxOption2);
            this.Controls.Add(this.textBoxOption1);
            this.Controls.Add(this.textBoxQuestion);
            this.Name = "SetQuestion";
            this.Text = "SetQuestion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxQuestion;
        private System.Windows.Forms.TextBox textBoxOption1;
        private System.Windows.Forms.TextBox textBoxOption2;
        private System.Windows.Forms.TextBox textBoxOption3;
        private System.Windows.Forms.TextBox textBoxOption4;
        private System.Windows.Forms.TextBox textBoxAnswer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonNext;
    }
}