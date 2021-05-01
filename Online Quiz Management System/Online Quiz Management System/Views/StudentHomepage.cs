using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Online_Quiz_Management_System.Models;
using Online_Quiz_Management_System.Controllers;
using System.Collections;

namespace Online_Quiz_Management_System.Views
{
    public partial class StudentHomepage : Form
    {
        public SqlConnection conn;
        public StudentHomepage()
        {
            InitializeComponent();
            string connString = "Server=HELLKING\\SQLEXPRESS;Database=Online_quiz; Integrated Security= true;";
            conn = new SqlConnection(connString);
            conn.Open();
            
            string query = "SELECT name FROM Quizs";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dataGridView1.CurrentRow.Selected = true;
               
                string name = dataGridView1.Rows[e.RowIndex].Cells["Name"].FormattedValue.ToString();


               ArrayList arrayList= QuestinController.GetAllQuestion(name);

                

              foreach(Question i in arrayList)
                {
                    new ViewQuestionForStudent(i,name).Show();
                }



                

            }
        }
    }
}
