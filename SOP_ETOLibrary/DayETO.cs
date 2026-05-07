using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace SOP_ETOLibrary
{
    public partial class DayETO
    {
        public int ID { get; set; }
        public int DayOfMonth { get; set; }
        public MonthETO Month { get; set; }
        public int Year { get; set; }
    }
}
