using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOP_ETOLibrary
{
    public  class EmployeeETO: IETO
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public LoginProfileETO LoginProfile { get; set; }
    }
}
