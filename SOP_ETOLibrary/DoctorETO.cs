using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOP_ETOLibrary
{
    public partial class DoctorETO
    {
        public int ID { get; set; }
        public string Specialization { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Addres { get; set; }
        public int BankNumber { get; set; }
        public string BankName { get; set; }
        public string BankDetails { get; set; }
        public IList<AvailabilityETO> Availabilites { get; set; }
    }
}
