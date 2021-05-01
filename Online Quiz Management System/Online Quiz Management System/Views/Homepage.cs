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
    public partial class Homepage : Form
    {
        public Homepage()
        {
            InitializeComponent();
        }

        private void buttonAdmin_Click(object sender, EventArgs e)
        {
            new Form1().Show();
        }

        private void buttonTeacher_Click(object sender, EventArgs e)
        {
            new TeacherLogIn().Show();
        }

        private void buttonStudent_Click(object sender, EventArgs e)
        {
            new StudentLogIn().Show();
        }
    }
}
