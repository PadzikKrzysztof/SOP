using SOP_Administration.HttpConnection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SOP_ETOLibrary;

namespace SOP_Administration.Models
{
    public partial class Doctor : DoctorETO
    {
        private static string _url = "api/Doctor";
        public static List<DoctorETO> GetList()
            => HttpHandler.GetList<DoctorETO>(_url);

        public static DoctorETO Get(int ID)
            => HttpHandler.Get<DoctorETO>(ID, _url);

        public static void Put(DoctorETO eto)
        {
            HttpHandler.Put(eto, _url);
        }
        public static void Post(DoctorETO eto)
        {
            HttpHandler.Post(eto, _url);
        }

        public static void Delete(int ID)
        {
            HttpHandler.Delete<DoctorETO>(ID, _url);
        }
    }
}
