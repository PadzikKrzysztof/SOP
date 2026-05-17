using SOP_Administration.HttpConnection;
using SOP_ETOLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOP_Administration.Models
{
    public class MonthEnum : MonthEnumETO
    {
        private static string _url = "api/MonthEnum";
        public static List<MonthEnumETO> GetList()
            => HttpHandler.GetList<MonthEnumETO>(_url);

        public static MonthEnumETO Get(int ID)
            => HttpHandler.Get<MonthEnumETO>(ID, _url);

        public static void Put(MonthEnumETO eto)
        {
            HttpHandler.Put(eto, _url);
        }
        public static void Post(MonthEnumETO eto)
        {
            HttpHandler.Post(eto, _url);
        }

        public static void Delete(int ID)
        {
            HttpHandler.Delete<MonthEnumETO>(ID, _url);
        }
    }
}
