using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Quiz_Management_System.Models
{
    public class Database
    {
        public Admins Admins { get; set; }
        public Teachers Teachers { get; set; }

        public Students Students { get; set; }
        public Quizs Quizs { get; set; }

        public Questions Questions { get; set; }

        

        public Database()
        {
            string connString = "Server=HELLKING\\SQLEXPRESS;Database=Online_quiz; Integrated Security= true;";
            SqlConnection conn = new SqlConnection(connString);
            
            Admins = new Admins(conn);
            Teachers = new Teachers(conn);
            Students = new Students(conn);
            Quizs = new Quizs(conn);
            Questions = new Questions(conn);

        }
    }
}
