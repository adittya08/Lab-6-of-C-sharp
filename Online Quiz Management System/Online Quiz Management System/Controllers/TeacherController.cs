using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Online_Quiz_Management_System.Models;

namespace Online_Quiz_Management_System.Controllers
{
   public class TeacherController
    {
        static Database db = new Database();

        public static bool AddTeacher(dynamic teacher)
        {
            Teacher t = new Teacher();
            t.UserName = teacher.UserName;
            t.Name = teacher.Name;
            t.Password = teacher.Password;
           

            return db.Teachers.AddTeacher(t);
        }

        public static Teacher GetTeacher(string username)
        {
            return db.Teachers.GetTeacher(username);
        }

        public static bool UpdateTeacher(dynamic teacher)
        {
            Teacher t = new Teacher();
            t.UserName = teacher.UserName;
            t.Name = teacher.Name;
            return db.Teachers.UpdateTeacher(t);
        }

        public static bool DeleteTeacher(string username)
        {
            return db.Teachers.DeleteTeacher(username);
        }

        public static Teacher AuthenticateTeacher(string Username, string Password)
        {
            return db.Teachers.AuthenticateTeacher(Username, Password);
        }
    }

   
}
