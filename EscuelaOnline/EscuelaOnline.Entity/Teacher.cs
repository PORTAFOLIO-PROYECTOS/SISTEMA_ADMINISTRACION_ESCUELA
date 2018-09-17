using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscuelaOnline.Entity
{
    public class Teacher
    {
        public int teacher_id { get; set; }
        public int school_id { get; set; }
        public string gender { get; set; }
        public string firts_name { get; set; }
        public string middle_name { get; set; }
        public string last_name { get; set; }
        public string other_teacher_details { get; set; }
    }
}
