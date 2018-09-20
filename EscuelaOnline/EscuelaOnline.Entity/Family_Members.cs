using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscuelaOnline.Entity
{
    public class Family_Members
    {
        public int family_member_id { get; set; }
        public int family_id { get; set; }
        public int parent_or_student_menber { get; set; }
        public int parent_id { get; set; }
        public int student_id { get; set; }
    }
}
