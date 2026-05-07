using SOP_Administration.HttpConnection;
using SOP_ETOLibrary;

namespace SOP_Administration.Models
{
    public partial class Month : MonthETO
    {
        private static string _url = "api/Month";
        public static List<MonthETO> GetList()
            => HttpHandler.GetList<MonthETO>(_url);

        public static void Put(MonthETO eto)
        {
            HttpHandler.Put(eto, _url);
        }
    }
}