using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscuelaOnline.Entity
{
    public class Homework
    {
        public int homework_id { get; set; }
        public int student_id { get; set; }
        public DateTime date_created { get; set; }
        public string homework_content { get; set; }
        public string grade { get; set; }
        public string other_homework_details { get; set; }
    }
}
