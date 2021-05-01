using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Online_Quiz_Management_System.Controllers;

namespace Online_Quiz_Management_System.Views
{
    public partial class TeacherLogIn : Form
    {
        public TeacherLogIn()
        {
            InitializeComponent();
        }

        private void buttonLogIn_Click(object sender, EventArgs e)
        {
            string UserName = textBoxUserName.Text;
            string Password = textBoxPassword.Text;
            var teacher = TeacherController.AuthenticateTeacher(UserName, Password);
            if (teacher != null)
            {

                new TeacherHomepage().Show();

            }
            else
            {
                MessageBox.Show("Invalid Username or Password");
            }
        }
    }
}
