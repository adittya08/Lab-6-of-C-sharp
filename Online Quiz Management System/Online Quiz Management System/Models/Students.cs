using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Online_Quiz_Management_System.Controllers;
using System.Data.SqlClient;

namespace Online_Quiz_Management_System.Models
{
    public class Students
    {
        public SqlConnection conn;

        public Students(SqlConnection conn)
        {
            this.conn = conn;
        }

        public bool AddStudent(Student student)
        {
            conn.Open();
            string query = String.Format("INSERT INTO Students VALUES ('{0}','{1}','{2}')", student.UserName, student.Name, student.Password);
            SqlCommand cmd = new SqlCommand(query, conn);
            int result = cmd.ExecuteNonQuery();
            conn.Close();
            if (result > 0) return true;
            return false;
        }

        public Student GetStudent(string username)
        {
            conn.Open();
            string query = String.Format("SELECT * FROM Students WHERE Username='{0}'", username);
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            Student student = null;
            while (reader.Read())
            {
                student = new Student();
                student.Id = reader.GetInt32(reader.GetOrdinal("Id"));
                student.Name = reader.GetString(reader.GetOrdinal("Name"));
                student.UserName = reader.GetString(reader.GetOrdinal("UserName"));
                student.Password = reader.GetString(reader.GetOrdinal("Password"));
            }
            conn.Close();
            return student;
        }


        public bool UpdateStudent(Student student)
        {
            conn.Open();
            string query = String.Format("UPDATE Students SET Name='{0}' WHERE UserName='{1}'", student.Name, student.UserName);
            SqlCommand cmd = new SqlCommand(query, conn);
            int r = cmd.ExecuteNonQuery();
            conn.Close();
            if (r > 0) return true;
            return false;
        }
        public bool DeleteStudent(string username)
        {
            conn.Open();
            string query = String.Format("DELETE FROM Students WHERE UserName='{0}'", username);
            SqlCommand cmd = new SqlCommand(query, conn);
            int r = cmd.ExecuteNonQuery();
            conn.Close();
            if (r > 0) return true;
            return false;
        }

        public Student AuthenticateStudent(string UserName, string Password)
        {
            conn.Open();
            string query = string.Format("select * from Students where UserName='{0}' and Password='{1}'", UserName, Password);
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            Student student = null;
            while (reader.Read())
            {
                student = new Student();
                student.Id = reader.GetInt32(reader.GetOrdinal("Id"));
                student.UserName = reader.GetString(reader.GetOrdinal("UserName"));
                student.Name = reader.GetString(reader.GetOrdinal("Name"));
                student.Password = reader.GetString(reader.GetOrdinal("Password"));




            }
            conn.Close();

            return student;


        }
    }
}
