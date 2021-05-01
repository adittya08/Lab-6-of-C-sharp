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
using Online_Quiz_Management_System.Models;
using Online_Quiz_Management_System.Views;

namespace Online_Quiz_Management_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonLogIn_Click(object sender, EventArgs e)
        {
            string UserName = textBoxUserName.Text;
            string Password = textBoxPassword.Text;
            var admin = AdminController.AuthenticateAdmin(UserName,Password);
            if (admin != null)
            {
                
                   new AdminHomePage().Show();
               
            }
            else
            {
                MessageBox.Show("Invalid Username or Password");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBoxUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
