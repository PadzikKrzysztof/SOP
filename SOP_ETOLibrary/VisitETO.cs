using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SOP_ETOLibrary
{
    public class VisitETO : IETO
    {
        public int ID { get; set; }
        public DateTime Day { get; set; }
        public DoctorETO Doctor { get; set; }
    }
}
