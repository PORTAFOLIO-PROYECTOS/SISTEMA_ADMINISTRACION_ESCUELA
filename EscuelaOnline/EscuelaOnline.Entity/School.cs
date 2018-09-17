using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscuelaOnline.Entity
{
    public class School
    {
        public int school_id { get; set; }
        public int address_id { get; set; }
        public string school_name { get; set; }
        public string school_principal { get; set; }
        public string other_school_details { get; set; }
    }
}
