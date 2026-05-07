using SOP_Administration.HttpConnection;
using SOP_ETOLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOP_Administration.Models
{
    public partial class Doctor: DoctorETO
    {
        private static string _url = "api/Doctor";
        public static List<DoctorETO> GetList()
            => HttpHandler.GetList<DoctorETO>(_url);

        public static void Put(DoctorETO eto)
        {
            HttpHandler.Put(eto, _url);
        }
    }
}
