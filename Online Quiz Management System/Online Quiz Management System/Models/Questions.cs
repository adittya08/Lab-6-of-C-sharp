using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Collections;

namespace Online_Quiz_Management_System.Models
{
   public class Questions
    {
        SqlConnection conn;
        public Questions(SqlConnection conn)
        {
            this.conn = conn;
        }

        public bool AddQuestion(Question question)
        {
            conn.Open();
            string query = String.Format("INSERT INTO Questions VALUES ('{0}','{1}','{2}','{3}','{4}','{5}',{6})", question.Name, question.ques,question.option1,question.option2,question.option3,question.option4,question.Answer);
            MessageBox.Show(question.Name);
            SqlCommand cmd = new SqlCommand(query, conn);
            int result = cmd.ExecuteNonQuery();
            conn.Close();
            if (result > 0) return true;
            return false;
        }

        public ArrayList GetAllQuestion(string name)
        {
            ArrayList question = new ArrayList();
            conn.Open();
            string query = string.Format("SELECT * FROM Questions where Name='{0}'",name);
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Question q = new Question();
                q.Id = reader.GetInt32(reader.GetOrdinal("Id"));
                q.Name = reader.GetString(reader.GetOrdinal("Name"));
                q.ques = reader.GetString(reader.GetOrdinal("Question"));
                q.option1 = reader.GetString(reader.GetOrdinal("Option1"));
                q.option2 = reader.GetString(reader.GetOrdinal("Option2"));
                q.option3 = reader.GetString(reader.GetOrdinal("Option3"));
                q.option4 = reader.GetString(reader.GetOrdinal("Option4"));
                q.Answer = reader.GetInt32(reader.GetOrdinal("Answer"));
                question.Add(q);
            }
            conn.Close();
            return question;
        }
    }
}
