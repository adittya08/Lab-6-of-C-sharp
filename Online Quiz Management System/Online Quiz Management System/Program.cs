using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Online_Quiz_Management_System.Models;
using Online_Quiz_Management_System.Views;


namespace Online_Quiz_Management_System
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
              Application.EnableVisualStyles();
             Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Homepage());
           
        }
    }
}
