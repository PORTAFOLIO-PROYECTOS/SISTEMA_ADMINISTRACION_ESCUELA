using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscuelaOnline.Entity
{
    public class Parent_Address
    {
        public int parent_id { get; set; }
        public int address_id { get; set; }
        public DateTime date_address_from { get; set; }
        public DateTime date_address_to { get; set; }
    }
}
