using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Online_Quiz_Management_System.Models;

namespace Online_Quiz_Management_System.Controllers
{
    public class StudentController
    {
        static Database db = new Database();

        public static bool AddStudent(dynamic student)
        {
            Student s = new Student();
            s.UserName = student.UserName;
            s.Name = student.Name;
            s.Password = student.Password;


            return db.Students.AddStudent(s);
        }

        public static Student GetStudent(string username)
        {
            return db.Students.GetStudent(username);
        }

        public static bool UpdateStudent(dynamic student)
        {
            Student s = new Student();
            s.UserName = student.UserName;
            s.Name = student.Name;
            return db.Students.UpdateStudent(s);
        }

        public static bool DeleteStudent(string username)
        {
            return db.Students.DeleteStudent(username);
        }

        public static Student AuthenticateStudent(string Username, string Password)
        {
            return db.Students.AuthenticateStudent(Username, Password);
        }
    }

}
