using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Online_Quiz_Management_System.Models
{
    public class Quizs
    {
        SqlConnection conn;
        public Quizs(SqlConnection conn)
        {
            this.conn = conn;
        }

        public bool AddQuiz(Quiz quiz)
        {
            conn.Open();
            quiz.Attend = 1;
            quiz.Average = 1;
            quiz.Highest = 1;
            string query = String.Format("INSERT INTO Quizs (Name,Attend,Average,Highest) VALUES ('{0}',{1},{2},{3})", quiz.Name, quiz.Highest, quiz.Average, quiz.Attend);
            SqlCommand cmd = new SqlCommand(query, conn);
            int result = cmd.ExecuteNonQuery();
            conn.Close();
            if (result > 0) return true;
            return false;
        }

        public DataSet SearchQuiz(string search)
        {
            conn.Open();
     
            string query = "SELECT * FROM Book where Name Like" + "'" + search + "%'";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            conn.Close();
            return ds;

            



        }

        public bool UpdateQuiz(int i, string name)
        {
            conn.Open();
            string query = string.Format("SELECT * FROM Quizs where Name='{0}'", name);
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            Quiz q=null;
            while (reader.Read())
            {
                q = new Quiz();
                q.Id = reader.GetInt32(reader.GetOrdinal("Id"));
                q.Name = reader.GetString(reader.GetOrdinal("Name"));
                q.Attend = reader.GetInt32(reader.GetOrdinal("Attend"));
                q.Average = reader.GetInt32(reader.GetOrdinal("Average"));
                q.Highest = reader.GetInt32(reader.GetOrdinal("Highest"));
            }
            conn.Close();


            conn.Open();

            query = String.Format("UPDATE Quizs SET Attend='{0}' WHERE Name='{1}'", q.Attend+1, name);
            SqlCommand u1 = new SqlCommand(query, conn);
            u1.ExecuteNonQuery();

            conn.Close();

            conn.Open();
            query = String.Format("UPDATE Quizs SET Average='{0}' WHERE Name='{1}'", ((q.Average*q.Attend)+i)/(q.Attend+1) + 1, name);
            SqlCommand u2 = new SqlCommand(query, conn);
            u2.ExecuteNonQuery();
            conn.Close();

            if (i > q.Highest)
            {
                conn.Open();
                query= String.Format("UPDATE Quizs SET Highest='{0}' WHERE Name='{1}'", i,name);
                SqlCommand u3 = new SqlCommand(query, conn);
                int r = u3.ExecuteNonQuery();
                conn.Close();
                if (r > 0) return true;
                return false;
            }
            conn.Close();
            return true;
            
        }

    }
}
