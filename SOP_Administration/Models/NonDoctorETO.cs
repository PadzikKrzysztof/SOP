using SOP_Administration.HttpConnection;
using SOP_ETOLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOP_Administration.Models
{
    public partial class NonDoctor : NonDoctorETO
    {
        private static string _url = "api/NonDoctor";
        public static List<NonDoctorETO> GetList()
            => HttpHandler.GetList<NonDoctorETO>(_url);

        public static void Put(NonDoctorETO eto)
        {
            HttpHandler.Put(eto, _url);
        }
    }
}
