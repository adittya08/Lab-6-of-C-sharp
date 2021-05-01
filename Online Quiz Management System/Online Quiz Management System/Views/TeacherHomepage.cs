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
    public partial class TeacherHomepage : Form
    {
        public TeacherHomepage()
        {
            InitializeComponent();
        }

        private void buttonSetQuiz_Click(object sender, EventArgs e)
        {
            Quiz quiz = new Quiz();
            quiz.Name = textBoxSetQuiz.Text;
            var result = QuizController.AddQuiz(quiz);
            if (result)
            {
                for (int i = 0; i < 5; i++)
                {
                    SetQuestion q = new SetQuestion(quiz.Name);
                    q.Show();
                    
                }
                
            }
            else
                MessageBox.Show("Quiz set unsuccessful"); 
        }

        private void buttonSearchQuiz_Click(object sender, EventArgs e)
        {
            new SeeQuizDetailsForTeacher().Show();
        }
    }
}
