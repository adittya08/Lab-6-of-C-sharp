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
    public partial class SearchForm : Form
    {
        public SearchForm()
        {
            InitializeComponent();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {

            string username = textBoxEnterUserName.Text;
            dynamic teacher = TeacherController.GetTeacher(username);
            if (teacher != null)
            {
                textBoxUserName.Text = teacher.UserName;
                textBoxName.Text = teacher.Name;

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
            var teacher = new
            {
                Name =textBoxName.Text,
                UserName = textBoxEnterUserName.Text,
            };
            bool result = TeacherController.UpdateTeacher(teacher);
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
            var r = TeacherController.DeleteTeacher(textBoxUserName.Text);
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
