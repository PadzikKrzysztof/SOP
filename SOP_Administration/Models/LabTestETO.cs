using SOP_Administration.HttpConnection;
using SOP_ETOLibrary;

namespace SOP_Administration.Models
{
    public partial class LabTest: LabTestETO
    {
        private static string _url = "api/LabTest";
        public static List<LabTestETO> GetList()
            => HttpHandler.GetList<LabTestETO>(_url);

        public static void Put(LabTestETO eto)
        {
            HttpHandler.Put(eto, _url);
        }
    }
}