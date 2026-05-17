using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOP_ETOLibrary
{
    public partial class DoctorETO : IETO
    {
        public int ID { get; set; }
        public SpecializationEnumETO Specialization { get; set; }
        public EmployeeETO Employee { get; set; }
        public IList<AvailabilityETO> Availabilites { get; set; }

        public override string ToString()
        {
            return $"{Employee.Name} {Employee.Surname}";
        }
    }
}
