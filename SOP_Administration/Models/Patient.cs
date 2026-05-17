using SOP_Administration.HttpConnection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SOP_ETOLibrary;

namespace SOP_Administration.Models
{
    public partial class Patient : PatientETO
    {
        private static string _url = "api/Patient";
        public static List<PatientETO> GetList()
            => HttpHandler.GetList<PatientETO>(_url);

        public static PatientETO Get(int ID)
            => HttpHandler.Get<PatientETO>(ID, _url);

        public static void Put(PatientETO eto)
        {
            HttpHandler.Put(eto, _url);
        }
        public static void Post(PatientETO eto)
        {
            HttpHandler.Post(eto, _url);
        }

        public static void Delete(int ID)
        {
            HttpHandler.Delete<PatientETO>(ID, _url);
        }
    }
}
