using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscuelaOnline.Entity
{
    public class Report
    {
        public int report_id { get; set; }
        public int student_id { get; set; }
        public DateTime date_create { get; set; }
        public string report_content { get; set; }
        public string teachers_coments { get; set; }
        public string other_report_details { get; set; }
    }
}
