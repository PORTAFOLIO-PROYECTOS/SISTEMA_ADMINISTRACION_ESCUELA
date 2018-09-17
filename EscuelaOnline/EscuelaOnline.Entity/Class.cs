using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscuelaOnline.Entity
{
    public class Class
    {
        public int class_id { get; set; }
        public int subject_id { get; set; }
        public int teacher_id{ get; set; }
        public string class_code { get; set; }
        public string class_name { get; set; }
        public DateTime date_from { get; set; }
        public DateTime date_to { get; set; }
    }
}
