using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOP_ETOLibrary
{
    public partial class AvailabilityETO : IETO
    {
        public int ID { get; set; }
        public DateTime DayTimeStart { get; set; }
        public DateTime DayTimeEnd { get; set; }
        public DoctorETO Doctor { get; set; }
    }
}
