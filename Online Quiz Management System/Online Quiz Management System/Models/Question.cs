using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Quiz_Management_System.Models
{
   public class Question
    {
        public int Id { set; get; }
        public string Name { set; get; }
        public string ques { set; get; }
        public string option1 { set; get; }
        public string option2 { set; get; }
        public string option3 { set; get; }
        public string option4 { set; get; }
        public int Answer { set; get; }


    }
}
