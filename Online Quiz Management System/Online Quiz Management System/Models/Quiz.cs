using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Quiz_Management_System.Models
{
   public class Quiz
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public int Attend { get; set; }
        public int Average { get; set; }
        public int Highest { get; set; }
    }
}
