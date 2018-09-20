using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscuelaOnline.Entity
{
    public class Students
    {
        public int student_id { get; set; }
        public string gender { get; set; }
        public string first_name { get; set; }
        public string middle_name { get; set; }
        public string last_name { get; set; }
        public DateTime date_of_birth { get; set; }
        public string other_student_details { get; set; }
    }
}
