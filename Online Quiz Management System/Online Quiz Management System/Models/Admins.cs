using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Online_Quiz_Management_System.Models
{
    public class Admins
    {
        SqlConnection conn;

        public Admins(SqlConnection conn)
        {
            this.conn = conn;
        }

        public Admin AuthenticateAdmin(string UserName, string Password)
        {
            conn.Open();
            string query = string.Format("select * from Admins where UserName='{0}' and Password='{1}'",UserName,Password);
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            Admin admin = null;
            while(reader.Read())
            {
                admin = new Admin();
                admin.Id = reader.GetInt32(reader.GetOrdinal("Id"));
                admin.UserName = reader.GetString(reader.GetOrdinal("UserName"));
                admin.Name = reader.GetString(reader.GetOrdinal("Name"));
                admin.Password = reader.GetString(reader.GetOrdinal("Password"));

               


            }
            conn.Close();

            return admin;


        }
    }
}
