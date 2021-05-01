using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Online_Quiz_Management_System.Models
{
   public class Teachers
    {
        public SqlConnection conn;
        
        public Teachers(SqlConnection conn)
        {
            this.conn = conn;
        }

        public bool AddTeacher(Teacher teacher)
        {
            conn.Open();
            string query = String.Format("INSERT INTO Teachers VALUES ('{0}','{1}','{2}')", teacher.UserName,teacher.Name, teacher.Password);
            SqlCommand cmd = new SqlCommand(query, conn);
            int result = cmd.ExecuteNonQuery();
            conn.Close();
            if (result > 0) return true;
            return false;
        }

        public Teacher GetTeacher(string username)
        {
            conn.Open();
            string query = String.Format("SELECT * FROM Teachers WHERE Username='{0}'", username);
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            Teacher teacher = null;
            while (reader.Read())
            {
                teacher =new Teacher();
                teacher.Id = reader.GetInt32(reader.GetOrdinal("Id"));
                teacher.Name = reader.GetString(reader.GetOrdinal("Name"));
                teacher.UserName = reader.GetString(reader.GetOrdinal("UserName"));
                teacher.Password = reader.GetString(reader.GetOrdinal("Password"));
            }
            conn.Close();
            return teacher;
        }


        public bool UpdateTeacher(Teacher teacher)
        {
            conn.Open();
            string query = String.Format("UPDATE Teachers SET Name='{0}' WHERE UserName='{1}'", teacher.Name, teacher.UserName);
            SqlCommand cmd = new SqlCommand(query, conn);
            int r = cmd.ExecuteNonQuery();
            conn.Close();
            if (r > 0) return true;
            return false;
        }
        public bool DeleteTeacher(string username)
        {
            conn.Open();
            string query = String.Format("DELETE FROM Teachers WHERE UserName='{0}'", username);
            SqlCommand cmd = new SqlCommand(query, conn);
            int r = cmd.ExecuteNonQuery();
            conn.Close();
            if (r > 0) return true;
            return false;
        }


        public Teacher AuthenticateTeacher(string UserName, string Password)
        {
            conn.Open();
            string query = string.Format("select * from Teachers where UserName='{0}' and Password='{1}'", UserName, Password);
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            Teacher teacher = null;
            while (reader.Read())
            {
                teacher = new Teacher();
                teacher.Id = reader.GetInt32(reader.GetOrdinal("Id"));
                teacher.UserName = reader.GetString(reader.GetOrdinal("UserName"));
                teacher.Name = reader.GetString(reader.GetOrdinal("Name"));
                teacher.Password = reader.GetString(reader.GetOrdinal("Password"));




            }
            conn.Close();

            return teacher;


        }
    }
}
