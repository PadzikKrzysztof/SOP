using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOP_ETOLibrary
{
    public partial class AvailabilityETO
    {
        public int ID { get; set; }
        public DateTime TimeStart { get; set; }
        public DateTime TimeEnd { get; set; }
        public DayETO Day { get; set; }
        public int DoctorId { get; set; }
    }
}
