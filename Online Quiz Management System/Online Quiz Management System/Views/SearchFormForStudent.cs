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
    public partial class SearchFormForStudent : Form
    {
        public SearchFormForStudent()
        {
            InitializeComponent();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string username = textBoxEnterUserName.Text;
            dynamic student = StudentController.GetStudent(username);
            if (student != null)
            {
                textBoxUserName.Text = student.UserName;
                textBoxName.Text = student.Name;

            }
            else
            {
                textBoxUserName.Text = "";
                textBoxName.Text = "";
                MessageBox.Show("No user found");
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            var student = new
            {
                Name = textBoxName.Text,
                UserName = textBoxEnterUserName.Text,
            };
            bool result = StudentController.UpdateStudent(student);
            if (result)
            {
                MessageBox.Show("User Updated");
            }
            else
            {
                MessageBox.Show("Could not Update");
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            var r = StudentController.DeleteStudent(textBoxUserName.Text);
            if (r)
            {
                MessageBox.Show("User Deleted");
            }
            else
            {
                MessageBox.Show("Could not Delete");
            }
        }
    }
}
