using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Online_Quiz_Management_System.Models;

namespace Online_Quiz_Management_System.Controllers
{
    
    public class QuestinController
    {
        
        static Database db = new Database();
        public static int mark=0;

        public static bool AddQuestion(dynamic question)
        {
            Question q = new Question();
            q.Name = question.Name;
            q.ques = question.ques;
            q.option1 = question.option1;
            q.option2 = question.option2;
            q.option3 = question.option3;
            q.option4 = question.option4;
            q.Answer = question.Answer;



            return db.Questions.AddQuestion(q);
        }
        public static ArrayList GetAllQuestion(string name)
        {
            return db.Questions.GetAllQuestion(name);
        }

        public static void CheckAnswer(int i,int a)
        {
            if(i==a)
            {
                MessageBox.Show("Right Answer");
                mark++;
                

            }
            else
            {
                MessageBox.Show("Wrong Answer");
            }
        }
    }
}
