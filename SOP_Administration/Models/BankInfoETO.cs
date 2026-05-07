using SOP_Administration.HttpConnection;
using SOP_ETOLibrary;
using System.Numerics;

namespace SOP_Administration.Models
{
    public partial class BankInfo: BankInfoETO
    {
        private static string _url = "api/BankInfo";
        public static List<BankInfoETO> GetList()
            => HttpHandler.GetList<BankInfoETO>(_url);

        public static void Put(BankInfoETO eto)
        {
            HttpHandler.Put(eto, _url);
        }
    }
}
