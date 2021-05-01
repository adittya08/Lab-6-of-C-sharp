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
    public partial class InputIdUserNameForTeacher : Form
    {
        public InputIdUserNameForTeacher()
        {
            InitializeComponent();
        }

        private void buttonSignUp_Click(object sender, EventArgs e)
        {
            var teacher = new
            {
                Id = 0,
                UserName = textBoxEnterUserName.Text,
                Name = textBoxEnterName.Text,
                Password = textBoxEnterPassword.Text
            };
            var result = TeacherController.AddTeacher(teacher);
            if (result)
            {
                MessageBox.Show("User Added");
            }
            else
            {
                MessageBox.Show("Could not Add User");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBoxEnterUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxEnterName_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxEnterPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
