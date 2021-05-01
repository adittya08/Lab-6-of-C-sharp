using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Online_Quiz_Management_System.Models;
using System.Data;

namespace Online_Quiz_Management_System.Controllers
{
    public class QuizController
    {
        static Database db = new Database();
        public static bool AddQuiz(dynamic quiz)
        {
            Quiz q= new Quiz();
            
            q.Name = quiz.Name;
            


            return db.Quizs.AddQuiz(q);
        }

        public static bool UpdateQuiz(int i, string name)
        {
            return db.Quizs.UpdateQuiz(i, name);
            
        }

    }
    }

