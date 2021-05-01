using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Online_Quiz_Management_System.Views
{
    public partial class SeeQuizDetailsForTeacher : Form
    {
        public SeeQuizDetailsForTeacher()
        {
            InitializeComponent();
        }

        private void buttonSearcch_Click(object sender, EventArgs e)
        {
            string connString = "Server=HELLKING\\SQLEXPRESS;Database=Online_quiz; Integrated Security= true;";
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();
            string search = textBoxSearch.Text;
            string query = "SELECT * FROM Quizs where Name Like" + "'" + search + "%'";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }
    }
}
