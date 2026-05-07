using SOP_Administration.HttpConnection;
using SOP_ETOLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace SOP_Administration.Models
{
    public partial class Day: DayETO
    {
        private static string _url = "api/Day";
        public static List<DayETO> GetList()
            => HttpHandler.GetList<DayETO>(_url);

        public static void Put(DayETO eto)
        {
            HttpHandler.Put(eto, _url);
        }
    }
}
