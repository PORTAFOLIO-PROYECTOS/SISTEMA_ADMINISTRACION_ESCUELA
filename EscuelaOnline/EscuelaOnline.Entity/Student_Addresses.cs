using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscuelaOnline.Entity
{
    public class Student_Addresses
    {
        public int student_id { get; set; }
        public int address_id { get; set; }
        public DateTime date_from { get; set; }
        public DateTime date_to { get; set; }
        public string address_details { get; set; }
    }
}
