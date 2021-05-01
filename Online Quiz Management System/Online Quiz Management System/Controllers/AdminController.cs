using Online_Quiz_Management_System.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Quiz_Management_System.Controllers

{
    public class AdminController
    {
       static Database db = new Database();
        public static Admin AuthenticateAdmin(string Username, string Password)
        {
            return db.Admins.AuthenticateAdmin(Username, Password);
        }
    }
}
