using SOP_Administration.HttpConnection;
using SOP_ETOLibrary;

namespace SOP_Administration.Models
{
    public partial class PatientFile : PatientFileETO
    {
        private static string _url = "api/PatientFile";
        public static List<PatientFileETO> GetList()
            => HttpHandler.GetList<PatientFileETO>(_url);

        public static void Put(PatientFileETO eto)
        {
            HttpHandler.Put(eto, _url);
        }
    }
}