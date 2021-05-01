using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Online_Quiz_Management_System.Models;
using Online_Quiz_Management_System.Controllers;

namespace Online_Quiz_Management_System.Views
{
    public partial class SetQuestion : Form
    {
        public string N;
        public SetQuestion(string Name)
        {
            InitializeComponent();
            this.N = Name;
        }

        private void buttonNext_Click(object sender, EventArgs e)
        { 
            
            Question q = new Question();
            q.Name = N;
            q.ques = textBoxQuestion.Text;
            q.option1 = textBoxOption1.Text;
            q.option2 = textBoxOption2.Text;
            q.option3 = textBoxOption3.Text;
            q.option4 = textBoxOption4.Text;
            q.Answer = Convert.ToInt32(textBoxAnswer.Text);

            var result = QuestinController.AddQuestion(q);
            if(result)
            {
                MessageBox.Show("Question added");
                Close();
            }
            else
            {
                MessageBox.Show("Question cannot be added");
            }
           
        }
    }
}
