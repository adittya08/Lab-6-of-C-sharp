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
    public partial class InputIdUserNameForStudent : Form
    {
        public InputIdUserNameForStudent()
        {
            InitializeComponent();
        }

        private void buttonSignUp_Click(object sender, EventArgs e)
        {
            var student = new
            {
                Id = 0,
                UserName = textBoxEnterUserName.Text,
                Name = textBoxEnterName.Text,
                Password = textBoxEnterPassword.Text
            };
            var result = StudentController.AddStudent(student);
            if (result)
            {
                MessageBox.Show("User Added");
            }
            else
            {
                MessageBox.Show("Could not Add User");
            }
        }
    }
}
