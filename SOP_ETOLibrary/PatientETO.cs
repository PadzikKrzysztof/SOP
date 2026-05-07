using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOP_ETOLibrary
{
    public partial class PatientETO
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int PESEL { get; set; }
        public List<PatientFileETO> PatientFiles { get; set; }
    }
}
