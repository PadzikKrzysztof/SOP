using SOP_ETOLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOP_Administration.Models
{
    public class DoctorVisit
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime Data { get; set; }
        public PatientETO PatientETO { get; set; }
        public int PatientFileID { get; set; }
        public int VisitID { get; set; }
    }
}
