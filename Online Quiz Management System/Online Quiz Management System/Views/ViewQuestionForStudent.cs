using Online_Quiz_Management_System.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Online_Quiz_Management_System.Controllers;

namespace Online_Quiz_Management_System.Views
{
    public partial class ViewQuestionForStudent : Form
    {
        public Question i;
        public static int count = 0;
        public string name;
        

        public ViewQuestionForStudent(Question i,string name)
        {
            InitializeComponent();
            this.i = i;
            this.name = name;
            labelQuestion.Text = i.ques;
            labelOption1.Text = i.option1;
            labelOption2.Text = i.option2;
            labelOption3.Text = i.option3;
            labelOption4.Text = i.option4;
        }

       

        private void buttonNext_Click(object sender, EventArgs e)
        {
            QuestinController.CheckAnswer(Convert.ToInt32(textBoxAnswer.Text), i.Answer);
           
            Close();
            count++;
            

            if (count == 5)
            {
                MessageBox.Show(string.Format("You have got {0}",Convert.ToString(QuestinController.mark)));

                var result = QuizController.UpdateQuiz(QuestinController.mark, name);
                if(result)
                {
                    MessageBox.Show("Updated");
                }
                else
                {
                    MessageBox.Show("Update failed");
                }

            }
            
            
        }
    }
}
