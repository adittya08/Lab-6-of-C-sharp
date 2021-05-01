using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Online_Quiz_Management_System.Views
{
    public partial class AdminHomePage : Form
    {
        public AdminHomePage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void buttonAddTeacherAccount_Click(object sender, EventArgs e)
        {
            new InputIdUserNameForTeacher().Show();
        }

        private void buttonUpdateTeacherAccount_Click(object sender, EventArgs e)
        {
            new SearchForm().Show();
        }

        private void buttonAddStudentAccount_Click(object sender, EventArgs e)
        {
            new InputIdUserNameForStudent().Show();
        }

        private void buttonUpdateStudentAccount_Click(object sender, EventArgs e)
        {
          new  SearchFormForStudent().Show();
        }
    }
}
