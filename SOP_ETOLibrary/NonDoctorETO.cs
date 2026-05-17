using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOP_ETOLibrary
{
    public partial class NonDoctorETO : IETO
    {
        public int ID { get; set; }
        public RoleEnumETO Role { get; set; }
        public EmployeeETO Employee { get; set; }
    }
}
