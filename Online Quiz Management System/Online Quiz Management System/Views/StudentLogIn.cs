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
    public partial class StudentLogIn : Form
    {
        public StudentLogIn()
        {
            InitializeComponent();
        }

        private void buttonLogIn_Click(object sender, EventArgs e)
        {
            string UserName = textBoxUserName.Text;
            string Password = textBoxPassword.Text;
            var student = StudentController.AuthenticateStudent(UserName, Password);
            if (student != null)
            {

               new StudentHomepage().Show();

            }
            else
            {
                MessageBox.Show("Invalid Username or Password");
            }
        }
    }
}
